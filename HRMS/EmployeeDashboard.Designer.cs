namespace HRMS
{
    partial class EmployeeDashboard
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
            this.pnlTopHr = new System.Windows.Forms.Panel();
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btncomplainbox = new System.Windows.Forms.Button();
            this.btnnotice = new System.Windows.Forms.Button();
            this.btnpayslip = new System.Windows.Forms.Button();
            this.btnsalarydetails = new System.Windows.Forms.Button();
            this.btnleavestatus = new System.Windows.Forms.Button();
            this.btnapplyforleave = new System.Windows.Forms.Button();
            this.btnattendancerecord = new System.Windows.Forms.Button();
            this.btndeptjobrule = new System.Windows.Forms.Button();
            this.btnchangepass = new System.Windows.Forms.Button();
            this.btnupdateprofile = new System.Windows.Forms.Button();
            this.btnProfileDetails = new System.Windows.Forms.Button();
            this.pnlTopHr.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHr
            // 
            this.pnlTopHr.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTopHr.Controls.Add(this.topHeaderLogin);
            this.pnlTopHr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHr.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHr.Name = "pnlTopHr";
            this.pnlTopHr.Size = new System.Drawing.Size(885, 60);
            this.pnlTopHr.TabIndex = 9;
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
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Ivory;
            this.btnLogout.Location = new System.Drawing.Point(479, 484);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.Lavender;
            this.pnlSideBar.Controls.Add(this.btncomplainbox);
            this.pnlSideBar.Controls.Add(this.btnnotice);
            this.pnlSideBar.Controls.Add(this.btnpayslip);
            this.pnlSideBar.Controls.Add(this.btnsalarydetails);
            this.pnlSideBar.Controls.Add(this.btnleavestatus);
            this.pnlSideBar.Controls.Add(this.btnapplyforleave);
            this.pnlSideBar.Controls.Add(this.btnattendancerecord);
            this.pnlSideBar.Controls.Add(this.btndeptjobrule);
            this.pnlSideBar.Controls.Add(this.btnchangepass);
            this.pnlSideBar.Controls.Add(this.btnupdateprofile);
            this.pnlSideBar.Controls.Add(this.btnProfileDetails);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 60);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(215, 471);
            this.pnlSideBar.TabIndex = 10;
            // 
            // btncomplainbox
            // 
            this.btncomplainbox.BackColor = System.Drawing.Color.White;
            this.btncomplainbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncomplainbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomplainbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomplainbox.Location = new System.Drawing.Point(0, 390);
            this.btncomplainbox.Name = "btncomplainbox";
            this.btncomplainbox.Size = new System.Drawing.Size(215, 39);
            this.btncomplainbox.TabIndex = 10;
            this.btncomplainbox.Text = "Complain Box";
            this.btncomplainbox.UseVisualStyleBackColor = false;
            this.btncomplainbox.Click += new System.EventHandler(this.btncomplainbox_Click);
            // 
            // btnnotice
            // 
            this.btnnotice.BackColor = System.Drawing.Color.Lavender;
            this.btnnotice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotice.Location = new System.Drawing.Point(0, 351);
            this.btnnotice.Name = "btnnotice";
            this.btnnotice.Size = new System.Drawing.Size(215, 39);
            this.btnnotice.TabIndex = 9;
            this.btnnotice.Text = "Notice";
            this.btnnotice.UseVisualStyleBackColor = false;
            this.btnnotice.Click += new System.EventHandler(this.btnnotice_Click);
            // 
            // btnpayslip
            // 
            this.btnpayslip.BackColor = System.Drawing.Color.White;
            this.btnpayslip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpayslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayslip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayslip.Location = new System.Drawing.Point(0, 312);
            this.btnpayslip.Name = "btnpayslip";
            this.btnpayslip.Size = new System.Drawing.Size(215, 39);
            this.btnpayslip.TabIndex = 8;
            this.btnpayslip.Text = "Payslip";
            this.btnpayslip.UseVisualStyleBackColor = false;
            this.btnpayslip.Click += new System.EventHandler(this.btnpayslip_Click);
            // 
            // btnsalarydetails
            // 
            this.btnsalarydetails.BackColor = System.Drawing.Color.Lavender;
            this.btnsalarydetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsalarydetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalarydetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalarydetails.Location = new System.Drawing.Point(0, 273);
            this.btnsalarydetails.Name = "btnsalarydetails";
            this.btnsalarydetails.Size = new System.Drawing.Size(215, 39);
            this.btnsalarydetails.TabIndex = 7;
            this.btnsalarydetails.Text = "Salary Details";
            this.btnsalarydetails.UseVisualStyleBackColor = false;
            this.btnsalarydetails.Click += new System.EventHandler(this.btnsalarydetails_Click);
            // 
            // btnleavestatus
            // 
            this.btnleavestatus.BackColor = System.Drawing.Color.White;
            this.btnleavestatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnleavestatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleavestatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleavestatus.Location = new System.Drawing.Point(0, 234);
            this.btnleavestatus.Name = "btnleavestatus";
            this.btnleavestatus.Size = new System.Drawing.Size(215, 39);
            this.btnleavestatus.TabIndex = 6;
            this.btnleavestatus.Text = "Leave Status";
            this.btnleavestatus.UseVisualStyleBackColor = false;
            this.btnleavestatus.Click += new System.EventHandler(this.btnleavestatus_Click);
            // 
            // btnapplyforleave
            // 
            this.btnapplyforleave.BackColor = System.Drawing.Color.Lavender;
            this.btnapplyforleave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnapplyforleave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapplyforleave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapplyforleave.Location = new System.Drawing.Point(0, 195);
            this.btnapplyforleave.Name = "btnapplyforleave";
            this.btnapplyforleave.Size = new System.Drawing.Size(215, 39);
            this.btnapplyforleave.TabIndex = 5;
            this.btnapplyforleave.Text = "Apply for Leave";
            this.btnapplyforleave.UseVisualStyleBackColor = false;
            this.btnapplyforleave.Click += new System.EventHandler(this.btnapplyforleave_Click);
            // 
            // btnattendancerecord
            // 
            this.btnattendancerecord.BackColor = System.Drawing.Color.White;
            this.btnattendancerecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnattendancerecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnattendancerecord.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattendancerecord.Location = new System.Drawing.Point(0, 156);
            this.btnattendancerecord.Name = "btnattendancerecord";
            this.btnattendancerecord.Size = new System.Drawing.Size(215, 39);
            this.btnattendancerecord.TabIndex = 4;
            this.btnattendancerecord.Text = "Attendance Record";
            this.btnattendancerecord.UseVisualStyleBackColor = false;
            this.btnattendancerecord.Click += new System.EventHandler(this.btnattendancerecord_Click);
            // 
            // btndeptjobrule
            // 
            this.btndeptjobrule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndeptjobrule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeptjobrule.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptjobrule.Location = new System.Drawing.Point(0, 117);
            this.btndeptjobrule.Name = "btndeptjobrule";
            this.btndeptjobrule.Size = new System.Drawing.Size(215, 39);
            this.btndeptjobrule.TabIndex = 3;
            this.btndeptjobrule.Text = "Department and Job Rule";
            this.btndeptjobrule.UseVisualStyleBackColor = true;
            this.btndeptjobrule.Click += new System.EventHandler(this.btndeptjobrule_Click);
            // 
            // btnchangepass
            // 
            this.btnchangepass.BackColor = System.Drawing.Color.White;
            this.btnchangepass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchangepass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangepass.Location = new System.Drawing.Point(0, 78);
            this.btnchangepass.Name = "btnchangepass";
            this.btnchangepass.Size = new System.Drawing.Size(215, 39);
            this.btnchangepass.TabIndex = 2;
            this.btnchangepass.Text = "Change Password";
            this.btnchangepass.UseVisualStyleBackColor = false;
            this.btnchangepass.Click += new System.EventHandler(this.btnchangepass_Click);
            // 
            // btnupdateprofile
            // 
            this.btnupdateprofile.BackColor = System.Drawing.Color.Lavender;
            this.btnupdateprofile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnupdateprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateprofile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateprofile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdateprofile.Location = new System.Drawing.Point(0, 39);
            this.btnupdateprofile.Name = "btnupdateprofile";
            this.btnupdateprofile.Size = new System.Drawing.Size(215, 39);
            this.btnupdateprofile.TabIndex = 1;
            this.btnupdateprofile.Text = "Update Profile Details";
            this.btnupdateprofile.UseVisualStyleBackColor = false;
            this.btnupdateprofile.Click += new System.EventHandler(this.btnupdateprofile_Click);
            // 
            // btnProfileDetails
            // 
            this.btnProfileDetails.BackColor = System.Drawing.Color.White;
            this.btnProfileDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfileDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileDetails.Location = new System.Drawing.Point(0, 0);
            this.btnProfileDetails.Name = "btnProfileDetails";
            this.btnProfileDetails.Size = new System.Drawing.Size(215, 39);
            this.btnProfileDetails.TabIndex = 0;
            this.btnProfileDetails.Text = "Profile";
            this.btnProfileDetails.UseVisualStyleBackColor = false;
            this.btnProfileDetails.Click += new System.EventHandler(this.btnProfileDetails_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 531);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlTopHr);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            this.pnlTopHr.ResumeLayout(false);
            this.pnlTopHr.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHr;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnupdateprofile;
        private System.Windows.Forms.Button btnProfileDetails;
        private System.Windows.Forms.Button btnchangepass;
        private System.Windows.Forms.Button btndeptjobrule;
        private System.Windows.Forms.Button btnattendancerecord;
        private System.Windows.Forms.Button btnapplyforleave;
        private System.Windows.Forms.Button btnsalarydetails;
        private System.Windows.Forms.Button btnleavestatus;
        private System.Windows.Forms.Button btnpayslip;
        private System.Windows.Forms.Button btnnotice;
        private System.Windows.Forms.Button btncomplainbox;
    }
}