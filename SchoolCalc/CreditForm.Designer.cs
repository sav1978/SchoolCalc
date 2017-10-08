namespace SchoolCalc
{
    partial class CreditForm
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
            this.grdCredits = new System.Windows.Forms.DataGridView();
            this.expense = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCredits
            // 
            this.grdCredits.AllowUserToDeleteRows = false;
            this.grdCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCredits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expense,
            this.desc,
            this.amount,
            this.rowid});
            this.grdCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCredits.Location = new System.Drawing.Point(0, 0);
            this.grdCredits.Name = "grdCredits";
            this.grdCredits.Size = new System.Drawing.Size(574, 356);
            this.grdCredits.TabIndex = 0;
            // 
            // expense
            // 
            this.expense.DataPropertyName = "expense_id";
            this.expense.HeaderText = "Статья расхода";
            this.expense.Name = "expense";
            this.expense.Width = 200;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "desc";
            this.desc.HeaderText = "Описание";
            this.desc.Name = "desc";
            this.desc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.desc.Width = 200;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Потрачено";
            this.amount.Name = "amount";
            // 
            // rowid
            // 
            this.rowid.HeaderText = "rowid";
            this.rowid.Name = "rowid";
            this.rowid.Visible = false;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 356);
            this.Controls.Add(this.grdCredits);
            this.Name = "CreditForm";
            this.ShowInTaskbar = false;
            this.Text = "Расход (потрачено)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebitForm_FormClosing);
            this.Load += new System.EventHandler(this.DebitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCredits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCredits;
        private System.Windows.Forms.DataGridViewComboBoxColumn expense;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
    }
}