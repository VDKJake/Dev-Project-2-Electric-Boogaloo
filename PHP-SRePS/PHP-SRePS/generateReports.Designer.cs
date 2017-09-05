namespace PHP_SRePS
{
    partial class generateReports
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
            this.csvReport = new System.Windows.Forms.Button();
            this.monthlyReport = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.weeklyReport = new System.Windows.Forms.Button();
            this.monthlyMonth = new System.Windows.Forms.ComboBox();
            this.monthlyYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // csvReport
            // 
            this.csvReport.Location = new System.Drawing.Point(71, 42);
            this.csvReport.Name = "csvReport";
            this.csvReport.Size = new System.Drawing.Size(145, 23);
            this.csvReport.TabIndex = 0;
            this.csvReport.Text = "Generate CSV Report";
            this.csvReport.UseVisualStyleBackColor = true;
            // 
            // monthlyReport
            // 
            this.monthlyReport.Location = new System.Drawing.Point(71, 141);
            this.monthlyReport.Name = "monthlyReport";
            this.monthlyReport.Size = new System.Drawing.Size(145, 23);
            this.monthlyReport.TabIndex = 1;
            this.monthlyReport.Text = "Generate Monthly Report";
            this.monthlyReport.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(105, 201);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // weeklyReport
            // 
            this.weeklyReport.Location = new System.Drawing.Point(71, 91);
            this.weeklyReport.Name = "weeklyReport";
            this.weeklyReport.Size = new System.Drawing.Size(145, 23);
            this.weeklyReport.TabIndex = 3;
            this.weeklyReport.Text = "Generate Weekly Report";
            this.weeklyReport.UseVisualStyleBackColor = true;
            // 
            // monthlyMonth
            // 
            this.monthlyMonth.FormattingEnabled = true;
            this.monthlyMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthlyMonth.Location = new System.Drawing.Point(222, 142);
            this.monthlyMonth.Name = "monthlyMonth";
            this.monthlyMonth.Size = new System.Drawing.Size(121, 21);
            this.monthlyMonth.TabIndex = 4;
            // 
            // monthlyYear
            // 
            this.monthlyYear.FormattingEnabled = true;
            this.monthlyYear.Location = new System.Drawing.Point(349, 142);
            this.monthlyYear.Name = "monthlyYear";
            this.monthlyYear.Size = new System.Drawing.Size(82, 21);
            this.monthlyYear.TabIndex = 5;
            // 
            // generateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.monthlyYear);
            this.Controls.Add(this.monthlyMonth);
            this.Controls.Add(this.weeklyReport);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.monthlyReport);
            this.Controls.Add(this.csvReport);
            this.Name = "generateReports";
            this.Text = "PHP-SRePS - Generate Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button csvReport;
        private System.Windows.Forms.Button monthlyReport;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button weeklyReport;
        private System.Windows.Forms.ComboBox monthlyMonth;
        private System.Windows.Forms.ComboBox monthlyYear;
    }
}