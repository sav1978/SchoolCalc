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
    public partial class CreditForm : Form
    {
        public CreditForm()
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
            var goalTable = new DataTable();
            var sqlda = new SQLiteDataAdapter("select rowid, desc from expense", Globals.Connection);
            sqlda.Fill(goalTable);
            expense.DataSource = goalTable;
            expense.ValueMember = "rowid";
            expense.DisplayMember = "desc";
            expense.DataPropertyName = "expense_id";


            sqlda = new SQLiteDataAdapter("select rowid, expense_id, desc, amount from credit", Globals.Connection);                        
            sqlda.Fill(dt);
            grdCredits.AutoGenerateColumns = false;
            grdCredits.DataSource = dt;
        }

        private void DebitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            grdCredits.CurrentRow.DataGridView.EndEdit();
            grdCredits.EndEdit(DataGridViewDataErrorContexts.Commit);
            grdCredits.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CurrencyManager cm = (CurrencyManager)grdCredits.BindingContext[grdCredits.DataSource, grdCredits.DataMember];
            cm.EndCurrentEdit();

            var added = dt.GetChanges(DataRowState.Added);
            if (added != null && added.Rows.Count > 0)
                foreach (DataRow row in added.Rows)
                {
                    if ((row.IsNull("expense_id") || row["expense_id"].ToString() == "")
                         && (row.IsNull("desc") || row["desc"].ToString() == "")
                         && (row.IsNull("amount") || row["amount"].ToString() == "")
                       )
                        continue;
                    var cmd = new SQLiteCommand("insert into credit(expense_id, desc, amount) values(" + row["expense_id"] + ", '" + row["desc"] + "', " + row["amount"] + ")", Globals.Connection);
                    cmd.ExecuteNonQuery();
                }

            var edited = dt.GetChanges(DataRowState.Modified);
            if (edited != null && edited.Rows.Count > 0)
                foreach (DataRow row in edited.Rows)
                {
                    var cmd = new SQLiteCommand("update credit set expense_id=" + row["expense_id"] + ", desc = '" + row["desc"] + "', amount=" + row["amount"] + "  where rowid=" + row["rowid"], Globals.Connection);
                    cmd.ExecuteNonQuery();
                }
        }
    }
}
