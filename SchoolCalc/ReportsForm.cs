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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var rep = new Stimulsoft.Report.StiReport();
            rep.Load(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(Resources.DebitCreditTotal)));
            rep.DataSources.Clear();

            var ds = new DataSet("data");
            var dt = new DataTable();
            dt.TableName = "data";
            dt.Columns.Add("expense", typeof(string));
            dt.Columns.Add("credit", typeof(int));

            var q = @"
                select  e.desc expense,
                        coalesce(c.credit, 0) credit
                from expense e
                        left join (
                            select expense_id, sum(amount) credit
                            from credit
                            group by expense_id
                        ) c on e.rowid = c.expense_id
            ";
            var sqlda = new SQLiteDataAdapter(q, Globals.Connection);
            sqlda.Fill(dt);
            ds.Tables.Add(dt);

            var dtt = new DataTable();
            dtt.TableName = "total";
            dtt.Columns.Add("debit", typeof(int));
            dtt.Columns.Add("prev_saldo", typeof(int));
            q = @"
                select coalesce(sum(amount), 0) debit, " + Globals.Saldo_2016_2017 + @" prev_saldo 
                from debit
            ";
            sqlda = new SQLiteDataAdapter(q, Globals.Connection);
            sqlda.Fill(dtt);
            if (dtt.Rows.Count == 0)
                dtt.Rows.Add(new object[] { 0, int.Parse(Globals.Saldo_2016_2017) });
            ds.Tables.Add(dtt);

            rep.Dictionary.Clear();
            rep.RegData(ds.DataSetName, ds.DataSetName, ds);
            rep.Dictionary.Synchronize();
            rep.Render();

            ShowReport(rep);

        }

        private void ShowReport(StiReport rep)
        {
            var f = new Stimulsoft.Report.Viewer.StiViewerForm(rep);
            f.ViewerControl.ShowBookmarksPanel = false;
            f.ViewerControl.ShowContextMenu = false;
            f.ViewerControl.ShowThumbsPanel = false;
            f.ViewerControl.ShowStatusBar = false;
            f.ViewerControl.ShowSendEMail = false;
            f.ViewerControl.ShowPageDesign = false;
            f.ViewerControl.ShowPageViewMode = false;
            f.ViewerControl.ShowPageControl = false;
            f.ViewerControl.ShowFind = false;
            f.ViewerControl.ShowOpen = false;
            f.ViewerControl.ShowZoom = false;
            f.ViewerControl.ShowFullScreen = false;
            f.ViewerControl.ShowSaveDocumentFile = false;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rep = new Stimulsoft.Report.StiReport();
            rep.Load(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(Resources.ScholarDebt)));
            rep.DataSources.Clear();

            var ds = new DataSet("data");
            var dt = new DataTable();
            dt.TableName = "data";
            dt.Columns.Add("scholar", typeof(string));
            dt.Columns.Add("goal_name", typeof(string));
            dt.Columns.Add("goal_debit", typeof(int));
            dt.Columns.Add("goal_debt", typeof(int));

            var q = @"
                select s.name scholar,
                        g.desc goal_name,
                        coalesce(d.debit, 0) goal_debit,
                        g.per_scholar - coalesce(d.debit, 0) goal_debt
                from goal g, scholar s
                        left join (
                            select scholar_id, goal_id, sum(amount) debit
                            from debit
                            group by scholar_id, goal_id
                        ) d on g.rowid = d.goal_id and s.rowid = d.scholar_id
                where d.debit is null or d.debit < g.per_scholar
                order by s.name, g.desc
            ";

            var sqlda = new SQLiteDataAdapter(q, Globals.Connection);
            sqlda.Fill(dt);

            ds.Tables.Add(dt);
            rep.Dictionary.Clear();
            rep.RegData("data", "data", ds);
            rep.Dictionary.Synchronize();
            rep.Render();

            ShowReport(rep);
        }


        DataTable dtExp = new DataTable();
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            var sqlda = new SQLiteDataAdapter("select rowid, desc from expense", Globals.Connection);
            sqlda.Fill(dtExp);

            cmbExpense.ValueMember = "rowid";
            cmbExpense.DisplayMember = "desc";
            cmbExpense.DataSource = dtExp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbExpense.SelectedValue == null || (long)cmbExpense.SelectedValue <= 0)
                return;

            var rep = new Stimulsoft.Report.StiReport();
            rep.Load(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(Resources.Expense)));
            rep.DataSources.Clear();

            var ds = new DataSet("data");
            var dt = new DataTable();
            dt.TableName = "data";
            dt.Columns.Add("expense", typeof(string));
            dt.Columns.Add("credit", typeof(int));

            var q = @"
                    select desc expense, amount credit
                    from credit
                    where expense_id = " +  cmbExpense.SelectedValue;

            var sqlda = new SQLiteDataAdapter(q, Globals.Connection);
            sqlda.Fill(dt);
            ds.Tables.Add(dt);

            var dtt = new DataTable();
            dtt.TableName = "total";
            dtt.Columns.Add("expense", typeof(string));
            dtt.Rows.Add(new object[]{cmbExpense.Text});
            ds.Tables.Add(dtt);

            rep.Dictionary.Clear();
            rep.RegData(ds.DataSetName, ds.DataSetName, ds);
            rep.Dictionary.Synchronize();
            rep.Render();

            ShowReport(rep);


        }
    }
}
