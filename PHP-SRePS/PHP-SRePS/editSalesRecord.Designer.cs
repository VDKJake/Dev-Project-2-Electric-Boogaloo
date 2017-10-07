﻿namespace PHP_SRePS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editSalesRecord));
            this.editButton = new System.Windows.Forms.Button();
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
            this.btnImages = new System.Windows.Forms.ImageList(this.components);
            this.salesRecords = new System.Windows.Forms.ListBox();
            this.saleRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHPSRePSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PHP_SRePSDataSet = new PHP_SRePS._PHP_SRePSDataSet();
            this.saleRecordsTableAdapter = new PHP_SRePS._PHP_SRePSDataSetTableAdapters.SaleRecordsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.saleRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPSRePSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PHP_SRePSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleRecordsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.Control;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ImageIndex = 1;
            this.editButton.ImageList = this.btnImages;
            this.editButton.Location = new System.Drawing.Point(247, 349);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 50);
            this.editButton.TabIndex = 2;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saleIDLabel
            // 
            this.saleIDLabel.AutoSize = true;
            this.saleIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleIDLabel.Location = new System.Drawing.Point(37, 294);
            this.saleIDLabel.Name = "saleIDLabel";
            this.saleIDLabel.Size = new System.Drawing.Size(53, 17);
            this.saleIDLabel.TabIndex = 4;
            this.saleIDLabel.Text = "Sale ID";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(154, 294);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(74, 17);
            this.productIDLabel.TabIndex = 5;
            this.productIDLabel.Text = "Product ID";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.Location = new System.Drawing.Point(277, 294);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(55, 17);
            this.userIDLabel.TabIndex = 6;
            this.userIDLabel.Text = "User ID";
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDateLabel.Location = new System.Drawing.Point(395, 294);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(70, 17);
            this.saleDateLabel.TabIndex = 7;
            this.saleDateLabel.Text = "Sale Date";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(519, 294);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(633, 294);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(68, 17);
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
            this.removeButton.BackColor = System.Drawing.SystemColors.Control;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ImageIndex = 0;
            this.removeButton.ImageList = this.btnImages;
            this.removeButton.Location = new System.Drawing.Point(380, 349);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 50);
            this.removeButton.TabIndex = 16;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // btnImages
            // 
            this.btnImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnImages.ImageStream")));
            this.btnImages.TransparentColor = System.Drawing.Color.Transparent;
            this.btnImages.Images.SetKeyName(0, "btn_Remove.png");
            this.btnImages.Images.SetKeyName(1, "btn_Edit.png");
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
            // saleRecordsBindingSource
            // 
            this.saleRecordsBindingSource.DataMember = "SaleRecords";
            this.saleRecordsBindingSource.DataSource = this.pHPSRePSDataSetBindingSource;
            // 
            // pHPSRePSDataSetBindingSource
            // 
            this.pHPSRePSDataSetBindingSource.DataSource = this._PHP_SRePSDataSet;
            this.pHPSRePSDataSetBindingSource.Position = 0;
            // 
            // _PHP_SRePSDataSet
            // 
            this._PHP_SRePSDataSet.DataSetName = "_PHP_SRePSDataSet";
            this._PHP_SRePSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleRecordsTableAdapter
            // 
            this.saleRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saleRecordsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 264);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // saleRecordsBindingSource1
            // 
            this.saleRecordsBindingSource1.DataMember = "SaleRecords";
            this.saleRecordsBindingSource1.DataSource = this.pHPSRePSDataSetBindingSource;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            this.saleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.editButton);
            this.Name = "editSalesRecord";
            this.Text = "editSalesRecord";
            this.Load += new System.EventHandler(this.editSalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPSRePSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PHP_SRePSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleRecordsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button editButton;
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
        private System.Windows.Forms.BindingSource pHPSRePSDataSetBindingSource;
        private _PHP_SRePSDataSet _PHP_SRePSDataSet;
        private System.Windows.Forms.BindingSource saleRecordsBindingSource;
        private _PHP_SRePSDataSetTableAdapters.SaleRecordsTableAdapter saleRecordsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource saleRecordsBindingSource1;
        private System.Windows.Forms.ImageList btnImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
    }
}