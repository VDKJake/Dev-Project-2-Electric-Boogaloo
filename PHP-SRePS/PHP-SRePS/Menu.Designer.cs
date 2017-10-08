﻿namespace PHP_SRePS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.addSale = new System.Windows.Forms.Button();
            this.editSales = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.loggedIn = new System.Windows.Forms.Label();
            this.reports = new System.Windows.Forms.Button();
            this.displayRecords = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabImages = new System.Windows.Forms.ImageList(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.logoutImages = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(12, 577);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.logout_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // loggedIn
            // 
            this.loggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loggedIn.AutoSize = true;
            this.loggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedIn.Location = new System.Drawing.Point(93, 586);
            this.loggedIn.Name = "loggedIn";
            this.loggedIn.Size = new System.Drawing.Size(88, 13);
            this.loggedIn.TabIndex = 4;
            this.loggedIn.Text = "Logged in as: ";
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(252, 79);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(113, 23);
            this.reports.TabIndex = 5;
            this.reports.Text = "Generate Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // displayRecords
            // 
            this.displayRecords.Location = new System.Drawing.Point(251, 124);
            this.displayRecords.Name = "displayRecords";
            this.displayRecords.Size = new System.Drawing.Size(113, 22);
            this.displayRecords.TabIndex = 7;
            this.displayRecords.Text = "Display Records";
            this.displayRecords.UseVisualStyleBackColor = true;
            this.displayRecords.Click += new System.EventHandler(this.displayRecords_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.ImageList = this.tabImages;
            this.tabControl1.ItemSize = new System.Drawing.Size(201, 50);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 565);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.welcomeLabel);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.ImageKey = "btn_Home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1204, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.welcomeLabel.Location = new System.Drawing.Point(194, 39);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(314, 75);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(21, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 167);
            this.panel1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.ImageKey = "btn_Add.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1204, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Sales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 75);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add Sales";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.ImageKey = "btn_Edit.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1204, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 75);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit Sales";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.ImageKey = "btn_View.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1204, 507);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Sales";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 75);
            this.label3.TabIndex = 11;
            this.label3.Text = "View Sales";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.ImageKey = "btn_Reports.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 54);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1204, 507);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sales Reports";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 75);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sale Reports";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pictureBox1);
            this.tabPage6.ImageKey = "btn_Est.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 54);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1204, 507);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Sales Estimations";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 45);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabImages
            // 
            this.tabImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabImages.ImageStream")));
            this.tabImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tabImages.Images.SetKeyName(0, "btn_Add.png");
            this.tabImages.Images.SetKeyName(1, "btn_Edit.png");
            this.tabImages.Images.SetKeyName(2, "btn_Est.png");
            this.tabImages.Images.SetKeyName(3, "btn_Home.png");
            this.tabImages.Images.SetKeyName(4, "btn_Reports.png");
            this.tabImages.Images.SetKeyName(5, "btn_View.png");
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(399, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(820, 594);
            this.panel.TabIndex = 6;
            // 
            // logoutImages
            // 
            this.logoutImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("logoutImages.ImageStream")));
            this.logoutImages.TransparentColor = System.Drawing.Color.Transparent;
            this.logoutImages.Images.SetKeyName(0, "btn_LogoutBase.png");
            this.logoutImages.Images.SetKeyName(1, "btn_LogoutHover.png");
            this.logoutImages.Images.SetKeyName(2, "btn_LogoutClick.png");
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.displayRecords);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.loggedIn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.editSales);
            this.Controls.Add(this.addSale);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSale;
        private System.Windows.Forms.Button editSales;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label loggedIn;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button displayRecords;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList tabImages;
        private System.Windows.Forms.ImageList logoutImages;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}