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
            DateTime weekStart;
            DateTime weekEnd;

            weekStart = startDate.Value;
            weekEnd = startDate.Value;
            //Gonna need to fix this up later, will also have to format them correctly

            databaseConnect(connection);
            string scmd = "SELECT * FROM dbo.SaleRecords WHERE SaleDate BETWEEN " + weekStart + " AND " + weekEnd + ";";


            databaseDisconnect(connection);
        }

        private void monthlyReport_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


