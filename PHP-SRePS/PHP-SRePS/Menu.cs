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

        public Menu()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            loggedIn.Text = "Logged in as: " + _user;
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

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
