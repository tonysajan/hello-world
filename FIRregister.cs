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
    public partial class FIRregister : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
        private string sql1;
        private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();

        private BindingSource dsource4 = new BindingSource();

        public FIRregister()
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

            Load_Complaint_cmb();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void Load_Complaint_cmb()
        {
            conn = new SqlConnection(ConnString);
            string Sql = "SELECT slno,comid from tbl_complaintdetails order by comid";
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
            comboBox3.DataSource = dataTable;
            comboBox3.DisplayMember = "Values";
            comboBox3.ValueMember = "Keys";

            conn.Close();

            Load_Complaint();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            view_fir vs = new view_fir(0);
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
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox1.Focus();
        }

        private void savedata()
        {
         
            string comb = dpdob.Value.Date.ToString("dd-MMM-yyyy");
           
            //On Error Resume Next
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please check FIR ID");
               
            }
            else if (string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Select Complaint Number");
                comboBox3.Focus();
            }
            
            else
            {
                string res = MessageBox.Show("Would You Like To Register FIR Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter();
                    SqlCommand cmd1 = new SqlCommand();
                    string Sql1 = null;
                    conn = new SqlConnection(ConnString);

                    Sql1 = "insert into tbl_firdetails(firid,comid,remarks) values(" + int.Parse(textBox1.Text) + "," + int.Parse(comboBox3.Text) + ",'" + textBox12.Text + "')";

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
                    MessageBox.Show("FIR Record Created");
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

            string res = MessageBox.Show("Would You Like To Delete FIR Record ?", "Save", MessageBoxButtons.YesNo).ToString();
            if (res == "Yes")
            {
                conn.Open();

                SqlDataAdapter Adapter2 = new SqlDataAdapter();
                SqlCommand cmd16 = new SqlCommand();
                string Sql16 = null;

                Sql16 = "delete from tbl_firdetails where slno='" + label7.Text + "'";

                Adapter2.UpdateCommand = new SqlCommand(Sql16, conn);
                Adapter2.UpdateCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("FIR Record Deleted");
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
            sql1 = "SELECT max(firid) from tbl_firdetails";
           
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
                MessageBox.Show("Please check FIR ID");

            }
            else if (string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Select Complaint Number");
                comboBox3.Focus();
            }
            else
            {
                string res = MessageBox.Show("Would You Like To Update FIR Record ?", "Save", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    conn.Open();
                    SqlDataAdapter Adapter1 = new SqlDataAdapter();
                    SqlCommand cmd15 = new SqlCommand();
                    string Sql15 = null;
                    Sql15 = "update tbl_firdetails set comid='" + int.Parse(comboBox3.Text) + "',remarks='" + textBox12.Text + "' where slno=" + label7.Text;
                    Adapter1.UpdateCommand = new SqlCommand(Sql15, conn);
                    Adapter1.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("FIR Details Modified");
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Complaint();
        }

        public void Load_Complaint()
        {
            try
            {

                conn = new SqlConnection(ConnString);
                sql1 = "SELECT * from tbl_complaintdetails where comid='" + comboBox3.Text + "'";

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader rs;

                cmd.CommandText = sql1;
                cmd.Connection = conn;
                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    dpdob.Text = rs["comdate"].ToString();
                    textBox2.Text = rs["commatter"].ToString();
                    textBox3.Text = rs["comtype"].ToString();
                    textBox4.Text = rs["cbyname"].ToString();
                    textBox5.Text = rs["cbyage"].ToString();
                    comboBox1.Text = rs["cbygender"].ToString();
                    textBox6.Text = rs["cbypno"].ToString();
                    textBox7.Text = rs["cbyaddress"].ToString();
                    textBox8.Text = rs["conname"].ToString();
                    textBox9.Text = rs["conage"].ToString();
                    comboBox2.Text = rs["congender"].ToString();
                    textBox10.Text = rs["conpno"].ToString();
                    textBox11.Text = rs["conaddress"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            { }
        }
    }
}
