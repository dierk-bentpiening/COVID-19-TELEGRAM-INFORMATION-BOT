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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datenToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void alleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInfectionStatistics shwIS;
            shwIS = new ShowInfectionStatistics();
            shwIS.Show();
        }

        private void alleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowStatistics shwSta;
            shwSta = new ShowStatistics();
            shwSta.Show();
        }
    }
}
