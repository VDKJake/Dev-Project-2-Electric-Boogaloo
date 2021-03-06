﻿using System;
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
            // Clear everything to make sure no GUI overlaps
            reportLabel.Text = "";
            csvLabel.Text = "";
            reportListView.Items.Clear();
            errorLabel.Text = "";
            DateTime weekStart = startDate.Value;
            DateTime weekEnd = startDate.Value.AddDays(6);

            // Setup new sql connection and query
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=true";
            string scmd = "SELECT ProductID, COUNT(SaleID) AS SaleID, SUM(Quantity) AS Quantity FROM dbo.SaleRecords WHERE SaleDate BETWEEN @weekStart AND @weekEnd GROUP BY ProductID;";

            // Add query parameters
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

                ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem item2 = new ListViewItem.ListViewSubItem();
                item1.Text = saleCount.ToString();
                item2.Text = quantitySold.ToString();
                reportListView.Items.Add(product.ToString()).SubItems.AddRange(new ListViewItem.ListViewSubItem[] { item1, item2 });
                csvOutput += "\n" + product + ", " + saleCount + ", " + quantitySold;
            }

            if (reader.HasRows)
            {
                reportListView.Visible = true;
                output.Text = "";
                string weekOutput1;
                string weekOutput2;
                string[] week1Split = weekStart.ToShortDateString().Split('/');
                string[] week2Split = weekEnd.ToShortDateString().Split('/');
                weekOutput1 = week1Split[0] + "-" + week1Split[1] + "-" + week1Split[2];
                weekOutput2 = week2Split[0] + "-" + week2Split[1] + "-" + week2Split[2];
                System.IO.File.WriteAllText(@"C:\Users\Public\WeeklyReport" + weekOutput1 + "to" + weekOutput2 + ".txt", csvOutput);
                csvLabel.Text = "CSV File for report successfully created at\nC:\\Users\\Public\\WeeklyReport" + weekOutput1 + "to" + weekOutput2 + ".txt";
            }
            //Temporary Location

            //Until proper UI gets added
            reportLabel.Text = tempOutput;
            if (reader.HasRows)
            { }
                //output.Text = tempOutput;
            else
            {
                output.Text = "No sales during this week";
                reportListView.Visible = false;
                csvLabel.Text = "";
            }

            reader.Close();
            con.Close();
        }

        private void monthlyReport_Click(object sender, EventArgs e)
        {
            reportLabel.Text = "";
            csvLabel.Text = "";
            reportListView.Items.Clear();
            errorLabel.Text = "";
            reportListView.Visible = true;
            DateTime monthStart;
            DateTime monthEnd;

            int number;
            bool result;
            int year;

            if (pickYear.Text.Length != 4)
            {
                //MessageBox.Show("Year must be in the following numerical format: yyyy");
                errorLabel.Text = "Year must be in the following numerical format: yyyy";
                errorTimer.Start();
                return;
            }
            else if (result = int.TryParse(pickYear.Text, out number))
                year = number;
            else
            {
                //MessageBox.Show("The year must be a number");
                errorLabel.Text = "The year must be a number";
                errorTimer.Start();
                return;
            }

            if (pickMonth.SelectedItem == null)
            {
                errorLabel.Text = "Please Select a Month";
                errorTimer.Start();
                return;
            }
            else
            {
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
                        //MessageBox.Show("Please Select a Month.");
                        return;
                }
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
                reportListView.Visible = true;
                output.Text = "";
                int product = (int)reader["ProductID"];
                int saleCount = (int)reader["SaleID"];
                int quantitySold = (int)reader["Quantity"];

                ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem item2 = new ListViewItem.ListViewSubItem();
                item1.Text = saleCount.ToString();
                item2.Text = quantitySold.ToString();
                //tempOutput += "Product ID: " + product + " - Sale Count: " + saleCount + " - Quantity: " + quantitySold + "\n";
                reportListView.Items.Add(product.ToString()).SubItems.AddRange(new ListViewItem.ListViewSubItem[] { item1, item2 });
                csvOutput += "\n" + product + ", " + saleCount + ", " + quantitySold;
                
            }

            if (reader.HasRows)
            {
                System.IO.File.WriteAllText(@"C:\Users\Public\MonthlyReport" + _selectedMonth + pickYear.Text + ".txt", csvOutput);
                csvLabel.Text = "CSV File for report successfully created at\nC:\\Users\\Public\\MonthlyReport" + _selectedMonth + pickYear.Text + ".txt";
            }
            //Temp Location

            reportLabel.Text = tempOutput;
            //Until proper UI gets added
            if (reader.HasRows)
            {
            }
            else
            {
                output.Text = "No sales during this month";
                csvLabel.Text = "";
                reportListView.Visible = false;
            }
                

            reader.Close();
            con.Close();
        }

        // All of these _MouseDown, _MouseLeave, _MouseUp & _MouseEnter functions
        // change the image of the buttons when hovering, pressing and taking the 
        // cursor off the buttons. It's such a bad way to do it but it works.
        private void pickMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMonth = pickMonth.SelectedItem.ToString();
        }

        private void weeklyReport_MouseDown(object sender, MouseEventArgs e)
        {
            weeklyReport.Image = weeklyImages.Images[2];
        }

        private void weeklyReport_MouseEnter(object sender, EventArgs e)
        {
            weeklyReport.Image = weeklyImages.Images[1];
        }

        private void weeklyReport_MouseLeave(object sender, EventArgs e)
        {
            weeklyReport.Image = weeklyImages.Images[0];
        }

        private void weeklyReport_MouseUp(object sender, MouseEventArgs e)
        {
            weeklyReport.Image = weeklyImages.Images[0];
        }

        private void monthlyReport_MouseDown(object sender, MouseEventArgs e)
        {
            monthlyReport.Image = monthlyImages.Images[2];
        }

        private void monthlyReport_MouseEnter(object sender, EventArgs e)
        {
            monthlyReport.Image = monthlyImages.Images[1];
        }

        private void monthlyReport_MouseLeave(object sender, EventArgs e)
        {
            monthlyReport.Image = monthlyImages.Images[0];
        }

        private void monthlyReport_MouseUp(object sender, MouseEventArgs e)
        {
            monthlyReport.Image = monthlyImages.Images[0];
        }

        private void errorTimer_Tick(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}


