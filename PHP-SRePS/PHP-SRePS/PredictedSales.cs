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

namespace PHP_SRePS
{
    public partial class PredictedSales : Form
    {
        public PredictedSales()
        {
            InitializeComponent();
            PredictSales();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PredictSales()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True";

            string scmd = "SELECT * FROM(SELECT TOP 2147483647 YEAR(SaleDate)[Year], ProductName, DATENAME(MONTH, SaleDate)[Month], SUM(Quantity)[Quantity] FROM dbo.SaleRecords JOIN dbo.Products ON Products.ProductID = SaleRecords.ProductID GROUP BY YEAR(SaleDate), ProductName, DATENAME(MONTH, SaleDate) ORDER BY YEAR(SaleDate)) AS MontlySalesData PIVOT(SUM([Quantity]) FOR Month IN([January],[February],[March],[April],[May],[June],[July],[August],[September],[October],[November],[December])) AS MNamePivot";

            SqlDataAdapter sda = new SqlDataAdapter(scmd, con);
            con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            predictions.DataSource = ds.Tables[0];

            //predections.Rows.Add("product", "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec", "year");
            con.Close();
        }
    }
}
