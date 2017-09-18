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
            UpdateListbox();
        }

        private void UpdateListbox()
        {
            //Remove all values in boxlist
            salesRecords.Items.Clear();

            //Create connection to db and open the connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";
            con.Open();
            //Command to retrive sales records from database
            string scmd = "SELECT * FROM dbo.saleRecords";
            SqlCommand cmd = new SqlCommand(scmd, con);
            //Execute the command as a reader
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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
