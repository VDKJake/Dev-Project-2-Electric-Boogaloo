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
            this.components = new System.ComponentModel.Container();
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
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            this._PHP_SRePSDataSet = new PHP_SRePS._PHP_SRePSDataSet();
            this.pHPSRePSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleRecordsTableAdapter = new PHP_SRePS._PHP_SRePSDataSetTableAdapters.SaleRecordsTableAdapter();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PHP_SRePSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPSRePSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(145, 349);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 50);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Entry";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(500, 349);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 50);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saleIDLabel
            // 
            this.saleIDLabel.AutoSize = true;
            this.saleIDLabel.Location = new System.Drawing.Point(12, 299);
            this.saleIDLabel.Name = "saleIDLabel";
            this.saleIDLabel.Size = new System.Drawing.Size(42, 13);
            this.saleIDLabel.TabIndex = 4;
            this.saleIDLabel.Text = "Sale ID";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(139, 299);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(58, 13);
            this.productIDLabel.TabIndex = 5;
            this.productIDLabel.Text = "Product ID";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(254, 299);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(43, 13);
            this.userIDLabel.TabIndex = 6;
            this.userIDLabel.Text = "User ID";
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Location = new System.Drawing.Point(377, 299);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(54, 13);
            this.saleDateLabel.TabIndex = 7;
            this.saleDateLabel.Text = "Sale Date";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(498, 299);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(618, 299);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Customer";
            // 
            // saleID
            // 
            this.saleID.Location = new System.Drawing.Point(15, 315);
            this.saleID.Name = "saleID";
            this.saleID.Size = new System.Drawing.Size(100, 20);
            this.saleID.TabIndex = 10;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(142, 315);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(100, 20);
            this.productID.TabIndex = 11;
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(257, 315);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 12;
            // 
            // saleDate
            // 
            this.saleDate.Location = new System.Drawing.Point(380, 315);
            this.saleDate.Name = "saleDate";
            this.saleDate.Size = new System.Drawing.Size(100, 20);
            this.saleDate.TabIndex = 13;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(501, 315);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 14;
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(621, 315);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(100, 20);
            this.customer.TabIndex = 15;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(322, 349);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 50);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "Remove Entry";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // salesRecords
            // 
            this.salesRecords.FormattingEnabled = true;
            this.salesRecords.Location = new System.Drawing.Point(15, 10);
            this.salesRecords.Name = "salesRecords";
            this.salesRecords.Size = new System.Drawing.Size(706, 264);
            this.salesRecords.TabIndex = 17;
            this.salesRecords.SelectedIndexChanged += new System.EventHandler(this.salesRecords_SelectedIndexChanged);
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AutoGenerateColumns = false;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.salesDataGrid.DataSource = this.saleRecordsBindingSource;
            this.salesDataGrid.Location = new System.Drawing.Point(40, 82);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.Size = new System.Drawing.Size(681, 148);
            this.salesDataGrid.TabIndex = 18;
            this.salesDataGrid.SelectionChanged += new System.EventHandler(this.salesDataGrid_SelectionChanged);
            // 
            // _PHP_SRePSDataSet
            // 
            this._PHP_SRePSDataSet.DataSetName = "_PHP_SRePSDataSet";
            this._PHP_SRePSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHPSRePSDataSetBindingSource
            // 
            this.pHPSRePSDataSetBindingSource.DataSource = this._PHP_SRePSDataSet;
            this.pHPSRePSDataSetBindingSource.Position = 0;
            // 
            // saleRecordsBindingSource
            // 
            this.saleRecordsBindingSource.DataMember = "SaleRecords";
            this.saleRecordsBindingSource.DataSource = this.pHPSRePSDataSetBindingSource;
            // 
            // saleRecordsTableAdapter
            // 
            this.saleRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // editSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.salesDataGrid);
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
            this.Load += new System.EventHandler(this.editSalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PHP_SRePSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPSRePSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleRecordsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView salesDataGrid;
        private System.Windows.Forms.BindingSource pHPSRePSDataSetBindingSource;
        private _PHP_SRePSDataSet _PHP_SRePSDataSet;
        private System.Windows.Forms.BindingSource saleRecordsBindingSource;
        private _PHP_SRePSDataSetTableAdapters.SaleRecordsTableAdapter saleRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
    }
}