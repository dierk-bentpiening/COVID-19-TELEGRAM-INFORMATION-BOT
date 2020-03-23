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
using System.IO;

namespace Data_Statistic_and_Analysis_Tool
{
    public partial class ShowInfectionStatistics : Form
    {
        private int nodeHeight;

        public ShowInfectionStatistics()
        {
            
           
            
            InitializeComponent();
        }

        public void showData()
        {
           
        }
        
        private void ShowInfectionStatistics_Load(object sender, EventArgs e)
        {


            dataFill("Select * from InfektionStatistics");

          
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void neusteZuerstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataFill("Select * from InfektionStatistics ORDER BY INFECTIONCOUNT ASC");
            
        }
    }
}
