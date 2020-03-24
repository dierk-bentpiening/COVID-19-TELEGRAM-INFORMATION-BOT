using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Data_Statistic_and_Analysis_Tool
{
    public partial class ShowStatistics : Form
    {
        public ShowStatistics()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ShowStatistics_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            dataFill("SELECT * FROM statistics");
        }

        public void dataFill(String vSQL)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
            connection.Open();
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(vSQL, connection);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds, "Infektionen");
            dvInfect.ClearSelection();
            dvInfect.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataFill("SELECT * FROM statistics");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void clearSearch()
        {
            txtSearch.Clear();
            cChatID.Checked = false;
            cQuerryType.Checked = false;
            cDateTime.Checked = false;
            cChatID.Enabled = true;
            cQuerryType.Enabled = true;
            cDateTime.Enabled = true;
            btnSearch.Enabled = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string vSearchText = txtSearch.Text.ToString();
            if (cChatID.Checked == true)
            {
                dataFill("SELECT * FROM statistics where CHATID = '" + vSearchText + "'");
                clearSearch();

            }
            if (cQuerryType.Checked == true)
            {
                dataFill("SELECT * FROM statistics where QUERRYTYPE like upper('%" + vSearchText + "%')");
                clearSearch();

            }
            if (cDateTime.Checked == true)
            {
                dataFill("SELECT * FROM statistics where DATETIME like upper('%" + vSearchText + "%')");
                clearSearch();

            }
            
        }

        private void cChatID_CheckedChanged(object sender, EventArgs e)
        {
            if (cChatID.Checked == true)
            {
                cQuerryType.Enabled = false;
                cDateTime.Enabled = false;
            }
            
        }

        private void cQuerryType_CheckedChanged(object sender, EventArgs e)
        {
            if (cQuerryType.Checked == true)
            {
                cChatID.Enabled = false;
                cDateTime.Enabled = false;
            }
           
        }

        private void cDateTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cDateTime.Checked == true)
            {
                cChatID.Enabled = false;
                cQuerryType.Enabled = false;
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

   

        private void absteigendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataFill("SELECT * FROM statistics ORDER BY ID DESC");
        }

        private void aufsteigendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataFill("SELECT * FROM statistics ORDER BY ID ASC");
        }

        private void dvInfect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLLauncher sqlLauncher;
            sqlLauncher = new SQLLauncher();
            sqlLauncher.Show();
        }
    }
}
