using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Statistic_and_Analysis_Tool
{
    public partial class ChangeConfiguration : Form
    {
        public ChangeConfiguration()
        {
            InitializeComponent();
        }

        private void ChangeConfiguration_Load(object sender, EventArgs e)
        {
            txtDB.Text = ConfigLoader.vDBPATH();
            txtFTPURI.Text = ConfigLoader.vFTPURI();
            txtUsername.Text = ConfigLoader.vFTPUSERNAME();
            txtPassword.Text = ConfigLoader.vFTPPASSWORD();
            txtPBURL.Text = ConfigLoader.vPUBLICURL();
            txtTelegram.Text = ConfigLoader.vBOTAUTHCODE();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String vConfigData = txtDB.Text + ";" + txtFTPURI.Text + ";" + txtUsername.Text + ";" + txtPassword.Text + ";" + txtPBURL.Text + ";" + txtTelegram.Text;
            try
            {
                System.IO.File.WriteAllText(@"C:\cbot.cfg", vConfigData);
                MessageBox.Show(" Daten geschrieben!", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(Exception ex)
            {
                Logging.WriteLog("Error: Cant write cbot.config " + ex);
            }
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
