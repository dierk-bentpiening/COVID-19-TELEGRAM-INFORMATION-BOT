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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Data_Statistic_and_Analysis_Tool
{
    public partial class ShowStatistics : Form
    {
        public ShowStatistics()
        {
            InitializeComponent();
            dataFill("SELECT * FROM statistics");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ShowStatistics_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            
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

        public void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dvInfect.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dvInfect.ColumnCount);
                            pdfTable.DefaultCell.Padding = 10;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfTable.DefaultCell.BorderWidth = 1;


                            //Adding Header row
                            foreach (DataGridViewColumn column in dvInfect.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));

                                pdfTable.AddCell(cell);
                            }

                            //Adding DataRow
                            foreach (DataGridViewRow row in dvInfect.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    try
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                    catch { }
                                }
                            }

                            //Exporting to PDF

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Daten wurden Exportiert: " + sfd.FileName.ToString(), "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Keine Daten zum Exportieren!", "Info");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dvInfect.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Datei konnte nicht geschrieben werden." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dvInfect.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dvInfect.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dvInfect.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dvInfect.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    try
                                    {
                                        outputCsv[i] += dvInfect.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                    catch{ }
                                    }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Daten erfolgreich exportiert " + sfd.FileName.ToString(), "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Keine Eintragungen zum Exportieren", "Info");
            }
        }
      
    }
}
