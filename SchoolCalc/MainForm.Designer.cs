namespace SchoolCalc
{
    partial class MainForm
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
            this.btnScholars = new System.Windows.Forms.Button();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnScholars
            // 
            this.btnScholars.Location = new System.Drawing.Point(12, 12);
            this.btnScholars.Name = "btnScholars";
            this.btnScholars.Size = new System.Drawing.Size(298, 42);
            this.btnScholars.TabIndex = 0;
            this.btnScholars.Text = "Ученики";
            this.btnScholars.UseVisualStyleBackColor = true;
            this.btnScholars.Click += new System.EventHandler(this.btnScholars_Click);
            // 
            // btnGoals
            // 
            this.btnGoals.Location = new System.Drawing.Point(12, 60);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(298, 42);
            this.btnGoals.TabIndex = 1;
            this.btnGoals.Text = "Цели (на что собираем)";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(12, 108);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(298, 42);
            this.btnDebit.TabIndex = 2;
            this.btnDebit.Text = "Приход (сдано)";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(138, 156);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(172, 42);
            this.btnCredit.TabIndex = 3;
            this.btnCredit.Text = "Расход (потрачено)";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(11, 204);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(299, 42);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Отчеты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.Location = new System.Drawing.Point(12, 156);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(120, 42);
            this.btnExpense.TabIndex = 5;
            this.btnExpense.Text = "Статьи расхода";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(162, 256);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(148, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "label1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 278);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.btnScholars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Классная \"бухгалтерия\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScholars;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Label lblVersion;
    }
}

