namespace Crime_Info
{
    partial class user_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView3
            // 
            this.DataGridView3.AllowUserToAddRows = false;
            this.DataGridView3.AllowUserToResizeColumns = false;
            this.DataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView3.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView3.GridColor = System.Drawing.Color.White;
            this.DataGridView3.Location = new System.Drawing.Point(4, 10);
            this.DataGridView3.Name = "DataGridView3";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView3.RowHeadersVisible = false;
            this.DataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView3.Size = new System.Drawing.Size(511, 418);
            this.DataGridView3.TabIndex = 280;
            this.DataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.DataGridView3);
            this.GroupBox4.Location = new System.Drawing.Point(4, 0);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(521, 431);
            this.GroupBox4.TabIndex = 276;
            this.GroupBox4.TabStop = false;
            // 
            // user_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 440);
            this.Controls.Add(this.GroupBox4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search User";
            this.Load += new System.EventHandler(this.user_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView3;
        internal System.Windows.Forms.GroupBox GroupBox4;
    }
}