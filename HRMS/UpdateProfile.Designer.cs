namespace HRMS
{
    partial class UpdateProfile
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
            this.pnlTopHr = new System.Windows.Forms.Panel();
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.richTxtadd = new System.Windows.Forms.RichTextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtJobtitle = new System.Windows.Forms.TextBox();
            this.lblJobtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlTopHr.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(455, 392);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(82, 26);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pnlTopHr
            // 
            this.pnlTopHr.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTopHr.Controls.Add(this.topHeaderLogin);
            this.pnlTopHr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHr.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHr.Name = "pnlTopHr";
            this.pnlTopHr.Size = new System.Drawing.Size(1017, 60);
            this.pnlTopHr.TabIndex = 10;
            // 
            // topHeaderLogin
            // 
            this.topHeaderLogin.AutoSize = true;
            this.topHeaderLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHeaderLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topHeaderLogin.Location = new System.Drawing.Point(228, 9);
            this.topHeaderLogin.Name = "topHeaderLogin";
            this.topHeaderLogin.Size = new System.Drawing.Size(341, 38);
            this.topHeaderLogin.TabIndex = 0;
            this.topHeaderLogin.Text = "HR Management System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePickerDOB);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.richTxtadd);
            this.panel2.Controls.Add(this.txtdepartment);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Controls.Add(this.txtJobtitle);
            this.panel2.Controls.Add(this.lblJobtitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblDob);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Location = new System.Drawing.Point(107, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 444);
            this.panel2.TabIndex = 20;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(498, 86);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(251, 22);
            this.dateTimePickerDOB.TabIndex = 49;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(237, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 26);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // richTxtadd
            // 
            this.richTxtadd.Location = new System.Drawing.Point(498, 160);
            this.richTxtadd.Name = "richTxtadd";
            this.richTxtadd.Size = new System.Drawing.Size(216, 101);
            this.richTxtadd.TabIndex = 47;
            this.richTxtadd.Text = "";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(498, 54);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(251, 22);
            this.txtdepartment.TabIndex = 46;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(399, 54);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(102, 20);
            this.lblDepartment.TabIndex = 45;
            this.lblDepartment.Text = "Department: ";
            // 
            // txtJobtitle
            // 
            this.txtJobtitle.Location = new System.Drawing.Point(498, 115);
            this.txtJobtitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobtitle.Name = "txtJobtitle";
            this.txtJobtitle.Size = new System.Drawing.Size(251, 22);
            this.txtJobtitle.TabIndex = 44;
            // 
            // lblJobtitle
            // 
            this.lblJobtitle.AutoSize = true;
            this.lblJobtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobtitle.Location = new System.Drawing.Point(424, 118);
            this.lblJobtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobtitle.Name = "lblJobtitle";
            this.lblJobtitle.Size = new System.Drawing.Size(77, 20);
            this.lblJobtitle.TabIndex = 43;
            this.lblJobtitle.Text = "Job Title: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Employee Details";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(451, 86);
            this.lblDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(50, 20);
            this.lblDob.TabIndex = 39;
            this.lblDob.Text = "Dob : ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(423, 151);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 38;
            this.lblAddress.Text = "Address : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 174);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 22);
            this.txtPhone.TabIndex = 37;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(55, 174);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 20);
            this.lblPhone.TabIndex = 36;
            this.lblPhone.Text = "Phone : ";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(139, 209);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(216, 22);
            this.txtGender.TabIndex = 35;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 140);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 22);
            this.txtName.TabIndex = 33;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(216, 22);
            this.txtId.TabIndex = 32;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(48, 209);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(72, 20);
            this.lblGender.TabIndex = 31;
            this.lblGender.Text = "Gender : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(61, 140);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 20);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 107);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(83, 54);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 20);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "ID : ";
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTopHr);
            this.Name = "UpdateProfile";
            this.Text = "UpdateProfile";
            this.Load += new System.EventHandler(this.UpdateProfile_Load);
            this.pnlTopHr.ResumeLayout(false);
            this.pnlTopHr.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlTopHr;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox richTxtadd;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtJobtitle;
        private System.Windows.Forms.Label lblJobtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
    }
}