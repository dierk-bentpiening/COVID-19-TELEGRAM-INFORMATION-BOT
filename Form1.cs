using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Data_Statistic_and_Analysis_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Logging.WriteLog("Start Application - Main Window Intializing");
            InitializeComponent();
        }

        private void datenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
        private void alleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logging.WriteLog("Loading Infection Statistics");
            ShowInfectionStatistics shwInfect = new ShowInfectionStatistics();
            //Thread infecShwThread = new Thread(shwInfect.Show);
            //infecShwThread.Start();
            shwInfect.Show();
        }

        private void alleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowStatistics shwSta;
            shwSta = new ShowStatistics();
            shwSta.Show();
            Console.WriteLine("*-*-* Show Bot statistics");
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
            Console.WriteLine("*-*-* Show Info Window");
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
            Console.WriteLine("*-*-* Open Add Ausganssperre Window");
        }

        private void nachrichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMesage addMe;
            addMe = new AddMesage();
            addMe.Show();
            Console.WriteLine("*-*-* Open Add Message Window");
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddURL addURL;
            addURL = new AddURL();
            addURL.Show();
            Console.WriteLine("*-*-* Open Add URL Window");
        }

        private void anzeigenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Debug.AllocConsole();
           
            }

        private void weltweitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Thread jhuThread = new Thread(jhuDataExtraktion.startExtractAsync);
            jhuThread.Start();
        }

        private void botToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread botStartThread = new Thread(StartBot.startingBot);
            botStartThread.Start();
        }

        private void neuErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Thread createDBThread = new Thread(DBBuilder.buildDB);
                createDBThread.Start();
            }
            catch(Exception ex)
            {
                Logging.WriteLog("Erront cant create DB " + ex);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anzeigenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowConfig shwCfg = new ShowConfig();
            shwCfg.Show();
        }

        private void verändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeConfiguration chgCFG = new ChangeConfiguration();
            chgCFG.Show();
        }

        private void pictureLOGO_Click(object sender, EventArgs e)
        {

        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void ausführenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLLauncher sqlLauncherW = new SQLLauncher();
            sqlLauncherW.Show();
        }

        private void fTPBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aufFTPServerSichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbBackup dbBackup = new DbBackup();
            dbBackup.Show();
        }
    }
    }

    

