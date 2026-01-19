namespace HRMS
{
    partial class Profile
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTxtadd = new System.Windows.Forms.RichTextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtJobtitle = new System.Windows.Forms.TextBox();
            this.lblJobtitle = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.pnlTopHr.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnback.Location = new System.Drawing.Point(379, 292);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(84, 28);
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
            this.pnlTopHr.Size = new System.Drawing.Size(1006, 60);
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
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(83, 57);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 20);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "ID : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 110);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name : ";
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 57);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(216, 22);
            this.txtId.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 110);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 22);
            this.txtName.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 140);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 34;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(139, 209);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(216, 22);
            this.txtGender.TabIndex = 35;
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
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 174);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 22);
            this.txtPhone.TabIndex = 37;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Profile Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTxtadd);
            this.panel2.Controls.Add(this.txtdepartment);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Controls.Add(this.txtJobtitle);
            this.panel2.Controls.Add(this.lblJobtitle);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDob);
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
            this.panel2.Location = new System.Drawing.Point(106, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 444);
            this.panel2.TabIndex = 19;
           // this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // richTxtadd
            // 
            this.richTxtadd.Location = new System.Drawing.Point(498, 160);
            this.richTxtadd.Name = "richTxtadd";
            this.richTxtadd.Size = new System.Drawing.Size(216, 71);
            this.richTxtadd.TabIndex = 47;
            this.richTxtadd.Text = "";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(498, 52);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(216, 22);
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
            this.txtJobtitle.Location = new System.Drawing.Point(498, 116);
            this.txtJobtitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobtitle.Name = "txtJobtitle";
            this.txtJobtitle.Size = new System.Drawing.Size(216, 22);
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
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(498, 86);
            this.txtDob.Margin = new System.Windows.Forms.Padding(4);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(216, 22);
            this.txtDob.TabIndex = 41;
            //this.txtDob.TextChanged += new System.EventHandler(this.txtDob_TextChanged);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTopHr);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
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
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtJobtitle;
        private System.Windows.Forms.Label lblJobtitle;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.RichTextBox richTxtadd;
        private System.Windows.Forms.TextBox txtDob;
    }
}