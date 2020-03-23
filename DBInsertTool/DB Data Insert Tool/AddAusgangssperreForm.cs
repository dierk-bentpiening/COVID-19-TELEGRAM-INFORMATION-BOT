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

namespace DB_Data_Insert_Tool
{
    public partial class AddAusgangssperreForm : Form
    {
        public AddAusgangssperreForm()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLKN.Text))
            {
                lblErrorMessage.Text = "Sie müssen alle Felder ausfüllen";
            }
            else if (string.IsNullOrWhiteSpace(txtBehörde.Text))
            {
                lblErrorMessage.Text = "Sie müssen alle Felder ausfüllen";
            }
            else if (string.IsNullOrWhiteSpace(txtBundesland.Text))
            {
                lblErrorMessage.Text = "Sie müssen alle Felder ausfüllen";
            }
            else if (string.IsNullOrWhiteSpace(txtPLZ.Text))
            {
                lblErrorMessage.Text = "Sie müssen alle Felder ausfüllen";
            }
            else
            {
                String vLKN = txtLKN.Text.ToString();
                String vBehörde = txtBehörde.Text.ToString();
                String vBundesland = txtBundesland.Text.ToString();
                String vPLZ = txtPLZ.Text.ToString();
                String vVon = dteVON.Value.ToString();
                string vBis = dteBis.Value.ToString();
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
                    lblErrorMessage.Text = " Daten in Datenbank geschrieben!";
                    txtLKN.Clear();
                    txtBehörde.Clear();
                    txtBundesland.Clear();
                    txtPLZ.Clear();
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Es ist ein Fehler aufgetreten!";
                    throw new Exception(ex.Message);
                    
                }

            }
        }
    }
}
