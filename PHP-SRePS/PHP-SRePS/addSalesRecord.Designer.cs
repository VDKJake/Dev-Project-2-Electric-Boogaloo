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
            this.productIDLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.ListBox();
            this.productList = new System.Windows.Forms.ComboBox();
            this.removeProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addSalesRecord
            // 
            this.addSalesRecord.Location = new System.Drawing.Point(51, 552);
            this.addSalesRecord.Name = "addSalesRecord";
            this.addSalesRecord.Size = new System.Drawing.Size(115, 23);
            this.addSalesRecord.TabIndex = 0;
            this.addSalesRecord.Text = "Add Sales Record";
            this.addSalesRecord.UseVisualStyleBackColor = true;
            this.addSalesRecord.Click += new System.EventHandler(this.addSalesRecord_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(214, 552);
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
            this.title.Location = new System.Drawing.Point(139, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(102, 13);
            this.title.TabIndex = 2;
            this.title.Text = "Add a Sales Record";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(73, 91);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(44, 13);
            this.productIDLabel.TabIndex = 4;
            this.productIDLabel.Text = "Product";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(181, 91);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(53, 63);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Customer";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(175, 107);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(52, 20);
            this.quantity.TabIndex = 9;
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(189, 56);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(100, 20);
            this.customer.TabIndex = 10;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(246, 105);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 11;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(51, 146);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(238, 329);
            this.products.TabIndex = 12;
            // 
            // productList
            // 
            this.productList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(45, 106);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(121, 21);
            this.productList.TabIndex = 13;
            // 
            // removeProduct
            // 
            this.removeProduct.Location = new System.Drawing.Point(91, 481);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(136, 23);
            this.removeProduct.TabIndex = 14;
            this.removeProduct.Text = "Remove Product";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // addSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 587);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.products);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productIDLabel);
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
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.ListBox products;
        private System.Windows.Forms.ComboBox productList;
        private System.Windows.Forms.Button removeProduct;
    }
}