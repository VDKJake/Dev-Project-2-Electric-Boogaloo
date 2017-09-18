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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void login_Click(object sender, EventArgs e)
        {
            //Connect to the database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PHP-SRePS.mdf;Integrated Security=True");

            //Set SQL query to check if there is an data entry matching the provided username and password (case sensitive)
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE UserID='" + username.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND  Password='" + password.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS;", con);

            //Create an empty virtual data table
            DataTable dt = new DataTable();
            //Fill virtual dt with results from the above query
            sda.Fill(dt);
            //Check if there is a matching entry in the dt and take according actions
            if (dt.Rows[0][0].ToString() == "1")
            {
                Menu menu = new Menu();
                menu.User = username.Text;
                menu.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                this.Hide();
                menu.Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            username.Text = null;
            password.Text = null;
        }
    }
}
