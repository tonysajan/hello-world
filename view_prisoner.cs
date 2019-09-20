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
    public partial class view_prisoner : Form
    {
        static string ConnString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private SqlConnection conn;
        int i;
        int p1;
        private string sql;
        private string sql1;
        private SqlDataAdapter da;
        private SqlDataAdapter da1;
        private DataSet ds = null;
        private DataSet ds1 = null;
        private BindingSource dsource = new BindingSource();
        private BindingSource dsource1 = new BindingSource();
        private SqlDataAdapter da2;
        private DataSet ds2 = null;
        private BindingSource dsource2 = new BindingSource();
        private SqlDataAdapter da3;
        private DataSet ds3 = null;
        private BindingSource dsource3 = new BindingSource();
        private SqlDataAdapter da4;
        private DataSet ds4 = null;
        private BindingSource dsource4 = new BindingSource();

        public view_prisoner(int p)
        {
            InitializeComponent();
            p1 = p;
        }

       

        private void dytm()
        {
            //On Error Resume Next
            conn = new SqlConnection(ConnString);
            string Sql = "SELECT slno,prid as 'Prisoner ID',ciid as 'Criminal ID',sname as 'Suspect Name',sgender as 'Gender',occupation as 'Occupation',pgiven as 'P Given',adate as 'Date',prno as 'Prisoner No.' from tbl_prisonerdetails";
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
            DataGridView3.Columns[4].Width = 100;
            DataGridView3.Columns[5].Width = 100;
            DataGridView3.Columns[6].Width = 100;
            DataGridView3.Columns[7].Width = 100;
            DataGridView3.Columns[8].Width = 100;
        }

        private void searc()
        {
            //On Error Resume Next
            conn = new SqlConnection(ConnString);
            string Sql = "SELECT slno,prid as 'Prisoner ID',ciid as 'Criminal ID',sname as 'Suspect Name',sgender as 'Gender',occupation as 'Occupation',pgiven as 'P Given',adate as 'Date',prno as 'Prisoner No.' from tbl_prisonerdetails where prid like '%" + TextBox1.Text + "%' order by prid";
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
            DataGridView3.Columns[4].Width = 100;
            DataGridView3.Columns[5].Width = 100;
            DataGridView3.Columns[6].Width = 100;
            DataGridView3.Columns[7].Width = 100;
            DataGridView3.Columns[8].Width = 100;
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (p1 == 0)
            {
                prisonerdetails r = null;

                foreach (Form f in Application.OpenForms)
                {
                    if (f is prisonerdetails)
                    {
                        r = (prisonerdetails)f;
                        break;
                    }
                }

                if (r == null) return;

                DataGridViewRow row = DataGridView3.Rows[e.RowIndex];

                
                r.label7.Text = row.Cells[0].Value.ToString();
                r.textBox1.Text = row.Cells[1].Value.ToString();
                r.comboBox1.Text = row.Cells[2].Value.ToString();
                
                r.textBox2.Text = row.Cells[3].Value.ToString();
                r.textBox3.Text = row.Cells[4].Value.ToString();
                r.textBox4.Text = row.Cells[5].Value.ToString();
                r.textBox5.Text = row.Cells[6].Value.ToString();
                r.dpdob.Text = row.Cells[7].Value.ToString();
                r.textBox6.Text = row.Cells[8].Value.ToString();

                r.groupBox1.Enabled = false;
       
                r.Button5.Enabled = true;
                r.Button6.Enabled = true;
                r.Button2.Enabled = false;

                this.Dispose();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                dytm();
            }
            else
            {
                searc();
            }

        }

        private void view_prisoner_Load(object sender, EventArgs e)
        {
            dytm();
        }

      
    }
}
