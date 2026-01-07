namespace HRMS
{
    partial class salaryManagement
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
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblempid = new System.Windows.Forms.Label();
            this.lblbasicsalary = new System.Windows.Forms.Label();
            this.lblbonus = new System.Windows.Forms.Label();
            this.lblpaydate = new System.Windows.Forms.Label();
            this.lbldeduction = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.dtppaydate = new System.Windows.Forms.DateTimePicker();
            this.txtbasicsalary = new System.Windows.Forms.TextBox();
            this.txtbonus = new System.Windows.Forms.TextBox();
            this.txtdeduction = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(482, 838);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(197, 41);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 75);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "HR Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 263);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(219, 430);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(151, 29);
            this.lblempid.TabIndex = 14;
            this.lblempid.Text = "Employee ID";
            // 
            // lblbasicsalary
            // 
            this.lblbasicsalary.AutoSize = true;
            this.lblbasicsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbasicsalary.Location = new System.Drawing.Point(219, 500);
            this.lblbasicsalary.Name = "lblbasicsalary";
            this.lblbasicsalary.Size = new System.Drawing.Size(145, 29);
            this.lblbasicsalary.TabIndex = 15;
            this.lblbasicsalary.Text = "Basic Salary";
            // 
            // lblbonus
            // 
            this.lblbonus.AutoSize = true;
            this.lblbonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbonus.Location = new System.Drawing.Point(219, 584);
            this.lblbonus.Name = "lblbonus";
            this.lblbonus.Size = new System.Drawing.Size(81, 29);
            this.lblbonus.TabIndex = 16;
            this.lblbonus.Text = "Bonus";
            // 
            // lblpaydate
            // 
            this.lblpaydate.AutoSize = true;
            this.lblpaydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaydate.Location = new System.Drawing.Point(219, 736);
            this.lblpaydate.Name = "lblpaydate";
            this.lblpaydate.Size = new System.Drawing.Size(109, 29);
            this.lblpaydate.TabIndex = 17;
            this.lblpaydate.Text = "Pay Date";
            // 
            // lbldeduction
            // 
            this.lbldeduction.AutoSize = true;
            this.lbldeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeduction.Location = new System.Drawing.Point(219, 657);
            this.lbldeduction.Name = "lbldeduction";
            this.lbldeduction.Size = new System.Drawing.Size(122, 29);
            this.lbldeduction.TabIndex = 18;
            this.lbldeduction.Text = "Deduction";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(473, 430);
            this.txtempid.Multiline = true;
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(206, 39);
            this.txtempid.TabIndex = 19;
            // 
            // dtppaydate
            // 
            this.dtppaydate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtppaydate.Location = new System.Drawing.Point(473, 739);
            this.dtppaydate.Name = "dtppaydate";
            this.dtppaydate.Size = new System.Drawing.Size(298, 26);
            this.dtppaydate.TabIndex = 20;
            // 
            // txtbasicsalary
            // 
            this.txtbasicsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbasicsalary.Location = new System.Drawing.Point(473, 497);
            this.txtbasicsalary.Multiline = true;
            this.txtbasicsalary.Name = "txtbasicsalary";
            this.txtbasicsalary.Size = new System.Drawing.Size(206, 39);
            this.txtbasicsalary.TabIndex = 21;
            // 
            // txtbonus
            // 
            this.txtbonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbonus.Location = new System.Drawing.Point(473, 581);
            this.txtbonus.Multiline = true;
            this.txtbonus.Name = "txtbonus";
            this.txtbonus.Size = new System.Drawing.Size(206, 39);
            this.txtbonus.TabIndex = 22;
            // 
            // txtdeduction
            // 
            this.txtdeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeduction.Location = new System.Drawing.Point(473, 654);
            this.txtdeduction.Multiline = true;
            this.txtdeduction.Name = "txtdeduction";
            this.txtdeduction.Size = new System.Drawing.Size(206, 39);
            this.txtdeduction.TabIndex = 23;
            this.txtdeduction.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(12, 838);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(209, 41);
            this.btninsert.TabIndex = 24;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(726, 838);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(197, 41);
            this.btnshow.TabIndex = 25;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(951, 838);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(197, 41);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(242, 838);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(209, 41);
            this.btnupdate.TabIndex = 27;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // salaryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 910);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtdeduction);
            this.Controls.Add(this.txtbonus);
            this.Controls.Add(this.txtbasicsalary);
            this.Controls.Add(this.dtppaydate);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.lbldeduction);
            this.Controls.Add(this.lblpaydate);
            this.Controls.Add(this.lblbonus);
            this.Controls.Add(this.lblbasicsalary);
            this.Controls.Add(this.lblempid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnback);
            this.Name = "salaryManagement";
            this.Text = "Salary Management";
            this.Load += new System.EventHandler(this.salaryManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblbasicsalary;
        private System.Windows.Forms.Label lblbonus;
        private System.Windows.Forms.Label lblpaydate;
        private System.Windows.Forms.Label lbldeduction;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.DateTimePicker dtppaydate;
        private System.Windows.Forms.TextBox txtbasicsalary;
        private System.Windows.Forms.TextBox txtbonus;
        private System.Windows.Forms.TextBox txtdeduction;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
    }
}