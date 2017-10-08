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
    public partial class GoalsForm : Form
    {
        public GoalsForm()
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
        private void GoalsForm_Load(object sender, EventArgs e)
        {            
            var sqlda = new SQLiteDataAdapter("select rowid, desc, per_scholar from goal", Globals.Connection);                        
            sqlda.Fill(dt);

            grdGoals.AutoGenerateColumns = false;
            grdGoals.DataSource = dt;
        }

        private void GoalsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            grdGoals.CurrentRow.DataGridView.EndEdit();
            grdGoals.EndEdit(DataGridViewDataErrorContexts.Commit);
            grdGoals.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CurrencyManager cm = (CurrencyManager)grdGoals.BindingContext[grdGoals.DataSource, grdGoals.DataMember];
            cm.EndCurrentEdit();            

            var added = dt.GetChanges(DataRowState.Added);
            if (added != null && added.Rows.Count > 0)
                foreach (DataRow row in added.Rows)
                {
                    if ((row.IsNull("desc") || row["desc"].ToString() == "")
                         && (row.IsNull("per_scholar") || row["per_scholar"].ToString() == "")
                       )
                        continue;
                    var cmd = new SQLiteCommand("insert into goal(desc, per_scholar) values('" + row["desc"] + "'," + row["per_scholar"] + ")", Globals.Connection);
                    cmd.ExecuteNonQuery();
                }

            var edited = dt.GetChanges(DataRowState.Modified);
            if (edited != null && edited.Rows.Count > 0)
                foreach (DataRow row in edited.Rows)
                {
                    var cmd = new SQLiteCommand("update goal set desc='" + row["desc"] + "', per_scholar = " + row["per_scholar"] + "  where rowid=" + row["rowid"], Globals.Connection);
                    cmd.ExecuteNonQuery();
                }
        }
    }
}
