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
        public displayRecords display;

        public editSalesRecord()
        {
            InitializeComponent();
            UpdateListbox();
            PopulateCombobox();
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

        private void salesRecords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Create connection to db and open the connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";

            //Prep query
            string scmd = "UPDATE dbo.SaleRecords SET ProductID = @productid, UserID = @userid, SaleDate = @date, Quantity = @quantity, Customer = @customer WHERE SaleID = @currentSaleID AND ProductID = @currentProductid AND UserID = @currentUserid AND SaleDate = @currentDate AND Quantity = @currentQuantity AND Customer = @currentCustomer";
            SqlCommand cmd = new SqlCommand(scmd, con);
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
            DateTime tempDate;
            int _productid = 0;
            int _quantity = 0;
            string _customer = string.Empty;
            string _user = string.Empty;
            DateTime _date;
            if (result = DateTime.TryParse(saleDate.Text, out tempDate))
            {
                _date = tempDate;
            }
            else
            {
                errorLabel2.Text = "Date must be in valid date format - DD/MM/YYYY";
                errorTimer.Start();
                return;
            }

            if (result = int.TryParse(productID.Text, out number))
                _productid = number;
            else
            {
                errorLabel2.Text = "The product ID must be a number";
                errorTimer.Start();
                return;
            }

            if (result = int.TryParse(quantity.Text, out number))
                _quantity = number;
            else
            {
                errorLabel2.Text = "The quantity must be a number";
                errorTimer.Start();
                return;
            }

            _customer = customer.Text;
            if (_customer == string.Empty)
            {
                errorLabel2.Text = "Customer can't be left empty";
                errorTimer.Start();
            }
            if (userList.SelectedIndex == -1)
            {
                errorLabel2.Text = "User can't be left empty";
                errorTimer.Start();
            }
            else
            {
                _user = userList.SelectedItem.ToString().Trim();
            }

            //Failsafe incase something above doesn't get picked up
            if (_productid == 0 || _quantity == 0 || _customer == string.Empty || _user == string.Empty || _date == null)
                return;

            //Get values from the selected listbox item
            int _saleidForm = 0;
            int _productidForm = 0;
            int _quantityForm = 0;
            string _userForm = string.Empty;
            string _customerForm = string.Empty;
            DateTime _dateForm = DateTime.Today;

            // Convert and check all values from selected dataGridView row
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
                errorLabel2.Text = "Please select a valid entry";
            else
            {
                bool resultForm;
                string[] _output = _selected.Split('\t');
                if (resultForm = int.TryParse(_output[0].Trim(), out number))
                    _saleidForm = number;
                else
                {
                    errorLabel2.Text = "Sale ID must be a number";
                    errorTimer.Start();
                }

                if (resultForm = int.TryParse(_output[1].Trim(), out number))
                    _productidForm = number;
                else
                {
                    errorLabel2.Text = "Sale ID must be a number";
                    errorTimer.Start();
                }
                if (resultForm = int.TryParse(_output[4].Trim(), out number))
                    _quantityForm = number;
                else
                {
                    errorLabel2.Text = "Sale ID must be a number";
                    errorTimer.Start();
                }
                _customerForm = _output[5].Trim();
                if (_customerForm == string.Empty)
                {
                    errorLabel2.Text = "Customer can't be left empty";
                    errorTimer.Start();
                }
                _userForm = _output[2].Trim();
                if (_userForm == string.Empty)
                {
                    errorLabel2.Text = "User can't be left empty";
                    errorTimer.Start();
                }

                _dateForm = Convert.ToDateTime(_output[3].Trim());
            }
            //Add values for the parameters
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
            var editCheck = MessageBox.Show("Are you sure want to edit this item?\n\nSale ID: " + _saleidForm + "\nProduct ID: " + _productidForm + "\nUser ID: " + _userForm + "\nDate: " + _dateForm.ToShortDateString() + "\nQuantity: " + _quantityForm + "\nCustomer: " + _customerForm + "\n\nWill be changed to:\n\nProduct ID: " + _productid + "\nUser ID: " + _user + "\nDate: " + _date.ToShortDateString() + "\nQuantity: " + _quantity + "\nCustomer: " + _customer,"Edit item", MessageBoxButtons.YesNo);
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
            display.ReloadData();
            dataGridView1.ClearSelection();

            // Clear the input textboxes, clear the error message and disable the buttons
            saleID.Clear();
            productID.Clear();
            userID.Clear();
            saleDate.Clear();
            quantity.Clear();
            customer.Clear();
            userList.SelectedIndex = -1;
            removeButton.Enabled = false;
            editButton.Enabled = false;
            errorLabel2.Text = "";
        }

        // Populates the Users drop down box with all usernames
        public void PopulateCombobox()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT UserID as name FROM Users", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                userList.Items.Add(sdr["name"].ToString().Trim());
            }
            con.Close();
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

            //Convert and check all values from selected dataGridView row
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
                errorLabel2.Text = "Please select a valid entry";
            else
            {
                bool resultForm;
                string[] _output = _selected.Split('\t');
                if (resultForm = int.TryParse(_output[0].Trim(), out number))
                    _saleidForm = number;
                else
                {
                    errorLabel2.Text = "Sale ID must be a number";
                    errorTimer.Start();
                }

                if (resultForm = int.TryParse(_output[1].Trim(), out number))
                    _productidForm = number;
                else
                {
                    errorLabel2.Text = "Sale ID must be a number";
                    errorTimer.Start();
                }

                if (resultForm = int.TryParse(_output[4].Trim(), out number))
                    _quantityForm = number;
                else
                {
                    errorLabel2.Text = "Sale ID must be a number";
                    errorTimer.Start();
                }

                _customerForm = _output[5].Trim();
                if (_customerForm == string.Empty)
                {
                    errorLabel2.Text = "Customer can't be left empty";
                    errorTimer.Start();
                }

                _userForm = _output[2].Trim();
                if (_userForm == string.Empty)
                {
                    errorLabel2.Text = "User can't be left empty";
                    errorTimer.Start();
                }

                _dateForm = Convert.ToDateTime(_output[3].Trim());

                //Add parameter values
                cmd.Parameters["@currentSaleid"].Value = _saleidForm;
                cmd.Parameters["@currentproductid"].Value = _productidForm;
                cmd.Parameters["@currentUserid"].Value = _userForm;
                cmd.Parameters["@currentDate"].Value = _dateForm;
                cmd.Parameters["@currentQuantity"].Value = _quantityForm;
                cmd.Parameters["@currentCustomer"].Value = _customerForm;

                var editCheck = MessageBox.Show("Are you sure you want to delete this item?\nSale ID: " + _saleidForm + "\nProduct ID: " + _productidForm + "\nUser ID: " + _userForm + "\nDate: " + _dateForm.ToShortDateString() + "\nQuantity: " + _quantityForm + "\nCustomer: " + _customerForm, "Delete item", MessageBoxButtons.YesNo);
                if (editCheck == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                    return;

                //UpdateListbox();
                ReloadData();
                display.ReloadData();
                dataGridView1.ClearSelection();

                // Clear the input textboxes, the error message and disable the buttons
                saleID.Clear();
                productID.Clear();
                userID.Clear();
                saleDate.Clear();
                quantity.Clear();
                customer.Clear();
                userList.SelectedIndex = -1;
                removeButton.Enabled = false;
                editButton.Enabled = false;
                errorLabel2.Text = "";
            }
        }

        private void editSalesRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PHP_SRePSDataSet.SaleRecords' table. You can move, or remove it, as needed.
            this.saleRecordsTableAdapter.Fill(this._PHP_SRePSDataSet.SaleRecords);
            dataGridView1.ClearSelection();
            removeButton.Enabled = false;
            editButton.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row data array, then copy the currently selected row to the array.
            Array.Clear(dataCells, 0, dataCells.Length);
            dataGridView1.CurrentRow.Cells.CopyTo(dataCells, 0);
            string _selected = "";
            removeButton.Enabled = true;
            editButton.Enabled = true;
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
                userList.SelectedIndex = userList.FindStringExact(_output[2].Trim());
                saleDate.Text = _output[3].Trim();
                quantity.Text = _output[4].Trim();
                customer.Text = _output[5].Trim();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // For when a header is clicked, just clears the selection
            Array.Clear(dataCells, 0, dataCells.Length);
            dataGridView1.ClearSelection();
            saleID.Clear();
            productID.Clear();
            userID.Clear();
            saleDate.Clear();
            quantity.Clear();
            customer.Clear();
            removeButton.Enabled = false;
            editButton.Enabled = false;
        }

        // Reloads the data in the dataGridView
        public void ReloadData()
        {
            saleRecordsTableAdapter.Fill(_PHP_SRePSDataSet.SaleRecords);
        }

        // All of these _MouseDown, _MouseLeave, _MouseUp & _MouseEnter functions
        // change the image of the buttons when hovering, pressing and taking the 
        // cursor off the buttons. It's such a bad way to do it but it works.
        private void editButton_MouseDown(object sender, MouseEventArgs e)
        {
            editButton.Image = editImages.Images[2];
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

        private void removeButton_MouseLeave(object sender, EventArgs e)
        {
            removeButton.Image = removeImages.Images[0];
        }

        private void removeButton_MouseUp(object sender, MouseEventArgs e)
        {
            removeButton.Image = removeImages.Images[0];
        }

        private void editButton_MouseEnter(object sender, EventArgs e)
        {
            editButton.Image = editImages.Images[1];
        }

        private void removeButton_MouseEnter(object sender, EventArgs e)
        {
            removeButton.Image = removeImages.Images[1];
        }

        // When another value is selected in the drop box reset the search text,
        // clear the current array of selected data, clear the data view selection,
        // clear the input boxes and disable the edit and remove buttons.
        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchText.Text = "";
            Array.Clear(dataCells, 0, dataCells.Length);
            dataGridView1.ClearSelection();
            saleID.Clear();
            productID.Clear();
            userID.Clear();
            saleDate.Clear();
            quantity.Clear();
            customer.Clear();
            userList.SelectedIndex = -1;
            removeButton.Enabled = false;
            editButton.Enabled = false;
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            bool result;
            int number;
            DataView DV = new DataView(_PHP_SRePSDataSet.SaleRecords);
            if (searchText.Text == "")
            {
                dataGridView1.DataSource = saleRecordsBindingSource;
            }
            else
            {
                switch (searchBox.SelectedItem)
                {
                    case "Sale ID":
                        if (result = int.TryParse(searchText.Text, out number))
                        {
                            DV.RowFilter = ("Convert(SaleID, System.String) LIKE '" + number + "%'");
                            dataGridView1.DataSource = DV;
                            errorLabel.Text = "";
                        }
                        else
                        {
                            errorLabel.Text = "The Sale ID must be a number.";
                            errorTimer.Start();
                            searchText.Clear();
                            return;
                        }
                        break;
                    case "Product ID":
                        if (result = int.TryParse(searchText.Text, out number))
                        {
                            DV.RowFilter = ("Convert(ProductID, System.String) LIKE '" + number + "%'");
                            dataGridView1.DataSource = DV;
                            errorLabel.Text = "";
                        }
                        else
                        {
                            errorLabel.Text = "The Product ID must be a number.";
                            errorTimer.Start();
                            searchText.Clear();
                            return;
                        }
                        break;
                    case "User ID":
                        DV.RowFilter = "UserID LIKE '" + searchText.Text.Trim() + "%'";
                        dataGridView1.DataSource = DV;
                        errorLabel.Text = "";
                        break;
                    case "Sale Date":
                        DV.RowFilter = "Convert(SaleDate, System.String) LIKE '" + searchText.Text.Trim() + "%'";
                        dataGridView1.DataSource = DV;
                        errorLabel.Text = "";
                        break;
                    case "Quantity":
                        if (result = int.TryParse(searchText.Text, out number))
                        {
                            DV.RowFilter = ("Convert(Quantity, System.String) LIKE '" + number + "%'");
                            dataGridView1.DataSource = DV;
                            errorLabel.Text = "";
                        }
                        else
                        {
                            ;
                            errorLabel.Text = "The Quantity must be a number.";
                            errorTimer.Start();
                            searchText.Clear();
                            return;
                        }
                        break;
                    case "Customer":
                        DV.RowFilter = "Customer LIKE '" + searchText.Text.Trim() + "%'";
                        dataGridView1.DataSource = DV;
                        errorLabel.Text = "";
                        break;
                }
            }
        }

        private void errorTimer_Tick(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            errorLabel2.Text = "";
        }
    }
}
