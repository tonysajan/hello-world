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
    public partial class addemployee : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
        private string sql1;
        private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();
        private SqlDataAdapter da4;
        private DataSet ds4 = null;
        private BindingSource dsource4 = new BindingSource();

        public addemployee()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            view_employee vs = new view_employee(0);
            vs.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            clear();
            Button2.Enabled = true;
            Button5.Enabled = false;
            Button6.Enabled = false;
            groupBox1.Enabled = true;
        }

        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }

        private void savedata()
        {
            string gender = "";
            string dob  = dpdob.Value.Date.ToString("dd-MMM-yyyy");
            string doj = dpdoj.Value.Date.ToString("dd-MMM-yyyy");

            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }

            //On Error Resume Next
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter The Employee Name");
                textBox1.Focus();
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter Designation");
                textBox4.Focus();
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Enter Salary");
                textBox5.Focus();
            }
            else
            {
                string res = MessageBox.Show("Would You Like To Create Employee Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    SqlCommand cmd1 = new SqlCommand();
                    string Sql1 = null;
                    conn = new SqlConnection(ConnString);

                    Sql1 = "insert into tbl_employee(ename,gender,pno,dob,doj,address,designation,salary) values('" + textBox1.Text + "','" + gender + "','" + textBox2.Text + "','" + dob + "','" + doj + "','" + textBox3.Text + "','" + textBox4.Text + "'," + decimal.Parse(textBox5.Text) + ")";

                    conn.Open();
                    Adapter.InsertCommand = new SqlCommand(Sql1, conn);
                    Adapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button2.Enabled = false;
                    groupBox1.Enabled = false;
                    clear();
                    MessageBox.Show("Employee Record Created");
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

        private void Button6_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnString);

            string res = MessageBox.Show("Would You Like To Delete Employee Record ?", "Save", MessageBoxButtons.YesNo).ToString();
            if (res == "Yes")
            {
                conn.Open();

                SqlDataAdapter Adapter2 = new SqlDataAdapter();
                SqlCommand cmd16 = new SqlCommand();
                string Sql16 = null;

                Sql16 = "delete from tbl_employee where slno='" + label7.Text + "'";

                Adapter2.UpdateCommand = new SqlCommand(Sql16, conn);
                Adapter2.UpdateCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Employee Record Deleted");
                clear();
                Button5.Enabled = false;
                Button6.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnString);
            string gender = "";
            string dob  = dpdob.Value.Date.ToString("dd-MMM-yyyy");
            string doj = dpdoj.Value.Date.ToString("dd-MMM-yyyy");

            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }

            //On Error Resume Next
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter The Employee Name");
                textBox1.Focus();
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter Designation");
                textBox4.Focus();
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Enter Salary");
                textBox5.Focus();
            }
            else
            {

                string res = MessageBox.Show("Would You Like To Update Employee Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    conn.Open();
                    SqlDataAdapter Adapter1 = new SqlDataAdapter();
                    SqlCommand cmd15 = new SqlCommand();
                    string Sql15 = null;
                    Sql15 = "update tbl_employee set ename='" + textBox1.Text + "',gender='" + gender + "',pno='" + textBox2.Text + "',dob='" + dob + "',doj='" + doj + "',address='" + textBox3.Text + "',designation='" + textBox4.Text + "',salary=" + decimal.Parse(textBox5.Text) + "  where slno=" + label7.Text;
                    Adapter1.UpdateCommand = new SqlCommand(Sql15, conn);
                    Adapter1.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Modified");
                    clear();
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    groupBox1.Enabled = false;
                }
                conn.Close();
            }
        }

        public int check()
        {
            int fg = 0;
            conn = new SqlConnection(ConnString);
            sql1 = "SELECT ename from tbl_employee where ename='" + textBox1.Text.Replace("'", "''").Trim() + "'";
            da4 = new SqlDataAdapter(sql1, conn);
            conn.Open();
            ds4 = new DataSet();

            SqlCommandBuilder commandBuilder3 = new SqlCommandBuilder(da4);

            da4.Fill(ds4, "tbl_employee");

            dsource4.DataSource = ds4.Tables["tbl_employee"];
            //MsgBox(dsource2.Count())

            if (dsource4.Count > 0)
            {
                //Dim res As String
                fg = 1;
                MessageBox.Show("This Employee Name already Exist");
                clear();
            }
            conn.Close();
            return fg;
        }

        private void addemployee_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }
    }
}
