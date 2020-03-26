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
    public partial class ShowConfig : Form
    {
        public ShowConfig()
        {
            InitializeComponent();
        }

        private void ShowConfig_Load(object sender, EventArgs e)
        {
            txtDB.Text = ConfigLoader.vDBPATH();
            txtFTPURI.Text = ConfigLoader.vFTPURI();
            txtUsername.Text = ConfigLoader.vFTPUSERNAME();
            txtPassword.Text = ConfigLoader.vFTPPASSWORD();
            txtPBURL.Text = ConfigLoader.vPUBLICURL();
            txtTelegram.Text = ConfigLoader.vBOTAUTHCODE();
            txtDB.Enabled = false;
            txtFTPURI.Enabled = false;
            txtPassword.Enabled = false;
            txtPBURL.Enabled = false;
            txtTelegram.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
