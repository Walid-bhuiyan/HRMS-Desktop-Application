namespace HRMS
{
    partial class btnadminoperations
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
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.btnattendence = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnresetpassword = new System.Windows.Forms.Button();
            this.btnaccountantoperations = new System.Windows.Forms.Button();
            this.btnempoyeeoperations = new System.Windows.Forms.Button();
            this.btnmangeroperations = new System.Windows.Forms.Button();
            this.lbladminmenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resetpasspanel = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtoldpass = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblwc = new System.Windows.Forms.Label();
            this.topLoginPanel.SuspendLayout();
            this.pnlsidebar.SuspendLayout();
            this.resetpasspanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.topLoginPanel.Size = new System.Drawing.Size(927, 60);
            this.topLoginPanel.TabIndex = 8;
            // 
            // topHeaderLogin
            // 
            this.topHeaderLogin.AutoSize = true;
            this.topHeaderLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHeaderLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topHeaderLogin.Location = new System.Drawing.Point(237, 11);
            this.topHeaderLogin.Name = "topHeaderLogin";
            this.topHeaderLogin.Size = new System.Drawing.Size(341, 38);
            this.topHeaderLogin.TabIndex = 0;
            this.topHeaderLogin.Text = "HR Management System";
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.BackColor = System.Drawing.SystemColors.Window;
            this.pnlsidebar.Controls.Add(this.btnattendence);
            this.pnlsidebar.Controls.Add(this.btnlogout);
            this.pnlsidebar.Controls.Add(this.btnresetpassword);
            this.pnlsidebar.Controls.Add(this.btnaccountantoperations);
            this.pnlsidebar.Controls.Add(this.btnempoyeeoperations);
            this.pnlsidebar.Controls.Add(this.btnmangeroperations);
            this.pnlsidebar.Controls.Add(this.lbladminmenu);
            this.pnlsidebar.Controls.Add(this.button1);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 60);
            this.pnlsidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(247, 552);
            this.pnlsidebar.TabIndex = 15;
            this.pnlsidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlsidebar_Paint);
            // 
            // btnattendence
            // 
            this.btnattendence.Location = new System.Drawing.Point(11, 310);
            this.btnattendence.Name = "btnattendence";
            this.btnattendence.Size = new System.Drawing.Size(132, 29);
            this.btnattendence.TabIndex = 22;
            this.btnattendence.Text = "Attendence";
            this.btnattendence.UseVisualStyleBackColor = true;
            this.btnattendence.Click += new System.EventHandler(this.btnattendence_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Salmon;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogout.Location = new System.Drawing.Point(12, 367);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(176, 33);
            this.btnlogout.TabIndex = 21;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnresetpassword
            // 
            this.btnresetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetpassword.Location = new System.Drawing.Point(12, 252);
            this.btnresetpassword.Name = "btnresetpassword";
            this.btnresetpassword.Size = new System.Drawing.Size(176, 36);
            this.btnresetpassword.TabIndex = 20;
            this.btnresetpassword.Text = "Reset Password";
            this.btnresetpassword.UseVisualStyleBackColor = true;
            this.btnresetpassword.Click += new System.EventHandler(this.btnresetpassword_Click);
            // 
            // btnaccountantoperations
            // 
            this.btnaccountantoperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccountantoperations.Location = new System.Drawing.Point(16, 246);
            this.btnaccountantoperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaccountantoperations.Name = "btnaccountantoperations";
            this.btnaccountantoperations.Size = new System.Drawing.Size(176, 33);
            this.btnaccountantoperations.TabIndex = 19;
            this.btnaccountantoperations.Text = "Accountant Operations";
            this.btnaccountantoperations.UseVisualStyleBackColor = true;
            // 
            // btnempoyeeoperations
            // 
            this.btnempoyeeoperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempoyeeoperations.Location = new System.Drawing.Point(16, 183);
            this.btnempoyeeoperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnempoyeeoperations.Name = "btnempoyeeoperations";
            this.btnempoyeeoperations.Size = new System.Drawing.Size(176, 34);
            this.btnempoyeeoperations.TabIndex = 18;
            this.btnempoyeeoperations.Text = "Employee Operations";
            this.btnempoyeeoperations.UseVisualStyleBackColor = true;
            // 
            // btnmangeroperations
            // 
            this.btnmangeroperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmangeroperations.Location = new System.Drawing.Point(16, 119);
            this.btnmangeroperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmangeroperations.Name = "btnmangeroperations";
            this.btnmangeroperations.Size = new System.Drawing.Size(176, 36);
            this.btnmangeroperations.TabIndex = 17;
            this.btnmangeroperations.Text = "Manager Operations";
            this.btnmangeroperations.UseVisualStyleBackColor = true;
            this.btnmangeroperations.Click += new System.EventHandler(this.btnmangeroperations_Click);
            // 
            // lbladminmenu
            // 
            this.lbladminmenu.AutoSize = true;
            this.lbladminmenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbladminmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladminmenu.Location = new System.Drawing.Point(16, 7);
            this.lbladminmenu.Margin = new System.Windows.Forms.Padding(11, 4, 11, 4);
            this.lbladminmenu.Name = "lbladminmenu";
            this.lbladminmenu.Size = new System.Drawing.Size(163, 25);
            this.lbladminmenu.TabIndex = 16;
            this.lbladminmenu.Text = "    Admin  Menu   ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Admin Operations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // resetpasspanel
            // 
            this.resetpasspanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetpasspanel.Controls.Add(this.txtusername);
            this.resetpasspanel.Controls.Add(this.label4);
            this.resetpasspanel.Controls.Add(this.btncancel);
            this.resetpasspanel.Controls.Add(this.txtconfirmpass);
            this.resetpasspanel.Controls.Add(this.txtnewpass);
            this.resetpasspanel.Controls.Add(this.txtoldpass);
            this.resetpasspanel.Controls.Add(this.btnconfirm);
            this.resetpasspanel.Controls.Add(this.label3);
            this.resetpasspanel.Controls.Add(this.label2);
            this.resetpasspanel.Controls.Add(this.label1);
            this.resetpasspanel.Location = new System.Drawing.Point(277, 241);
            this.resetpasspanel.Name = "resetpasspanel";
            this.resetpasspanel.Size = new System.Drawing.Size(293, 183);
            this.resetpasspanel.TabIndex = 16;
            this.resetpasspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(118, 14);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(133, 20);
            this.txtusername.TabIndex = 9;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(23, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Name :";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Black;
            this.btncancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancel.Location = new System.Drawing.Point(25, 134);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(103, 30);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(118, 92);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(133, 20);
            this.txtconfirmpass.TabIndex = 6;
            this.txtconfirmpass.TextChanged += new System.EventHandler(this.txtconfirmpass_TextChanged);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(118, 66);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(133, 20);
            this.txtnewpass.TabIndex = 5;
            this.txtnewpass.TextChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            // 
            // txtoldpass
            // 
            this.txtoldpass.Location = new System.Drawing.Point(118, 40);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.Size = new System.Drawing.Size(133, 20);
            this.txtoldpass.TabIndex = 4;
            this.txtoldpass.TextChanged += new System.EventHandler(this.txtoldpass_TextChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnconfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnconfirm.Location = new System.Drawing.Point(169, 134);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(103, 30);
            this.btnconfirm.TabIndex = 3;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password :";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(202, 86);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 37);
            this.lblwelcome.TabIndex = 17;
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblwc, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 62);
            this.tableLayoutPanel1.TabIndex = 18;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblwc
            // 
            this.lblwc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblwc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblwc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblwc.Location = new System.Drawing.Point(3, 0);
            this.lblwc.Name = "lblwc";
            this.lblwc.Size = new System.Drawing.Size(474, 62);
            this.lblwc.TabIndex = 0;
            this.lblwc.Text = "Wekcome-";
            this.lblwc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnadminoperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HRMS.Properties.Resources.business_businessman_communication_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(695, 497);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resetpasspanel);
            this.Controls.Add(this.pnlsidebar);
            this.Controls.Add(this.topLoginPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "btnadminoperations";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.topLoginPanel.ResumeLayout(false);
            this.topLoginPanel.PerformLayout();
            this.pnlsidebar.ResumeLayout(false);
            this.pnlsidebar.PerformLayout();
            this.resetpasspanel.ResumeLayout(false);
            this.resetpasspanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topLoginPanel;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnresetpassword;
        private System.Windows.Forms.Button btnaccountantoperations;
        private System.Windows.Forms.Button btnempoyeeoperations;
        private System.Windows.Forms.Button btnmangeroperations;
        private System.Windows.Forms.Label lbladminmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel resetpasspanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.TextBox txtoldpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblwc;
        private System.Windows.Forms.Button btnattendence;
    }
}