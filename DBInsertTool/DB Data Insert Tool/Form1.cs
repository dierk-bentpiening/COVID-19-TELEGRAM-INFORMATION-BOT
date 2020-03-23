using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_Data_Insert_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAusgangssperreForm addAUSGS;
            addAUSGS = new AddAusgangssperreForm();
            addAUSGS.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            AddMessage addMSG;
            addMSG = new AddMessage();
            addMSG.Show();
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            AddURL addURI;
            addURI = new AddURL();
            addURI.Show();
        }
    }
}
