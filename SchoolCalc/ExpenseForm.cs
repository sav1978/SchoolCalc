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
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
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
        private void ScholarsForm_Load(object sender, EventArgs e)
        {
            var sqlda = new SQLiteDataAdapter("select rowid, desc from expense", Globals.Connection);                        
            sqlda.Fill(dt);

            grdExpense.AutoGenerateColumns = false;
            grdExpense.DataSource = dt;
        }

        private void ScholarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            grdExpense.CurrentRow.DataGridView.EndEdit();
            grdExpense.EndEdit(DataGridViewDataErrorContexts.Commit);
            grdExpense.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CurrencyManager cm = (CurrencyManager)grdExpense.BindingContext[grdExpense.DataSource, grdExpense.DataMember];
            cm.EndCurrentEdit();

            var added = dt.GetChanges(DataRowState.Added);
            if (added != null && added.Rows.Count > 0)
                foreach (DataRow row in added.Rows)
                {
                    if ( row.IsNull("desc") || row["desc"].ToString() == "" )
                        continue;
                    var cmd = new SQLiteCommand("insert into expense(desc) values('" + row["desc"] + "')", Globals.Connection);
                    cmd.ExecuteNonQuery();
                }

            var edited = dt.GetChanges(DataRowState.Modified);
            if (edited != null && edited.Rows.Count > 0)
                foreach (DataRow row in edited.Rows)
                {
                    var cmd = new SQLiteCommand("update expense set desc='" + row["desc"] + "' where rowid=" + row["rowid"], Globals.Connection);
                    cmd.ExecuteNonQuery();
                }
        }

        private void grdExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
