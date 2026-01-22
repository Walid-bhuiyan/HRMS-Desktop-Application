namespace HRMS
{
    partial class Admin_PayrollManagement
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
            this.cmbselectmonth = new System.Windows.Forms.ComboBox();
            this.btngeneratepayroll = new System.Windows.Forms.Button();
            this.txtpayrollid = new System.Windows.Forms.TextBox();
            this.lblpayrollid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblerroryearpayroll = new System.Windows.Forms.Label();
            this.lblerrormonthpayroll = new System.Windows.Forms.Label();
            this.lblerrormonth = new System.Windows.Forms.Label();
            this.btnreset2 = new System.Windows.Forms.Button();
            this.lblerrorempidpayroll = new System.Windows.Forms.Label();
            this.lblpayrollbreakdown = new System.Windows.Forms.Label();
            this.lblempinfopayroll = new System.Windows.Forms.Label();
            this.txtnetsalarypayroll = new System.Windows.Forms.TextBox();
            this.lblnetsalarypayroll = new System.Windows.Forms.Label();
            this.txttotaldeductionpayroll = new System.Windows.Forms.TextBox();
            this.lblerroryear = new System.Windows.Forms.Label();
            this.cmbselectyear = new System.Windows.Forms.ComboBox();
            this.lbltotaldeductionpayroll = new System.Windows.Forms.Label();
            this.txtgrosssalarypayroll = new System.Windows.Forms.TextBox();
            this.txtyearpayroll = new System.Windows.Forms.TextBox();
            this.lblyearpayroll = new System.Windows.Forms.Label();
            this.txtmonthpayroll = new System.Windows.Forms.TextBox();
            this.lblmonthpayroll = new System.Windows.Forms.Label();
            this.txtjobtitlepayroll = new System.Windows.Forms.TextBox();
            this.lbljobtitlepayroll = new System.Windows.Forms.Label();
            this.btnBackToHR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnviewemppayroll = new System.Windows.Forms.Button();
            this.lblgrosssalarypayroll = new System.Windows.Forms.Label();
            this.lblselectmonth = new System.Windows.Forms.Label();
            this.txtdepartmentpayroll = new System.Windows.Forms.TextBox();
            this.topLoginPanel = new System.Windows.Forms.Panel();
            this.topHeaderLogin = new System.Windows.Forms.Label();
            this.payrollProcessingPanel = new System.Windows.Forms.Panel();
            this.viewemppayrollPanel = new System.Windows.Forms.Panel();
            this.lbldepartmentpayroll = new System.Windows.Forms.Label();
            this.txtempnamepayroll = new System.Windows.Forms.TextBox();
            this.lblempnamepayroll = new System.Windows.Forms.Label();
            this.btnresetpayroll = new System.Windows.Forms.Button();
            this.cmbselectmonthpayroll = new System.Windows.Forms.ComboBox();
            this.lblselectmonthpayroll = new System.Windows.Forms.Label();
            this.lblselectyearpayroll = new System.Windows.Forms.Label();
            this.txtempidpayroll = new System.Windows.Forms.TextBox();
            this.cmbselectyearpayroll = new System.Windows.Forms.ComboBox();
            this.btnsearch2 = new System.Windows.Forms.Button();
            this.lblempidpayroll = new System.Windows.Forms.Label();
            this.lblviewemppayroll = new System.Windows.Forms.Label();
            this.lblselectyear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.topLoginPanel.SuspendLayout();
            this.payrollProcessingPanel.SuspendLayout();
            this.viewemppayrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbselectmonth
            // 
            this.cmbselectmonth.FormattingEnabled = true;
            this.cmbselectmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbselectmonth.Location = new System.Drawing.Point(248, 46);
            this.cmbselectmonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbselectmonth.Name = "cmbselectmonth";
            this.cmbselectmonth.Size = new System.Drawing.Size(231, 31);
            this.cmbselectmonth.TabIndex = 26;
            // 
            // btngeneratepayroll
            // 
            this.btngeneratepayroll.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btngeneratepayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratepayroll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btngeneratepayroll.Location = new System.Drawing.Point(248, 173);
            this.btngeneratepayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngeneratepayroll.Name = "btngeneratepayroll";
            this.btngeneratepayroll.Size = new System.Drawing.Size(210, 32);
            this.btngeneratepayroll.TabIndex = 25;
            this.btngeneratepayroll.Text = "Generate Payroll";
            this.btngeneratepayroll.UseVisualStyleBackColor = false;
            this.btngeneratepayroll.Click += new System.EventHandler(this.btngeneratepayroll_Click);
            // 
            // txtpayrollid
            // 
            this.txtpayrollid.Location = new System.Drawing.Point(217, 399);
            this.txtpayrollid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpayrollid.Name = "txtpayrollid";
            this.txtpayrollid.Size = new System.Drawing.Size(231, 30);
            this.txtpayrollid.TabIndex = 62;
            // 
            // lblpayrollid
            // 
            this.lblpayrollid.AutoSize = true;
            this.lblpayrollid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayrollid.Location = new System.Drawing.Point(57, 402);
            this.lblpayrollid.Name = "lblpayrollid";
            this.lblpayrollid.Size = new System.Drawing.Size(88, 23);
            this.lblpayrollid.TabIndex = 61;
            this.lblpayrollid.Text = "Payroll ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(399, 626);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 34);
            this.button1.TabIndex = 60;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblerroryearpayroll
            // 
            this.lblerroryearpayroll.AutoSize = true;
            this.lblerroryearpayroll.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroryearpayroll.ForeColor = System.Drawing.Color.Red;
            this.lblerroryearpayroll.Location = new System.Drawing.Point(206, 241);
            this.lblerroryearpayroll.Name = "lblerroryearpayroll";
            this.lblerroryearpayroll.Size = new System.Drawing.Size(0, 19);
            this.lblerroryearpayroll.TabIndex = 59;
            // 
            // lblerrormonthpayroll
            // 
            this.lblerrormonthpayroll.AutoSize = true;
            this.lblerrormonthpayroll.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrormonthpayroll.ForeColor = System.Drawing.Color.Red;
            this.lblerrormonthpayroll.Location = new System.Drawing.Point(206, 182);
            this.lblerrormonthpayroll.Name = "lblerrormonthpayroll";
            this.lblerrormonthpayroll.Size = new System.Drawing.Size(0, 19);
            this.lblerrormonthpayroll.TabIndex = 58;
            // 
            // lblerrormonth
            // 
            this.lblerrormonth.AutoSize = true;
            this.lblerrormonth.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrormonth.ForeColor = System.Drawing.Color.Red;
            this.lblerrormonth.Location = new System.Drawing.Point(252, 77);
            this.lblerrormonth.Name = "lblerrormonth";
            this.lblerrormonth.Size = new System.Drawing.Size(0, 19);
            this.lblerrormonth.TabIndex = 29;
            // 
            // btnreset2
            // 
            this.btnreset2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnreset2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnreset2.Location = new System.Drawing.Point(97, 614);
            this.btnreset2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset2.Name = "btnreset2";
            this.btnreset2.Size = new System.Drawing.Size(300, 32);
            this.btnreset2.TabIndex = 28;
            this.btnreset2.Text = "Reset";
            this.btnreset2.UseVisualStyleBackColor = false;
            this.btnreset2.Click += new System.EventHandler(this.btnreset2_Click);
            // 
            // lblerrorempidpayroll
            // 
            this.lblerrorempidpayroll.AutoSize = true;
            this.lblerrorempidpayroll.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorempidpayroll.ForeColor = System.Drawing.Color.Red;
            this.lblerrorempidpayroll.Location = new System.Drawing.Point(206, 122);
            this.lblerrorempidpayroll.Name = "lblerrorempidpayroll";
            this.lblerrorempidpayroll.Size = new System.Drawing.Size(0, 19);
            this.lblerrorempidpayroll.TabIndex = 57;
            // 
            // lblpayrollbreakdown
            // 
            this.lblpayrollbreakdown.AutoSize = true;
            this.lblpayrollbreakdown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayrollbreakdown.ForeColor = System.Drawing.Color.Navy;
            this.lblpayrollbreakdown.Location = new System.Drawing.Point(716, 323);
            this.lblpayrollbreakdown.Name = "lblpayrollbreakdown";
            this.lblpayrollbreakdown.Size = new System.Drawing.Size(161, 23);
            this.lblpayrollbreakdown.TabIndex = 56;
            this.lblpayrollbreakdown.Text = "Payroll Breakdown";
            // 
            // lblempinfopayroll
            // 
            this.lblempinfopayroll.AutoSize = true;
            this.lblempinfopayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempinfopayroll.ForeColor = System.Drawing.Color.Navy;
            this.lblempinfopayroll.Location = new System.Drawing.Point(151, 352);
            this.lblempinfopayroll.Name = "lblempinfopayroll";
            this.lblempinfopayroll.Size = new System.Drawing.Size(189, 23);
            this.lblempinfopayroll.TabIndex = 55;
            this.lblempinfopayroll.Text = "Employee Information";
            // 
            // txtnetsalarypayroll
            // 
            this.txtnetsalarypayroll.Location = new System.Drawing.Point(765, 557);
            this.txtnetsalarypayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnetsalarypayroll.Name = "txtnetsalarypayroll";
            this.txtnetsalarypayroll.Size = new System.Drawing.Size(231, 30);
            this.txtnetsalarypayroll.TabIndex = 54;
            // 
            // lblnetsalarypayroll
            // 
            this.lblnetsalarypayroll.AutoSize = true;
            this.lblnetsalarypayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetsalarypayroll.Location = new System.Drawing.Point(608, 559);
            this.lblnetsalarypayroll.Name = "lblnetsalarypayroll";
            this.lblnetsalarypayroll.Size = new System.Drawing.Size(94, 23);
            this.lblnetsalarypayroll.TabIndex = 53;
            this.lblnetsalarypayroll.Text = "Net Salary";
            // 
            // txttotaldeductionpayroll
            // 
            this.txttotaldeductionpayroll.Location = new System.Drawing.Point(765, 511);
            this.txttotaldeductionpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotaldeductionpayroll.Name = "txttotaldeductionpayroll";
            this.txttotaldeductionpayroll.Size = new System.Drawing.Size(231, 30);
            this.txttotaldeductionpayroll.TabIndex = 52;
            // 
            // lblerroryear
            // 
            this.lblerroryear.AutoSize = true;
            this.lblerroryear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroryear.ForeColor = System.Drawing.Color.Red;
            this.lblerroryear.Location = new System.Drawing.Point(252, 141);
            this.lblerroryear.Name = "lblerroryear";
            this.lblerroryear.Size = new System.Drawing.Size(0, 19);
            this.lblerroryear.TabIndex = 30;
            // 
            // cmbselectyear
            // 
            this.cmbselectyear.FormattingEnabled = true;
            this.cmbselectyear.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cmbselectyear.Location = new System.Drawing.Point(248, 109);
            this.cmbselectyear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbselectyear.Name = "cmbselectyear";
            this.cmbselectyear.Size = new System.Drawing.Size(231, 31);
            this.cmbselectyear.TabIndex = 27;
            // 
            // lbltotaldeductionpayroll
            // 
            this.lbltotaldeductionpayroll.AutoSize = true;
            this.lbltotaldeductionpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldeductionpayroll.Location = new System.Drawing.Point(608, 514);
            this.lbltotaldeductionpayroll.Name = "lbltotaldeductionpayroll";
            this.lbltotaldeductionpayroll.Size = new System.Drawing.Size(137, 23);
            this.lbltotaldeductionpayroll.TabIndex = 51;
            this.lbltotaldeductionpayroll.Text = "Total Deduction";
            // 
            // txtgrosssalarypayroll
            // 
            this.txtgrosssalarypayroll.Location = new System.Drawing.Point(765, 466);
            this.txtgrosssalarypayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgrosssalarypayroll.Name = "txtgrosssalarypayroll";
            this.txtgrosssalarypayroll.Size = new System.Drawing.Size(231, 30);
            this.txtgrosssalarypayroll.TabIndex = 50;
            // 
            // txtyearpayroll
            // 
            this.txtyearpayroll.Location = new System.Drawing.Point(765, 421);
            this.txtyearpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtyearpayroll.Name = "txtyearpayroll";
            this.txtyearpayroll.Size = new System.Drawing.Size(231, 30);
            this.txtyearpayroll.TabIndex = 48;
            // 
            // lblyearpayroll
            // 
            this.lblyearpayroll.AutoSize = true;
            this.lblyearpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyearpayroll.Location = new System.Drawing.Point(608, 423);
            this.lblyearpayroll.Name = "lblyearpayroll";
            this.lblyearpayroll.Size = new System.Drawing.Size(43, 23);
            this.lblyearpayroll.TabIndex = 47;
            this.lblyearpayroll.Text = "Year";
            // 
            // txtmonthpayroll
            // 
            this.txtmonthpayroll.Location = new System.Drawing.Point(765, 374);
            this.txtmonthpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmonthpayroll.Name = "txtmonthpayroll";
            this.txtmonthpayroll.Size = new System.Drawing.Size(231, 30);
            this.txtmonthpayroll.TabIndex = 46;
            // 
            // lblmonthpayroll
            // 
            this.lblmonthpayroll.AutoSize = true;
            this.lblmonthpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthpayroll.Location = new System.Drawing.Point(608, 376);
            this.lblmonthpayroll.Name = "lblmonthpayroll";
            this.lblmonthpayroll.Size = new System.Drawing.Size(63, 23);
            this.lblmonthpayroll.TabIndex = 45;
            this.lblmonthpayroll.Text = "Month";
            // 
            // txtjobtitlepayroll
            // 
            this.txtjobtitlepayroll.Location = new System.Drawing.Point(218, 558);
            this.txtjobtitlepayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtjobtitlepayroll.Name = "txtjobtitlepayroll";
            this.txtjobtitlepayroll.Size = new System.Drawing.Size(231, 30);
            this.txtjobtitlepayroll.TabIndex = 44;
            // 
            // lbljobtitlepayroll
            // 
            this.lbljobtitlepayroll.AutoSize = true;
            this.lbljobtitlepayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljobtitlepayroll.Location = new System.Drawing.Point(57, 560);
            this.lbljobtitlepayroll.Name = "lbljobtitlepayroll";
            this.lbljobtitlepayroll.Size = new System.Drawing.Size(80, 23);
            this.lbljobtitlepayroll.TabIndex = 43;
            this.lbljobtitlepayroll.Text = "Job Title";
            // 
            // btnBackToHR
            // 
            this.btnBackToHR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBackToHR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBackToHR.Location = new System.Drawing.Point(535, 660);
            this.btnBackToHR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToHR.Name = "btnBackToHR";
            this.btnBackToHR.Size = new System.Drawing.Size(121, 32);
            this.btnBackToHR.TabIndex = 41;
            this.btnBackToHR.Text = "Back";
            this.btnBackToHR.UseVisualStyleBackColor = false;
            this.btnBackToHR.Click += new System.EventHandler(this.btnBackToHR_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(445, 614);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(97, 249);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(988, 342);
            this.dataGridView2.TabIndex = 14;
            // 
            // btnviewemppayroll
            // 
            this.btnviewemppayroll.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnviewemppayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewemppayroll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnviewemppayroll.Location = new System.Drawing.Point(785, 614);
            this.btnviewemppayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnviewemppayroll.Name = "btnviewemppayroll";
            this.btnviewemppayroll.Size = new System.Drawing.Size(300, 32);
            this.btnviewemppayroll.TabIndex = 13;
            this.btnviewemppayroll.Text = "View Employee Payroll ";
            this.btnviewemppayroll.UseVisualStyleBackColor = false;
            this.btnviewemppayroll.Click += new System.EventHandler(this.btnviewemppayroll_Click);
            // 
            // lblgrosssalarypayroll
            // 
            this.lblgrosssalarypayroll.AutoSize = true;
            this.lblgrosssalarypayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosssalarypayroll.Location = new System.Drawing.Point(608, 469);
            this.lblgrosssalarypayroll.Name = "lblgrosssalarypayroll";
            this.lblgrosssalarypayroll.Size = new System.Drawing.Size(108, 23);
            this.lblgrosssalarypayroll.TabIndex = 49;
            this.lblgrosssalarypayroll.Text = "Gross Salary";
            // 
            // lblselectmonth
            // 
            this.lblselectmonth.AutoSize = true;
            this.lblselectmonth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectmonth.Location = new System.Drawing.Point(92, 48);
            this.lblselectmonth.Name = "lblselectmonth";
            this.lblselectmonth.Size = new System.Drawing.Size(116, 23);
            this.lblselectmonth.TabIndex = 0;
            this.lblselectmonth.Text = "Select Month";
            // 
            // txtdepartmentpayroll
            // 
            this.txtdepartmentpayroll.Location = new System.Drawing.Point(218, 503);
            this.txtdepartmentpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdepartmentpayroll.Name = "txtdepartmentpayroll";
            this.txtdepartmentpayroll.Size = new System.Drawing.Size(231, 30);
            this.txtdepartmentpayroll.TabIndex = 42;
            // 
            // topLoginPanel
            // 
            this.topLoginPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.topLoginPanel.Controls.Add(this.topHeaderLogin);
            this.topLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.topLoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topLoginPanel.Name = "topLoginPanel";
            this.topLoginPanel.Size = new System.Drawing.Size(1296, 59);
            this.topLoginPanel.TabIndex = 38;
            // 
            // topHeaderLogin
            // 
            this.topHeaderLogin.AutoSize = true;
            this.topHeaderLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHeaderLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topHeaderLogin.Location = new System.Drawing.Point(486, 9);
            this.topHeaderLogin.Name = "topHeaderLogin";
            this.topHeaderLogin.Size = new System.Drawing.Size(254, 38);
            this.topHeaderLogin.TabIndex = 0;
            this.topHeaderLogin.Text = "Payroll Processing";
            this.topHeaderLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payrollProcessingPanel
            // 
            this.payrollProcessingPanel.Controls.Add(this.lblerroryear);
            this.payrollProcessingPanel.Controls.Add(this.btnBackToHR);
            this.payrollProcessingPanel.Controls.Add(this.lblerrormonth);
            this.payrollProcessingPanel.Controls.Add(this.btnreset2);
            this.payrollProcessingPanel.Controls.Add(this.cmbselectyear);
            this.payrollProcessingPanel.Controls.Add(this.cmbselectmonth);
            this.payrollProcessingPanel.Controls.Add(this.btngeneratepayroll);
            this.payrollProcessingPanel.Controls.Add(this.button3);
            this.payrollProcessingPanel.Controls.Add(this.dataGridView2);
            this.payrollProcessingPanel.Controls.Add(this.btnviewemppayroll);
            this.payrollProcessingPanel.Controls.Add(this.lblselectyear);
            this.payrollProcessingPanel.Controls.Add(this.lblselectmonth);
            this.payrollProcessingPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.payrollProcessingPanel.Location = new System.Drawing.Point(72, 74);
            this.payrollProcessingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payrollProcessingPanel.Name = "payrollProcessingPanel";
            this.payrollProcessingPanel.Size = new System.Drawing.Size(1192, 703);
            this.payrollProcessingPanel.TabIndex = 39;
            // 
            // viewemppayrollPanel
            // 
            this.viewemppayrollPanel.Controls.Add(this.txtpayrollid);
            this.viewemppayrollPanel.Controls.Add(this.lblpayrollid);
            this.viewemppayrollPanel.Controls.Add(this.button1);
            this.viewemppayrollPanel.Controls.Add(this.lblerroryearpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblerrormonthpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblerrorempidpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblpayrollbreakdown);
            this.viewemppayrollPanel.Controls.Add(this.lblempinfopayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtnetsalarypayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblnetsalarypayroll);
            this.viewemppayrollPanel.Controls.Add(this.txttotaldeductionpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lbltotaldeductionpayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtgrosssalarypayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblgrosssalarypayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtyearpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblyearpayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtmonthpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblmonthpayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtjobtitlepayroll);
            this.viewemppayrollPanel.Controls.Add(this.lbljobtitlepayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtdepartmentpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lbldepartmentpayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtempnamepayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblempnamepayroll);
            this.viewemppayrollPanel.Controls.Add(this.btnresetpayroll);
            this.viewemppayrollPanel.Controls.Add(this.cmbselectmonthpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblselectmonthpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblselectyearpayroll);
            this.viewemppayrollPanel.Controls.Add(this.txtempidpayroll);
            this.viewemppayrollPanel.Controls.Add(this.cmbselectyearpayroll);
            this.viewemppayrollPanel.Controls.Add(this.btnsearch2);
            this.viewemppayrollPanel.Controls.Add(this.lblempidpayroll);
            this.viewemppayrollPanel.Controls.Add(this.lblviewemppayroll);
            this.viewemppayrollPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewemppayrollPanel.Location = new System.Drawing.Point(72, 78);
            this.viewemppayrollPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewemppayrollPanel.Name = "viewemppayrollPanel";
            this.viewemppayrollPanel.Size = new System.Drawing.Size(1183, 699);
            this.viewemppayrollPanel.TabIndex = 40;
            this.viewemppayrollPanel.Visible = false;
            // 
            // lbldepartmentpayroll
            // 
            this.lbldepartmentpayroll.AutoSize = true;
            this.lbldepartmentpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartmentpayroll.Location = new System.Drawing.Point(57, 506);
            this.lbldepartmentpayroll.Name = "lbldepartmentpayroll";
            this.lbldepartmentpayroll.Size = new System.Drawing.Size(108, 23);
            this.lbldepartmentpayroll.TabIndex = 41;
            this.lbldepartmentpayroll.Text = "Department";
            // 
            // txtempnamepayroll
            // 
            this.txtempnamepayroll.Location = new System.Drawing.Point(217, 447);
            this.txtempnamepayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtempnamepayroll.Name = "txtempnamepayroll";
            this.txtempnamepayroll.Size = new System.Drawing.Size(231, 30);
            this.txtempnamepayroll.TabIndex = 40;
            // 
            // lblempnamepayroll
            // 
            this.lblempnamepayroll.AutoSize = true;
            this.lblempnamepayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempnamepayroll.Location = new System.Drawing.Point(57, 450);
            this.lblempnamepayroll.Name = "lblempnamepayroll";
            this.lblempnamepayroll.Size = new System.Drawing.Size(140, 23);
            this.lblempnamepayroll.TabIndex = 39;
            this.lblempnamepayroll.Text = "Employee Name";
            // 
            // btnresetpayroll
            // 
            this.btnresetpayroll.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnresetpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetpayroll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnresetpayroll.Location = new System.Drawing.Point(61, 282);
            this.btnresetpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnresetpayroll.Name = "btnresetpayroll";
            this.btnresetpayroll.Size = new System.Drawing.Size(191, 34);
            this.btnresetpayroll.TabIndex = 38;
            this.btnresetpayroll.Text = "Reset";
            this.btnresetpayroll.UseVisualStyleBackColor = false;
            this.btnresetpayroll.Click += new System.EventHandler(this.btnresetpayroll_Click);
            // 
            // cmbselectmonthpayroll
            // 
            this.cmbselectmonthpayroll.FormattingEnabled = true;
            this.cmbselectmonthpayroll.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbselectmonthpayroll.Location = new System.Drawing.Point(202, 151);
            this.cmbselectmonthpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbselectmonthpayroll.Name = "cmbselectmonthpayroll";
            this.cmbselectmonthpayroll.Size = new System.Drawing.Size(270, 31);
            this.cmbselectmonthpayroll.TabIndex = 37;
            // 
            // lblselectmonthpayroll
            // 
            this.lblselectmonthpayroll.AutoSize = true;
            this.lblselectmonthpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectmonthpayroll.Location = new System.Drawing.Point(57, 154);
            this.lblselectmonthpayroll.Name = "lblselectmonthpayroll";
            this.lblselectmonthpayroll.Size = new System.Drawing.Size(116, 23);
            this.lblselectmonthpayroll.TabIndex = 36;
            this.lblselectmonthpayroll.Text = "Select Month";
            // 
            // lblselectyearpayroll
            // 
            this.lblselectyearpayroll.AutoSize = true;
            this.lblselectyearpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectyearpayroll.Location = new System.Drawing.Point(57, 212);
            this.lblselectyearpayroll.Name = "lblselectyearpayroll";
            this.lblselectyearpayroll.Size = new System.Drawing.Size(96, 23);
            this.lblselectyearpayroll.TabIndex = 35;
            this.lblselectyearpayroll.Text = "Select Year";
            // 
            // txtempidpayroll
            // 
            this.txtempidpayroll.Location = new System.Drawing.Point(202, 93);
            this.txtempidpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtempidpayroll.Name = "txtempidpayroll";
            this.txtempidpayroll.Size = new System.Drawing.Size(270, 30);
            this.txtempidpayroll.TabIndex = 34;
            // 
            // cmbselectyearpayroll
            // 
            this.cmbselectyearpayroll.FormattingEnabled = true;
            this.cmbselectyearpayroll.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cmbselectyearpayroll.Location = new System.Drawing.Point(202, 210);
            this.cmbselectyearpayroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbselectyearpayroll.Name = "cmbselectyearpayroll";
            this.cmbselectyearpayroll.Size = new System.Drawing.Size(270, 31);
            this.cmbselectyearpayroll.TabIndex = 33;
            // 
            // btnsearch2
            // 
            this.btnsearch2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnsearch2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsearch2.Location = new System.Drawing.Point(280, 282);
            this.btnsearch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch2.Name = "btnsearch2";
            this.btnsearch2.Size = new System.Drawing.Size(191, 34);
            this.btnsearch2.TabIndex = 32;
            this.btnsearch2.Text = "Search";
            this.btnsearch2.UseVisualStyleBackColor = false;
            this.btnsearch2.Click += new System.EventHandler(this.btnsearch2_Click);
            // 
            // lblempidpayroll
            // 
            this.lblempidpayroll.AutoSize = true;
            this.lblempidpayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempidpayroll.Location = new System.Drawing.Point(57, 95);
            this.lblempidpayroll.Name = "lblempidpayroll";
            this.lblempidpayroll.Size = new System.Drawing.Size(111, 23);
            this.lblempidpayroll.TabIndex = 31;
            this.lblempidpayroll.Text = "Employee ID";
            // 
            // lblviewemppayroll
            // 
            this.lblviewemppayroll.AutoSize = true;
            this.lblviewemppayroll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewemppayroll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblviewemppayroll.Location = new System.Drawing.Point(400, 14);
            this.lblviewemppayroll.Name = "lblviewemppayroll";
            this.lblviewemppayroll.Size = new System.Drawing.Size(273, 32);
            this.lblviewemppayroll.TabIndex = 6;
            this.lblviewemppayroll.Text = "View Employee Payroll";
            // 
            // lblselectyear
            // 
            this.lblselectyear.AutoSize = true;
            this.lblselectyear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectyear.Location = new System.Drawing.Point(92, 110);
            this.lblselectyear.Name = "lblselectyear";
            this.lblselectyear.Size = new System.Drawing.Size(96, 23);
            this.lblselectyear.TabIndex = 1;
            this.lblselectyear.Text = "Select Year";
            // 
            // Admin_PayrollManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 782);
            this.Controls.Add(this.viewemppayrollPanel);
            this.Controls.Add(this.topLoginPanel);
            this.Controls.Add(this.payrollProcessingPanel);
            this.Name = "Admin_PayrollManagement";
            this.Text = "Admin_PayrollManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.topLoginPanel.ResumeLayout(false);
            this.topLoginPanel.PerformLayout();
            this.payrollProcessingPanel.ResumeLayout(false);
            this.payrollProcessingPanel.PerformLayout();
            this.viewemppayrollPanel.ResumeLayout(false);
            this.viewemppayrollPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbselectmonth;
        private System.Windows.Forms.Button btngeneratepayroll;
        private System.Windows.Forms.TextBox txtpayrollid;
        private System.Windows.Forms.Label lblpayrollid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblerroryearpayroll;
        private System.Windows.Forms.Label lblerrormonthpayroll;
        private System.Windows.Forms.Label lblerrormonth;
        private System.Windows.Forms.Button btnreset2;
        private System.Windows.Forms.Label lblerrorempidpayroll;
        private System.Windows.Forms.Label lblpayrollbreakdown;
        private System.Windows.Forms.Label lblempinfopayroll;
        private System.Windows.Forms.TextBox txtnetsalarypayroll;
        private System.Windows.Forms.Label lblnetsalarypayroll;
        private System.Windows.Forms.TextBox txttotaldeductionpayroll;
        private System.Windows.Forms.Label lblerroryear;
        private System.Windows.Forms.ComboBox cmbselectyear;
        private System.Windows.Forms.Label lbltotaldeductionpayroll;
        private System.Windows.Forms.TextBox txtgrosssalarypayroll;
        private System.Windows.Forms.TextBox txtyearpayroll;
        private System.Windows.Forms.Label lblyearpayroll;
        private System.Windows.Forms.TextBox txtmonthpayroll;
        private System.Windows.Forms.Label lblmonthpayroll;
        private System.Windows.Forms.TextBox txtjobtitlepayroll;
        private System.Windows.Forms.Label lbljobtitlepayroll;
        private System.Windows.Forms.Button btnBackToHR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnviewemppayroll;
        private System.Windows.Forms.Label lblgrosssalarypayroll;
        private System.Windows.Forms.Label lblselectmonth;
        private System.Windows.Forms.TextBox txtdepartmentpayroll;
        private System.Windows.Forms.Panel topLoginPanel;
        private System.Windows.Forms.Label topHeaderLogin;
        private System.Windows.Forms.Panel payrollProcessingPanel;
        private System.Windows.Forms.Panel viewemppayrollPanel;
        private System.Windows.Forms.Label lbldepartmentpayroll;
        private System.Windows.Forms.TextBox txtempnamepayroll;
        private System.Windows.Forms.Label lblempnamepayroll;
        private System.Windows.Forms.Button btnresetpayroll;
        private System.Windows.Forms.ComboBox cmbselectmonthpayroll;
        private System.Windows.Forms.Label lblselectmonthpayroll;
        private System.Windows.Forms.Label lblselectyearpayroll;
        private System.Windows.Forms.TextBox txtempidpayroll;
        private System.Windows.Forms.ComboBox cmbselectyearpayroll;
        private System.Windows.Forms.Button btnsearch2;
        private System.Windows.Forms.Label lblempidpayroll;
        private System.Windows.Forms.Label lblviewemppayroll;
        private System.Windows.Forms.Label lblselectyear;
    }
}