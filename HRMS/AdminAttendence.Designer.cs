namespace HRMS
{
    partial class AdminAttendence
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
            this.topLoginPanel = new System.Windows.Forms.Panel();
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chbdept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.topLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnback.Location = new System.Drawing.Point(13, 206);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(122, 28);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // topLoginPanel
            // 
            this.topLoginPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topLoginPanel.Controls.Add(this.topHeaderLogin);
            this.topLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginPanel.Name = "topLoginPanel";
            this.topLoginPanel.Size = new System.Drawing.Size(703, 64);
            this.topLoginPanel.TabIndex = 12;
            // 
            // topHeaderLogin
            // 
            this.topHeaderLogin.AutoSize = true;
            this.topHeaderLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHeaderLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topHeaderLogin.Location = new System.Drawing.Point(237, 12);
            this.topHeaderLogin.Name = "topHeaderLogin";
            this.topHeaderLogin.Size = new System.Drawing.Size(268, 30);
            this.topHeaderLogin.TabIndex = 0;
            this.topHeaderLogin.Text = "HR Management System";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(434, 87);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 23);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(380, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date :";
            // 
            // chbdept
            // 
            this.chbdept.FormattingEnabled = true;
            this.chbdept.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee",
            "Accountant"});
            this.chbdept.Location = new System.Drawing.Point(165, 86);
            this.chbdept.Margin = new System.Windows.Forms.Padding(4);
            this.chbdept.Name = "chbdept";
            this.chbdept.Size = new System.Drawing.Size(160, 25);
            this.chbdept.TabIndex = 19;
            this.chbdept.SelectedIndexChanged += new System.EventHandler(this.chbdept_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(67, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Department :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Present});
            this.dataGridView1.Location = new System.Drawing.Point(13, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 251);
            this.dataGridView1.TabIndex = 21;
            // 
            // Present
            // 
            this.Present.HeaderText = "Present";
            this.Present.Name = "Present";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(165, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.Cyan;
            this.btnconfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnconfirm.Location = new System.Drawing.Point(434, 129);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(160, 36);
            this.btnconfirm.TabIndex = 23;
            this.btnconfirm.Text = "Save Attendence";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Orange;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsearch.Location = new System.Drawing.Point(434, 181);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(160, 39);
            this.btnsearch.TabIndex = 32;
            this.btnsearch.Text = "View Attendence";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // AdminAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 497);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbdept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.topLoginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminAttendence";
            this.Text = "AdminAttendence";
            this.topLoginPanel.ResumeLayout(false);
            this.topLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel topLoginPanel;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chbdept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Present;
    }
}