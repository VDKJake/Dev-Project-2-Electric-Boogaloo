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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generateReports));
            this.monthlyReport = new System.Windows.Forms.Button();
            this.weeklyReport = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.weeklyLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.pickMonth = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.pickYear = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.weeklyImages = new System.Windows.Forms.ImageList(this.components);
            this.monthlyImages = new System.Windows.Forms.ImageList(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.reportListView = new System.Windows.Forms.ListView();
            this.productIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saleCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reportLabel = new System.Windows.Forms.Label();
            this.errorTimer = new System.Windows.Forms.Timer(this.components);
            this.csvLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthlyReport
            // 
            this.monthlyReport.FlatAppearance.BorderSize = 0;
            this.monthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthlyReport.Image = ((System.Drawing.Image)(resources.GetObject("monthlyReport.Image")));
            this.monthlyReport.Location = new System.Drawing.Point(26, 67);
            this.monthlyReport.Name = "monthlyReport";
            this.monthlyReport.Size = new System.Drawing.Size(135, 23);
            this.monthlyReport.TabIndex = 1;
            this.monthlyReport.UseVisualStyleBackColor = true;
            this.monthlyReport.Click += new System.EventHandler(this.monthlyReport_Click);
            this.monthlyReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthlyReport_MouseDown);
            this.monthlyReport.MouseEnter += new System.EventHandler(this.monthlyReport_MouseEnter);
            this.monthlyReport.MouseLeave += new System.EventHandler(this.monthlyReport_MouseLeave);
            this.monthlyReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.monthlyReport_MouseUp);
            // 
            // weeklyReport
            // 
            this.weeklyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.weeklyReport.FlatAppearance.BorderSize = 0;
            this.weeklyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weeklyReport.Image = ((System.Drawing.Image)(resources.GetObject("weeklyReport.Image")));
            this.weeklyReport.Location = new System.Drawing.Point(26, 21);
            this.weeklyReport.Name = "weeklyReport";
            this.weeklyReport.Size = new System.Drawing.Size(135, 23);
            this.weeklyReport.TabIndex = 3;
            this.weeklyReport.UseVisualStyleBackColor = true;
            this.weeklyReport.Click += new System.EventHandler(this.weeklyReport_Click);
            this.weeklyReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.weeklyReport_MouseDown);
            this.weeklyReport.MouseEnter += new System.EventHandler(this.weeklyReport_MouseEnter);
            this.weeklyReport.MouseLeave += new System.EventHandler(this.weeklyReport_MouseLeave);
            this.weeklyReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.weeklyReport_MouseUp);
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd/MM/yyyy";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(285, 24);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(121, 20);
            this.startDate.TabIndex = 6;
            // 
            // weeklyLabel
            // 
            this.weeklyLabel.AutoSize = true;
            this.weeklyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyLabel.Location = new System.Drawing.Point(167, 25);
            this.weeklyLabel.Name = "weeklyLabel";
            this.weeklyLabel.Size = new System.Drawing.Size(116, 17);
            this.weeklyLabel.TabIndex = 7;
            this.weeklyLabel.Text = "Week Start Date:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(168, 70);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(51, 17);
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
            this.pickMonth.Location = new System.Drawing.Point(221, 69);
            this.pickMonth.Name = "pickMonth";
            this.pickMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pickMonth.Size = new System.Drawing.Size(95, 21);
            this.pickMonth.TabIndex = 4;
            this.pickMonth.SelectedIndexChanged += new System.EventHandler(this.pickMonth_SelectedIndexChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(317, 71);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 17);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Year:";
            // 
            // pickYear
            // 
            this.pickYear.Location = new System.Drawing.Point(361, 70);
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
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(127, 159);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 17);
            this.output.TabIndex = 10;
            // 
            // weeklyImages
            // 
            this.weeklyImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("weeklyImages.ImageStream")));
            this.weeklyImages.TransparentColor = System.Drawing.Color.Transparent;
            this.weeklyImages.Images.SetKeyName(0, "btn_WeeklyReportBase.png");
            this.weeklyImages.Images.SetKeyName(1, "btn_WeeklyReportHover.png");
            this.weeklyImages.Images.SetKeyName(2, "btn_WeeklyReportClick.png");
            // 
            // monthlyImages
            // 
            this.monthlyImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("monthlyImages.ImageStream")));
            this.monthlyImages.TransparentColor = System.Drawing.Color.Transparent;
            this.monthlyImages.Images.SetKeyName(0, "btn_MonthlyReportBase.png");
            this.monthlyImages.Images.SetKeyName(1, "btn_MonthlyReportHover.png");
            this.monthlyImages.Images.SetKeyName(2, "btn_MonthlyReportClick.png");
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(116, 99);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 33;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportListView
            // 
            this.reportListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productIdHeader,
            this.saleCountHeader,
            this.quantityHeader});
            this.reportListView.GridLines = true;
            this.reportListView.Location = new System.Drawing.Point(36, 144);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(366, 245);
            this.reportListView.TabIndex = 34;
            this.reportListView.UseCompatibleStateImageBehavior = false;
            this.reportListView.View = System.Windows.Forms.View.Details;
            // 
            // productIdHeader
            // 
            this.productIdHeader.Text = "Product ID";
            this.productIdHeader.Width = 120;
            // 
            // saleCountHeader
            // 
            this.saleCountHeader.Text = "Sale Count";
            this.saleCountHeader.Width = 120;
            // 
            // quantityHeader
            // 
            this.quantityHeader.Text = "Quantity";
            this.quantityHeader.Width = 120;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(42, 119);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportLabel.Size = new System.Drawing.Size(0, 20);
            this.reportLabel.TabIndex = 35;
            // 
            // errorTimer
            // 
            this.errorTimer.Interval = 5000;
            this.errorTimer.Tick += new System.EventHandler(this.errorTimer_Tick);
            // 
            // csvLabel
            // 
            this.csvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.csvLabel.AutoSize = true;
            this.csvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvLabel.ForeColor = System.Drawing.Color.Green;
            this.csvLabel.Location = new System.Drawing.Point(74, 399);
            this.csvLabel.Name = "csvLabel";
            this.csvLabel.Size = new System.Drawing.Size(0, 13);
            this.csvLabel.TabIndex = 36;
            this.csvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 441);
            this.Controls.Add(this.csvLabel);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.reportListView);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.output);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.weeklyLabel);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.pickYear);
            this.Controls.Add(this.pickMonth);
            this.Controls.Add(this.weeklyReport);
            this.Controls.Add(this.monthlyReport);
            this.Name = "generateReports";
            this.Text = "8";
            this.Load += new System.EventHandler(this.generateReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button monthlyReport;
        private System.Windows.Forms.Button weeklyReport;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label weeklyLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox pickMonth;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox pickYear;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.ImageList weeklyImages;
        private System.Windows.Forms.ImageList monthlyImages;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ListView reportListView;
        private System.Windows.Forms.ColumnHeader productIdHeader;
        private System.Windows.Forms.ColumnHeader saleCountHeader;
        private System.Windows.Forms.ColumnHeader quantityHeader;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Timer errorTimer;
        private System.Windows.Forms.Label csvLabel;
    }
}