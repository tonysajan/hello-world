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
    public partial class add_user : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
        private string sql1;
        private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();
        private SqlDataAdapter da4;
        private DataSet ds4 = null;
        private BindingSource dsource4 = new BindingSource();

        public add_user()
        {
            InitializeComponent();
        }

      
        private void Button1_Click(object sender, EventArgs e)
        {
            clear();
            ComboBox1.Enabled = true;
            Button2.Enabled = true;
            Button5.Enabled = false;
            Button6.Enabled = false;
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            ComboBox1.Enabled = true;
            ComboBox1.Focus();
        }
        public void clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            ComboBox1.SelectedIndex = 0;
            Label7.Text = "";
            Label6.Text = "";
            TextBox1.Focus();
        }


        private void savedata()
        {
            //On Error Resume Next
           if (string.IsNullOrEmpty(TextBox1.Text))
            {
                MessageBox.Show("Enter The User Name");
                TextBox1.Focus();
            }
            else if (string.IsNullOrEmpty(TextBox2.Text))
            {
                MessageBox.Show("Enter The Password");
                TextBox2.Focus();
            }
            else
            {
                string res = MessageBox.Show("Would You Like To Create User Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    SqlCommand cmd1 = new SqlCommand();
                    string Sql1 = null;
                    conn = new SqlConnection(ConnString);

                    Sql1 = "insert into tbl_user(usertype,username,password) values('" + ComboBox1.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "')";
                    
                    conn.Open();
                    Adapter.InsertCommand = new SqlCommand(Sql1, conn);
                    Adapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button2.Enabled = false;
                    TextBox1.Enabled = false;
                    TextBox2.Enabled = false;
                    ComboBox1.Enabled = false;
                    clear();
                    MessageBox.Show("User Record Created");
                }
                conn.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (check() == 1)
            {
                return;
            }
            savedata();
            Button5.Enabled = false;
            Button6.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnString);

            string res = MessageBox.Show("Would You Like To Delete User Record ?", "Save", MessageBoxButtons.YesNo).ToString();
            if (res == "Yes")
            {
                conn.Open();

                SqlDataAdapter Adapter2 = new SqlDataAdapter();
                SqlCommand cmd16 = new SqlCommand();
                string Sql16 = null;

                Sql16 = "delete from tbl_user where slno='" + Label7.Text + "'";

                Adapter2.UpdateCommand = new SqlCommand(Sql16, conn);
                Adapter2.UpdateCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("User Details Deleted");
                clear();
                Button5.Enabled = false;
                Button6.Enabled = false;
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                ComboBox1.Enabled = true;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnString);

            string res = MessageBox.Show("Would You Like To Update User Record ?", "Save", MessageBoxButtons.YesNo).ToString();
            if (res == "Yes")
            {
                conn.Open();
                SqlDataAdapter Adapter1 = new SqlDataAdapter();
                SqlCommand cmd15 = new SqlCommand();
                string Sql15 = null;
                Sql15 = "update tbl_user set usertype='" + ComboBox1.Text + "',username='" + TextBox1.Text + "',password='" + TextBox2.Text + "'  where slno=" + Label7.Text;
                Adapter1.UpdateCommand = new SqlCommand(Sql15, conn);
                Adapter1.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("User Details Modified");
                clear();
                Button5.Enabled = false;
                Button6.Enabled = false;
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                ComboBox1.Enabled = false;
            }
            conn.Close();
        }


        public int check()
        {
            int fg = 0;
            conn = new SqlConnection(ConnString);
            sql1 = "SELECT username from tbl_user where username='" + TextBox1.Text.Replace("'", "''").Trim() + "' and usertype='" + ComboBox1.Text + "'";
            da4 = new SqlDataAdapter(sql1, conn);
            conn.Open();
            ds4 = new DataSet();

            SqlCommandBuilder commandBuilder3 = new SqlCommandBuilder(da4);

            da4.Fill(ds4, "tbl_user");

            dsource4.DataSource = ds4.Tables["tbl_user"];
            //MsgBox(dsource2.Count())

            if (dsource4.Count  > 0)
            {
                //Dim res As String
                fg = 1;
                MessageBox.Show("This User Name already Exist");
                clear();
            }
            conn.Close();
            return fg;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            user_list vs = new user_list();
            vs.Show();
        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }

      

    }
}
