using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Statistic_and_Analysis_Tool
{

    public partial class SQLLauncherDataViewer : Form
    {
        public SQLLauncherDataViewer()
        {
            InitializeComponent();
        }

        


        private void konsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.AllocConsole();
        }

        private void schließenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataFill(Globals.vSQLCMD, "first");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void dataFill(String vSQL, string vFirst)
        {
            try
            {
                if(vFirst == "first")
                {
                    Globals.vSQLCMD = vSQL;
                    SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                    connection.Open();
                    SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(vSQL, connection);
                    DataSet ds = new System.Data.DataSet();
                    dataadapter.Fill(ds, "Infektionen");
                    dvInfect.ClearSelection();
                    dvInfect.DataSource = ds.Tables[0];
                }
                else
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
            catch(Exception ex)
            {
                // todo

            }
            
            }

        private void aufsteigendToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String sqlString = Globals.vSQLCMD.ToString() + " order by ID ASC";
            dataFill(sqlString, "second");
        }

        private void absteigendToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String sqlString = Globals.vSQLCMD.ToString() + " order by ID DESC";
            dataFill(sqlString, "second");
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
                                    catch { }
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

    public static class Globals
    {
        public static String vSQLCMD = "";
    }

}
