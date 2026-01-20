namespace HRMS
{
    partial class SalaryDetails
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
            this.lblSalaryDetails = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtHouseRent = new System.Windows.Forms.TextBox();
            this.lblHouseRent = new System.Windows.Forms.Label();
            this.txtMedical = new System.Windows.Forms.TextBox();
            this.lblMedical = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblAfterAllowance = new System.Windows.Forms.Label();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.pnlTopHr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnback.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(421, 365);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(66, 24);
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
            this.pnlTopHr.Size = new System.Drawing.Size(800, 60);
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
            // lblSalaryDetails
            // 
            this.lblSalaryDetails.AutoSize = true;
            this.lblSalaryDetails.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryDetails.Location = new System.Drawing.Point(297, 63);
            this.lblSalaryDetails.Name = "lblSalaryDetails";
            this.lblSalaryDetails.Size = new System.Drawing.Size(172, 31);
            this.lblSalaryDetails.TabIndex = 45;
            this.lblSalaryDetails.Text = "Salary Details";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 218);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(216, 22);
            this.txtId.TabIndex = 44;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(31, 218);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 20);
            this.lblId.TabIndex = 43;
            this.lblId.Text = "ID : ";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(128, 262);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(216, 22);
            this.txtSalary.TabIndex = 47;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(31, 264);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(60, 20);
            this.lblSalary.TabIndex = 46;
            this.lblSalary.Text = "Salary: ";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(287, 365);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 24);
            this.btnShow.TabIndex = 48;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtHouseRent
            // 
            this.txtHouseRent.Location = new System.Drawing.Point(538, 172);
            this.txtHouseRent.Margin = new System.Windows.Forms.Padding(4);
            this.txtHouseRent.Name = "txtHouseRent";
            this.txtHouseRent.Size = new System.Drawing.Size(216, 22);
            this.txtHouseRent.TabIndex = 50;
            // 
            // lblHouseRent
            // 
            this.lblHouseRent.AutoSize = true;
            this.lblHouseRent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseRent.Location = new System.Drawing.Point(412, 174);
            this.lblHouseRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHouseRent.Name = "lblHouseRent";
            this.lblHouseRent.Size = new System.Drawing.Size(102, 20);
            this.lblHouseRent.TabIndex = 49;
            this.lblHouseRent.Text = "House Rent : ";
            // 
            // txtMedical
            // 
            this.txtMedical.Location = new System.Drawing.Point(538, 218);
            this.txtMedical.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedical.Name = "txtMedical";
            this.txtMedical.Size = new System.Drawing.Size(216, 22);
            this.txtMedical.TabIndex = 52;
            // 
            // lblMedical
            // 
            this.lblMedical.AutoSize = true;
            this.lblMedical.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedical.Location = new System.Drawing.Point(412, 220);
            this.lblMedical.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedical.Name = "lblMedical";
            this.lblMedical.Size = new System.Drawing.Size(75, 20);
            this.lblMedical.TabIndex = 51;
            this.lblMedical.Text = "Medical : ";
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(538, 257);
            this.txtTransport.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(216, 22);
            this.txtTransport.TabIndex = 54;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransport.Location = new System.Drawing.Point(412, 259);
            this.lblTransport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(89, 20);
            this.lblTransport.TabIndex = 53;
            this.lblTransport.Text = "Transport : ";
            // 
            // lblAfterAllowance
            // 
            this.lblAfterAllowance.AutoSize = true;
            this.lblAfterAllowance.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterAllowance.Location = new System.Drawing.Point(564, 124);
            this.lblAfterAllowance.Name = "lblAfterAllowance";
            this.lblAfterAllowance.Size = new System.Drawing.Size(157, 25);
            this.lblAfterAllowance.TabIndex = 55;
            this.lblAfterAllowance.Text = "After Allowance";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Location = new System.Drawing.Point(538, 296);
            this.txtTotalSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(216, 22);
            this.txtTotalSalary.TabIndex = 57;
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalary.Location = new System.Drawing.Point(412, 298);
            this.lblTotalSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(103, 20);
            this.lblTotalSalary.TabIndex = 56;
            this.lblTotalSalary.Text = "Total Salary : ";
            // 
            // SalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAfterAllowance);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.txtMedical);
            this.Controls.Add(this.lblMedical);
            this.Controls.Add(this.txtHouseRent);
            this.Controls.Add(this.lblHouseRent);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblSalaryDetails);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pnlTopHr);
            this.Controls.Add(this.btnback);
            this.Name = "SalaryDetails";
            this.Text = "SalaryDetails";
            this.Load += new System.EventHandler(this.SalaryDetails_Load);
            this.pnlTopHr.ResumeLayout(false);
            this.pnlTopHr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlTopHr;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Label lblSalaryDetails;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtHouseRent;
        private System.Windows.Forms.Label lblHouseRent;
        private System.Windows.Forms.TextBox txtMedical;
        private System.Windows.Forms.Label lblMedical;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblAfterAllowance;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label lblTotalSalary;
    }
}