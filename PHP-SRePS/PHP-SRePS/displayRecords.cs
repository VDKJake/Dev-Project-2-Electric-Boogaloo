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

namespace PHP_SRePS
{
    public partial class displayRecords : Form
    {
        public displayRecords()
        {
            InitializeComponent();
        }

        private void displayRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PHP_SRePSDataSet.SaleRecords' table. You can move, or remove it, as needed.
            this.saleRecordsTableAdapter.Fill(this._PHP_SRePSDataSet.SaleRecords);

        }

        // Reloads the data for the dataGridView
        public void ReloadData()
        {
            saleRecordsTableAdapter.Fill(_PHP_SRePSDataSet.SaleRecords);
        }

        private void productIdSearch_TextChanged(object sender, EventArgs e)
        {
            /*bool result;
            int number;
            if (productIdSearch.Text == "")
            {
                dataGridView1.DataSource = saleRecordsBindingSource;

            }
            else if (result = int.TryParse(productIdSearch.Text, out number))
            {
                DataView DV = new DataView(_PHP_SRePSDataSet.SaleRecords);
                DV.RowFilter += ("Convert(ProductID, System.String) LIKE '" + number + "%'");
                dataGridView1.DataSource = DV;
            }
            else
            {
                MessageBox.Show("The product ID must be a number");
                productIdSearch.Clear();
                return;
            }*/
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchText.Text = "";
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
                        {;
                            errorLabel.Text = "The Quantity must be a number.";
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
        }
    }
}
