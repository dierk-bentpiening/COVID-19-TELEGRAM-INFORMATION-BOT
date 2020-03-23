using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DB_Data_Insert_Tool
{
    public partial class AddURL : Form
    {
        public AddURL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddURL_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                lblErrorMessage.Text = "Sie müssen alle Felder ausfüllen";
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                connection.Open();

                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO URLLIST (ID, URL) VALUES (NULL, $URL)", connection);
                insertSQL.Parameters.Add("$URL", System.Data.DbType.String).Value = txtURL.Text;


                Console.WriteLine("### WRITTEN AUSGANGSSPERRE DATA IN DB");
                try
                {
                    insertSQL.ExecuteNonQuery();
                    lblErrorMessage.Text = " Daten in Datenbank geschrieben!";

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
