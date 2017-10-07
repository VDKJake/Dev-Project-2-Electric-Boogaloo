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
        public editSalesRecord edit;

        public addSaleRecord()
        {
            InitializeComponent();
            PopulateCombobox();
        }

        private void addSalesRecord_Click(object sender, EventArgs e)
        {
            //Create connection to db and open the connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";


            //Check to make sure the user's inputs are valid formats for the query
            //Parse the text values to int, if it is an int value, set variable to be int for the query
            bool result;
            int number;
            List<string> _products = new List<string>();
            List<int> _quantity = new List<int>();
            string _customer = string.Empty;
            DateTime _date = DateTime.Today;

            foreach (string s in products.Items)
            {
                if (s == string.Empty)
                {
                    MessageBox.Show("Products and their quantity must be added to the record");
                }
                else
                {
                    string[] output = s.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                    _products.Add(output[0].Trim());
                    if (result = int.TryParse(output[1].Trim(), out number))
                        _quantity.Add(number);
                }
            }

            _customer = customer.Text;
            if (_customer == string.Empty)
                MessageBox.Show("Customer can't be left empty");

            //Failsafe incase something above doesn't get picked up
            if (_products.Count == 0 || _quantity.Count == 0 || _customer == string.Empty)
                return;

            List<int> _productIDs = new List<int>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            for (int i = 0; i < _products.Count; i++)
            {
                cmd.CommandText = "SELECT ProductID FROM dbo.Products WHERE ProductName = '" + _products[i].Trim() + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                    _productIDs.Add((int)sdr["ProductID"]);
                sdr.Close();
            }

            string scmd = "INSERT INTO dbo.SaleRecords (ProductID, UserID, SaleDate, Quantity, Customer) VALUES ";
            for (int i = 0; i < _products.Count; i++)
            {
                scmd += "(" + _productIDs[i] + ", '@user', @date, " + _quantity[i] + ", '" + _customer + "')";
                if (i < _productIDs.Count - 1)
                    scmd += ",";
            }

            cmd = new SqlCommand(scmd, con);

            cmd.Parameters.Add("@user", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@date", SqlDbType.Date);

            ////Add values for the parameters
            cmd.Parameters["@user"].Value = _user;
            cmd.Parameters["@date"].Value =_date;


            //Execute query and then close the connection
            cmd.ExecuteNonQuery();
            con.Close();
            //Display a confimation message for the added entry
            MessageBox.Show("Successfully added sales data");
            //reset all textboxes to display nothing
            quantity.Text = string.Empty;
            customer.Text = string.Empty;
            products.Items.Clear();
            edit.ReloadData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string User
        {
            set { _user = value; }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            bool result;
            int number;
            int _qty;

            if (result = int.TryParse(quantity.Text, out number))
                _qty = number;
            else
            {
                MessageBox.Show("The quantity must be a number");
                return;
            }

            string add = productList.SelectedItem + "\t" + _qty;
            products.Items.Add(add);
            quantity.Clear();
        }

        private void PopulateCombobox()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT ProductName as name FROM Products", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read())
            {
                productList.Items.Add(sdr["name"].ToString().Trim());
            }
            con.Close();
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            if(products.SelectedIndex > 0)
                products.Items.RemoveAt(products.SelectedIndex);
        }

        private void addSalesRecord_MouseDown(object sender, MouseEventArgs e)
        {
            addSalesRecord.Image = addImages.Images[2];
        }

        private void addSalesRecord_MouseHover(object sender, EventArgs e)
        {
            addSalesRecord.Image = addImages.Images[1];
        }

        private void addSalesRecord_MouseLeave(object sender, EventArgs e)
        {
            addSalesRecord.Image = addImages.Images[0];
        }

        private void addSalesRecord_MouseUp(object sender, MouseEventArgs e)
        {
            addSalesRecord.Image = addImages.Images[0];
        }
    }
}
