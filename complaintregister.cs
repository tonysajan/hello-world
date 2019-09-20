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
    public partial class complaintregister : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
        private string sql1;
        private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();
        private BindingSource dsource4 = new BindingSource();

        public complaintregister()
        {
            InitializeComponent();
        }

        private void complaintregister_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            view_complaint vs = new view_complaint(0);
            vs.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            clear();
            Button2.Enabled = true;
            Button5.Enabled = false;
            Button6.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            textBox1.Text = GetID().ToString();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox1.Focus();
        }

        private void savedata()
        {
         
            string comb = dpdob.Value.Date.ToString("dd-MMM-yyyy");
           
            //On Error Resume Next
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please check Complaint ID");
                textBox1.Focus();
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter Complaint Matter");
                textBox2.Focus();
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Enter Complaint Type");
                textBox3.Focus();
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter Complaint Given By Name");
                textBox4.Focus();
            }
            else if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Enter Complaint Given On Name");
                textBox8.Focus();
            }
            else
            {
                string res = MessageBox.Show("Would You Like To Create Complaint Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    SqlCommand cmd1 = new SqlCommand();
                    string Sql1 = null;
                    conn = new SqlConnection(ConnString);

                    Sql1 = "insert into tbl_complaintdetails(comid,comdate,commatter,comtype,cbyname,cbyage,cbygender,cbypno,cbyaddress,conname,conage,congender,conpno,conaddress) values(" + int.Parse(textBox1.Text) + ",'" + comb + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + comboBox2.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";

                    conn.Open();
                    Adapter.InsertCommand = new SqlCommand(Sql1, conn);
                    Adapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button2.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    clear();
                    MessageBox.Show("Complaint Record Created");
                }
                conn.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            savedata();
            Button5.Enabled = false;
            Button6.Enabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnString);

            string res = MessageBox.Show("Would You Like To Delete Complaint Record ?", "Save", MessageBoxButtons.YesNo).ToString();
            if (res == "Yes")
            {
                conn.Open();

                SqlDataAdapter Adapter2 = new SqlDataAdapter();
                SqlCommand cmd16 = new SqlCommand();
                string Sql16 = null;

                Sql16 = "delete from tbl_complaintdetails where slno='" + label7.Text + "'";

                Adapter2.UpdateCommand = new SqlCommand(Sql16, conn);
                Adapter2.UpdateCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Complaint Record Deleted");
                clear();
                Button5.Enabled = false;
                Button6.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }

        public int GetID()
        {
            int fg = 0;
            int cid =0;
            conn = new SqlConnection(ConnString);
            sql1 = "SELECT max(comid) from tbl_complaintdetails";
           
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rs;

            cmd.CommandText = sql1;
            cmd.Connection = conn;
            rs = cmd.ExecuteReader();

            if (rs.Read())
            {
                
                 if (rs[0].ToString() == "")
                {
                    cid = 1;
                }
                else
                {
                    cid = int.Parse(rs[0].ToString());
                    cid++;
                }
            }
            conn.Close();
            return cid;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnString);

            string comb = dpdob.Value.Date.ToString("dd-MMM-yyyy");

            //On Error Resume Next
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please check Complaint ID");
                textBox1.Focus();
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter Complaint Matter");
                textBox2.Focus();
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Enter Complaint Type");
                textBox3.Focus();
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter Complaint Given By Name");
                textBox4.Focus();
            }
            else if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Enter Complaint Given On Name");
                textBox8.Focus();
            }
            else
            {
                string res = MessageBox.Show("Would You Like To Update Complaint Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    conn.Open();
                    SqlDataAdapter Adapter1 = new SqlDataAdapter();
                    SqlCommand cmd15 = new SqlCommand();
                    string Sql15 = null;
                    Sql15 = "update tbl_complaintdetails set comdate='" + comb + "',commatter='" + textBox2.Text + "',comtype='" + textBox3.Text + "',cbyname='" + textBox4.Text + "',cbyage='" + textBox5.Text + "',cbygender='" + comboBox1.Text + "',cbypno='" + textBox6.Text + "',cbyaddress='" + textBox7.Text + "',conname='" + textBox8.Text + "',conage='" + textBox9.Text + "',congender='" + comboBox2.Text + "',conpno='" + textBox10.Text + "',conaddress='" + textBox11.Text + "' where slno=" + label7.Text;
                    Adapter1.UpdateCommand = new SqlCommand(Sql15, conn);
                    Adapter1.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Complaint Details Modified");
                    clear();
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
                conn.Close();
            }
        }
    }
}
