using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Crime_Info
{
    public partial class login : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
        private string sql1;
        private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();
        private SqlDataAdapter da4;
        private DataSet ds4 = null;
        private BindingSource dsource4 = new BindingSource();

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            ComboBox1.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Enter User Name");
                TextBox1.Focus();
                return;
            }
            if (TextBox2.Text == "")
            {
                MessageBox.Show("Enter Password");
                TextBox2.Focus();
                return;
            }

            conn = new SqlConnection(ConnString);
            sql1 = "SELECT * from tbl_user where username='" + TextBox1.Text.Replace("'", "''").Trim() + "' and usertype='" + ComboBox1.Text + "' and password='" + TextBox2.Text.Trim() + "'";

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rs;
            cmd.CommandText = sql1;
            cmd.Connection = conn;
            rs = cmd.ExecuteReader();

            if (rs.Read())
            {
                if (rs["usertype"].ToString() == "STAFF")
                {
                    rs.Close();
                    Form1 frm = new Form1();
                    frm.administratorToolStripMenuItem.Enabled = false;
                    frm.employeeToolStripMenuItem.Enabled = false;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    rs.Close();
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                rs.Close();
                MessageBox.Show("Invalid User Name Or Password");
                TextBox1.Focus();
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
