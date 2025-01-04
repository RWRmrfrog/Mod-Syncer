using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using System.Drawing;
using System.Runtime.InteropServices;

using File = System.IO.File;

namespace ModSyncer
{
    public partial class ModSyncer : Form
    {
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref Margins margins);

        public struct Margins
        {
            public int Left, Right, Top, Bottom;
        }

        const int DWMWA_CAPTION_COLOR = 35; // Attribute for caption color
        const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20; // Optional for dark mode themes

        public ModSyncer()
        {
            InitializeComponent();
            SetTitleBarColor(Color.FromArgb(22, 22, 22)); // Change title bar color here
        }

        private void SetTitleBarColor(Color color)
        {
            IntPtr hwnd = this.Handle;

            // Set the custom title bar color
            int colorValue = ColorTranslator.ToWin32(color);
            DwmSetWindowAttribute(hwnd, DWMWA_CAPTION_COLOR, ref colorValue, sizeof(int));

            // Optional: Extend the frame into the client area for additional customization
            Margins margins = new Margins { Left = 0, Right = 0, Top = 0, Bottom = 0 };
            DwmExtendFrameIntoClientArea(hwnd, ref margins);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.FilePath;
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void deleteFiles(string zipFile, string[] files, string folderPath)
        {
            using (FileStream zipToOpen = new FileStream(zipFile, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        string relativePathInZip = entry.FullName.Replace("/", "\\");

                        foreach (string file in files)
                        {
                            string relativePathInFolder = GetRelativePath(folderPath, file);

                            if (relativePathInZip.Equals(relativePathInFolder, StringComparison.OrdinalIgnoreCase))
                            {
                                File.Delete(file);
                            }
                        }
                    }
                }
            }
        }

        public static string GetRelativePath(string basePath, string fullPath)
        {
            Uri baseUri = new Uri(AppendDirectorySeparator(basePath));
            Uri fullUri = new Uri(fullPath);
            return Uri.UnescapeDataString(baseUri.MakeRelativeUri(fullUri).ToString())
                       .Replace("/", "\\");
        }

        private static string AppendDirectorySeparator(string path)
        {
            return !path.EndsWith(Path.DirectorySeparatorChar.ToString())
                   ? path + Path.DirectorySeparatorChar
                   : path;
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            syncBtn.Enabled = false;
            config_btn.Enabled = false;

            string gameFilePath;

            if (textBox1.Text != "")
            {
                gameFilePath = textBox1.Text;
            }
            else
            {
                gameFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";
            }

            Properties.Settings.Default.FilePath = gameFilePath;
            Properties.Settings.Default.Save();

            string modsFolderPath = gameFilePath + "\\mods";
            string configFolderPath = gameFilePath + "\\config";
            string resourceFolderPath = gameFilePath + "\\resourcepacks";
            string[] configFiles = Directory.GetFiles(configFolderPath, "*.*", SearchOption.AllDirectories);
            string[] resourceFiles = Directory.GetFiles(resourceFolderPath, "*.*", SearchOption.AllDirectories);

            label3.Text = "Downloading Mods...";

            string zippedMods = gameFilePath + "\\mods.zip";
            string zippedConfig = gameFilePath + "\\config.zip";
            string zippedResource = gameFilePath + "\\resourcepacks.zip";

            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Credentials = new NetworkCredential("username", "password");
                    client.DownloadFile("http://localhost/other/mods.zip", zippedMods);
                    client.DownloadFile("http://localhost/other/config.zip", zippedConfig);
                    client.DownloadFile("http://localhost/other/resourcepacks.zip", zippedResource);

                    if (Directory.Exists(modsFolderPath))
                    {
                        Directory.Delete(modsFolderPath, true);
                    }

                    deleteFiles(zippedConfig, configFiles, configFolderPath);
                    deleteFiles(zippedResource, resourceFiles, resourceFolderPath);

                    ZipFile.ExtractToDirectory(zippedMods, modsFolderPath);
                    ZipFile.ExtractToDirectory(zippedConfig, configFolderPath);
                    ZipFile.ExtractToDirectory(zippedResource, resourceFolderPath);

                    File.Delete(zippedMods);
                    File.Delete(zippedConfig);
                    File.Delete(zippedResource);

                    string clientMods = gameFilePath + "\\clientMods";
                    string blacklist = gameFilePath + "\\blacklisted_mods.txt";

                    if (File.Exists(blacklist))
                    {
                        label3.Text = "Deleting Blacklisted Mods...";

                        string[] blacklist_file = File.ReadAllLines(blacklist);
                        string[] mods = Directory.GetFiles(modsFolderPath);

                        foreach (string mod in mods)
                        {
                            foreach (string line in blacklist_file)
                            {
                                if (mod.Contains(line))
                                {
                                    File.Delete(mod);
                                }
                            }
                        }
                    }

                    if (Directory.Exists(clientMods))
                    {
                        string[] files = Directory.GetFiles(clientMods);
                        foreach (string s in files)
                        {
                            string fileName = Path.GetFileName(s);
                            string _currFileName = Path.Combine(modsFolderPath, fileName);
                            File.Copy(s, _currFileName, true);
                        }
                    }

                    label3.Text = "Finished Installing Mods!";
                }
                catch
                {
                    label3.Text = "An occured fetching mods!";
                }
            }

            syncBtn.Enabled = true;
            config_btn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaderBtn.Enabled = false;

            string modsyncerPath = Directory.GetCurrentDirectory();
            string quilt = modsyncerPath + "\\quilt.exe";

            if (File.Exists(quilt))
            {
                File.Delete(quilt);
            }

            label3.Text = "Installing Quilt Launcher...";

            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://quiltmc.org/api/v1/download-latest-installer/windows-x86_64", quilt);

                    label3.Text = "Launching Quilt...";

                    Process process = new Process();
                    process.EnableRaisingEvents = false;
                    process.StartInfo.FileName = quilt;
                    process.Start();

                    process.WaitForExit();
                    label3.Text = "";
                }
                catch 
                {
                    label3.Text = "An occured fetching quilt!";
                }
            }

            loaderBtn.Enabled = true;
        }

        private void config_btn_Click(object sender, EventArgs e)
        {
            config_btn.Enabled = false;

            popup popup = new popup();
            DialogResult dialogresult = popup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                label3.Text = "Installing Default Config...";

                string gameFilePath = Properties.Settings.Default.FilePath;
                string configFilePath = gameFilePath + "\\config";
                string zippedConfig = gameFilePath + "\\config.zip";

                using (WebClient client = new WebClient())
                {
                    try
                    {
                        client.Credentials = new NetworkCredential("username", "password");
                        client.DownloadFile("http://localhost/other/default_config.zip", zippedConfig);

                        if (Directory.Exists(configFilePath))
                        {
                            Directory.Delete(configFilePath, true);
                        }

                        ZipFile.ExtractToDirectory(zippedConfig, configFilePath);
                        File.Delete(zippedConfig);

                        label3.Text = "Finished Installing Default Config!";
                    }
                    catch
                    {
                        label3.Text = "An occured fetching config!";
                    }
                }
            }

            config_btn.Enabled = true;
        }
    }
}
