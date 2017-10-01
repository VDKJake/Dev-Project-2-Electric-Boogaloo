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
//Temp using for Debug.WriteLine
using System.Diagnostics;

namespace PHP_SRePS
{
    public partial class generateReports : Form
    {
        string _selectedMonth;

        public generateReports()
        {
            InitializeComponent();
        }

        private void generateReports_Load(object sender, EventArgs e)
        {

        }

        private void pickYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void weeklyReport_Click(object sender, EventArgs e)
        {
            DateTime weekStart = startDate.Value;
            DateTime weekEnd = startDate.Value.AddDays(6);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=true";
            string scmd = "SELECT ProductID, COUNT(SaleID) AS SaleID, SUM(Quantity) AS Quantity FROM dbo.SaleRecords WHERE SaleDate BETWEEN @weekStart AND @weekEnd GROUP BY ProductID;";

            SqlCommand cmd = new SqlCommand(scmd, con);
            cmd.Parameters.Add("@weekStart", SqlDbType.Date);
            cmd.Parameters.Add("@weekEnd", SqlDbType.Date);
            cmd.Parameters["@weekStart"].Value = weekStart;
            cmd.Parameters["@weekEnd"].Value = weekEnd;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            //Until proper UI gets added
            string tempOutput = "Weekly Report: " + weekStart.ToShortDateString() + " to " + weekEnd.ToShortDateString() + ".\n";
            string csvOutput = "Weekly Report: " + weekStart.ToShortDateString() + " to " + weekEnd.ToShortDateString() + ".\nProductID, SaleCount, QuanititySold";


            while (reader.Read())
            {
                int product = (int)reader["ProductID"];
                int saleCount = (int)reader["SaleID"];
                int quantitySold = (int)reader["Quantity"];

                tempOutput += "Product ID: " + product + " - Sale Count: " + saleCount + " - Quantity: " + quantitySold + "\n";
                csvOutput += "\n" + product + ", " + saleCount + ", " + quantitySold;
            }

            if (reader.HasRows)
                //Output to file


            //Until proper UI gets added
            if (reader.HasRows)
                output.Text = tempOutput;
            else
                output.Text = "No sales during this week";

            reader.Close();
            con.Close();
        }

        private void monthlyReport_Click(object sender, EventArgs e)
        {
            DateTime monthStart;
            DateTime monthEnd;

            int number;
            bool result;
            int year;

            if (pickYear.Text.Length != 4)
            {
                MessageBox.Show("Year must be in the following numerical format: yyyy");
                return;
            }
            else if (result = int.TryParse(pickYear.Text, out number))
                year = number;
            else
            {
                MessageBox.Show("The year must be a number");
                return;
            }

            switch (pickMonth.SelectedItem.ToString())
            {
                case "January":
                    monthStart = Convert.ToDateTime("01/01/" + year);
                    monthEnd = Convert.ToDateTime("31/01/" + year);
                    break;
                case "February":
                    monthStart = Convert.ToDateTime("01/02/" + year);
                    if (year % 4 == 0)
                        monthEnd = Convert.ToDateTime("29/02/" + year);
                    else
                        monthEnd = Convert.ToDateTime("28/02/" + year);
                    break;
                case "March":
                    monthStart = Convert.ToDateTime("01/03/" + year);
                    monthEnd = Convert.ToDateTime("31/03/" + year);
                    break;
                case "April":
                    monthStart = Convert.ToDateTime("01/04/" + year);
                    monthEnd = Convert.ToDateTime("30/04/" + year);
                    break;
                case "May":
                    monthStart = Convert.ToDateTime("01/05/" + year);
                    monthEnd = Convert.ToDateTime("31/05/" + year);
                    break;
                case "June":
                    monthStart = Convert.ToDateTime("01/06/" + year);
                    monthEnd = Convert.ToDateTime("30/06/" + year);
                    break;
                case "July":
                    monthStart = Convert.ToDateTime("01/07/" + year);
                    monthEnd = Convert.ToDateTime("31/07/" + year);
                    break;
                case "August":
                    monthStart = Convert.ToDateTime("01/08/" + year);
                    monthEnd = Convert.ToDateTime("31/08/" + year);
                    break;
                case "September":
                    monthStart = Convert.ToDateTime("01/09/" + year);
                    monthEnd = Convert.ToDateTime("30/09/" + year);
                    break;
                case "October":
                    monthStart = Convert.ToDateTime("01/10/" + year);
                    monthEnd = Convert.ToDateTime("31/10/" + year);
                    break;
                case "November":
                    monthStart = Convert.ToDateTime("01/11/" + year);
                    monthEnd = Convert.ToDateTime("30/11/" + year);
                    break;
                case "December":
                    monthStart = Convert.ToDateTime("01/12/" + year);
                    monthEnd = Convert.ToDateTime("31/12/" + year);
                    break;
                default:
                    MessageBox.Show("Please Select a Month.");
                    return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=true";
            string scmd = "SELECT ProductID, COUNT(SaleID) AS SaleID, SUM(Quantity) AS Quantity FROM dbo.SaleRecords WHERE SaleDate BETWEEN @monthStart AND @monthEnd GROUP BY ProductID;";

            SqlCommand cmd = new SqlCommand(scmd, con);
            cmd.Parameters.Add("@monthStart", SqlDbType.Date);
            cmd.Parameters.Add("@monthEnd", SqlDbType.Date);
            cmd.Parameters["@monthStart"].Value = monthStart;
            cmd.Parameters["@monthEnd"].Value = monthEnd;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            //Until proper UI gets added
            string tempOutput = "Monthly Report: " + _selectedMonth + " " + pickYear.Text + ".\n";
            string csvOutput = "Monthly Report: " + _selectedMonth + " " + pickYear.Text + "\nProductID, SaleCount, QuanititySold";

            while (reader.Read())
            {
                int product = (int)reader["ProductID"];
                int saleCount = (int)reader["SaleID"];
                int quantitySold = (int)reader["Quantity"];

                tempOutput += "Product ID: " + product + " - Sale Count: " + saleCount + " - Quantity: " + quantitySold + "\n";
                csvOutput += "\n" + product + ", " + saleCount + ", " + quantitySold;
            }

            if (reader.HasRows)
                //Output to file

            //Until proper UI gets added
            if (reader.HasRows)
                output.Text = tempOutput;
            else
                output.Text = "No sales during this month";

            reader.Close();
            con.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pickMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMonth = pickMonth.SelectedItem.ToString();
        }
    }
}


