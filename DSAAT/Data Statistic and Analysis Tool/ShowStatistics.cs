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
    }
}
