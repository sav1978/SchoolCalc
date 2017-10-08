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
using Stimulsoft.Report;
using Stimulsoft.Base.Services;
using Stimulsoft.Base;

namespace SchoolCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblVersion.Text = "v" + Globals.Version;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Globals.DbName))
            {
                SQLiteConnection.CreateFile(Globals.DbName);

                using (var connection = new SQLiteConnection("Data Source=" + Globals.DbName +";Version=3;"))
                {
                    connection.Open();

                    string sql = @"
                        CREATE TABLE `scholar` (
                          `name` TEXT
                        );

                        CREATE TABLE  `goal` (
                          `desc` TEXT,
                          `per_scholar` INTEGER
                        );

                        CREATE TABLE `debit` (
                          `goal_id` INTEGER,
                          `scholar_id` INTEGER,
                          `amount` INTEGER
                        );

                        CREATE TABLE `expense` (
                          `desc` TEXT
                        );

                        CREATE TABLE `credit` (
                          `expense_id` INTEGER,
                          `desc` TEXT,
                          `amount` INTEGER
                        );
                    ";

                    var cmd = new SQLiteCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }
            }

            Globals.Connection = new SQLiteConnection("Data Source=" + Globals.DbName + ";Version=3;");
            Globals.Connection.Open();

            foreach (StiService service in StiConfig.Services.GetServices(typeof(Stimulsoft.Report.Export.StiExportService)))
            {
                if (!(service is Stimulsoft.Report.Export.StiPdfExportService) && !(service is Stimulsoft.Report.Export.StiImageExportService))
                {
                    service.ServiceEnabled = false;
                    continue;
                }
                //
            } 
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Globals.Connection.Close();
            }
            catch { }
        }

        private void btnScholars_Click(object sender, EventArgs e)
        {
            var f = new ScholarsForm();
            f.ShowDialog();
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            var f = new GoalsForm();
            f.ShowDialog();
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            var f = new DebitForm();
            f.ShowDialog();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            var f = new CreditForm();
            f.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var f = new ReportsForm();
            f.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            var f = new ExpenseForm();
            f.ShowDialog();
        }

    }
}
