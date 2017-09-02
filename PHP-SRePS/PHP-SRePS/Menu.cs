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
            add.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            add.User = _user;
            this.Hide();
            add.Show();
        }


        private void editSales_Click(object sender, EventArgs e)
        {
            editSalesRecord edit = new editSalesRecord();
            edit.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            edit.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show this window again when another is closed
        private void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
