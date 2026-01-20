namespace HRMS
{
    partial class ApplyforLeave
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
            this.lblReason = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.pnlTopHr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnback.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnback.Location = new System.Drawing.Point(266, 327);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(68, 27);
            this.btnback.TabIndex = 1;
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
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(50, 208);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(72, 20);
            this.lblReason.TabIndex = 46;
            this.lblReason.Text = "Reason : ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 91);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(234, 22);
            this.txtId.TabIndex = 42;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(54, 174);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(67, 20);
            this.lblToDate.TabIndex = 40;
            this.lblToDate.Text = "ToDate: ";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(34, 144);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(87, 20);
            this.lblFromDate.TabIndex = 39;
            this.lblFromDate.Text = "FromDate: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(83, 93);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 20);
            this.lblId.TabIndex = 38;
            this.lblId.Text = "ID : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(128, 174);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker2.TabIndex = 49;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(128, 208);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 96);
            this.richTextBox1.TabIndex = 50;
            this.richTextBox1.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(153, 327);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 27);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(560, 252);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 27);
            this.btnCheck.TabIndex = 52;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(478, 190);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(250, 38);
            this.lblCheck.TabIndex = 53;
            this.lblCheck.Text = "Check Leave Status";
            // 
            // ApplyforLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pnlTopHr);
            this.Controls.Add(this.btnback);
            this.Name = "ApplyforLeave";
            this.Text = "ApplyforLeave";
            this.Load += new System.EventHandler(this.ApplyforLeave_Load);
            this.pnlTopHr.ResumeLayout(false);
            this.pnlTopHr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlTopHr;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCheck;
    }
}