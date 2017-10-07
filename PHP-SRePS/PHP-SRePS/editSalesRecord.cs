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
using System.Data.SqlClient;
using System.Diagnostics;

namespace PHP_SRePS
{
    public partial class editSalesRecord : Form
    {
        private DataGridViewCell[] dataCells = new DataGridViewCell[6];

        public editSalesRecord()
        {
            InitializeComponent();
            UpdateListbox();
        }

        public void UpdateListbox()
        {
            //Remove all values in boxlist
            salesRecords.Items.Clear();

            //Create connection to db and open the connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";

            //Command to retrive sales records from database
            string scmd = "SELECT * FROM dbo.saleRecords";
            SqlCommand cmd = new SqlCommand(scmd, con);
            //Execute the command as a reader
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            //While there is data in the reader output the data into a list
            string inital = "Sale ID \t Product ID \t User ID   \t Sale Date \t Quantity \t Customer";
            salesRecords.Items.Add(inital);
            while (sdr.Read())
            {
                //Convert all columns into variables
                int _saleid = (int)sdr["SaleID"];
                int _productid = (int)sdr["ProductID"];
                string _userid = (string)sdr["UserID"];
                DateTime _date = (DateTime)sdr["SaleDate"];
                string date = _date.ToShortDateString();
                int _quantity = (int)sdr["Quantity"];
                string _customer = (string)sdr["Customer"];

                //Concat the variables into a single string
                string item = string.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5}", _saleid, _productid, _userid, date, _quantity, _customer);
                //Insert the entry into the table
                salesRecords.Items.Add(item);
            }
            con.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salesRecords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Create connection to db and open the connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";

