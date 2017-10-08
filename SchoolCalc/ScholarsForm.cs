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
    public partial class ScholarsForm : Form
    {
        public ScholarsForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        private void ScholarsForm_Load(object sender, EventArgs e)
        {            
            var sqlda = new SQLiteDataAdapter("select rowid, name from scholar", Globals.Connection);                        
            sqlda.Fill(dt);

            grdScholars.AutoGenerateColumns = false;
            grdScholars.DataSource = dt;
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

        private void ScholarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            grdScholars.CurrentRow.DataGridView.EndEdit();
            grdScholars.EndEdit(DataGridViewDataErrorContexts.Commit);
            grdScholars.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CurrencyManager cm = (CurrencyManager)grdScholars.BindingContext[grdScholars.DataSource, grdScholars.DataMember];
            cm.EndCurrentEdit();

            var added = dt.GetChanges(DataRowState.Added);
            if (added != null && added.Rows.Count > 0)
                foreach (DataRow row in added.Rows)
                {
                    if ( row.IsNull("name") || row["name"].ToString() == "" )
                        continue;
                    var cmd = new SQLiteCommand("insert into scholar(name) values('" + row["name"] + "')", Globals.Connection);
                    cmd.ExecuteNonQuery();
                }

            var edited = dt.GetChanges(DataRowState.Modified);
            if (edited != null && edited.Rows.Count > 0)
                foreach (DataRow row in edited.Rows)
                {
                    var cmd = new SQLiteCommand("update scholar set name='" + row["name"] + "' where rowid=" + row["rowid"], Globals.Connection);
                    cmd.ExecuteNonQuery();
                }
        }
    }
}
