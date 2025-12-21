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
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnRecruitment = new System.Windows.Forms.Button();
            this.btnLeaveManagement = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopHr.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHr
            // 
            this.pnlTopHr.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTopHr.Controls.Add(this.btnLogout);
            this.pnlTopHr.Controls.Add(this.topHeaderLogin);
            this.pnlTopHr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHr.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHr.Name = "pnlTopHr";
            this.pnlTopHr.Size = new System.Drawing.Size(800, 60);
            this.pnlTopHr.TabIndex = 8;
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
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Ivory;
            this.btnLogout.Location = new System.Drawing.Point(706, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnEmployees);
            this.pnlSidebar.Controls.Add(this.btnLeaveManagement);
            this.pnlSidebar.Controls.Add(this.btnRecruitment);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(220, 390);
            this.pnlSidebar.TabIndex = 9;
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 10);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(220, 45);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnRecruitment
            // 
            this.btnRecruitment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecruitment.FlatAppearance.BorderSize = 0;
            this.btnRecruitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruitment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecruitment.ForeColor = System.Drawing.Color.White;
            this.btnRecruitment.Location = new System.Drawing.Point(0, 55);
            this.btnRecruitment.Name = "btnRecruitment";
            this.btnRecruitment.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRecruitment.Size = new System.Drawing.Size(220, 45);
            this.btnRecruitment.TabIndex = 1;
            this.btnRecruitment.Text = "Recruitment";
            this.btnRecruitment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruitment.UseVisualStyleBackColor = true;
            // 
            // btnLeaveManagement
            // 
            this.btnLeaveManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeaveManagement.FlatAppearance.BorderSize = 0;
            this.btnLeaveManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveManagement.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveManagement.ForeColor = System.Drawing.Color.White;
            this.btnLeaveManagement.Location = new System.Drawing.Point(0, 100);
            this.btnLeaveManagement.Name = "btnLeaveManagement";
            this.btnLeaveManagement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLeaveManagement.Size = new System.Drawing.Size(220, 45);
            this.btnLeaveManagement.TabIndex = 2;
            this.btnLeaveManagement.Text = "Leave Management";
            this.btnLeaveManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveManagement.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(0, 145);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(220, 45);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 190);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 45);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(580, 390);
            this.pnlMain.TabIndex = 10;
            // 
            // HRManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopHr);
            this.Name = "HRManagerDashboard";
            this.Text = "HRManagerDashboard";
            this.pnlTopHr.ResumeLayout(false);
            this.pnlTopHr.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHr;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnLeaveManagement;
        private System.Windows.Forms.Button btnRecruitment;
        private System.Windows.Forms.Panel pnlMain;
    }
}