            //Prep query
            string scmd = "UPDATE dbo.SaleRecords SET SaleID = @saleid, ProductID = @productid, UserID = @userid, SaleDate = @date, Quantity = @quantity, Customer = @customer WHERE SaleID = @currentSaleID AND ProductID = @currentProductid AND UserID = @currentUserid AND SaleDate = @currentDate AND Quantity = @currentQuantity AND Customer = @currentCustomer";
            SqlCommand cmd = new SqlCommand(scmd, con);
            cmd.Parameters.Add("@saleid", SqlDbType.Int);
            cmd.Parameters.Add("@productid", SqlDbType.Int);
            cmd.Parameters.Add("@userid", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters.Add("@customer", SqlDbType.NChar, 30);
            cmd.Parameters.Add("@currentSaleid", SqlDbType.Int);
            cmd.Parameters.Add("@currentProductid", SqlDbType.Int);
            cmd.Parameters.Add("@currentUserid", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@currentDate", SqlDbType.Date);
            cmd.Parameters.Add("@currentQuantity", SqlDbType.Int);
            cmd.Parameters.Add("@currentCustomer", SqlDbType.NChar, 30);

            //Failsafe for correct datatypes
            bool result;
            int number;
            int _saleid = 0;
            int _productid = 0;
            int _quantity = 0;
            string _customer = string.Empty;
            string _user = string.Empty;
            DateTime _date = Convert.ToDateTime(saleDate.Text);
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
            _user = userID.Text;
            if (_user == string.Empty)
                MessageBox.Show("User can't be left empty");

            //Failsafe incase something above doesn't get picked up
            if (_saleid == 0 || _productid == 0 || _quantity == 0 || _customer == string.Empty || _user == string.Empty || _date == null)
                return;

            //Get values from the selected listbox item
            int _saleidForm = 0;
            int _productidForm = 0;
            int _quantityForm = 0;
            string _userForm = string.Empty;
            string _customerForm = string.Empty;
            DateTime _dateForm = DateTime.Today;

            //string _selected = salesRecords.GetItemText(salesRecords.SelectedItem);
            string _selected = "";
            for (int i = 0; i < dataCells.Length; i++)
            {
                if (i == dataCells.Length - 1)
                {
                    _selected += dataCells[i].FormattedValue.ToString();
                }
                else
                {
                    _selected += dataCells[i].FormattedValue.ToString() + " \t ";
                }
            }
            if (_selected == "Sale ID \t Product ID \t User ID   \t Sale Date \t Quantity \t Customer" || _selected == string.Empty)
                MessageBox.Show("Please select a valid entry");
            else
            {
                bool resultForm;
                string[] _output = _selected.Split('\t');
                if (resultForm = int.TryParse(_output[0].Trim(), out number))
                    _saleidForm = number;
                else
                    MessageBox.Show("Sale ID must be a number");

                if (resultForm = int.TryParse(_output[1].Trim(), out number))
                    _productidForm = number;
                else
                    MessageBox.Show("Sale ID must be a number");

                if (resultForm = int.TryParse(_output[4].Trim(), out number))
                    _quantityForm = number;
                else
                    MessageBox.Show("Sale ID must be a number");

                _customerForm = _output[5].Trim();
                if (_customerForm == string.Empty)
                    MessageBox.Show("Customer can't be left empty");

                _userForm = _output[2].Trim();
                if (_userForm == string.Empty)
                    MessageBox.Show("User can't be left empty");

                _dateForm = Convert.ToDateTime(_output[3].Trim());
            }
            //Add values for the parameters
            cmd.Parameters["@saleid"].Value = _saleid;
            cmd.Parameters["@productid"].Value = _productid;
            cmd.Parameters["@userid"].Value = _user;
            cmd.Parameters["@date"].Value = _date;
            cmd.Parameters["@quantity"].Value = _quantity;
            cmd.Parameters["@customer"].Value = _customer;
            cmd.Parameters["@currentSaleid"].Value = _saleidForm;
            cmd.Parameters["@currentproductid"].Value = _productidForm;
            cmd.Parameters["@currentUserid"].Value = _userForm;
            cmd.Parameters["@currentDate"].Value = _dateForm;
            cmd.Parameters["@currentQuantity"].Value = _quantityForm;
            cmd.Parameters["@currentCustomer"].Value = _customerForm;

            //Display a confirmation box - if yes then run the query
            var editCheck = MessageBox.Show("Are you sure want to edit this item?\n" + _saleid + ", " + _productid + ", " + _user + ", " + _date.ToShortDateString() + ", " + _quantity + ", " + _customer + "\nto\n" + _saleidForm + ", " + _productidForm + ", " + _userForm + ", " + _dateForm.ToShortDateString() + ", " + _quantityForm + ", " + _customerForm, "Edit item", MessageBoxButtons.YesNo);
            if (editCheck == DialogResult.Yes)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
                return;

            //"Refresh" the listbox
            UpdateListbox();
            ReloadData();
            dataGridView1.ClearSelection();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //Create connection to db and open the connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";
            con.Open();
            //Create command and query for removal of item
            string scmd = "DELETE FROM dbo.SaleRecords WHERE SaleID = @currentSaleID AND ProductID = @currentProductid AND UserID = @currentUserid AND SaleDate = @currentDate AND Quantity = @currentQuantity AND Customer = @currentCustomer";
            SqlCommand cmd = new SqlCommand(scmd, con);
            //set parameters for cmd
            cmd.Parameters.Add("@currentSaleid", SqlDbType.Int);
            cmd.Parameters.Add("@currentProductid", SqlDbType.Int);
            cmd.Parameters.Add("@currentUserid", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@currentDate", SqlDbType.Date);
            cmd.Parameters.Add("@currentQuantity", SqlDbType.Int);
            cmd.Parameters.Add("@currentCustomer", SqlDbType.NChar, 30);

            //Get information from selected item in listbox
            int number;
            int _saleidForm = 0;
            int _productidForm = 0;
            int _quantityForm = 0;
            string _userForm = string.Empty;
            string _customerForm = string.Empty;
            DateTime _dateForm = DateTime.Today;

            //Convert and check all values from selected listbox item
            //string _selected = salesRecords.GetItemText(salesRecords.SelectedItem);
            string _selected = "";
            for (int i = 0; i < dataCells.Length; i++)
            {
                if (i == dataCells.Length - 1)
                {
                    _selected += dataCells[i].FormattedValue.ToString();
                }
                else
                {
                    _selected += dataCells[i].FormattedValue.ToString() + " \t ";
                }
            }
            if (_selected == "Sale ID \t Product ID \t User ID   \t Sale Date \t Quantity \t Customer")
                MessageBox.Show("Please select a valid entry");
            else
            {
                bool resultForm;
                string[] _output = _selected.Split('\t');
                if (resultForm = int.TryParse(_output[0].Trim(), out number))
                    _saleidForm = number;
                else
                    MessageBox.Show("Sale ID must be a number");

                if (resultForm = int.TryParse(_output[1].Trim(), out number))
                    _productidForm = number;
                else
                    MessageBox.Show("Sale ID must be a number");

                if (resultForm = int.TryParse(_output[4].Trim(), out number))
                    _quantityForm = number;
                else
                    MessageBox.Show("Sale ID must be a number");

                _customerForm = _output[5].Trim();
                if (_customerForm == string.Empty)
                    MessageBox.Show("Customer can't be left empty");

                _userForm = _output[2].Trim();
                if (_userForm == string.Empty)
                    MessageBox.Show("User can't be left empty");

                _dateForm = Convert.ToDateTime(_output[3].Trim());

                //Add parameter values
                cmd.Parameters["@currentSaleid"].Value = _saleidForm;
                cmd.Parameters["@currentproductid"].Value = _productidForm;
                cmd.Parameters["@currentUserid"].Value = _userForm;
                cmd.Parameters["@currentDate"].Value = _dateForm;
                cmd.Parameters["@currentQuantity"].Value = _quantityForm;
                cmd.Parameters["@currentCustomer"].Value = _customerForm;

                var editCheck = MessageBox.Show("Are you sure to delete this item?\n" + _saleidForm + ", " + _productidForm + ", " + _userForm + ", " + _dateForm.ToShortDateString() + ", " + _quantityForm + ", " + _customerForm, "Delete item", MessageBoxButtons.YesNo);
                if (editCheck == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                    return;

                //UpdateListbox();
                ReloadData();
                dataGridView1.ClearSelection();
            }
        }

        private void editSalesRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PHP_SRePSDataSet.SaleRecords' table. You can move, or remove it, as needed.
            this.saleRecordsTableAdapter.Fill(this._PHP_SRePSDataSet.SaleRecords);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row data array, then copy the currently selected row to the array.
            Array.Clear(dataCells, 0, dataCells.Length);
            dataGridView1.CurrentRow.Cells.CopyTo(dataCells, 0);
            string _selected = "";
            for (int i = 0; i < dataCells.Length; i++)
            {
                if (i == dataCells.Length - 1)
                {
                    _selected += dataCells[i].FormattedValue.ToString();
                }
                else
                {
                    _selected += dataCells[i].FormattedValue.ToString() + " \t ";
                }
            }
            //Check to see if its the first entry (table headers), if so return else output the values to the text boxes
            if (_selected == "Sale ID \t Product ID \t User ID   \t Sale Date \t Quantity \t Customer" || _selected == string.Empty)
                return;
            else
            {
                string[] _output = _selected.Split('\t');
                saleID.Text = _output[0].Trim();
                productID.Text = _output[1].Trim();
                userID.Text = _output[2].Trim();
                saleDate.Text = _output[3].Trim();
                quantity.Text = _output[4].Trim();
                customer.Text = _output[5].Trim();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Array.Clear(dataCells, 0, dataCells.Length);
            dataGridView1.ClearSelection();
        }

        public void ReloadData()
        {
            saleRecordsTableAdapter.Fill(_PHP_SRePSDataSet.SaleRecords);
        }

        private void editButton_MouseDown(object sender, MouseEventArgs e)
        {
            editButton.Image = editImages.Images[2];
        }

        private void editButton_MouseHover(object sender, EventArgs e)
        {
            editButton.Image = editImages.Images[1];
        }

        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            editButton.Image = editImages.Images[0];
        }

        private void editButton_MouseUp(object sender, MouseEventArgs e)
        {
            editButton.Image = editImages.Images[0];
        }

        private void removeButton_MouseDown(object sender, MouseEventArgs e)
        {
            removeButton.Image = removeImages.Images[2];
        }

        private void removeButton_MouseHover(object sender, EventArgs e)
        {
            removeButton.Image = removeImages.Images[1];
        }

        private void removeButton_MouseLeave(object sender, EventArgs e)
        {
            removeButton.Image = removeImages.Images[0];
        }

        private void removeButton_MouseUp(object sender, MouseEventArgs e)
        {
            removeButton.Image = removeImages.Images[0];
        }
    }
}
