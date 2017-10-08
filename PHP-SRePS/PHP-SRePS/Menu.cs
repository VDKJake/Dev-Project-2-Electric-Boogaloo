using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRePS
{
    public partial class Menu : Form
    {
        private string _user;
        private int tabNo = 0;
        private addSaleRecord add = new addSaleRecord();
        private editSalesRecord edit = new editSalesRecord();
        private displayRecords display = new displayRecords();
        private generateReports reportsTab = new generateReports();
        private PredictedSales predictedtab = new PredictedSales();
        private bool closing = false;

        public Menu()
        {
            InitializeComponent();
            // This code needs to be fixed and optimized
            // Adds the forms to the panel pages
            SetTab(add);
            SetTab(edit);
            SetTab(display);
            SetTab(reportsTab);
            SetTab(predictedtab);
        }

        protected override void OnShown(EventArgs e)
        {
            loggedIn.Text = "Logged in as: " + _user;
            welcomeLabel.Text = "Welcome, " + _user;
            add.User = _user;
            add.edit = edit;
            add.display = display;
            edit.display = display;
        }

        private void addSale_Click(object sender, EventArgs e)
        {
            addSaleRecord add = new addSaleRecord();
            add.User = _user;
            add.TopLevel = false;
            add.AutoScroll = true;
            add.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Clear();
            panel.Controls.Add(add);
            add.Show();
        }


        private void editSales_Click(object sender, EventArgs e)
        {
            editSalesRecord edit = new editSalesRecord();
            edit.TopLevel = false;
            edit.AutoScroll = true;
            edit.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Clear();
            panel.Controls.Add(edit);
            edit.Show();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            generateReports reports = new generateReports();
            reports.TopLevel = false;
            reports.AutoScroll = true;
            reports.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Clear();
            panel.Controls.Add(reports);
            reports.Show();
        }

        private void displayRecords_Click(object sender, EventArgs e)
        {
            displayRecords display = new displayRecords();
            display.TopLevel = false;
            display.AutoScroll = true;
            display.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Clear();
            panel.Controls.Add(display);
            display.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            
            this.Close();
            closing = true;
        }

        // Sets the next tab page to the supplied form
        private void SetTab(Form form)
        {
            tabNo += 1;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            tabControl1.TabPages[tabNo].Controls.Add(form);
            form.Location = new Point((tabControl1.TabPages[tabNo].Size.Width / 2) - (form.Size.Width / 2), (tabControl1.TabPages[tabNo].Size.Height / 2) - (form.Size.Height / 2));
            form.Anchor = (AnchorStyles.None);
        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        // All of these _MouseDown, _MouseLeave, _MouseUp & _MouseEnter functions
        // change the image of the buttons when hovering, pressing and taking the 
        // cursor off the buttons. It's such a bad way to do it but it works.
        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.Image = logoutImages.Images[2];
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            if (closing != true)
            {
                CloseButton.Image = logoutImages.Images[0];
            }
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (closing != true)
            {
                CloseButton.Image = logoutImages.Images[0];
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.Image = logoutImages.Images[1];
        }

        // Don't remove this, it makes the logout button not crash the program.
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
        }
    }
}
