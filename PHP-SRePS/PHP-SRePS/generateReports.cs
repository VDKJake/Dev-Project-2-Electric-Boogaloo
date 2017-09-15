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
    public partial class generateReports : Form
    {
        SqlConnection connection;

        public generateReports()
        {
            InitializeComponent();
        }

        private void databaseConnect(SqlConnection con)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=true";
            con.Open();
        }

        private void databaseDisconnect(SqlConnection con)
        {
            con.Close();
        }

        private void generateReports_Load(object sender, EventArgs e)
        {

        }

        private void pickYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void weeklyReport_Click(object sender, EventArgs e)
        {
            string weekStart;
            string weekEnd;

            weekStart = startDate.ToString();
            weekEnd = startDate.Value.AddDays(7).ToString();

            databaseConnect(connection);
            string scmd = "SELECT * FROM dbo.SaleRecords WHERE SaleDate BETWEEN " + weekStart + " AND " + weekEnd + ";";


            databaseDisconnect(connection);
        }

        private void monthlyReport_Click(object sender, EventArgs e)
        {
            string monthStart;
            string monthEnd;

            if (pickYear.Text.Length != 4)
            {
                MessageBox.Show("Year must be in the following format: yyyy");
            }

            switch (pickMonth.SelectedItem.ToString())
            {
                case "January":
                    monthStart = "01/01/";
                    monthEnd = "31/01/";
                    break;
                case "February":
                    monthStart = "01/02/";
                    monthEnd = "29/02/";
                    break;
                case "March":
                    monthStart = "01/03/";
                    monthEnd = "31/03/";
                    break;
                case "April":
                    monthStart = "01/04/";
                    monthEnd = "30/04/";
                    break;
                case "May":
                    monthStart = "01/05/";
                    monthEnd = "31/05/";
                    break;
                case "June":
                    monthStart = "01/06/";
                    monthEnd = "30/06/";
                    break;
                case "July":
                    monthStart = "01/07/";
                    monthEnd = "31/07/";
                    break;
                case "August":
                    monthStart = "01/08/";
                    monthEnd = "31/08/";
                    break;
                case "September":
                    monthStart = "01/09/";
                    monthEnd = "30/09/";
                    break;
                case "October":
                    monthStart = "01/10/";
                    monthEnd = "31/10/";
                    break;
                case "November":
                    monthStart = "01/11/";
                    monthEnd = "30/11/";
                    break;
                case "December":
                    monthStart = "01/12/";
                    monthEnd = "31/12/";
                    break;
                default:
                    MessageBox.Show("Please Select a Month.");
                    return;
            }

            monthStart = monthStart + pickYear.Text;
            monthEnd = monthEnd + pickYear.Text;

            databaseConnect(connection);
            string scmnd = "SELECT * FROM dbo.SaleRecords WHERE SaleDate BETWEEN " + monthStart + " AND " + monthEnd + ";";


            databaseDisconnect(connection);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pickMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


