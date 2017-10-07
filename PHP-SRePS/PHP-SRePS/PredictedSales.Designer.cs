namespace PHP_SRePS
{
    partial class PredictedSales
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
            this.title = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.january = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.february = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.march = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.april = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.may = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.june = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.july = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.august = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.september = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.october = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.november = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.december = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(369, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(81, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Predicted Sales";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(375, 380);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.january,
            this.february,
            this.march,
            this.april,
            this.may,
            this.june,
            this.july,
            this.august,
            this.september,
            this.october,
            this.november,
            this.december,
            this.year});
            this.dataGridView1.Location = new System.Drawing.Point(11, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 353);
            this.dataGridView1.TabIndex = 2;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product Name";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // january
            // 
            this.january.HeaderText = "January";
            this.january.Name = "january";
            this.january.ReadOnly = true;
            // 
            // february
            // 
            this.february.HeaderText = "February";
            this.february.Name = "february";
            this.february.ReadOnly = true;
            // 
            // march
            // 
            this.march.HeaderText = "March";
            this.march.Name = "march";
            this.march.ReadOnly = true;
            // 
            // april
            // 
            this.april.HeaderText = "April";
            this.april.Name = "april";
            this.april.ReadOnly = true;
            // 
            // may
            // 
            this.may.HeaderText = "May";
            this.may.Name = "may";
            this.may.ReadOnly = true;
            // 
            // june
            // 
            this.june.HeaderText = "June";
            this.june.Name = "june";
            this.june.ReadOnly = true;
            // 
            // july
            // 
            this.july.HeaderText = "July";
            this.july.Name = "july";
            this.july.ReadOnly = true;
            // 
            // august
            // 
            this.august.HeaderText = "August";
            this.august.Name = "august";
            this.august.ReadOnly = true;
            // 
            // september
            // 
            this.september.HeaderText = "September";
            this.september.Name = "september";
            this.september.ReadOnly = true;
            // 
            // october
            // 
            this.october.HeaderText = "October";
            this.october.Name = "october";
            this.october.ReadOnly = true;
            // 
            // november
            // 
            this.november.HeaderText = "November";
            this.november.Name = "november";
            this.november.ReadOnly = true;
            // 
            // december
            // 
            this.december.HeaderText = "December";
            this.december.Name = "december";
            this.december.ReadOnly = true;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // PredictedSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.title);
            this.Name = "PredictedSales";
            this.Text = "PHP-SRePS - Predicted Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn january;
        private System.Windows.Forms.DataGridViewTextBoxColumn february;
        private System.Windows.Forms.DataGridViewTextBoxColumn march;
        private System.Windows.Forms.DataGridViewTextBoxColumn april;
        private System.Windows.Forms.DataGridViewTextBoxColumn may;
        private System.Windows.Forms.DataGridViewTextBoxColumn june;
        private System.Windows.Forms.DataGridViewTextBoxColumn july;
        private System.Windows.Forms.DataGridViewTextBoxColumn august;
        private System.Windows.Forms.DataGridViewTextBoxColumn september;
        private System.Windows.Forms.DataGridViewTextBoxColumn october;
        private System.Windows.Forms.DataGridViewTextBoxColumn november;
        private System.Windows.Forms.DataGridViewTextBoxColumn december;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
    }
}