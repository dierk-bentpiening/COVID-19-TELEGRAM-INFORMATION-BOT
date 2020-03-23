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
    public partial class AddMessage : Form
    {
        public AddMessage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                txtMessage.Text = "Sie müssen alle Felder ausfüllen";
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
                    txtMessage.Text = " Daten in Datenbank geschrieben!";
               
                }
                catch (Exception ex)
                {
                    txtMessage.Text = "Es ist ein Fehler aufgetreten!";
                    throw new Exception(ex.Message);

                }
            }
        }
    }
}
