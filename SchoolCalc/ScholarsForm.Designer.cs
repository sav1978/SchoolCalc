namespace SchoolCalc
{
    partial class ScholarsForm
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
            this.grdScholars = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdScholars)).BeginInit();
            this.SuspendLayout();
            // 
            // grdScholars
            // 
            this.grdScholars.AllowUserToDeleteRows = false;
            this.grdScholars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScholars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.rowid});
            this.grdScholars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdScholars.Location = new System.Drawing.Point(0, 0);
            this.grdScholars.Name = "grdScholars";
            this.grdScholars.Size = new System.Drawing.Size(496, 356);
            this.grdScholars.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // rowid
            // 
            this.rowid.HeaderText = "rowid";
            this.rowid.Name = "rowid";
            this.rowid.Visible = false;
            // 
            // ScholarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.grdScholars);
            this.Name = "ScholarsForm";
            this.ShowInTaskbar = false;
            this.Text = "Список учеников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScholarsForm_FormClosing);
            this.Load += new System.EventHandler(this.ScholarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdScholars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdScholars;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
    }
}