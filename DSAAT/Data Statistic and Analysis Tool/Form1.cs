﻿using System;
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

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoFenster ifFenster;
            ifFenster = new InfoFenster();
            ifFenster.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ausgangssperreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAusgangssperre addAUSG;
            addAUSG = new AddAusgangssperre();
            addAUSG.Show();
        }

        private void nachrichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMesage addMe;
            addMe = new AddMesage();
            addMe.Show();
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddURL addURL;
            addURL = new AddURL();
            addURL.Show();
        }
    }
}
