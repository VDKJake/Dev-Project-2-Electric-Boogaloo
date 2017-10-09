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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictedSales));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.messageLabel = new System.Windows.Forms.Label();
            this.singleImages = new System.Windows.Forms.ImageList(this.components);
            this.allImages = new System.Windows.Forms.ImageList(this.components);
            this.produceImages = new System.Windows.Forms.ImageList(this.components);
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.csvLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.predictions = new System.Windows.Forms.DataGridView();
            this.allProducts = new System.Windows.Forms.Button();
            this.singleProduct = new System.Windows.Forms.Button();
            this.singleItemPick = new System.Windows.Forms.ComboBox();
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.produceSinglePrediction = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.previous = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estListView = new System.Windows.Forms.ListView();
            this.errorLabel = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estListViewAll = new System.Windows.Forms.ListView();
            this.produceAllPredictions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Green;
            this.messageLabel.Location = new System.Drawing.Point(149, 241);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 20);
            this.messageLabel.TabIndex = 35;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singleImages
            // 
            this.singleImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("singleImages.ImageStream")));
            this.singleImages.TransparentColor = System.Drawing.Color.Transparent;
            this.singleImages.Images.SetKeyName(0, "btn_SingleProdPredictionBase.png");
            this.singleImages.Images.SetKeyName(1, "btn_SingleProdPredictionHover.png");
            this.singleImages.Images.SetKeyName(2, "btn_SingleProdPredictionClick.png");
            // 
            // allImages
            // 
            this.allImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("allImages.ImageStream")));
            this.allImages.TransparentColor = System.Drawing.Color.Transparent;
            this.allImages.Images.SetKeyName(0, "btn_AllProdPredictionBase.png");
            this.allImages.Images.SetKeyName(1, "btn_AllProdPredictionHover.png");
            this.allImages.Images.SetKeyName(2, "btn_AllProdPredictionClick.png");
            // 
            // produceImages
            // 
            this.produceImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("produceImages.ImageStream")));
            this.produceImages.TransparentColor = System.Drawing.Color.Transparent;
            this.produceImages.Images.SetKeyName(0, "btn_ProdPredictionBase.png");
            this.produceImages.Images.SetKeyName(1, "btn_ProdPredictionHover.png");
            this.produceImages.Images.SetKeyName(2, "btn_ProdPredictionClick.png");
            // 
            // errorLabel2
            // 
            this.errorLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel2.Location = new System.Drawing.Point(203, 396);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 13);
            this.errorLabel2.TabIndex = 38;
            this.errorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // csvLabel
            // 
            this.csvLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.csvLabel.AutoSize = true;
            this.csvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvLabel.ForeColor = System.Drawing.Color.Green;
            this.csvLabel.Location = new System.Drawing.Point(206, 436);
            this.csvLabel.Name = "csvLabel";
            this.csvLabel.Size = new System.Drawing.Size(0, 13);
            this.csvLabel.TabIndex = 39;
            this.csvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-134, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 353);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // predictions
            // 
            this.predictions.AllowUserToAddRows = false;
            this.predictions.AllowUserToDeleteRows = false;
            this.predictions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predictions.Location = new System.Drawing.Point(-133, 99);
            this.predictions.Name = "predictions";
            this.predictions.ReadOnly = true;
            this.predictions.RowHeadersWidth = 20;
            this.predictions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predictions.Size = new System.Drawing.Size(1002, 353);
            this.predictions.TabIndex = 2;
            // 
            // allProducts
            // 
            this.allProducts.FlatAppearance.BorderSize = 0;
            this.allProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allProducts.Image = ((System.Drawing.Image)(resources.GetObject("allProducts.Image")));
            this.allProducts.Location = new System.Drawing.Point(378, 30);
            this.allProducts.Name = "allProducts";
            this.allProducts.Size = new System.Drawing.Size(114, 42);
            this.allProducts.TabIndex = 4;
            this.allProducts.UseVisualStyleBackColor = true;
            this.allProducts.Click += new System.EventHandler(this.allProducts_Click);
            this.allProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allProducts_MouseDown);
            this.allProducts.MouseEnter += new System.EventHandler(this.allProducts_MouseEnter);
            this.allProducts.MouseLeave += new System.EventHandler(this.allProducts_MouseLeave);
            this.allProducts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.allProducts_MouseUp);
            // 
            // singleProduct
            // 
            this.singleProduct.FlatAppearance.BorderSize = 0;
            this.singleProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleProduct.Image = ((System.Drawing.Image)(resources.GetObject("singleProduct.Image")));
            this.singleProduct.Location = new System.Drawing.Point(259, 30);
            this.singleProduct.Name = "singleProduct";
            this.singleProduct.Size = new System.Drawing.Size(114, 42);
            this.singleProduct.TabIndex = 8;
            this.singleProduct.UseVisualStyleBackColor = true;
            this.singleProduct.Click += new System.EventHandler(this.singleProduct_Click);
            this.singleProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.singleProduct_MouseDown);
            this.singleProduct.MouseEnter += new System.EventHandler(this.singleProduct_MouseEnter);
            this.singleProduct.MouseLeave += new System.EventHandler(this.singleProduct_MouseLeave);
            this.singleProduct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.singleProduct_MouseUp);
            // 
            // singleItemPick
            // 
            this.singleItemPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.singleItemPick.FormattingEnabled = true;
            this.singleItemPick.Location = new System.Drawing.Point(299, 110);
            this.singleItemPick.Name = "singleItemPick";
            this.singleItemPick.Size = new System.Drawing.Size(152, 21);
            this.singleItemPick.TabIndex = 9;
            this.singleItemPick.Visible = false;
            this.singleItemPick.SelectedIndexChanged += new System.EventHandler(this.singleItemPick_SelectedIndexChanged);
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectItemLabel.Location = new System.Drawing.Point(285, 86);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(181, 21);
            this.selectItemLabel.TabIndex = 10;
            this.selectItemLabel.Text = "Select Product";
            this.selectItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectItemLabel.Visible = false;
            // 
            // produceSinglePrediction
            // 
            this.produceSinglePrediction.FlatAppearance.BorderSize = 0;
            this.produceSinglePrediction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produceSinglePrediction.Image = ((System.Drawing.Image)(resources.GetObject("produceSinglePrediction.Image")));
            this.produceSinglePrediction.Location = new System.Drawing.Point(319, 137);
            this.produceSinglePrediction.Name = "produceSinglePrediction";
            this.produceSinglePrediction.Size = new System.Drawing.Size(114, 42);
            this.produceSinglePrediction.TabIndex = 11;
            this.produceSinglePrediction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produceSinglePrediction.UseVisualStyleBackColor = true;
            this.produceSinglePrediction.Visible = false;
            this.produceSinglePrediction.Click += new System.EventHandler(this.produceSinglePrediction_Click);
            this.produceSinglePrediction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.produceSinglePrediction_MouseDown);
            this.produceSinglePrediction.MouseEnter += new System.EventHandler(this.produceSinglePrediction_MouseEnter);
            this.produceSinglePrediction.MouseLeave += new System.EventHandler(this.produceSinglePrediction_MouseLeave);
            this.produceSinglePrediction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.produceSinglePrediction_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 80;
            // 
            // previous
            // 
            this.previous.Text = "Month-1";
            this.previous.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Month1";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Month 2";
            this.columnHeader3.Width = 160;
            // 
            // estListView
            // 
            this.estListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.previous,
            this.columnHeader2,
            this.columnHeader3});
            this.estListView.GridLines = true;
            this.estListView.Location = new System.Drawing.Point(156, 184);
            this.estListView.Name = "estListView";
            this.estListView.Size = new System.Drawing.Size(444, 46);
            this.estListView.TabIndex = 12;
            this.estListView.UseCompatibleStateImageBehavior = false;
            this.estListView.View = System.Windows.Forms.View.Details;
            this.estListView.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(210, 241);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 34;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Name";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Month-1";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Month1";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Month 2";
            this.columnHeader7.Width = 160;
            // 
            // estListViewAll
            // 
            this.estListViewAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.estListViewAll.GridLines = true;
            this.estListViewAll.Location = new System.Drawing.Point(156, 126);
            this.estListViewAll.Name = "estListViewAll";
            this.estListViewAll.Size = new System.Drawing.Size(444, 267);
            this.estListViewAll.TabIndex = 36;
            this.estListViewAll.UseCompatibleStateImageBehavior = false;
            this.estListViewAll.View = System.Windows.Forms.View.Details;
            this.estListViewAll.Visible = false;
            // 
            // produceAllPredictions
            // 
            this.produceAllPredictions.FlatAppearance.BorderSize = 0;
            this.produceAllPredictions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produceAllPredictions.Image = ((System.Drawing.Image)(resources.GetObject("produceAllPredictions.Image")));
            this.produceAllPredictions.Location = new System.Drawing.Point(319, 78);
            this.produceAllPredictions.Name = "produceAllPredictions";
            this.produceAllPredictions.Size = new System.Drawing.Size(114, 42);
            this.produceAllPredictions.TabIndex = 37;
            this.produceAllPredictions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produceAllPredictions.UseVisualStyleBackColor = true;
            this.produceAllPredictions.Visible = false;
            this.produceAllPredictions.Click += new System.EventHandler(this.produceAllPredictions_Click);
            this.produceAllPredictions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.produceAllPredictions_MouseDown);
            this.produceAllPredictions.MouseEnter += new System.EventHandler(this.produceAllPredictions_MouseEnter);
            this.produceAllPredictions.MouseLeave += new System.EventHandler(this.produceAllPredictions_MouseLeave);
            this.produceAllPredictions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.produceAllPredictions_MouseUp);
            // 
            // PredictedSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 504);
            this.Controls.Add(this.csvLabel);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.produceAllPredictions);
            this.Controls.Add(this.estListViewAll);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.estListView);
            this.Controls.Add(this.produceSinglePrediction);
            this.Controls.Add(this.selectItemLabel);
            this.Controls.Add(this.singleItemPick);
            this.Controls.Add(this.singleProduct);
            this.Controls.Add(this.allProducts);
            this.Controls.Add(this.predictions);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PredictedSales";
            this.Text = "PHP-SRePS - Predicted Sales";
            this.Shown += new System.EventHandler(this.PredictedSales_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ImageList singleImages;
        private System.Windows.Forms.ImageList allImages;
        private System.Windows.Forms.ImageList produceImages;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Label csvLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView predictions;
        private System.Windows.Forms.Button allProducts;
        private System.Windows.Forms.Button singleProduct;
        private System.Windows.Forms.ComboBox singleItemPick;
        private System.Windows.Forms.Label selectItemLabel;
        private System.Windows.Forms.Button produceSinglePrediction;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader previous;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView estListView;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView estListViewAll;
        private System.Windows.Forms.Button produceAllPredictions;
    }
}