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
    public partial class AddURL : Form
    {
        public AddURL()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                connection.Open();

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO URLLIST (ID, URL) VALUES (NULL, $URL)", connection);
                insertSQL.Parameters.Add("$URL", System.Data.DbType.String).Value = txtURL.Text;

                try
                {
                    insertSQL.ExecuteNonQuery();
                    MessageBox.Show(" Daten in Datenbank geschrieben!", "Abgeschlossen",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception(ex.Message);

                }
            }
        }

        private void AddURL_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                connection.Open();

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO URLLIST (ID, URL) VALUES (NULL, $URL)", connection);
                insertSQL.Parameters.Add("$URL", System.Data.DbType.String).Value = txtURL.Text;

                try
                {
                    insertSQL.ExecuteNonQuery();
                    MessageBox.Show(" Daten in Datenbank geschrieben!", "Abgeschlossen",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception(ex.Message);

                }
            }
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
