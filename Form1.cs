using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crime_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addemployee frm = new addemployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_employee frm = new view_employee(1);
            frm.MdiParent = this;
            frm.Text = "View Employee";
            frm.Show();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            complaintregister frm = new complaintregister();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_complaint frm = new view_complaint(1);
            frm.MdiParent = this;
            frm.Text = "View Complaint";
            frm.Show();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FIRregister frm = new FIRregister();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            view_fir frm = new view_fir(1);
            frm.MdiParent = this;
            frm.Text = "View FIR Details";
            frm.Show();
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            chargesheet frm = new chargesheet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewRecordToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            view_chargesheet frm = new view_chargesheet(1);
            frm.MdiParent = this;
            frm.Text = "View Charge Sheet Details";
            frm.Show();
        }

        private void addNewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            judgementdetails frm = new judgementdetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewRecordToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            view_judgement frm = new view_judgement(1);
            frm.MdiParent = this;
            frm.Text = "View Judgement Details";
            frm.Show();
        }

        private void addNewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            criminaldetails frm = new criminaldetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewRecordToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            view_criminal frm = new view_criminal(1);
            frm.MdiParent = this;
            frm.Text = "View Criminal Details";
            frm.Show();
        }

        private void addNewToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            prisonerdetails frm = new prisonerdetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewRecordToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            view_prisoner frm = new view_prisoner(1);
            frm.MdiParent = this;
            frm.Text = "View Prisoner Details";
            frm.Show();
        }
    }
}
