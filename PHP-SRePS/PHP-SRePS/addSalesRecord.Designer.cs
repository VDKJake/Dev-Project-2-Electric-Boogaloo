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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSaleRecord));
            this.addSalesRecord = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.ListBox();
            this.productList = new System.Windows.Forms.ComboBox();
            this.removeProduct = new System.Windows.Forms.Button();
            this.addImages = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSalesRecord
            // 
            this.addSalesRecord.FlatAppearance.BorderSize = 0;
            this.addSalesRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSalesRecord.Image = ((System.Drawing.Image)(resources.GetObject("addSalesRecord.Image")));
            this.addSalesRecord.Location = new System.Drawing.Point(116, 354);
            this.addSalesRecord.Name = "addSalesRecord";
            this.addSalesRecord.Size = new System.Drawing.Size(110, 50);
            this.addSalesRecord.TabIndex = 0;
            this.addSalesRecord.UseVisualStyleBackColor = true;
            this.addSalesRecord.Click += new System.EventHandler(this.addSalesRecord_Click);
            this.addSalesRecord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addSalesRecord_MouseDown);
            this.addSalesRecord.MouseEnter += new System.EventHandler(this.addSalesRecord_MouseEnter);
            this.addSalesRecord.MouseLeave += new System.EventHandler(this.addSalesRecord_MouseLeave);
            this.addSalesRecord.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addSalesRecord_MouseUp);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(264, 381);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(72, 51);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(44, 13);
            this.productIDLabel.TabIndex = 4;
            this.productIDLabel.Text = "Product";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(180, 51);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(63, 20);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(82, 13);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Customer Name";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(174, 67);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(52, 20);
            this.quantity.TabIndex = 9;
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(165, 16);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(100, 20);
            this.customer.TabIndex = 10;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(245, 65);
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
            this.products.Location = new System.Drawing.Point(50, 106);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(238, 186);
            this.products.TabIndex = 12;
            // 
            // productList
            // 
            this.productList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(44, 66);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(121, 21);
            this.productList.TabIndex = 13;
            // 
            // removeProduct
            // 
            this.removeProduct.Location = new System.Drawing.Point(90, 315);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(136, 23);
            this.removeProduct.TabIndex = 14;
            this.removeProduct.Text = "Remove Product";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // addImages
            // 
            this.addImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addImages.ImageStream")));
            this.addImages.TransparentColor = System.Drawing.Color.Transparent;
            this.addImages.Images.SetKeyName(0, "btn_AddBase.png");
            this.addImages.Images.SetKeyName(1, "btn_AddHover.png");
            this.addImages.Images.SetKeyName(2, "btn_AddClick.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // addSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.products);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productIDLabel);
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
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.ListBox products;
        private System.Windows.Forms.ComboBox productList;
        private System.Windows.Forms.Button removeProduct;
        private System.Windows.Forms.ImageList addImages;
        private System.Windows.Forms.Label label1;
    }
}