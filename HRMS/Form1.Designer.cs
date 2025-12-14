namespace HRMS
{
    partial class loginframe
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
            this.topLoginPanel = new System.Windows.Forms.Panel();
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.cmbLoginAs = new System.Windows.Forms.ComboBox();
            this.lblLoginAs = new System.Windows.Forms.Label();
            this.lblForgetPass = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblerroruname = new System.Windows.Forms.Label();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.topLoginPanel.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLoginPanel
            // 
            this.topLoginPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topLoginPanel.Controls.Add(this.topHeaderLogin);
            this.topLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topLoginPanel.Name = "topLoginPanel";
            this.topLoginPanel.Size = new System.Drawing.Size(900, 75);
            this.topLoginPanel.TabIndex = 7;
            // 
            // topHeaderLogin
            // 
            this.topHeaderLogin.AutoSize = true;
            this.topHeaderLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHeaderLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topHeaderLogin.Location = new System.Drawing.Point(256, 11);
            this.topHeaderLogin.Name = "topHeaderLogin";
            this.topHeaderLogin.Size = new System.Drawing.Size(404, 45);
            this.topHeaderLogin.TabIndex = 0;
            this.topHeaderLogin.Text = "HR Management System";
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.SystemColors.Window;
            this.PanelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLogin.Controls.Add(this.cmbLoginAs);
            this.PanelLogin.Controls.Add(this.lblLoginAs);
            this.PanelLogin.Controls.Add(this.lblForgetPass);
            this.PanelLogin.Controls.Add(this.txtuname);
            this.PanelLogin.Controls.Add(this.lblPass);
            this.PanelLogin.Controls.Add(this.lblerroruname);
            this.PanelLogin.Controls.Add(this.lblerrorpass);
            this.PanelLogin.Controls.Add(this.lblUname);
            this.PanelLogin.Controls.Add(this.txtpass);
            this.PanelLogin.Controls.Add(this.btnlogin);
            this.PanelLogin.Location = new System.Drawing.Point(227, 82);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(450, 437);
            this.PanelLogin.TabIndex = 11;
            // 
            // cmbLoginAs
            // 
            this.cmbLoginAs.DropDownHeight = 50;
            this.cmbLoginAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoginAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoginAs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoginAs.FormattingEnabled = true;
            this.cmbLoginAs.IntegralHeight = false;
            this.cmbLoginAs.Items.AddRange(new object[] {
            "Admin",
            "HR Manager",
            "Employee",
            "Accountant"});
            this.cmbLoginAs.Location = new System.Drawing.Point(171, 55);
            this.cmbLoginAs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLoginAs.Name = "cmbLoginAs";
            this.cmbLoginAs.Size = new System.Drawing.Size(242, 36);
            this.cmbLoginAs.TabIndex = 13;
            this.cmbLoginAs.Tag = "";
            // 
            // lblLoginAs
            // 
            this.lblLoginAs.AutoSize = true;
            this.lblLoginAs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLoginAs.Location = new System.Drawing.Point(44, 64);
            this.lblLoginAs.Name = "lblLoginAs";
            this.lblLoginAs.Size = new System.Drawing.Size(99, 30);
            this.lblLoginAs.TabIndex = 12;
            this.lblLoginAs.Text = "Login As";
            this.lblLoginAs.Click += new System.EventHandler(this.lblLoginAs_Click);
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.AutoSize = true;
            this.lblForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPass.ForeColor = System.Drawing.Color.Red;
            this.lblForgetPass.Location = new System.Drawing.Point(284, 339);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(50, 21);
            this.lblForgetPass.TabIndex = 11;
            this.lblForgetPass.Text = "!!@@";
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtuname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(171, 199);
            this.txtuname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(243, 35);
            this.txtuname.TabIndex = 10;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Red;
            this.lblPass.Location = new System.Drawing.Point(44, 278);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(112, 30);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password";
            // 
            // lblerroruname
            // 
            this.lblerroruname.AutoSize = true;
            this.lblerroruname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroruname.ForeColor = System.Drawing.Color.Red;
            this.lblerroruname.Location = new System.Drawing.Point(168, 240);
            this.lblerroruname.Name = "lblerroruname";
            this.lblerroruname.Size = new System.Drawing.Size(0, 21);
            this.lblerroruname.TabIndex = 6;
            // 
            // lblerrorpass
            // 
            this.lblerrorpass.AutoSize = true;
            this.lblerrorpass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpass.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpass.Location = new System.Drawing.Point(168, 316);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(0, 21);
            this.lblerrorpass.TabIndex = 5;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.Color.Transparent;
            this.lblUname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.Color.Red;
            this.lblUname.Location = new System.Drawing.Point(44, 202);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(117, 30);
            this.lblUname.TabIndex = 1;
            this.lblUname.Text = "Username";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(171, 275);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(243, 35);
            this.txtpass.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(162, 368);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(126, 42);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.LightGray;
            this.panelShadow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShadow.Location = new System.Drawing.Point(227, 82);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(454, 442);
            this.panelShadow.TabIndex = 12;
            // 
            // loginframe
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.topLoginPanel);
            this.Controls.Add(this.panelShadow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loginframe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login Frame";
            this.Load += new System.EventHandler(this.loginframe_Load);
            this.topLoginPanel.ResumeLayout(false);
            this.topLoginPanel.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topLoginPanel;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblerroruname;
        private System.Windows.Forms.Label lblerrorpass;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblForgetPass;
        private System.Windows.Forms.ComboBox cmbLoginAs;
        private System.Windows.Forms.Label lblLoginAs;
    }
}

