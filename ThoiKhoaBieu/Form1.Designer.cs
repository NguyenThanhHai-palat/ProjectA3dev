namespace App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ping1 = new System.Net.NetworkInformation.Ping();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UPDATECHECKER = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadIMGBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiLạiGiaoDiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.COPYRIGHTS = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TKBAPPVIEW 1.0-OP-V08";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UPDATECHECKER,
            this.DownloadIMGBtn,
            this.tHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UPDATECHECKER
            // 
            this.UPDATECHECKER.AutoToolTip = true;
            this.UPDATECHECKER.BackColor = System.Drawing.Color.Silver;
            this.UPDATECHECKER.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.UPDATECHECKER.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UPDATECHECKER.Image = ((System.Drawing.Image)(resources.GetObject("UPDATECHECKER.Image")));
            this.UPDATECHECKER.ImageTransparentColor = System.Drawing.Color.White;
            this.UPDATECHECKER.Name = "UPDATECHECKER";
            this.UPDATECHECKER.Size = new System.Drawing.Size(169, 20);
            this.UPDATECHECKER.Text = "KIỂM TRA VÀ CẬP NHẬT";
            this.UPDATECHECKER.ToolTipText = "NHẤN VÀO ĐỂ KIỂM TRA BẢN CẬP NHẬT";
            this.UPDATECHECKER.Click += new System.EventHandler(this.UPDATECHECKER_Click);
            // 
            // DownloadIMGBtn
            // 
            this.DownloadIMGBtn.AutoToolTip = true;
            this.DownloadIMGBtn.BackColor = System.Drawing.Color.Silver;
            this.DownloadIMGBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DownloadIMGBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.DownloadIMGBtn.Image = ((System.Drawing.Image)(resources.GetObject("DownloadIMGBtn.Image")));
            this.DownloadIMGBtn.Name = "DownloadIMGBtn";
            this.DownloadIMGBtn.Size = new System.Drawing.Size(224, 20);
            this.DownloadIMGBtn.Text = "TẢI VỀ FILE ẢNH THỜI KHÓA BIỂU";
            this.DownloadIMGBtn.Click += new System.EventHandler(this.DownloadIMGBtn_Click);
            // 
            // tHToolStripMenuItem
            // 
            this.tHToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.tHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.tảiLạiGiaoDiệnToolStripMenuItem});
            this.tHToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tHToolStripMenuItem.Name = "tHToolStripMenuItem";
            this.tHToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tHToolStripMenuItem.Text = "THÊM..";
            this.tHToolStripMenuItem.Click += new System.EventHandler(this.tHToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tToolStripMenuItem.Text = "Tắt bật lại App";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // tảiLạiGiaoDiệnToolStripMenuItem
            // 
            this.tảiLạiGiaoDiệnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tảiLạiGiaoDiệnToolStripMenuItem.Name = "tảiLạiGiaoDiệnToolStripMenuItem";
            this.tảiLạiGiaoDiệnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tảiLạiGiaoDiệnToolStripMenuItem.Text = "Tải lại giao diện";
            this.tảiLạiGiaoDiệnToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiGiaoDiệnToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(884, 537);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://9a3libscript.glitch.me/tkbappview.html", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // COPYRIGHTS
            // 
            this.COPYRIGHTS.AutoSize = true;
            this.COPYRIGHTS.BackColor = System.Drawing.Color.Transparent;
            this.COPYRIGHTS.Dock = System.Windows.Forms.DockStyle.Right;
            this.COPYRIGHTS.Location = new System.Drawing.Point(802, 24);
            this.COPYRIGHTS.Name = "COPYRIGHTS";
            this.COPYRIGHTS.Size = new System.Drawing.Size(82, 13);
            this.COPYRIGHTS.TabIndex = 3;
            this.COPYRIGHTS.Text = "©9A3WEBDEV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.COPYRIGHTS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "XEM THỜI KHÓA BIỂU-Source Edition";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UPDATECHECKER;
        private System.Windows.Forms.Label label1;
        private System.Net.NetworkInformation.Ping ping1;
        private System.Windows.Forms.ToolStripMenuItem DownloadIMGBtn;
        private System.Windows.Forms.ToolStripMenuItem tHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiGiaoDiệnToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label COPYRIGHTS;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

