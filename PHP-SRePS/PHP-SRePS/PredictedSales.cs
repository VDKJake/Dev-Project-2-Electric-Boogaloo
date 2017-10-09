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
using System.Data.SqlTypes;
using System.Globalization;
using System.Diagnostics;

namespace PHP_SRePS
{
    public partial class PredictedSales : Form
    {
        private DataGridViewCell[] selectedItem = new DataGridViewCell[14];
        private DataSet ds = new DataSet();
        private int targetMonth;

        public PredictedSales()
        {
            InitializeComponent();
            //PredictSales();
            // Get the current month and set the target month to the next month
            switch (/*pickMonth.SelectedItem.ToString()*/DateTime.Today.Month)
            {
                case 1:
                    targetMonth = 3;
                    break;
                case 2:
                    targetMonth = 4;
                    break;
                case 3:
                    targetMonth = 5;
                    break;
                case 4:
                    targetMonth = 6;
                    break;
                case 5:
                    targetMonth = 7;
                    break;
                case 6:
                    targetMonth = 8;
                    break;
                case 7:
                    targetMonth = 9;
                    break;
                case 8:
                    targetMonth = 10;
                    break;
                case 9:
                    targetMonth = 11;
                    break;
                case 10:
                    targetMonth = 12;
                    break;
                case 11:
                    targetMonth = 13;
                    break;
                case 12:
                    // I literally cant be assed making this work
                    targetMonth = 13;
                    break;
                default:
                    return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT ProductName as name FROM Products", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                singleItemPick.Items.Add(sdr["name"].ToString().Trim());
            }
            con.Close();
            predictions.Visible = false;
            PopulateAllSales();
            listView1.Columns[1].Text = GetMonth(DateTime.Today.Month) + "'s Sales";
            listView1.Columns[2].Text = GetMonth(DateTime.Today.Month + 1) + "'s Predicted Sales";
        }
        
        private string GetMonth(int num)
        {
            string result = "";
            switch (num)
            {
                case 1:
                    result = "January";
                    break;
                case 2:
                    result = "February";
                    break;
                case 3:
                    result = "March";
                    break;
                case 4:
                    result = "April";
                    break;
                case 5:
                    result = "May";
                    break;
                case 6:
                    result = "June";
                    break;
                case 7:
                    result = "July";
                    break;
                case 8:
                    result = "August";
                    break;
                case 9:
                    result = "September";
                    break;
                case 10:
                    result = "October";
                    break;
                case 11:
                    result = "November";
                    break;
                case 12:
                    result = "December";
                    break;
            }
            return result;
        }

        private void PopulateAllSales()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";

            string scmd = "SELECT * FROM(SELECT TOP 2147483647 YEAR(SaleDate)[Year], ProductName, DATENAME(MONTH, SaleDate)[Month], SUM(Quantity)[Quantity] FROM dbo.SaleRecords JOIN dbo.Products ON Products.ProductID = SaleRecords.ProductID GROUP BY YEAR(SaleDate), ProductName, DATENAME(MONTH, SaleDate) ORDER BY YEAR(SaleDate)) AS MontlySalesData PIVOT(SUM([Quantity]) FOR Month IN([January],[February],[March],[April],[May],[June],[July],[August],[September],[October],[November],[December])) AS MNamePivot";

            SqlDataAdapter sda = new SqlDataAdapter(scmd, con);
            con.Open();
            sda.Fill(ds);
            predictions.DataSource = ds.Tables[0];
            //predections.Rows.Add("product", "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec", "year");
            con.Close();
            for (int i = 2; i < 14; i++)
            {
                predictions.Columns[i].Width = 65;
            }
            // To make this actually predict sales we need to add in a function that reads the
            // percentage increase/decrease in sales from month to month and averages it out.
            // Then it needs to apply that percentage increase to each following month. Maybe only to the end of the year or something.
            // Also need to differentiate for single items and all items, and add CSV output
        }
        
        public void Predict(DataGridViewRow r)
        {
            Array.Clear(selectedItem, 0, selectedItem.Length);
            //predictions.Rows[1].Cells.CopyTo(selectedItem, 0);
            r.Cells.CopyTo(selectedItem, 0);
            //float[] percentageChange = new float[11];
            float percentageChange;
            /*for (int i = 0; i < selectedItem.Length; i++)
            {
                Debug.Write(selectedItem[i].FormattedValue.ToString());
            }*/
            //Debug.Write(selectedItem[2].ToString());
            float change = 0;
            float no1;
            float no2;
            predictLabel.Text = ("\n" + selectedItem[1].FormattedValue.ToString() + ": ");
            if (selectedItem[targetMonth - 2].FormattedValue.ToString() != "" && selectedItem[targetMonth - 1].FormattedValue.ToString() != "")
            {
                no1 = float.Parse(selectedItem[targetMonth - 2].FormattedValue.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                no2 = float.Parse(selectedItem[targetMonth - 1].FormattedValue.ToString(), CultureInfo.InvariantCulture.NumberFormat);

                if (no1 < no2)
                {
                    percentageChange = ((no2 - no1) / no1) * 100;
                    predictLabel.Text = (Math.Round(no2 + (no2 * percentageChange / 100))).ToString();
                }
                else if (no2 < no1)
                {
                    percentageChange = ((no1 - no2) / no1 * 100);
                    predictLabel.Text = (Math.Round(no2 - (no2 * percentageChange / 100))).ToString();
                }
                else
                {
                    percentageChange = 0;
                    predictLabel.Text = "\n no change";
                }
            }
            else
            {
                predictLabel.Text = "Insufficient data for accurate prediction";
            }

            Debug.Write("\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            DataGridViewRow r = predictions.SelectedRows[0];
            Predict(r);
        }

        private void PredictedSales_Shown(object sender, EventArgs e)
        {
            productTitleLabel.Text = "Product Sales for " + DateTime.Today.Year.ToString();
            Debug.Write(DateTime.Today.Year.ToString());
        }

        private void singleProduct_Click(object sender, EventArgs e)
        {
            selectItemLabel.Visible = true;
            singleItemPick.Visible = true;
            predictions.Visible = false;
            listView1.Visible = true;
        }

        private void singleItemPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView DGV = new DataGridView();
            DGV.Columns.Add("year", "2017");
            DGV.Columns.Add("product", "Product Name");
            DGV.Columns.Add("jan", "January");
            DGV.Columns.Add("feb", "February");
            DGV.Columns.Add("march", "March");
            DGV.Columns.Add("april", "April");
            DGV.Columns.Add("may", "May");
            DGV.Columns.Add("june", "June");
            DGV.Columns.Add("july", "July");
            DGV.Columns.Add("aug", "August");
            DGV.Columns.Add("sep", "September");
            DGV.Columns.Add("oct", "October");
            DGV.Columns.Add("nov", "November");
            DGV.Columns.Add("dec", "December");
            //DGV.Rows.Add(predictions.Rows[0]);
            for (int i = 2; i < 14; i++)
            {
                predictions.Columns[i].Width = 65;
            }
        }

        private void produceSinglePrediction_Click(object sender, EventArgs e)
        {
            singleItemPick.SelectedItem.ToString();

        }
    }
}
