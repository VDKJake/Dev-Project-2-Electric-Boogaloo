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
            this.predictions = new System.Windows.Forms.DataGridView();
            this.allProducts = new System.Windows.Forms.Button();
            this.predictLabel = new System.Windows.Forms.Label();
            this.productTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.singleProduct = new System.Windows.Forms.Button();
            this.singleItemPick = new System.Windows.Forms.ComboBox();
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.produceSinglePrediction = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.predictions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // predictions
            // 
            this.predictions.AllowUserToAddRows = false;
            this.predictions.AllowUserToDeleteRows = false;
            this.predictions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predictions.Location = new System.Drawing.Point(11, 99);
            this.predictions.Name = "predictions";
            this.predictions.ReadOnly = true;
            this.predictions.RowHeadersWidth = 20;
            this.predictions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predictions.Size = new System.Drawing.Size(1002, 353);
            this.predictions.TabIndex = 2;
            // 
            // allProducts
            // 
            this.allProducts.Location = new System.Drawing.Point(522, 30);
            this.allProducts.Name = "allProducts";
            this.allProducts.Size = new System.Drawing.Size(113, 41);
            this.allProducts.TabIndex = 4;
            this.allProducts.Text = "Produce Prrediction for All Products";
            this.allProducts.UseVisualStyleBackColor = true;
            this.allProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // predictLabel
            // 
            this.predictLabel.AutoSize = true;
            this.predictLabel.Location = new System.Drawing.Point(307, 470);
            this.predictLabel.Name = "predictLabel";
            this.predictLabel.Size = new System.Drawing.Size(35, 13);
            this.predictLabel.TabIndex = 5;
            this.predictLabel.Text = "label1";
            // 
            // productTitleLabel
            // 
            this.productTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTitleLabel.Location = new System.Drawing.Point(429, 74);
            this.productTitleLabel.Name = "productTitleLabel";
            this.productTitleLabel.Size = new System.Drawing.Size(181, 21);
            this.productTitleLabel.TabIndex = 6;
            this.productTitleLabel.Text = "Product Sales for";
            this.productTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // singleProduct
            // 
            this.singleProduct.Location = new System.Drawing.Point(403, 30);
            this.singleProduct.Name = "singleProduct";
            this.singleProduct.Size = new System.Drawing.Size(113, 41);
            this.singleProduct.TabIndex = 8;
            this.singleProduct.Text = "Produce Prrediction for a Single Product";
            this.singleProduct.UseVisualStyleBackColor = true;
            this.singleProduct.Click += new System.EventHandler(this.singleProduct_Click);
            // 
            // singleItemPick
            // 
            this.singleItemPick.FormattingEnabled = true;
            this.singleItemPick.Location = new System.Drawing.Point(443, 110);
            this.singleItemPick.Name = "singleItemPick";
            this.singleItemPick.Size = new System.Drawing.Size(152, 21);
            this.singleItemPick.TabIndex = 9;
            this.singleItemPick.Visible = false;
            this.singleItemPick.SelectedIndexChanged += new System.EventHandler(this.singleItemPick_SelectedIndexChanged);
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectItemLabel.Location = new System.Drawing.Point(429, 86);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(181, 21);
            this.selectItemLabel.TabIndex = 10;
            this.selectItemLabel.Text = "Select Product";
            this.selectItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectItemLabel.Visible = false;
            // 
            // produceSinglePrediction
            // 
            this.produceSinglePrediction.Location = new System.Drawing.Point(463, 137);
            this.produceSinglePrediction.Name = "produceSinglePrediction";
            this.produceSinglePrediction.Size = new System.Drawing.Size(113, 41);
            this.produceSinglePrediction.TabIndex = 11;
            this.produceSinglePrediction.Text = "Produce Prediction";
            this.produceSinglePrediction.UseVisualStyleBackColor = true;
            this.produceSinglePrediction.Click += new System.EventHandler(this.produceSinglePrediction_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(280, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 233);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 80;
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
            // PredictedSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 504);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.produceSinglePrediction);
            this.Controls.Add(this.selectItemLabel);
            this.Controls.Add(this.singleItemPick);
            this.Controls.Add(this.singleProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productTitleLabel);
            this.Controls.Add(this.predictLabel);
            this.Controls.Add(this.allProducts);
            this.Controls.Add(this.predictions);
            this.Name = "PredictedSales";
            this.Text = "PHP-SRePS - Predicted Sales";
            this.Shown += new System.EventHandler(this.PredictedSales_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.predictions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView predictions;
        private System.Windows.Forms.Button allProducts;
        private System.Windows.Forms.Label predictLabel;
        private System.Windows.Forms.Label productTitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button singleProduct;
        private System.Windows.Forms.ComboBox singleItemPick;
        private System.Windows.Forms.Label selectItemLabel;
        private System.Windows.Forms.Button produceSinglePrediction;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}