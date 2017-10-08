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

namespace SchoolCalc
{
    public partial class DebitForm : Form
    {
        public DebitForm()
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

        DataTable dt = new DataTable();
        private void DebitForm_Load(object sender, EventArgs e)
        {
            var scholarTable = new DataTable();
            var sqlda = new SQLiteDataAdapter("select rowid, name from scholar", Globals.Connection);
            sqlda.Fill(scholarTable);
            scholar.DataSource = scholarTable;
            scholar.ValueMember = "rowid";
            scholar.DisplayMember = "name";
            scholar.DataPropertyName = "scholar_id";


            var goalTable = new DataTable();
            sqlda = new SQLiteDataAdapter("select rowid, desc from goal", Globals.Connection);
            sqlda.Fill(goalTable);
            goal.DataSource = goalTable;
            goal.ValueMember = "rowid";
            goal.DisplayMember = "desc";
            goal.DataPropertyName = "goal_id";


            sqlda = new SQLiteDataAdapter("select rowid, goal_id, scholar_id, amount from debit", Globals.Connection);                        
            sqlda.Fill(dt);
            grdDebits.AutoGenerateColumns = false;
            grdDebits.DataSource = dt;
        }

        private void DebitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            grdDebits.CurrentRow.DataGridView.EndEdit();
            grdDebits.EndEdit(DataGridViewDataErrorContexts.Commit);
            grdDebits.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CurrencyManager cm = (CurrencyManager)grdDebits.BindingContext[grdDebits.DataSource, grdDebits.DataMember];
            cm.EndCurrentEdit();

            var added = dt.GetChanges(DataRowState.Added);
            if (added != null && added.Rows.Count > 0)
                foreach (DataRow row in added.Rows)
                {
                    if ( (row.IsNull("goal_id") || row["goal_id"].ToString() == "")
                         && (row.IsNull("scholar_id") || row["scholar_id"].ToString() == "")
                         && (row.IsNull("amount") || row["amount"].ToString() == "")
                       )
                        continue;
                    var cmd = new SQLiteCommand("insert into debit(goal_id, scholar_id, amount) values(" + row["goal_id"] + "," + row["scholar_id"] + ", " + row["amount"] + ")", Globals.Connection);
                    cmd.ExecuteNonQuery();
                }

            var edited = dt.GetChanges(DataRowState.Modified);
            if (edited != null && edited.Rows.Count > 0)
                foreach (DataRow row in edited.Rows)
                {
                    var cmd = new SQLiteCommand("update debit set goal_id=" + row["goal_id"] + ", scholar_id = " + row["scholar_id"] + ", amount=" + row["amount"] + "  where rowid=" + row["rowid"], Globals.Connection);
                    cmd.ExecuteNonQuery();
                }
        }
    }
}
