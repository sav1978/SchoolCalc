namespace SchoolCalc
{
    partial class GoalsForm
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
            this.grdGoals = new System.Windows.Forms.DataGridView();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per_scholar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdGoals)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGoals
            // 
            this.grdGoals.AllowUserToDeleteRows = false;
            this.grdGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGoals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desc,
            this.per_scholar,
            this.rowid});
            this.grdGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGoals.Location = new System.Drawing.Point(0, 0);
            this.grdGoals.Name = "grdGoals";
            this.grdGoals.Size = new System.Drawing.Size(574, 356);
            this.grdGoals.TabIndex = 0;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "desc";
            this.desc.HeaderText = "Описание";
            this.desc.Name = "desc";
            this.desc.Width = 300;
            // 
            // per_scholar
            // 
            this.per_scholar.DataPropertyName = "per_scholar";
            this.per_scholar.HeaderText = "Сколько (на каждого ученика)";
            this.per_scholar.Name = "per_scholar";
            this.per_scholar.Width = 200;
            // 
            // rowid
            // 
            this.rowid.HeaderText = "rowid";
            this.rowid.Name = "rowid";
            this.rowid.Visible = false;
            // 
            // GoalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 356);
            this.Controls.Add(this.grdGoals);
            this.Name = "GoalsForm";
            this.ShowInTaskbar = false;
            this.Text = "На что собираем деньги (цели)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoalsForm_FormClosing);
            this.Load += new System.EventHandler(this.GoalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGoals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn per_scholar;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
    }
}