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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PHP_SRePSDataSet.SaleRecords' table. You can move, or remove it, as needed.
            this.saleRecordsTableAdapter.Fill(this._PHP_SRePSDataSet.SaleRecords);

        }
    }
}
