namespace PHP_SRePS
{
    partial class addSaleRecord
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
            this.addSalesRecord = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.saleIDLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.saleID = new System.Windows.Forms.TextBox();
            this.productID = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addSalesRecord
            // 
            this.addSalesRecord.Location = new System.Drawing.Point(76, 240);
            this.addSalesRecord.Name = "addSalesRecord";
            this.addSalesRecord.Size = new System.Drawing.Size(115, 23);
            this.addSalesRecord.TabIndex = 0;
            this.addSalesRecord.Text = "Add Sales Record";
            this.addSalesRecord.UseVisualStyleBackColor = true;
            this.addSalesRecord.Click += new System.EventHandler(this.addSalesRecord_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(272, 240);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(159, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(102, 13);
            this.title.TabIndex = 2;
            this.title.Text = "Add a Sales Record";
            // 
            // saleIDLabel
            // 
            this.saleIDLabel.AutoSize = true;
            this.saleIDLabel.Location = new System.Drawing.Point(73, 68);
            this.saleIDLabel.Name = "saleIDLabel";
            this.saleIDLabel.Size = new System.Drawing.Size(42, 13);
            this.saleIDLabel.TabIndex = 3;
            this.saleIDLabel.Text = "Sale ID";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(73, 113);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(58, 13);
            this.productIDLabel.TabIndex = 4;
            this.productIDLabel.Text = "Product ID";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(73, 155);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(73, 200);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Customer";
            // 
            // saleID
            // 
            this.saleID.Location = new System.Drawing.Point(247, 61);
            this.saleID.Name = "saleID";
            this.saleID.Size = new System.Drawing.Size(100, 20);
            this.saleID.TabIndex = 7;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(247, 106);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(100, 20);
            this.productID.TabIndex = 8;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(247, 148);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 9;
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(247, 193);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(100, 20);
            this.customer.TabIndex = 10;
            // 
            // addSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 294);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.saleID);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.saleIDLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addSalesRecord);
            this.Name = "addSaleRecord";
            this.Text = "PHP-SRePS - Add a Sales Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSalesRecord;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label saleIDLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox saleID;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox customer;
    }
}