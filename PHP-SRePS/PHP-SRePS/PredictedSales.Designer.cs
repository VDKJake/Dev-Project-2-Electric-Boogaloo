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
            this.predictions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.predictions)).BeginInit();
            this.SuspendLayout();
            // 
            // predictions
            // 
            this.predictions.AllowUserToAddRows = false;
            this.predictions.AllowUserToDeleteRows = false;
            this.predictions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predictions.Location = new System.Drawing.Point(11, 21);
            this.predictions.Name = "predictions";
            this.predictions.ReadOnly = true;
            this.predictions.Size = new System.Drawing.Size(779, 353);
            this.predictions.TabIndex = 2;
            // 
            // PredictedSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 406);
            this.Controls.Add(this.predictions);
            this.Name = "PredictedSales";
            this.Text = "PHP-SRePS - Predicted Sales";
            ((System.ComponentModel.ISupportInitialize)(this.predictions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView predictions;
    }
}