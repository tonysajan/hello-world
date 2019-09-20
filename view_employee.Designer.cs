namespace Crime_Info
{
    partial class view_employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 15);
            this.Label1.TabIndex = 291;
            this.Label1.Text = "Employee Name";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(117, 5);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(412, 20);
            this.TextBox1.TabIndex = 290;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // DataGridView3
            // 
            this.DataGridView3.AllowUserToAddRows = false;
            this.DataGridView3.AllowUserToResizeColumns = false;
            this.DataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView3.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView3.GridColor = System.Drawing.Color.White;
            this.DataGridView3.Location = new System.Drawing.Point(12, 32);
            this.DataGridView3.Name = "DataGridView3";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView3.RowHeadersVisible = false;
            this.DataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView3.Size = new System.Drawing.Size(851, 468);
            this.DataGridView3.TabIndex = 289;
            this.DataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
            // 
            // view_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 508);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.DataGridView3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "view_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.view_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.DataGridView DataGridView3;
    }
}