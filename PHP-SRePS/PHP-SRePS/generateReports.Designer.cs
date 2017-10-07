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
            this.monthlyReport = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.weeklyReport = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.weeklyLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.pickMonth = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.pickYear = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthlyReport
            // 
            this.monthlyReport.Location = new System.Drawing.Point(26, 110);
            this.monthlyReport.Name = "monthlyReport";
            this.monthlyReport.Size = new System.Drawing.Size(135, 23);
            this.monthlyReport.TabIndex = 1;
            this.monthlyReport.Text = "Generate Monthly Report";
            this.monthlyReport.UseVisualStyleBackColor = true;
            this.monthlyReport.Click += new System.EventHandler(this.monthlyReport_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(26, 432);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // weeklyReport
            // 
            this.weeklyReport.Location = new System.Drawing.Point(26, 64);
            this.weeklyReport.Name = "weeklyReport";
            this.weeklyReport.Size = new System.Drawing.Size(135, 23);
            this.weeklyReport.TabIndex = 3;
            this.weeklyReport.Text = "Generate Weekly Report";
            this.weeklyReport.UseVisualStyleBackColor = true;
            this.weeklyReport.Click += new System.EventHandler(this.weeklyReport_Click);
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd/MM/yyyy";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(268, 67);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(121, 20);
            this.startDate.TabIndex = 6;
            // 
            // weeklyLabel
            // 
            this.weeklyLabel.AutoSize = true;
            this.weeklyLabel.Location = new System.Drawing.Point(172, 69);
            this.weeklyLabel.Name = "weeklyLabel";
            this.weeklyLabel.Size = new System.Drawing.Size(90, 13);
            this.weeklyLabel.TabIndex = 7;
            this.weeklyLabel.Text = "Week Start Date:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(175, 115);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 8;
            this.monthLabel.Text = "Month:";
            // 
            // pickMonth
            // 
            this.pickMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickMonth.FormattingEnabled = true;
            this.pickMonth.Items.AddRange(new object[] {
            "January",
            "February",
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
            this.pickMonth.Location = new System.Drawing.Point(221, 112);
            this.pickMonth.Name = "pickMonth";
            this.pickMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pickMonth.Size = new System.Drawing.Size(95, 21);
            this.pickMonth.TabIndex = 4;
            this.pickMonth.SelectedIndexChanged += new System.EventHandler(this.pickMonth_SelectedIndexChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(323, 115);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Year:";
            // 
            // pickYear
            // 
            this.pickYear.Location = new System.Drawing.Point(361, 113);
            this.pickYear.MaxLength = 4;
            this.pickYear.Name = "pickYear";
            this.pickYear.Size = new System.Drawing.Size(47, 20);
            this.pickYear.TabIndex = 5;
            this.pickYear.Text = "yyyy";
            this.pickYear.TextChanged += new System.EventHandler(this.pickYear_TextChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(26, 169);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 10;
            // 
            // generateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 467);
            this.Controls.Add(this.output);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.weeklyLabel);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.pickYear);
            this.Controls.Add(this.pickMonth);
            this.Controls.Add(this.weeklyReport);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.monthlyReport);
            this.Name = "generateReports";
            this.Text = "PHP-SRePS - Generate Reports";
            this.Load += new System.EventHandler(this.generateReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button monthlyReport;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button weeklyReport;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label weeklyLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox pickMonth;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox pickYear;
        private System.Windows.Forms.Label output;
    }
}