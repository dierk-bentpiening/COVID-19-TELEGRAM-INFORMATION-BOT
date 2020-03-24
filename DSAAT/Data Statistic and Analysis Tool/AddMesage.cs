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
    public partial class AddMesage : Form
    {
        public AddMesage()
        {
            InitializeComponent();
        }

        private void AddMesage_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                connection.Open();

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO PMESSAGES (ID, MESSAGE) VALUES (NULL, $MESSAGE)", connection);
                insertSQL.Parameters.Add("$MESSAGE", System.Data.DbType.String).Value = txtMessage.Text;


                Console.WriteLine("### WRITTEN AUSGANGSSPERRE DATA IN DB");
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

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                connection.Open();

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO PMESSAGES (ID, MESSAGE) VALUES (NULL, $MESSAGE)", connection);
                insertSQL.Parameters.Add("$MESSAGE", System.Data.DbType.String).Value = txtMessage.Text;


                Console.WriteLine("### WRITTEN AUSGANGSSPERRE DATA IN DB");
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

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
