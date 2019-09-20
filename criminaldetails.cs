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
    public partial class criminaldetails : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
        private string sql1;
        private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();
        private SqlDataAdapter da4;
        private DataSet ds4 = null;
        private BindingSource dsource4 = new BindingSource();

        public criminaldetails()
        {
            InitializeComponent();
        }

       

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void Load_judgement_cmb()
        {
            conn = new SqlConnection(ConnString);
            string Sql = "SELECT slno,crid from tbl_judgmentdetails order by jdid";
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rs;

            dataTable.Columns.Add("Keys");
            dataTable.Columns.Add("Values");
            conn.Open();
            cmd.CommandText = Sql;
            cmd.Connection = conn;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                dataTable.Rows.Add(rs[0], rs[1]);
            }
            rs.Close();
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "Values";
            comboBox1.ValueMember = "Keys";

            conn.Close();

            Load_Complaint();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            view_criminal vs = new view_criminal(0);
            vs.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            clear();
            Button2.Enabled = true;
            Button5.Enabled = false;
            Button6.Enabled = false;
            groupBox1.Enabled = true;
           
            textBox1.Text = GetID().ToString();
            Load_Complaint();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text ="";
            textBox6.Text = "";

            textBox4.Focus();
        }

        private void savedata()
        {
         
            string comb = dpdob.Value.Date.ToString("dd-MMM-yyyy");
           
            //On Error Resume Next
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please check Criminal ID");
               
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Select Judgement Number");
                comboBox1.Focus();
            }
            
            else
            {
                string res = MessageBox.Show("Would You Like To Register Criminal Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    SqlCommand cmd1 = new SqlCommand();
                    string Sql1 = null;
                    conn = new SqlConnection(ConnString);

                    Sql1 = "insert into tbl_criminaldetails(ciid,jdid,firid,comid,sname,sgender,saddress,adate,occupation) values(" + int.Parse(textBox1.Text) + "," + int.Parse(comboBox1.Text) + "," + int.Parse(textBox2.Text) + ",'" + int.Parse(textBox3.Text) + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + comb + "','" + textBox6.Text + "')";

                    conn.Open();
                    Adapter.InsertCommand = new SqlCommand(Sql1, conn);
                    Adapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button2.Enabled = false;
                    groupBox1.Enabled = false;
              
                    clear();
                    MessageBox.Show("Criminal Record Created");
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

            string res = MessageBox.Show("Would You Like To Delete Criminal Record ?", "Save", MessageBoxButtons.YesNo).ToString();
            if (res == "Yes")
            {
                conn.Open();

                SqlDataAdapter Adapter2 = new SqlDataAdapter();
                SqlCommand cmd16 = new SqlCommand();
                string Sql16 = null;

                Sql16 = "delete from tbl_criminaldetails where slno='" + label7.Text + "'";

                Adapter2.UpdateCommand = new SqlCommand(Sql16, conn);
                Adapter2.UpdateCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Criminal Record Deleted");
                clear();
                Button5.Enabled = false;
                Button6.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        public int GetID()
        {
            int fg = 0;
            int cid =0;
            conn = new SqlConnection(ConnString);
            sql1 = "SELECT max(ciid) from tbl_criminaldetails";
           
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
            //conn = new SqlConnection(ConnString);

            //string comb = dpdob.Value.Date.ToString("dd-MMM-yyyy");

            ////On Error Resume Next
            //if (string.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("Please check Charge Sheet ID");

            //}
            //else if (string.IsNullOrEmpty(comboBox1.Text))
            //{
            //    MessageBox.Show("Select FIR Number");
            //    comboBox1.Focus();
            //}
            //else
            //{
            //    string res = MessageBox.Show("Would You Like To Update Charge Sheet Record ?", "Save", MessageBoxButtons.YesNo).ToString();
            //    if (res == "Yes")
            //    {
            //        conn.Open();
            //        SqlDataAdapter Adapter1 = new SqlDataAdapter();
            //        SqlCommand cmd15 = new SqlCommand();
            //        string Sql15 = null;
            //        Sql15 = "update tbl_ cha set comid='" + int.Parse(comboBox1.Text) + "',remarks='" + textBox12.Text + "' where slno=" + label7.Text;
            //        Adapter1.UpdateCommand = new SqlCommand(Sql15, conn);
            //        Adapter1.UpdateCommand.ExecuteNonQuery();
            //        MessageBox.Show("FIR Details Modified");
            //        clear();
            //        Button5.Enabled = false;
            //        Button6.Enabled = false;
            //        groupBox1.Enabled = false;
            //        groupBox2.Enabled = false;
            //        groupBox3.Enabled = false;
            //    }
            //    conn.Close();
            //}
        }

      

        public void Load_Complaint()
        {
            try
            {

                conn = new SqlConnection(ConnString);
                sql1 = "SELECT * from tbl_judgmentdetails where jdid='" + comboBox1.Text + "'";

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader rs;

                cmd.CommandText = sql1;
                cmd.Connection = conn;
                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    textBox2.Text = rs["firid"].ToString();
                    textBox3.Text = rs["comid"].ToString();
                    textBox4.Text = rs["sname"].ToString();
               }
                conn.Close();
            }
            catch (Exception ex)
            { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Complaint();
        }

        private void criminaldetails_Load(object sender, EventArgs e)
        {
           
            groupBox1.Enabled = false;
            Load_judgement_cmb();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

     
    }
}
