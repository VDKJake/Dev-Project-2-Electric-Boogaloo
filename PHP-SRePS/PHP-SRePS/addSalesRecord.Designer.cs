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
            this.removeProductImages = new System.Windows.Forms.ImageList(this.components);
            this.productListView = new System.Windows.Forms.ListView();
            this.productColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewImages = new System.Windows.Forms.ImageList(this.components);
            this.addProductImages = new System.Windows.Forms.ImageList(this.components);
            this.errorTimer = new System.Windows.Forms.Timer(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSalesRecord
            // 
            this.addSalesRecord.FlatAppearance.BorderSize = 0;
            this.addSalesRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSalesRecord.Image = ((System.Drawing.Image)(resources.GetObject("addSalesRecord.Image")));
            this.addSalesRecord.Location = new System.Drawing.Point(116, 343);
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
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(75, 45);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(57, 17);
            this.productIDLabel.TabIndex = 4;
            this.productIDLabel.Text = "Product";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(171, 45);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(50, 17);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(109, 17);
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
            this.addProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProduct.FlatAppearance.BorderSize = 0;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Image = ((System.Drawing.Image)(resources.GetObject("addProduct.Image")));
            this.addProduct.Location = new System.Drawing.Point(245, 65);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 11;
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            this.addProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addProduct_MouseDown);
            this.addProduct.MouseEnter += new System.EventHandler(this.addProduct_MouseEnter);
            this.addProduct.MouseLeave += new System.EventHandler(this.addProduct_MouseLeave);
            this.addProduct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addProduct_MouseUp);
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(50, 113);
            this.products.MultiColumn = true;
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(238, 173);
            this.products.TabIndex = 12;
            this.products.Visible = false;
            // 
            // productList
            // 
            this.productList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productList.BackColor = System.Drawing.SystemColors.Window;
            this.productList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(44, 66);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(121, 21);
            this.productList.TabIndex = 13;
            // 
            // removeProduct
            // 
            this.removeProduct.BackColor = System.Drawing.Color.Transparent;
            this.removeProduct.FlatAppearance.BorderSize = 0;
            this.removeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProduct.Image = ((System.Drawing.Image)(resources.GetObject("removeProduct.Image")));
            this.removeProduct.Location = new System.Drawing.Point(103, 306);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(136, 30);
            this.removeProduct.TabIndex = 14;
            this.removeProduct.UseVisualStyleBackColor = false;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            this.removeProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.removeProduct_MouseDown);
            this.removeProduct.MouseEnter += new System.EventHandler(this.removeProduct_MouseEnter);
            this.removeProduct.MouseLeave += new System.EventHandler(this.removeProduct_MouseLeave);
            this.removeProduct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.removeProduct_MouseUp);
            // 
            // addImages
            // 
            this.addImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addImages.ImageStream")));
            this.addImages.TransparentColor = System.Drawing.Color.Transparent;
            this.addImages.Images.SetKeyName(0, "btn_AddBase.png");
            this.addImages.Images.SetKeyName(1, "btn_AddHover.png");
            this.addImages.Images.SetKeyName(2, "btn_AddClick.png");
            // 
            // removeProductImages
            // 
            this.removeProductImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("removeProductImages.ImageStream")));
            this.removeProductImages.TransparentColor = System.Drawing.Color.Transparent;
            this.removeProductImages.Images.SetKeyName(0, "btn_RemoveProductBase.png");
            this.removeProductImages.Images.SetKeyName(1, "btn_RemoveProductHover.png");
            this.removeProductImages.Images.SetKeyName(2, "btn_RemoveProductClick.png");
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productColumn,
            this.quantityColumn});
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.Location = new System.Drawing.Point(53, 112);
            this.productListView.MultiSelect = false;
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(238, 188);
            this.productListView.TabIndex = 15;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            // 
            // productColumn
            // 
            this.productColumn.Text = "Product Name";
            this.productColumn.Width = 119;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Quantity";
            this.quantityColumn.Width = 115;
            // 
            // listViewImages
            // 
            this.listViewImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listViewImages.ImageStream")));
            this.listViewImages.TransparentColor = System.Drawing.Color.Transparent;
            this.listViewImages.Images.SetKeyName(0, "lv_ProductName.png");
            this.listViewImages.Images.SetKeyName(1, "lv_Quantity.png");
            // 
            // addProductImages
            // 
            this.addProductImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addProductImages.ImageStream")));
            this.addProductImages.TransparentColor = System.Drawing.Color.Transparent;
            this.addProductImages.Images.SetKeyName(0, "btn_AddProductBase.png");
            this.addProductImages.Images.SetKeyName(1, "btn_AddProductHover.png");
            this.addProductImages.Images.SetKeyName(2, "btn_AddProductClick.png");
            // 
            // errorTimer
            // 
            this.errorTimer.Interval = 5000;
            this.errorTimer.Tick += new System.EventHandler(this.errorTimer_Tick);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(60, 93);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 402);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.products);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.addSalesRecord);
            this.Name = "addSaleRecord";
            this.Text = "PHP-SRePS - Add a Sales Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSalesRecord;
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
        private System.Windows.Forms.ImageList removeProductImages;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ColumnHeader productColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ImageList listViewImages;
        private System.Windows.Forms.ImageList addProductImages;
        private System.Windows.Forms.Timer errorTimer;
        private System.Windows.Forms.Label errorLabel;
    }
}