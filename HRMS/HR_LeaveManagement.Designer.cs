namespace HRMS
{
    partial class HR_LeaveManagement
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
            this.btnBack = new System.Windows.Forms.Button();
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewLeaves = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtLeaveID = new System.Windows.Forms.TextBox();
            this.lblLeaceId = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.topLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // topLoginPanel
            // 
            this.topLoginPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topLoginPanel.Controls.Add(this.btnBack);
            this.topLoginPanel.Controls.Add(this.topHeaderLogin);
            this.topLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topLoginPanel.Name = "topLoginPanel";
            this.topLoginPanel.Size = new System.Drawing.Size(858, 59);
            this.topLoginPanel.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Ivory;
            this.btnBack.Location = new System.Drawing.Point(774, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 45);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // topHeaderLogin
            // 
            this.topHeaderLogin.AutoSize = true;
            this.topHeaderLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHeaderLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topHeaderLogin.Location = new System.Drawing.Point(281, 9);
            this.topHeaderLogin.Name = "topHeaderLogin";
            this.topHeaderLogin.Size = new System.Drawing.Size(274, 38);
            this.topHeaderLogin.TabIndex = 0;
            this.topHeaderLogin.Text = "Leave Management";
            this.topHeaderLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Leave Requests Table";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(300, 424);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(234, 22);
            this.dtTo.TabIndex = 50;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(300, 379);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(234, 22);
            this.dtFrom.TabIndex = 49;
            // 
            // dataGridViewLeaves
            // 
            this.dataGridViewLeaves.AllowUserToAddRows = false;
            this.dataGridViewLeaves.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaves.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewLeaves.MultiSelect = false;
            this.dataGridViewLeaves.Name = "dataGridViewLeaves";
            this.dataGridViewLeaves.ReadOnly = true;
            this.dataGridViewLeaves.RowHeadersWidth = 51;
            this.dataGridViewLeaves.RowTemplate.Height = 24;
            this.dataGridViewLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeaves.Size = new System.Drawing.Size(834, 150);
            this.dataGridViewLeaves.TabIndex = 48;
            this.dataGridViewLeaves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeaves_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(562, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtLeaveID
            // 
            this.txtLeaveID.Location = new System.Drawing.Point(299, 333);
            this.txtLeaveID.Name = "txtLeaveID";
            this.txtLeaveID.Size = new System.Drawing.Size(235, 22);
            this.txtLeaveID.TabIndex = 46;
            // 
            // lblLeaceId
            // 
            this.lblLeaceId.AutoSize = true;
            this.lblLeaceId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaceId.Location = new System.Drawing.Point(172, 332);
            this.lblLeaceId.Name = "lblLeaceId";
            this.lblLeaceId.Size = new System.Drawing.Size(78, 23);
            this.lblLeaceId.TabIndex = 45;
            this.lblLeaceId.Text = "LeaveID:";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.Red;
            this.btnReject.Location = new System.Drawing.Point(427, 598);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(100, 35);
            this.btnReject.TabIndex = 44;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(301, 598);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(100, 35);
            this.btnApprove.TabIndex = 43;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(562, 326);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(367, 223);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 35);
            this.btnView.TabIndex = 41;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Reason:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(299, 555);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(235, 22);
            this.txtStatus.TabIndex = 39;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(172, 556);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 23);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "Status:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(172, 424);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(78, 23);
            this.lblToDate.TabIndex = 37;
            this.lblToDate.Text = "To-Date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(172, 379);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(102, 23);
            this.lblFromDate.TabIndex = 36;
            this.lblFromDate.Text = "From-Date:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(299, 466);
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(235, 68);
            this.txtReason.TabIndex = 35;
            this.txtReason.Text = "";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(299, 283);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(235, 22);
            this.txtEmployeeID.TabIndex = 34;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(172, 283);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(111, 23);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "EmployeeID:";
            // 
            // HR_LeaveManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(858, 658);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dataGridViewLeaves);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtLeaveID);
            this.Controls.Add(this.lblLeaceId);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topLoginPanel);
            this.Name = "HR_LeaveManagement";
            this.Text = "HR_LeaveManagement";
            this.Load += new System.EventHandler(this.HR_LeaveManagement_Load);
            this.topLoginPanel.ResumeLayout(false);
            this.topLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topLoginPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DataGridView dataGridViewLeaves;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtLeaveID;
        private System.Windows.Forms.Label lblLeaceId;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblId;
    }
}