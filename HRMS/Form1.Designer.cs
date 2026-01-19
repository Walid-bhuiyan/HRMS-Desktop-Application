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
            this.Forgetpasspanel = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdatepass = new System.Windows.Forms.Button();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsecurityans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbshowpass = new System.Windows.Forms.CheckBox();
            this.cmbLoginAs = new System.Windows.Forms.ComboBox();
            this.lblLoginAs = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
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
            this.Forgetpasspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLoginPanel
            // 
            this.topLoginPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topLoginPanel.Controls.Add(this.topHeaderLogin);
            this.topLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topLoginPanel.Name = "topLoginPanel";
            this.topLoginPanel.Size = new System.Drawing.Size(800, 60);
            this.topLoginPanel.TabIndex = 7;
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
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.SystemColors.Window;
            this.PanelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLogin.Controls.Add(this.Forgetpasspanel);
            this.PanelLogin.Controls.Add(this.chbshowpass);
            this.PanelLogin.Controls.Add(this.cmbLoginAs);
            this.PanelLogin.Controls.Add(this.lblLoginAs);
            this.PanelLogin.Controls.Add(this.lblForgotPassword);
            this.PanelLogin.Controls.Add(this.txtuname);
            this.PanelLogin.Controls.Add(this.lblPass);
            this.PanelLogin.Controls.Add(this.lblerroruname);
            this.PanelLogin.Controls.Add(this.lblerrorpass);
            this.PanelLogin.Controls.Add(this.lblUname);
            this.PanelLogin.Controls.Add(this.txtpass);
            this.PanelLogin.Controls.Add(this.btnlogin);
            this.PanelLogin.Location = new System.Drawing.Point(203, 69);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(399, 388);
            this.PanelLogin.TabIndex = 11;
            // 
            // Forgetpasspanel
            // 
            this.Forgetpasspanel.Controls.Add(this.btnback);
            this.Forgetpasspanel.Controls.Add(this.btnupdatepass);
            this.Forgetpasspanel.Controls.Add(this.txtnewpass);
            this.Forgetpasspanel.Controls.Add(this.label4);
            this.Forgetpasspanel.Controls.Add(this.txtemail);
            this.Forgetpasspanel.Controls.Add(this.label3);
            this.Forgetpasspanel.Controls.Add(this.txtsecurityans);
            this.Forgetpasspanel.Controls.Add(this.label2);
            this.Forgetpasspanel.Controls.Add(this.label1);
            this.Forgetpasspanel.Location = new System.Drawing.Point(-4, -4);
            this.Forgetpasspanel.Margin = new System.Windows.Forms.Padding(4);
            this.Forgetpasspanel.Name = "Forgetpasspanel";
            this.Forgetpasspanel.Size = new System.Drawing.Size(405, 390);
            this.Forgetpasspanel.TabIndex = 13;
            this.Forgetpasspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Forgetpasspanel_Paint);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Black;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnback.Location = new System.Drawing.Point(8, 352);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(111, 33);
            this.btnback.TabIndex = 31;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnupdatepass
            // 
            this.btnupdatepass.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdatepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdatepass.FlatAppearance.BorderSize = 0;
            this.btnupdatepass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnupdatepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnupdatepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatepass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatepass.ForeColor = System.Drawing.Color.White;
            this.btnupdatepass.Location = new System.Drawing.Point(108, 270);
            this.btnupdatepass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdatepass.Name = "btnupdatepass";
            this.btnupdatepass.Size = new System.Drawing.Size(183, 34);
            this.btnupdatepass.TabIndex = 14;
            this.btnupdatepass.Text = "Update Password";
            this.btnupdatepass.UseVisualStyleBackColor = false;
            this.btnupdatepass.Click += new System.EventHandler(this.btnupdatepass_Click);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(148, 187);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(168, 22);
            this.txtnewpass.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Password :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(148, 132);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(168, 22);
            this.txtemail.TabIndex = 11;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email :";
            // 
            // txtsecurityans
            // 
            this.txtsecurityans.Location = new System.Drawing.Point(148, 74);
            this.txtsecurityans.Margin = new System.Windows.Forms.Padding(4);
            this.txtsecurityans.Name = "txtsecurityans";
            this.txtsecurityans.Size = new System.Drawing.Size(168, 22);
            this.txtsecurityans.TabIndex = 9;
            this.txtsecurityans.TextChanged += new System.EventHandler(this.txtsecurityans_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Security Ans :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Security Question: What is  your pet name?";
            // 
            // chbshowpass
            // 
            this.chbshowpass.AutoSize = true;
            this.chbshowpass.Location = new System.Drawing.Point(233, 258);
            this.chbshowpass.Margin = new System.Windows.Forms.Padding(4);
            this.chbshowpass.Name = "chbshowpass";
            this.chbshowpass.Size = new System.Drawing.Size(125, 20);
            this.chbshowpass.TabIndex = 14;
            this.chbshowpass.Text = "Show Password";
            this.chbshowpass.UseVisualStyleBackColor = true;
            this.chbshowpass.CheckedChanged += new System.EventHandler(this.chbshowpass_CheckedChanged);
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
            this.cmbLoginAs.Location = new System.Drawing.Point(152, 44);
            this.cmbLoginAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoginAs.Name = "cmbLoginAs";
            this.cmbLoginAs.Size = new System.Drawing.Size(216, 31);
            this.cmbLoginAs.TabIndex = 3;
            this.cmbLoginAs.Tag = "";
            this.cmbLoginAs.SelectedIndexChanged += new System.EventHandler(this.cmbLoginAs_SelectedIndexChanged);
            // 
            // lblLoginAs
            // 
            this.lblLoginAs.AutoSize = true;
            this.lblLoginAs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAs.ForeColor = System.Drawing.Color.Black;
            this.lblLoginAs.Location = new System.Drawing.Point(39, 50);
            this.lblLoginAs.Name = "lblLoginAs";
            this.lblLoginAs.Size = new System.Drawing.Size(79, 23);
            this.lblLoginAs.TabIndex = 12;
            this.lblLoginAs.Text = "Login As";
            this.lblLoginAs.Click += new System.EventHandler(this.lblLoginAs_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblForgotPassword.Location = new System.Drawing.Point(236, 283);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(125, 20);
            this.lblForgotPassword.TabIndex = 4;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtuname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(152, 158);
            this.txtuname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(215, 30);
            this.txtuname.TabIndex = 0;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPass.Location = new System.Drawing.Point(39, 222);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(92, 25);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password";
            // 
            // lblerroruname
            // 
            this.lblerroruname.AutoSize = true;
            this.lblerroruname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroruname.ForeColor = System.Drawing.Color.Red;
            this.lblerroruname.Location = new System.Drawing.Point(149, 192);
            this.lblerroruname.Name = "lblerroruname";
            this.lblerroruname.Size = new System.Drawing.Size(0, 17);
            this.lblerroruname.TabIndex = 6;
            // 
            // lblerrorpass
            // 
            this.lblerrorpass.AutoSize = true;
            this.lblerrorpass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpass.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpass.Location = new System.Drawing.Point(149, 254);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(0, 17);
            this.lblerrorpass.TabIndex = 5;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.Color.Transparent;
            this.lblUname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.Color.Black;
            this.lblUname.Location = new System.Drawing.Point(39, 162);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(97, 25);
            this.lblUname.TabIndex = 1;
            this.lblUname.Text = "Username";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(152, 220);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(215, 30);
            this.txtpass.TabIndex = 1;
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
            this.btnlogin.Location = new System.Drawing.Point(44, 318);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(183, 34);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.LightGray;
            this.panelShadow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShadow.Location = new System.Drawing.Point(203, 66);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(399, 390);
            this.panelShadow.TabIndex = 12;
            // 
            // loginframe
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.topLoginPanel);
            this.Controls.Add(this.panelShadow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginframe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login Frame";
            this.Load += new System.EventHandler(this.loginframe_Load);
            this.topLoginPanel.ResumeLayout(false);
            this.topLoginPanel.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.Forgetpasspanel.ResumeLayout(false);
            this.Forgetpasspanel.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbLoginAs;
        private System.Windows.Forms.Label lblLoginAs;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.CheckBox chbshowpass;
        private System.Windows.Forms.Panel Forgetpasspanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsecurityans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Button btnupdatepass;
        private System.Windows.Forms.Button btnback;
    }
}

