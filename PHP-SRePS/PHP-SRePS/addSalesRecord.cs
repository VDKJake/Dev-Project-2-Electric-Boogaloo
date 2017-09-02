using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PHP_SRePS
{
    public partial class addSaleRecord : Form
    {
        private string _user;

        public addSaleRecord()
        {
            InitializeComponent();
        }

        private void addSalesRecord_Click(object sender, EventArgs e)
        {
            //Create connection to db and open the connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";
            con.Open();
            //Set the SQL command to a string for sercurity and create the command
            string scmd = "INSERT INTO dbo.SaleRecords (SaleID, ProductID, UserID, SaleDate, Quantity, Customer) VALUES (@saleID, @productID, @user, @date, @quantity, @customer);";
            SqlCommand cmd = new SqlCommand(scmd, con);
            //Set up parameters for the SQL command - this is to protect against SQL injection
            cmd.Parameters.Add("@saleID", SqlDbType.Int);
            cmd.Parameters.Add("@productID", SqlDbType.Int);
            cmd.Parameters.Add("@user", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters.Add("@customer", SqlDbType.NChar, 30);

            //Check to make sure the user's inputs are valid formats for the query
            //Parse the text values to int, if it is an int value, set variable to be int for the query
            bool result;
            int number;
            int _saleid = 0;
            int _productid = 0;
            int _quantity = 0;
            string _customer = string.Empty;
            DateTime _date= DateTime.Today;
            if (result = int.TryParse(saleID.Text, out number))
                _saleid = number;
            else
            {
                MessageBox.Show("The sale ID must be a number");
                return;
            }

            if (result = int.TryParse(productID.Text, out number))
                _productid = number;
            else
            {
                MessageBox.Show("The product ID must be a number");
                return;
            }

            if (result = int.TryParse(quantity.Text, out number))
                _quantity = number;
            else
            {
                MessageBox.Show("The quantity must be a number");
                return;
            }

            _customer = customer.Text;
            if (_customer == string.Empty)
                MessageBox.Show("Customer can't be left empty");

            //Failsafe incase something above doesn't get picked up
            if (_saleid == 0 || _productid == 0 || _quantity == 0 || _customer == string.Empty)
                return;

            //Add values for the parameters
            cmd.Parameters["@saleID"].Value = _saleid;
            cmd.Parameters["@productID"].Value = _productid;
            cmd.Parameters["@user"].Value = _user;
            cmd.Parameters["@date"].Value =_date;
            cmd.Parameters["@quantity"].Value = _quantity;
            cmd.Parameters["@customer"].Value = _customer;

            //Execute query and then close the connection
            cmd.ExecuteNonQuery();
            con.Close();
            //Display a confimation message for the added entry
            MessageBox.Show("Successfully added: \nSale ID:" + _saleid + "\nProduct ID: " + _productid + "\nUser ID: " + _user + "\nDate: " + _date + "\nQuantity: " + _quantity + "\nCustomer: " + _customer);
            //reset all textboxes to display nothing
            saleID.Text = string.Empty;
            productID.Text = string.Empty;
            quantity.Text = string.Empty;
            customer.Text = string.Empty;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string User
        {
            set { _user = value; }
        }
    }
}
