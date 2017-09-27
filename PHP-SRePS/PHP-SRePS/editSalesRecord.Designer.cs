namespace PHP_SRePS
{
    partial class editSalesRecord
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
            this.editButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.saleIDLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.saleID = new System.Windows.Forms.TextBox();
            this.productID = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.TextBox();
            this.saleDate = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.salesRecords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(149, 372);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(508, 372);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saleIDLabel
            // 
            this.saleIDLabel.AutoSize = true;
            this.saleIDLabel.Location = new System.Drawing.Point(19, 301);
            this.saleIDLabel.Name = "saleIDLabel";
            this.saleIDLabel.Size = new System.Drawing.Size(42, 13);
            this.saleIDLabel.TabIndex = 4;
            this.saleIDLabel.Text = "Sale ID";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(146, 301);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(58, 13);
            this.productIDLabel.TabIndex = 5;
            this.productIDLabel.Text = "Product ID";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(261, 301);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(43, 13);
            this.userIDLabel.TabIndex = 6;
            this.userIDLabel.Text = "User ID";
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Location = new System.Drawing.Point(384, 301);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(54, 13);
            this.saleDateLabel.TabIndex = 7;
            this.saleDateLabel.Text = "Sale Date";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(505, 301);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(625, 301);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Customer";
            // 
            // saleID
            // 
            this.saleID.Location = new System.Drawing.Point(22, 317);
            this.saleID.Name = "saleID";
            this.saleID.Size = new System.Drawing.Size(100, 20);
            this.saleID.TabIndex = 10;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(149, 317);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(100, 20);
            this.productID.TabIndex = 11;
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(264, 317);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 12;
            // 
            // saleDate
            // 
            this.saleDate.Location = new System.Drawing.Point(387, 317);
            this.saleDate.Name = "saleDate";
            this.saleDate.Size = new System.Drawing.Size(100, 20);
            this.saleDate.TabIndex = 13;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(508, 317);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 14;
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(628, 317);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(100, 20);
            this.customer.TabIndex = 15;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(333, 372);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // salesRecords
            // 
            this.salesRecords.FormattingEnabled = true;
            this.salesRecords.Location = new System.Drawing.Point(22, 12);
            this.salesRecords.Name = "salesRecords";
            this.salesRecords.Size = new System.Drawing.Size(706, 264);
            this.salesRecords.TabIndex = 17;
            this.salesRecords.SelectedIndexChanged += new System.EventHandler(this.salesRecords_SelectedIndexChanged);
            // 
            // editSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 413);
            this.Controls.Add(this.salesRecords);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.saleDate);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.saleID);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.saleDateLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.saleIDLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editButton);
            this.Name = "editSalesRecord";
            this.Text = "editSalesRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label saleIDLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox saleID;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox saleDate;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox salesRecords;
    }
}