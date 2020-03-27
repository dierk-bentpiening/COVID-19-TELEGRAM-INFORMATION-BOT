using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Statistic_and_Analysis_Tool
{
    public partial class DbBackup : Form
    {
        public DbBackup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try

            {
                String vDateTime = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
                // FTP UPLOAD FUNCTION
                string vFileNameBuffer = "DataBaseBackup-" + vDateTime + ".sqlite3";
                String sourcefilepath = ConfigLoader.vDBPATH();
                String ftpurl = txtURL.Text + "/" + vFileNameBuffer; // e.g. ftp://serverip/foldername/foldername
                String ftpusername = txtUsername.Text;
                String ftppassword = txtPassword.Text;
                string ftpfullpath = ftpurl;
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential(ftpusername, ftppassword);

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                FileStream fs = File.OpenRead(ConfigLoader.vDBPATH());
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                Stream ftpstream = ftp.GetRequestStream();
                ftpstream.Write(buffer, 0, buffer.Length);
                ftpstream.Close();
                Console.WriteLine("### UPLOADED: " + vFileNameBuffer + " to: " + ftpurl);
                MessageBox.Show("Datenbank auf " + ftpurl + " gesichert", "Abgeschlossen",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

                // using (WebClient webClient = new WebClient())
                // {
                //     webClient.Credentials = new NetworkCredential(ConfigLoader.vFTPUSERNAME(), ConfigLoader.vFTPPASSWORD());
                //     await webClient.UploadFileTaskAsync(ConfigLoader.vFTPURI(), WebRequestMethods.Ftp.UploadFile, vDateiName);
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString(), "ERROR",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
        }
    }
}
