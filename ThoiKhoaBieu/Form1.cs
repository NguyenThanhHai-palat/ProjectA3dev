using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ping p1 = new Ping();
            PingReply PR = p1.Send("192.168.1.1");
        }

        void updatejoin(){}
        private void UPDATECHECKER_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Ứng Dụng Sẽ Tải Về Bản Mới Nhất Và Tự Động Cập Nhật.\nBạn Có Đồng Ý?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                using (var clientdow = new WebClient())
                {
                    clientdow.DownloadFile("https://static-voidupdate.palat001.cf/update/appnet/tkbappview/update", "VerUP.exe");
                }
                MessageBox.Show("Đã Tải Về Sẵn Sàng Cập Nhật !\nỨng Dụng Sẽ Tự Tắt! ", "Thông Báo");
                Process.Start("atu.exe");
            }
            else
            {
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.GetElementById("menu").Style = "display:none";
        }

        private void DownloadIMGBtn_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                try
                {
                    SaveFileDialog saveFile1 = new SaveFileDialog();

                    saveFile1.DefaultExt = "*.png";
                    saveFile1.Filter = "PNG files|*.png|All files (*.*)|*.*";

                    if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                       saveFile1.FileName.Length > 0)
                    {
                        client.DownloadFile(
                        "https://satictkb.9a3thsp.cf/tkbviewerdownloader/",saveFile1.FileName);
                        MessageBox.Show("ĐÃ TẢI XUỐNG ẢNH Ở '" + saveFile1.FileName + "'", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    while (ex != null)
                    {
                        Console.WriteLine(ex.Message);
                        ex = ex.InnerException;
                        MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("reload.exe");

        }

        private void tảiLạiGiaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ping p1 = new Ping();
            PingReply PR = p1.Send("192.168.1.1");
            webBrowser1.Refresh();
        }

        private void ContactANIBTN_Click(object sender, EventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://forms.gle/6TjG4ebFVZJXvp3HA");
        }

        private void autoupdatebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ứng Dụng Sẽ Tự Động Cập Nhật. Bạn Có Đồng Ý?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
             
                using (var clientdow = new WebClient())
                {
                    clientdow.DownloadFile("https://static-voidupdate.palat001.cf/update/appnet/tkbappview/update", "VerUP.exe");
                }
                Process.Start("atu.exe");
            }
            else
            {
            }
        }

        private void tHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void chosemusicMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("playermusic.exe");
        }
    }
}
