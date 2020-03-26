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
    public partial class AddAusgangssperre : Form
    {
        public AddAusgangssperre()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLKN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddAusgangssperre_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLKN.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtBehörde.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtBundesland.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtPLZ.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
            else
            {
                String vLKN = txtLKN.Text.ToString();
                String vBehörde = txtBehörde.Text.ToString();
                String vBundesland = txtBundesland.Text.ToString();
                String vPLZ = txtPLZ.Text.ToString();
                String vVon = dtnVON.Value.ToString();
                string vBis = dtnBIS.Value.ToString();
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                connection.Open();

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO AusgangssperrenLK (ID, LKN, VON, BIS, Bundesland, BEHÖRDE, PLZ) VALUES (NULL, $LKN, $VON, $BIS, $BUNDESLAND, $BEHÖRDE, $PLZ)", connection);
                insertSQL.Parameters.Add("$LKN", System.Data.DbType.String).Value = vLKN;
                insertSQL.Parameters.Add("$VON", System.Data.DbType.String).Value = vVon;
                insertSQL.Parameters.Add("$BIS", System.Data.DbType.String).Value = vBis;
                insertSQL.Parameters.Add("$BUNDESLAND", System.Data.DbType.String).Value = vBundesland;
                insertSQL.Parameters.Add("$BEHÖRDE", System.Data.DbType.String).Value = vBehörde;
                insertSQL.Parameters.Add("$PLZ", System.Data.DbType.String).Value = vPLZ;

                Console.WriteLine("### WRITTEN AUSGANGSSPERRE DATA IN DB");
                try
                {
                    insertSQL.ExecuteNonQuery();
                    MessageBox.Show(" Daten in Datenbank geschrieben!", "Abgeschlossen",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLKN.Clear();
                    txtBehörde.Clear();
                    txtBundesland.Clear();
                    txtPLZ.Clear();
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
            if (string.IsNullOrWhiteSpace(txtLKN.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtBehörde.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtBundesland.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtPLZ.Text))
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen", "Warnung!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                String vLKN = txtLKN.Text.ToString();
                String vBehörde = txtBehörde.Text.ToString();
                String vBundesland = txtBundesland.Text.ToString();
                String vPLZ = txtPLZ.Text.ToString();
                String vVon = dtnVON.Value.ToString();
                string vBis = dtnBIS.Value.ToString();
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                connection.Open();

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO AusgangssperrenLK (ID, LKN, VON, BIS, Bundesland, BEHÖRDE, PLZ) VALUES (NULL, $LKN, $VON, $BIS, $BUNDESLAND, $BEHÖRDE, $PLZ)", connection);
                insertSQL.Parameters.Add("$LKN", System.Data.DbType.String).Value = vLKN;
                insertSQL.Parameters.Add("$VON", System.Data.DbType.String).Value = vVon;
                insertSQL.Parameters.Add("$BIS", System.Data.DbType.String).Value = vBis;
                insertSQL.Parameters.Add("$BUNDESLAND", System.Data.DbType.String).Value = vBundesland;
                insertSQL.Parameters.Add("$BEHÖRDE", System.Data.DbType.String).Value = vBehörde;
                insertSQL.Parameters.Add("$PLZ", System.Data.DbType.String).Value = vPLZ;

                Console.WriteLine("### WRITTEN AUSGANGSSPERRE DATA IN DB");
                try
                {
                    insertSQL.ExecuteNonQuery();
                    MessageBox.Show(" Daten in Datenbank geschrieben!", "Abgeschlossen",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLKN.Clear();
                    txtBehörde.Clear();
                    txtBundesland.Clear();
                    txtPLZ.Clear();
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
    }
}
