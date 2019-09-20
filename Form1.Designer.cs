namespace Crime_Info
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crimeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chargeSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.judgementDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.criminalRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.crimeManagementToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "&Administrator";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserToolStripMenuItem.Text = "&Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem1,
            this.viewEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "&Employee";
            // 
            // createUserToolStripMenuItem1
            // 
            this.createUserToolStripMenuItem1.Name = "createUserToolStripMenuItem1";
            this.createUserToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.createUserToolStripMenuItem1.Text = "&Create Employee";
            this.createUserToolStripMenuItem1.Click += new System.EventHandler(this.createUserToolStripMenuItem1_Click);
            // 
            // viewEmployeeToolStripMenuItem
            // 
            this.viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            this.viewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewEmployeeToolStripMenuItem.Text = "&View Employee";
            this.viewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeToolStripMenuItem_Click);
            // 
            // crimeManagementToolStripMenuItem
            // 
            this.crimeManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.complaintRegisterToolStripMenuItem,
            this.fIRToolStripMenuItem,
            this.chargeSheetToolStripMenuItem,
            this.judgementDetailsToolStripMenuItem,
            this.criminalRegistrationToolStripMenuItem,
            this.prisonerRegistrationToolStripMenuItem});
            this.crimeManagementToolStripMenuItem.Name = "crimeManagementToolStripMenuItem";
            this.crimeManagementToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.crimeManagementToolStripMenuItem.Text = "&Crime Management";
            // 
            // complaintRegisterToolStripMenuItem
            // 
            this.complaintRegisterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.viewRecordToolStripMenuItem});
            this.complaintRegisterToolStripMenuItem.Name = "complaintRegisterToolStripMenuItem";
            this.complaintRegisterToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.complaintRegisterToolStripMenuItem.Text = "Complaint Register";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // viewRecordToolStripMenuItem
            // 
            this.viewRecordToolStripMenuItem.Name = "viewRecordToolStripMenuItem";
            this.viewRecordToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.viewRecordToolStripMenuItem.Text = "View Record";
            this.viewRecordToolStripMenuItem.Click += new System.EventHandler(this.viewRecordToolStripMenuItem_Click);
            // 
            // fIRToolStripMenuItem
            // 
            this.fIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.viewRecordToolStripMenuItem1});
            this.fIRToolStripMenuItem.Name = "fIRToolStripMenuItem";
            this.fIRToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fIRToolStripMenuItem.Text = "FIR";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.addNewToolStripMenuItem1.Text = "Add New";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // viewRecordToolStripMenuItem1
            // 
            this.viewRecordToolStripMenuItem1.Name = "viewRecordToolStripMenuItem1";
            this.viewRecordToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.viewRecordToolStripMenuItem1.Text = "View Record";
            this.viewRecordToolStripMenuItem1.Click += new System.EventHandler(this.viewRecordToolStripMenuItem1_Click);
            // 
            // chargeSheetToolStripMenuItem
            // 
            this.chargeSheetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem2,
            this.viewRecordToolStripMenuItem2});
            this.chargeSheetToolStripMenuItem.Name = "chargeSheetToolStripMenuItem";
            this.chargeSheetToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.chargeSheetToolStripMenuItem.Text = "Charge Sheet";
            // 
            // addNewToolStripMenuItem2
            // 
            this.addNewToolStripMenuItem2.Name = "addNewToolStripMenuItem2";
            this.addNewToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.addNewToolStripMenuItem2.Text = "Add New";
            this.addNewToolStripMenuItem2.Click += new System.EventHandler(this.addNewToolStripMenuItem2_Click);
            // 
            // viewRecordToolStripMenuItem2
            // 
            this.viewRecordToolStripMenuItem2.Name = "viewRecordToolStripMenuItem2";
            this.viewRecordToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.viewRecordToolStripMenuItem2.Text = "View Record";
            this.viewRecordToolStripMenuItem2.Click += new System.EventHandler(this.viewRecordToolStripMenuItem2_Click);
            // 
            // judgementDetailsToolStripMenuItem
            // 
            this.judgementDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem3,
            this.viewRecordToolStripMenuItem3});
            this.judgementDetailsToolStripMenuItem.Name = "judgementDetailsToolStripMenuItem";
            this.judgementDetailsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.judgementDetailsToolStripMenuItem.Text = "Judgement Details";
            // 
            // addNewToolStripMenuItem3
            // 
            this.addNewToolStripMenuItem3.Name = "addNewToolStripMenuItem3";
            this.addNewToolStripMenuItem3.Size = new System.Drawing.Size(139, 22);
            this.addNewToolStripMenuItem3.Text = "Add New";
            this.addNewToolStripMenuItem3.Click += new System.EventHandler(this.addNewToolStripMenuItem3_Click);
            // 
            // viewRecordToolStripMenuItem3
            // 
            this.viewRecordToolStripMenuItem3.Name = "viewRecordToolStripMenuItem3";
            this.viewRecordToolStripMenuItem3.Size = new System.Drawing.Size(139, 22);
            this.viewRecordToolStripMenuItem3.Text = "View Record";
            this.viewRecordToolStripMenuItem3.Click += new System.EventHandler(this.viewRecordToolStripMenuItem3_Click);
            // 
            // criminalRegistrationToolStripMenuItem
            // 
            this.criminalRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem4,
            this.viewRecordToolStripMenuItem4});
            this.criminalRegistrationToolStripMenuItem.Name = "criminalRegistrationToolStripMenuItem";
            this.criminalRegistrationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.criminalRegistrationToolStripMenuItem.Text = "Criminal Registration";
            // 
            // addNewToolStripMenuItem4
            // 
            this.addNewToolStripMenuItem4.Name = "addNewToolStripMenuItem4";
            this.addNewToolStripMenuItem4.Size = new System.Drawing.Size(139, 22);
            this.addNewToolStripMenuItem4.Text = "Add New";
            this.addNewToolStripMenuItem4.Click += new System.EventHandler(this.addNewToolStripMenuItem4_Click);
            // 
            // viewRecordToolStripMenuItem4
            // 
            this.viewRecordToolStripMenuItem4.Name = "viewRecordToolStripMenuItem4";
            this.viewRecordToolStripMenuItem4.Size = new System.Drawing.Size(139, 22);
            this.viewRecordToolStripMenuItem4.Text = "View Record";
            this.viewRecordToolStripMenuItem4.Click += new System.EventHandler(this.viewRecordToolStripMenuItem4_Click);
            // 
            // prisonerRegistrationToolStripMenuItem
            // 
            this.prisonerRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem5,
            this.viewRecordToolStripMenuItem5});
            this.prisonerRegistrationToolStripMenuItem.Name = "prisonerRegistrationToolStripMenuItem";
            this.prisonerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.prisonerRegistrationToolStripMenuItem.Text = "Prisoner Registration";
            // 
            // addNewToolStripMenuItem5
            // 
            this.addNewToolStripMenuItem5.Name = "addNewToolStripMenuItem5";
            this.addNewToolStripMenuItem5.Size = new System.Drawing.Size(139, 22);
            this.addNewToolStripMenuItem5.Text = "Add New";
            this.addNewToolStripMenuItem5.Click += new System.EventHandler(this.addNewToolStripMenuItem5_Click);
            // 
            // viewRecordToolStripMenuItem5
            // 
            this.viewRecordToolStripMenuItem5.Name = "viewRecordToolStripMenuItem5";
            this.viewRecordToolStripMenuItem5.Size = new System.Drawing.Size(139, 22);
            this.viewRecordToolStripMenuItem5.Text = "View Record";
            this.viewRecordToolStripMenuItem5.Click += new System.EventHandler(this.viewRecordToolStripMenuItem5_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 475);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Crime Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crimeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chargeSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem judgementDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem criminalRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem prisonerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
    }
}

