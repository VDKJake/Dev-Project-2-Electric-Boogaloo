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

            string scmd = "SELECT ProductID, Quantity, SaleDate FROM SaleRecords";
            SqlDataAdapter sda = new SqlDataAdapter(scmd, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

        }
    }
}
