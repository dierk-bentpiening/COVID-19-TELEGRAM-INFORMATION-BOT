using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Data_Statistic_and_Analysis_Tool
{
    public partial class SQLLauncher : Form
    {
        public SQLLauncher()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ShowStatistics showSta;
            showSta = new ShowStatistics();

           
            showSta.Show();
            showSta.dataFill(txtSQL.Text);
        }

        private void chkDevelTrue_CheckedChanged(object sender, EventArgs e)
        {
            btnRun.Enabled = true;
        }

        private void SQLLauncher_Load(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            int iSelStart = txtSQL.SelectionStart;
            int iSelLength = txtSQL.SelectionLength;

            string tokens = "(auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|const|float|short|unsigned|continue|for|signed|void|default|goto|sizeof|volatile|do|if|static|while|order|by|desc|asc|select|where|like|upper|from)";

            Regex rex = new Regex(tokens);

            MatchCollection mc = rex.Matches(txtSQL.Text);

            int iStart = txtSQL.SelectionStart;

            foreach (Match m in mc)
            {
                int iStartIndex = m.Index;
                int iStopIndex = m.Length;

                txtSQL.Select(iStartIndex, iStopIndex);
                txtSQL.SelectionColor = Color.Blue;
                txtSQL.SelectionStart = iStart;
                txtSQL.SelectionColor = Color.Black;
            }

            txtSQL.SelectionStart = iSelStart;
            txtSQL.SelectionLength = iSelLength;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSQL.Clear();
            chkDevelTrue.Checked = false;
        }

        private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.AllocConsole();
        }

        private void interpreterStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interpreter.Shell();
        }
    }
    }


