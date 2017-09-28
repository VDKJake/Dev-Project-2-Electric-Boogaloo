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

        public Menu()
        {
            InitializeComponent();
            // This code needs to be fixed and optimized
            // Adds the forms to the panel pages
            addSaleRecord add = new addSaleRecord();
            editSalesRecord edit = new editSalesRecord();
            displayRecords display = new displayRecords();
            generateReports reports = new generateReports();
            
            SetTab(add);
            SetTab(edit);
            SetTab(display);
            SetTab(reports);
        }

        protected override void OnShown(EventArgs e)
        {
            loggedIn.Text = "Logged in as: " + _user;
            welcomeLabel.Text = "Welcome, " + _user;
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
        }

        // Sets the next tab page to the inputted form
        private void SetTab(Form form)
        {
            tabNo += 1;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            //form.Location = new Point(266, 171); // Position needs to be changed, just a temporary one for now
            tabControl1.TabPages[tabNo].Controls.Add(form);
            //form.Size = tabControl1.TabPages[tabNo].Size;
            form.Location = new Point((tabControl1.TabPages[tabNo].Size.Width / 2) - (form.Size.Width / 2), (tabControl1.TabPages[tabNo].Size.Height / 2) - (form.Size.Height / 2));
            form.Anchor = (AnchorStyles.None);
        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
