namespace ModSyncer
{
    partial class popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popup));
            this.warning_label = new System.Windows.Forms.Label();
            this.warning_test1 = new System.Windows.Forms.Label();
            this.warning_test2 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warning_label
            // 
            this.warning_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("Mojangles", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(235, 13);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(120, 31);
            this.warning_label.TabIndex = 2;
            this.warning_label.Text = "Warning!";
            this.warning_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // warning_test1
            // 
            this.warning_test1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.warning_test1.AutoSize = true;
            this.warning_test1.Font = new System.Drawing.Font("Mojangles", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_test1.ForeColor = System.Drawing.Color.White;
            this.warning_test1.Location = new System.Drawing.Point(18, 60);
            this.warning_test1.Name = "warning_test1";
            this.warning_test1.Size = new System.Drawing.Size(569, 22);
            this.warning_test1.TabIndex = 2;
            this.warning_test1.Text = " This will install the recommended default config ";
            this.warning_test1.Click += new System.EventHandler(this.label1_Click);
            // 
            // warning_test2
            // 
            this.warning_test2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.warning_test2.AutoSize = true;
            this.warning_test2.Font = new System.Drawing.Font("Mojangles", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_test2.ForeColor = System.Drawing.Color.White;
            this.warning_test2.Location = new System.Drawing.Point(92, 97);
            this.warning_test2.Name = "warning_test2";
            this.warning_test2.Size = new System.Drawing.Size(408, 22);
            this.warning_test2.TabIndex = 3;
            this.warning_test2.Text = "All existing configs will be deleted!";
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_btn.BackColor = System.Drawing.Color.DimGray;
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.ForeColor = System.Drawing.Color.White;
            this.ok_btn.Location = new System.Drawing.Point(200, 147);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(89, 33);
            this.ok_btn.TabIndex = 8;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.BackColor = System.Drawing.Color.DimGray;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(306, 147);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(89, 33);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(602, 199);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.warning_test2);
            this.Controls.Add(this.warning_test1);
            this.Controls.Add(this.warning_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.Label warning_test1;
        private System.Windows.Forms.Label warning_test2;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}