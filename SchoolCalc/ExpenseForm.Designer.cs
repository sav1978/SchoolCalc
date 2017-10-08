namespace SchoolCalc
{
    partial class ExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdExpense = new System.Windows.Forms.DataGridView();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // grdExpense
            // 
            this.grdExpense.AllowUserToResizeRows = false;
            this.grdExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExpense.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowid,
            this.desc});
            this.grdExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExpense.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grdExpense.Location = new System.Drawing.Point(0, 0);
            this.grdExpense.MultiSelect = false;
            this.grdExpense.Name = "grdExpense";
            this.grdExpense.ReadOnly = true;
            this.grdExpense.Size = new System.Drawing.Size(496, 356);
            this.grdExpense.TabIndex = 0;
            this.grdExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExpense_CellContentClick);
            // 
            // rowid
            // 
            this.rowid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowid.HeaderText = "ID";
            this.rowid.Name = "rowid";
            this.rowid.ReadOnly = true;
            this.rowid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowid.Width = 50;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "desc";
            this.desc.HeaderText = "Статья расхода";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.grdExpense);
            this.Name = "ExpenseForm";
            this.ShowInTaskbar = false;
            this.Text = "Список статей расходов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScholarsForm_FormClosing);
            this.Load += new System.EventHandler(this.ScholarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}