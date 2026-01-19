namespace HRMS
{
    partial class HRManagerDashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnLeaveManagementSP = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnOrganization = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDashboardSB = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPendingLeavesValue = new System.Windows.Forms.Label();
            this.lblPendingLeavesTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalDepartmentsValue = new System.Windows.Forms.Label();
            this.lblTotalDepartmentsTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTodayPresentValue = new System.Windows.Forms.Label();
            this.lblTodayPresentTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalEmployeesValue = new System.Windows.Forms.Label();
            this.lblTotalEmployeesTitle = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlDepartments = new System.Windows.Forms.Panel();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTodayPresent = new System.Windows.Forms.Panel();
            this.lblPendingLeaves = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPendingLeaves = new System.Windows.Forms.Panel();
            this.lblTodayPresent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTotalEmployees = new System.Windows.Forms.Panel();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.lblTotalEmployeesText = new System.Windows.Forms.Label();
            this.pnlTopHr.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlDepartments.SuspendLayout();
            this.pnlTodayPresent.SuspendLayout();
            this.pnlPendingLeaves.SuspendLayout();
            this.pnlTotalEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHr
            // 
            this.pnlTopHr.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTopHr.Controls.Add(this.btnLogout);
            this.pnlTopHr.Controls.Add(this.topHeaderLogin);
            this.pnlTopHr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHr.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHr.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopHr.Name = "pnlTopHr";
            this.pnlTopHr.Size = new System.Drawing.Size(800, 60);
            this.pnlTopHr.TabIndex = 8;
            this.pnlTopHr.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopHr_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Ivory;
            this.btnLogout.Location = new System.Drawing.Point(707, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 34);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlSidebar.Controls.Add(this.btnChangePassword);
            this.pnlSidebar.Controls.Add(this.btnProfile);
            this.pnlSidebar.Controls.Add(this.btnPayroll);
            this.pnlSidebar.Controls.Add(this.btnLeaveManagementSP);
            this.pnlSidebar.Controls.Add(this.btnAttendance);
            this.pnlSidebar.Controls.Add(this.btnOrganization);
            this.pnlSidebar.Controls.Add(this.btnEmployees);
            this.pnlSidebar.Controls.Add(this.btnDashboardSB);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 56);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(220, 448);
            this.pnlSidebar.TabIndex = 9;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 332);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(220, 46);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 286);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(220, 46);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnPayroll
            // 
            this.btnPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayroll.FlatAppearance.BorderSize = 0;
            this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayroll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.Location = new System.Drawing.Point(0, 240);
            this.btnPayroll.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPayroll.Size = new System.Drawing.Size(220, 46);
            this.btnPayroll.TabIndex = 7;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.UseVisualStyleBackColor = true;
            // 
            // btnLeaveManagementSP
            // 
            this.btnLeaveManagementSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeaveManagementSP.FlatAppearance.BorderSize = 0;
            this.btnLeaveManagementSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveManagementSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveManagementSP.ForeColor = System.Drawing.Color.White;
            this.btnLeaveManagementSP.Location = new System.Drawing.Point(0, 194);
            this.btnLeaveManagementSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaveManagementSP.Name = "btnLeaveManagementSP";
            this.btnLeaveManagementSP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLeaveManagementSP.Size = new System.Drawing.Size(220, 46);
            this.btnLeaveManagementSP.TabIndex = 11;
            this.btnLeaveManagementSP.Text = "Leave Management ";
            this.btnLeaveManagementSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveManagementSP.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(0, 148);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(220, 46);
            this.btnAttendance.TabIndex = 6;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnOrganization
            // 
            this.btnOrganization.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrganization.FlatAppearance.BorderSize = 0;
            this.btnOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganization.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganization.ForeColor = System.Drawing.Color.White;
            this.btnOrganization.Location = new System.Drawing.Point(0, 102);
            this.btnOrganization.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrganization.Name = "btnOrganization";
            this.btnOrganization.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrganization.Size = new System.Drawing.Size(220, 46);
            this.btnOrganization.TabIndex = 5;
            this.btnOrganization.Text = "Organization";
            this.btnOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganization.UseVisualStyleBackColor = true;
            this.btnOrganization.Click += new System.EventHandler(this.btnOrganization_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(0, 56);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(220, 46);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnDashboardSB
            // 
            this.btnDashboardSB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboardSB.FlatAppearance.BorderSize = 0;
            this.btnDashboardSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardSB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardSB.ForeColor = System.Drawing.Color.White;
            this.btnDashboardSB.Location = new System.Drawing.Point(0, 10);
            this.btnDashboardSB.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboardSB.Name = "btnDashboardSB";
            this.btnDashboardSB.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboardSB.Size = new System.Drawing.Size(220, 46);
            this.btnDashboardSB.TabIndex = 0;
            this.btnDashboardSB.Text = "Dashboard";
            this.btnDashboardSB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardSB.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(235, 71);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(554, 397);
            this.pnlMain.TabIndex = 10;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lblPendingLeavesValue);
            this.panel3.Controls.Add(this.lblPendingLeavesTitle);
            this.panel3.Location = new System.Drawing.Point(20, 221);
            this.panel3.Margin = new System.Windows.Forms.Padding(15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 110);
            this.panel3.TabIndex = 4;
            // 
            // lblPendingLeavesValue
            // 
            this.lblPendingLeavesValue.AutoSize = true;
            this.lblPendingLeavesValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingLeavesValue.ForeColor = System.Drawing.Color.White;
            this.lblPendingLeavesValue.Location = new System.Drawing.Point(74, 44);
            this.lblPendingLeavesValue.Name = "lblPendingLeavesValue";
            this.lblPendingLeavesValue.Size = new System.Drawing.Size(39, 45);
            this.lblPendingLeavesValue.TabIndex = 1;
            this.lblPendingLeavesValue.Text = "0";
            this.lblPendingLeavesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPendingLeavesTitle
            // 
            this.lblPendingLeavesTitle.AutoSize = true;
            this.lblPendingLeavesTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingLeavesTitle.ForeColor = System.Drawing.Color.White;
            this.lblPendingLeavesTitle.Location = new System.Drawing.Point(29, 11);
            this.lblPendingLeavesTitle.Name = "lblPendingLeavesTitle";
            this.lblPendingLeavesTitle.Size = new System.Drawing.Size(132, 23);
            this.lblPendingLeavesTitle.TabIndex = 0;
            this.lblPendingLeavesTitle.Text = "Pending Leaves";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.lblTotalDepartmentsValue);
            this.panel4.Controls.Add(this.lblTotalDepartmentsTitle);
            this.panel4.Location = new System.Drawing.Point(336, 221);
            this.panel4.Margin = new System.Windows.Forms.Padding(15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 110);
            this.panel4.TabIndex = 5;
            // 
            // lblTotalDepartmentsValue
            // 
            this.lblTotalDepartmentsValue.AutoSize = true;
            this.lblTotalDepartmentsValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepartmentsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalDepartmentsValue.Location = new System.Drawing.Point(80, 44);
            this.lblTotalDepartmentsValue.Name = "lblTotalDepartmentsValue";
            this.lblTotalDepartmentsValue.Size = new System.Drawing.Size(39, 45);
            this.lblTotalDepartmentsValue.TabIndex = 1;
            this.lblTotalDepartmentsValue.Text = "0";
            this.lblTotalDepartmentsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalDepartmentsTitle
            // 
            this.lblTotalDepartmentsTitle.AutoSize = true;
            this.lblTotalDepartmentsTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepartmentsTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalDepartmentsTitle.Location = new System.Drawing.Point(24, 11);
            this.lblTotalDepartmentsTitle.Name = "lblTotalDepartmentsTitle";
            this.lblTotalDepartmentsTitle.Size = new System.Drawing.Size(159, 23);
            this.lblTotalDepartmentsTitle.TabIndex = 0;
            this.lblTotalDepartmentsTitle.Text = "Total Departments";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblTodayPresentValue);
            this.panel2.Controls.Add(this.lblTodayPresentTitle);
            this.panel2.Location = new System.Drawing.Point(336, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 110);
            this.panel2.TabIndex = 6;
            // 
            // lblTodayPresentValue
            // 
            this.lblTodayPresentValue.AutoSize = true;
            this.lblTodayPresentValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPresentValue.ForeColor = System.Drawing.Color.White;
            this.lblTodayPresentValue.Location = new System.Drawing.Point(74, 44);
            this.lblTodayPresentValue.Name = "lblTodayPresentValue";
            this.lblTodayPresentValue.Size = new System.Drawing.Size(39, 45);
            this.lblTodayPresentValue.TabIndex = 1;
            this.lblTodayPresentValue.Text = "0";
            this.lblTodayPresentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTodayPresentTitle
            // 
            this.lblTodayPresentTitle.AutoSize = true;
            this.lblTodayPresentTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPresentTitle.ForeColor = System.Drawing.Color.White;
            this.lblTodayPresentTitle.Location = new System.Drawing.Point(29, 11);
            this.lblTodayPresentTitle.Name = "lblTodayPresentTitle";
            this.lblTodayPresentTitle.Size = new System.Drawing.Size(133, 23);
            this.lblTodayPresentTitle.TabIndex = 0;
            this.lblTodayPresentTitle.Text = "Today’s Present";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTotalEmployeesValue);
            this.panel1.Controls.Add(this.lblTotalEmployeesTitle);
            this.panel1.Location = new System.Drawing.Point(20, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 110);
            this.panel1.TabIndex = 3;
            // 
            // lblTotalEmployeesValue
            // 
            this.lblTotalEmployeesValue.AutoSize = true;
            this.lblTotalEmployeesValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployeesValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalEmployeesValue.Location = new System.Drawing.Point(74, 44);
            this.lblTotalEmployeesValue.Name = "lblTotalEmployeesValue";
            this.lblTotalEmployeesValue.Size = new System.Drawing.Size(39, 45);
            this.lblTotalEmployeesValue.TabIndex = 1;
            this.lblTotalEmployeesValue.Text = "0";
            this.lblTotalEmployeesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalEmployeesTitle
            // 
            this.lblTotalEmployeesTitle.AutoSize = true;
            this.lblTotalEmployeesTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployeesTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalEmployeesTitle.Location = new System.Drawing.Point(29, 11);
            this.lblTotalEmployeesTitle.Name = "lblTotalEmployeesTitle";
            this.lblTotalEmployeesTitle.Size = new System.Drawing.Size(139, 23);
            this.lblTotalEmployeesTitle.TabIndex = 0;
            this.lblTotalEmployeesTitle.Text = "Total Employees";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.pnlDepartments);
            this.pnlDashboard.Controls.Add(this.pnlTodayPresent);
            this.pnlDashboard.Controls.Add(this.pnlPendingLeaves);
            this.pnlDashboard.Controls.Add(this.pnlTotalEmployees);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(579, 388);
            this.pnlDashboard.TabIndex = 0;
            // 
            // pnlDepartments
            // 
            this.pnlDepartments.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlDepartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDepartments.Controls.Add(this.lblDepartments);
            this.pnlDepartments.Controls.Add(this.label4);
            this.pnlDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDepartments.Location = new System.Drawing.Point(0, 270);
            this.pnlDepartments.Name = "pnlDepartments";
            this.pnlDepartments.Size = new System.Drawing.Size(579, 90);
            this.pnlDepartments.TabIndex = 3;
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.ForeColor = System.Drawing.Color.White;
            this.lblDepartments.Location = new System.Drawing.Point(259, 39);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(46, 54);
            this.lblDepartments.TabIndex = 7;
            this.lblDepartments.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Departments";
            // 
            // pnlTodayPresent
            // 
            this.pnlTodayPresent.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTodayPresent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodayPresent.Controls.Add(this.lblPendingLeaves);
            this.pnlTodayPresent.Controls.Add(this.label3);
            this.pnlTodayPresent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTodayPresent.Location = new System.Drawing.Point(0, 180);
            this.pnlTodayPresent.Name = "pnlTodayPresent";
            this.pnlTodayPresent.Size = new System.Drawing.Size(579, 90);
            this.pnlTodayPresent.TabIndex = 1;
            // 
            // lblPendingLeaves
            // 
            this.lblPendingLeaves.AutoSize = true;
            this.lblPendingLeaves.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingLeaves.ForeColor = System.Drawing.Color.White;
            this.lblPendingLeaves.Location = new System.Drawing.Point(265, 39);
            this.lblPendingLeaves.Name = "lblPendingLeaves";
            this.lblPendingLeaves.Size = new System.Drawing.Size(46, 54);
            this.lblPendingLeaves.TabIndex = 5;
            this.lblPendingLeaves.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pending Leaves";
            // 
            // pnlPendingLeaves
            // 
            this.pnlPendingLeaves.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlPendingLeaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPendingLeaves.Controls.Add(this.lblTodayPresent);
            this.pnlPendingLeaves.Controls.Add(this.label2);
            this.pnlPendingLeaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPendingLeaves.Location = new System.Drawing.Point(0, 90);
            this.pnlPendingLeaves.Name = "pnlPendingLeaves";
            this.pnlPendingLeaves.Size = new System.Drawing.Size(579, 90);
            this.pnlPendingLeaves.TabIndex = 2;
            // 
            // lblTodayPresent
            // 
            this.lblTodayPresent.AutoSize = true;
            this.lblTodayPresent.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPresent.ForeColor = System.Drawing.Color.White;
            this.lblTodayPresent.Location = new System.Drawing.Point(256, 39);
            this.lblTodayPresent.Name = "lblTodayPresent";
            this.lblTodayPresent.Size = new System.Drawing.Size(46, 54);
            this.lblTodayPresent.TabIndex = 3;
            this.lblTodayPresent.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Today Present";
            // 
            // pnlTotalEmployees
            // 
            this.pnlTotalEmployees.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTotalEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployees);
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesText);
            this.pnlTotalEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTotalEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlTotalEmployees.Name = "pnlTotalEmployees";
            this.pnlTotalEmployees.Size = new System.Drawing.Size(579, 90);
            this.pnlTotalEmployees.TabIndex = 0;
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.ForeColor = System.Drawing.Color.White;
            this.lblTotalEmployees.Location = new System.Drawing.Point(260, 40);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(46, 54);
            this.lblTotalEmployees.TabIndex = 1;
            this.lblTotalEmployees.Text = "0";
            // 
            // lblTotalEmployeesText
            // 
            this.lblTotalEmployeesText.AutoSize = true;
            this.lblTotalEmployeesText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployeesText.ForeColor = System.Drawing.Color.White;
            this.lblTotalEmployeesText.Location = new System.Drawing.Point(209, 17);
            this.lblTotalEmployeesText.Name = "lblTotalEmployeesText";
            this.lblTotalEmployeesText.Size = new System.Drawing.Size(139, 23);
            this.lblTotalEmployeesText.TabIndex = 0;
            this.lblTotalEmployeesText.Text = "Total Employees";
            // 
            // HRManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.pnlTopHr);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HRManagerDashboard";
            this.Text = "HRManagerDashboard";
            this.Load += new System.EventHandler(this.HRManagerDashboard_Load);
            this.pnlTopHr.ResumeLayout(false);
            this.pnlTopHr.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDepartments.ResumeLayout(false);
            this.pnlDepartments.PerformLayout();
            this.pnlTodayPresent.ResumeLayout(false);
            this.pnlTodayPresent.PerformLayout();
            this.pnlPendingLeaves.ResumeLayout(false);
            this.pnlPendingLeaves.PerformLayout();
            this.pnlTotalEmployees.ResumeLayout(false);
            this.pnlTotalEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHr;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDashboardSB;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnOrganization;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLeaveManagementSP;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlTotalEmployees;
        private System.Windows.Forms.Panel pnlDepartments;
        private System.Windows.Forms.Panel pnlTodayPresent;
        private System.Windows.Forms.Panel pnlPendingLeaves;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Label lblTotalEmployeesText;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPendingLeaves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTodayPresent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPendingLeavesValue;
        private System.Windows.Forms.Label lblPendingLeavesTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalDepartmentsValue;
        private System.Windows.Forms.Label lblTotalDepartmentsTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTodayPresentValue;
        private System.Windows.Forms.Label lblTodayPresentTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalEmployeesValue;
        private System.Windows.Forms.Label lblTotalEmployeesTitle;
    }
}