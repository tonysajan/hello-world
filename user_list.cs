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
    public partial class user_list : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
       private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();
        private SqlDataAdapter da2;
        private DataSet ds2 = null;
        private BindingSource dsource2 = new BindingSource();
 
        private BindingSource dsource3 = new BindingSource();

        private BindingSource dsource4 = new BindingSource();

        public user_list()
        {
            InitializeComponent();
        }

        private void user_list_Load(object sender, EventArgs e)
        {
            dytm();
        }

        private void dytm()
        {
            //On Error Resume Next
            conn = new SqlConnection(ConnString);
            string Sql = "SELECT slno,usertype as 'User Type',username as 'User Name',password as 'Password' from tbl_user order by username";
            da2 = new SqlDataAdapter(Sql, conn);
            conn.Open();
            ds2 = new DataSet();
            SqlCommandBuilder commandBuilder1 = new SqlCommandBuilder(da2);
            da2.Fill(ds2, "Pub");
            dsource2.DataSource = ds2.Tables["Pub"];
            conn.Close();
            DataGridView3.DataSource = dsource2;
            DataGridView3.Refresh();
            DataGridView3.Columns[0].Visible = false;
            DataGridView3.Columns[1].Width = 150;
            DataGridView3.Columns[2].Width = 150;
            DataGridView3.Columns[3].Width = 100;

        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_user r = null;

            foreach (Form f in Application.OpenForms)
            {
                if (f is add_user)
                {
                    r = (add_user)f;
                    break;
                }
            }

            if (r == null) return;

            DataGridViewRow row = DataGridView3.Rows[e.RowIndex];
            
            r.Label7.Text = row.Cells[0].Value.ToString();
            r.ComboBox1.Text = row.Cells[1].Value.ToString();
            r.TextBox1.Text = row.Cells[2].Value.ToString();
            r.TextBox2.Text = row.Cells[3].Value.ToString();
           
            r.TextBox1.Enabled = true;
            r.TextBox2.Enabled = true;
            r.ComboBox1.Enabled = true;
            r.Button5.Enabled = true;
            r.Button6.Enabled = true;
            r.Button2.Enabled = false;
            this.Dispose();
        }
    }
}
