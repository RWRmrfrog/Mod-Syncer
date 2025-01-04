namespace ModSyncer
{
    partial class ModSyncer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModSyncer));
            this.syncBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.loaderBtn = new System.Windows.Forms.Button();
            this.config_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syncBtn
            // 
            this.syncBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.syncBtn.BackColor = System.Drawing.Color.DimGray;
            this.syncBtn.ForeColor = System.Drawing.Color.White;
            this.syncBtn.Location = new System.Drawing.Point(581, 184);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(89, 33);
            this.syncBtn.TabIndex = 0;
            this.syncBtn.Text = "Sync Mods";
            this.syncBtn.UseVisualStyleBackColor = false;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mojangles", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please locate your game instance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mojangles", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "If you are using the official minecraft launcher than leave this input blank";
            // 
            // openFolder
            // 
            this.openFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.openFolder.BackColor = System.Drawing.Color.DimGray;
            this.openFolder.ForeColor = System.Drawing.Color.White;
            this.openFolder.Location = new System.Drawing.Point(581, 97);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(89, 33);
            this.openFolder.TabIndex = 3;
            this.openFolder.Text = "Open Folder";
            this.openFolder.UseVisualStyleBackColor = false;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(9, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mojangles", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 5;
            // 
            // loaderBtn
            // 
            this.loaderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loaderBtn.BackColor = System.Drawing.Color.DimGray;
            this.loaderBtn.ForeColor = System.Drawing.Color.White;
            this.loaderBtn.Location = new System.Drawing.Point(486, 184);
            this.loaderBtn.Name = "loaderBtn";
            this.loaderBtn.Size = new System.Drawing.Size(89, 33);
            this.loaderBtn.TabIndex = 6;
            this.loaderBtn.Text = "Quilt Installer";
            this.loaderBtn.UseVisualStyleBackColor = false;
            this.loaderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // config_btn
            // 
            this.config_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.config_btn.BackColor = System.Drawing.Color.DimGray;
            this.config_btn.ForeColor = System.Drawing.Color.White;
            this.config_btn.Location = new System.Drawing.Point(9, 184);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(89, 33);
            this.config_btn.TabIndex = 7;
            this.config_btn.Text = "Default Config";
            this.config_btn.UseVisualStyleBackColor = false;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // ModSyncer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(680, 229);
            this.Controls.Add(this.config_btn);
            this.Controls.Add(this.loaderBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.syncBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModSyncer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neo-Origins Mod Syncer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button syncBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loaderBtn;
        private System.Windows.Forms.Button config_btn;
    }
}

