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
        private DataView dv = new DataView();
        private int targetMonth;
        private string allCsvOutput = "";

        public PredictedSales()
        {
            InitializeComponent();
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
            estListView.Columns[1].Text = GetMonth(DateTime.Today.Month - 1) + "'s Sales";
            estListView.Columns[2].Text = GetMonth(DateTime.Today.Month) + "'s Sales";
            estListView.Columns[3].Text = GetMonth(DateTime.Today.Month + 1) + "'s Predicted Sales";
            estListViewAll.Columns[1].Text = GetMonth(DateTime.Today.Month - 1) + "'s Sales";
            estListViewAll.Columns[2].Text = GetMonth(DateTime.Today.Month) + "'s Sales";
            estListViewAll.Columns[3].Text = GetMonth(DateTime.Today.Month + 1) + "'s Predicted Sales";
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
            dv.Table = ds.Tables[0];
            con.Close();
            for (int i = 2; i < 14; i++)
            {
                predictions.Columns[i].Width = 65;
            }
        }
        
        public void Predict(DataGridViewRow r, string type)
        {
            Array.Clear(selectedItem, 0, selectedItem.Length);
            r.Cells.CopyTo(selectedItem, 0);
            float percentageChange;
            float no1;
            float no2;
            string nextMonthValue = "";
            if (selectedItem[targetMonth - 2].FormattedValue.ToString() != "" && selectedItem[targetMonth - 1].FormattedValue.ToString() != "")
            {
                no1 = float.Parse(selectedItem[targetMonth - 2].FormattedValue.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                no2 = float.Parse(selectedItem[targetMonth - 1].FormattedValue.ToString(), CultureInfo.InvariantCulture.NumberFormat);

                if (no1 < no2)
                {
                    percentageChange = ((no2 - no1) / no1) * 100;
                    nextMonthValue = (Math.Round(no2 + (no2 * percentageChange / 100))).ToString();
                    if (type == "single")
                    {
                        messageLabel.Text = "Based on " + GetMonth(DateTime.Today.Month - 1) + "'s and " 
                            + GetMonth(DateTime.Today.Month) + "'s sales for " + selectedItem[1].FormattedValue.ToString()
                            + ",\n" + GetMonth(DateTime.Today.Month + 1) + "'s sales for " + selectedItem[1].FormattedValue.ToString()
                            + " will be " + nextMonthValue + " items.";
                    }
                }
                else if (no2 < no1)
                {
                    percentageChange = ((no1 - no2) / no1 * 100);
                    nextMonthValue = (Math.Round(no2 - (no2 * percentageChange / 100))).ToString();
                    if (type == "single")
                    {
                        messageLabel.Text = "Based on " + GetMonth(DateTime.Today.Month - 1) + "'s and "
                            + GetMonth(DateTime.Today.Month) + "'s sales for " + selectedItem[1].FormattedValue.ToString()
                            + ",\n" + GetMonth(DateTime.Today.Month + 1) + "'s sales for " + selectedItem[1].FormattedValue.ToString()
                            + " will be " + nextMonthValue + " items.";
                    }
                }
                else
                {
                    percentageChange = 0;
                    nextMonthValue = no2.ToString();
                    if (type == "single")
                    {
                        messageLabel.Text = "Based on " + GetMonth(DateTime.Today.Month - 1) + "'s and "
                            + GetMonth(DateTime.Today.Month) + "'s sales for " + selectedItem[1].FormattedValue.ToString()
                            + ",\n" + GetMonth(DateTime.Today.Month + 1) + "'s sales for " + selectedItem[1].FormattedValue.ToString()
                            + " will be " + nextMonthValue + " items.";
                    }
                }

                if (type == "single")
                {
                    ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem item2 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem item3 = new ListViewItem.ListViewSubItem();
                    item1.Text = no1.ToString();
                    item2.Text = no2.ToString();
                    item3.Text = nextMonthValue.ToString();
                    estListView.Items.Add(selectedItem[1].FormattedValue.ToString()).SubItems.AddRange(new ListViewItem.ListViewSubItem[] { item1, item2, item3 });
                    string csvOutput = selectedItem[1].FormattedValue.ToString() + " Estimated Sales for " + GetMonth(DateTime.Today.Month + 1) + ".\nPredictedSaleAmount\n" + nextMonthValue.ToString();
                    System.IO.File.WriteAllText(@"C:\Users\Public\" + selectedItem[1].FormattedValue.ToString().Replace(" ", "") + GetMonth(DateTime.Today.Month + 1) + "SalesEstimation.txt", csvOutput);
                    csvLabel.Text = "CSV File for estimation successfully created at\nC:\\Users\\Public\\" + selectedItem[1].FormattedValue.ToString().Replace(" ", "") + GetMonth(DateTime.Today.Month + 1) + "SalesEstimation.txt";
                }
                else if (type == "all")
                {
                    ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem item2 = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem item3 = new ListViewItem.ListViewSubItem();
                    item1.Text = no1.ToString();
                    item2.Text = no2.ToString();
                    item3.Text = nextMonthValue.ToString();
                    estListViewAll.Items.Add(selectedItem[1].FormattedValue.ToString()).SubItems.AddRange(new ListViewItem.ListViewSubItem[] { item1, item2, item3 });
                    allCsvOutput += "\n" + selectedItem[1].FormattedValue.ToString() + ", " + nextMonthValue.ToString();
                }
            }
            else
            {
                if (type == "single")
                {
                    errorLabel.Text = "Insufficient sales data for accurate prediction";
                }
                else if (type == "all")
                {
                    errorLabel2.Text = "Unable to produce an accurate prediction for some products\ndue to insufficient sales data.";
                }
            }
            
            Debug.Write("\n");
        }

        private void allProducts_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            errorLabel.Text = "";
            errorLabel2.Text = "";
            csvLabel.Text = "";
            selectItemLabel.Visible = false;
            singleItemPick.Visible = false;
            singleItemPick.Enabled = false;
            produceSinglePrediction.Visible = false;
            produceSinglePrediction.Enabled = false;
            estListView.Visible = false;
            estListView.Enabled = false;
            predictions.Visible = false;
            produceAllPredictions.Visible = true;
            produceAllPredictions.Enabled = true;
            estListViewAll.Enabled = true;
        }

        private void produceAllPredictions_Click(object sender, EventArgs e)
        {
            estListViewAll.Visible = true;
            estListViewAll.Clear();
            estListViewAll.Columns.Add("Product Name", 80);
            estListViewAll.Columns.Add(GetMonth(DateTime.Today.Month - 1) + "'s Sales", 100);
            estListViewAll.Columns.Add(GetMonth(DateTime.Today.Month) + "'s Sales", 100);
            estListViewAll.Columns.Add(GetMonth(DateTime.Today.Month + 1) + "'s Predicted Sales", 160);
            errorLabel2.Text = "";
            for (int i = 1; i < predictions.Rows.Count; i++)
            {
                Predict(predictions.Rows[i], "all");
            }
            string csvHeader = "Estimated Sales for All Products for " + GetMonth(DateTime.Today.Month + 1) + ".\nProductName, PredictedSaleAmount" + allCsvOutput;
            System.IO.File.WriteAllText(@"C:\Users\Public\" + GetMonth(DateTime.Today.Month + 1) + "AllProductsSalesEstimation.txt", csvHeader);
            csvLabel.Text = "CSV File for estimation successfully created at\nC:\\Users\\Public\\" + GetMonth(DateTime.Today.Month + 1) + "AllProductsSalesEstimation.txt";
        }

        private void PredictedSales_Shown(object sender, EventArgs e)
        {
        }

        private void singleProduct_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            errorLabel.Text = "";
            errorLabel2.Text = "";
            csvLabel.Text = "";
            selectItemLabel.Visible = true;
            singleItemPick.Visible = true;
            singleItemPick.Enabled = true;
            produceSinglePrediction.Visible = true;
            produceSinglePrediction.Enabled = false;
            estListView.Enabled = true;
            predictions.Visible = false;
            produceAllPredictions.Visible = false;
            produceAllPredictions.Enabled = false;
            estListViewAll.Visible = false;
            estListViewAll.Enabled = false;
        }

        private void singleItemPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "ProductName = '" + singleItemPick.SelectedItem.ToString() + "'";
            dataGridView1.DataSource = dv;
            produceSinglePrediction.Enabled = true;
        }

        private void produceSinglePrediction_Click(object sender, EventArgs e)
        {
            if (singleItemPick.SelectedItem != null)
            {
                messageLabel.Text = "";
                errorLabel.Text = "";
                estListView.Visible = true;
                estListView.Clear();
                estListView.Columns.Add("Product Name", 80);
                estListView.Columns.Add(GetMonth(DateTime.Today.Month - 1) + "'s Sales", 100);
                estListView.Columns.Add(GetMonth(DateTime.Today.Month) + "'s Sales", 100);
                estListView.Columns.Add(GetMonth(DateTime.Today.Month + 1) + "'s Predicted Sales", 160);
                Predict(dataGridView1.Rows[0], "single");
            }
        }

        private void singleProduct_MouseDown(object sender, MouseEventArgs e)
        {
            singleProduct.Image = singleImages.Images[2];
        }

        private void singleProduct_MouseEnter(object sender, EventArgs e)
        {
            singleProduct.Image = singleImages.Images[1];
        }

        private void singleProduct_MouseLeave(object sender, EventArgs e)
        {
            singleProduct.Image = singleImages.Images[0];
        }

        private void singleProduct_MouseUp(object sender, MouseEventArgs e)
        {
            singleProduct.Image = singleImages.Images[0];
        }

        private void allProducts_MouseDown(object sender, MouseEventArgs e)
        {
            allProducts.Image = allImages.Images[2];
        }

        private void allProducts_MouseEnter(object sender, EventArgs e)
        {
            allProducts.Image = allImages.Images[1];
        }

        private void allProducts_MouseLeave(object sender, EventArgs e)
        {
            allProducts.Image = allImages.Images[0];
        }

        private void allProducts_MouseUp(object sender, MouseEventArgs e)
        {
            allProducts.Image = allImages.Images[0];
        }

        private void produceSinglePrediction_MouseDown(object sender, MouseEventArgs e)
        {
            produceSinglePrediction.Image = produceImages.Images[2];
        }

        private void produceSinglePrediction_MouseEnter(object sender, EventArgs e)
        {
            produceSinglePrediction.Image = produceImages.Images[1];
        }

        private void produceSinglePrediction_MouseLeave(object sender, EventArgs e)
        {
            produceSinglePrediction.Image = produceImages.Images[0];
        }

        private void produceSinglePrediction_MouseUp(object sender, MouseEventArgs e)
        {
            produceSinglePrediction.Image = produceImages.Images[0];
        }

        private void produceAllPredictions_MouseDown(object sender, MouseEventArgs e)
        {
            produceAllPredictions.Image = produceImages.Images[2];
        }

        private void produceAllPredictions_MouseEnter(object sender, EventArgs e)
        {
            produceAllPredictions.Image = produceImages.Images[1];
        }

        private void produceAllPredictions_MouseLeave(object sender, EventArgs e)
        {
            produceAllPredictions.Image = produceImages.Images[0];
        }

        private void produceAllPredictions_MouseUp(object sender, MouseEventArgs e)
        {
            produceAllPredictions.Image = produceImages.Images[0];
        }
    }
}
