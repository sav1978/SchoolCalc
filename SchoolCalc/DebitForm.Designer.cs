namespace SchoolCalc
{
    partial class DebitForm
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
            this.grdDebits = new System.Windows.Forms.DataGridView();
            this.scholar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDebits)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDebits
            // 
            this.grdDebits.AllowUserToDeleteRows = false;
            this.grdDebits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDebits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scholar,
            this.goal,
            this.amount,
            this.rowid});
            this.grdDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDebits.Location = new System.Drawing.Point(0, 0);
            this.grdDebits.Name = "grdDebits";
            this.grdDebits.Size = new System.Drawing.Size(574, 356);
            this.grdDebits.TabIndex = 0;
            // 
            // scholar
            // 
            this.scholar.DataPropertyName = "scholar_id";
            this.scholar.HeaderText = "Ученик";
            this.scholar.Name = "scholar";
            this.scholar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scholar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scholar.Width = 200;
            // 
            // goal
            // 
            this.goal.DataPropertyName = "goal_id";
            this.goal.HeaderText = "Цель";
            this.goal.Name = "goal";
            this.goal.Width = 200;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Сдано";
            this.amount.Name = "amount";
            // 
            // rowid
            // 
            this.rowid.HeaderText = "rowid";
            this.rowid.Name = "rowid";
            this.rowid.Visible = false;
            // 
            // DebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 356);
            this.Controls.Add(this.grdDebits);
            this.Name = "DebitForm";
            this.ShowInTaskbar = false;
            this.Text = "Приход (сдано)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebitForm_FormClosing);
            this.Load += new System.EventHandler(this.DebitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDebits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDebits;
        private System.Windows.Forms.DataGridViewComboBoxColumn scholar;
        private System.Windows.Forms.DataGridViewComboBoxColumn goal;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
    }
}