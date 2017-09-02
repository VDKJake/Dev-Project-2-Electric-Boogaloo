namespace PHP_SRePS
{
    partial class Menu
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
            this.addSale = new System.Windows.Forms.Button();
            this.editSales = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.loggedIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSale
            // 
            this.addSale.Location = new System.Drawing.Point(39, 79);
            this.addSale.Name = "addSale";
            this.addSale.Size = new System.Drawing.Size(104, 23);
            this.addSale.TabIndex = 0;
            this.addSale.Text = "Add Sales Record";
            this.addSale.UseVisualStyleBackColor = true;
            this.addSale.Click += new System.EventHandler(this.addSale_Click);
            // 
            // editSales
            // 
            this.editSales.Location = new System.Drawing.Point(39, 124);
            this.editSales.Name = "editSales";
            this.editSales.Size = new System.Drawing.Size(117, 23);
            this.editSales.TabIndex = 1;
            this.editSales.Text = "Edit Sales Records";
            this.editSales.UseVisualStyleBackColor = true;
            this.editSales.Click += new System.EventHandler(this.editSales_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(39, 171);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Logout";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(176, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(34, 13);
            this.title.TabIndex = 3;
            this.title.Text = "Menu";
            // 
            // loggedIn
            // 
            this.loggedIn.AutoSize = true;
            this.loggedIn.Location = new System.Drawing.Point(109, 223);
            this.loggedIn.Name = "loggedIn";
            this.loggedIn.Size = new System.Drawing.Size(74, 13);
            this.loggedIn.TabIndex = 4;
            this.loggedIn.Text = "Logged in as: ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.loggedIn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.editSales);
            this.Controls.Add(this.addSale);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSale;
        private System.Windows.Forms.Button editSales;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label loggedIn;
    }
}