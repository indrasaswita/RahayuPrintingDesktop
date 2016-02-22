namespace Rahayu_Program.PVC.Sales
{
    partial class ViewAllSales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridHeader = new System.Windows.Forms.DataGridView();
            this.btnGoToBottom = new System.Windows.Forms.Button();
            this.btnGoToTop = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.gridPayment = new System.Windows.Forms.DataGridView();
            this.nudBayar = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHutang = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbTotalHutang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPayPerCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnBayar2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteHeader = new System.Windows.Forms.Button();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTransferPVC = new System.Windows.Forms.Button();
            this.btnCreateSales = new System.Windows.Forms.Button();
            this.btnPrintNota = new System.Windows.Forms.Button();
            this.btnRefreshHeader = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridHeader
            // 
            this.gridHeader.AllowUserToAddRows = false;
            this.gridHeader.AllowUserToDeleteRows = false;
            this.gridHeader.AllowUserToResizeColumns = false;
            this.gridHeader.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.gridHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridHeader.BackgroundColor = System.Drawing.Color.White;
            this.gridHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHeader.DefaultCellStyle = dataGridViewCellStyle10;
            this.gridHeader.Location = new System.Drawing.Point(12, 46);
            this.gridHeader.Name = "gridHeader";
            this.gridHeader.ReadOnly = true;
            this.gridHeader.RowHeadersVisible = false;
            this.gridHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHeader.Size = new System.Drawing.Size(375, 688);
            this.gridHeader.TabIndex = 18;
            this.gridHeader.SelectionChanged += new System.EventHandler(this.gridHeader_SelectionChanged);
            // 
            // btnGoToBottom
            // 
            this.btnGoToBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToBottom.BackgroundImage")));
            this.btnGoToBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToBottom.ForeColor = System.Drawing.Color.White;
            this.btnGoToBottom.Location = new System.Drawing.Point(393, 684);
            this.btnGoToBottom.Name = "btnGoToBottom";
            this.btnGoToBottom.Size = new System.Drawing.Size(50, 50);
            this.btnGoToBottom.TabIndex = 19;
            this.btnGoToBottom.UseVisualStyleBackColor = true;
            this.btnGoToBottom.Click += new System.EventHandler(this.btnGoToBottom_Click);
            // 
            // btnGoToTop
            // 
            this.btnGoToTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToTop.BackgroundImage")));
            this.btnGoToTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToTop.ForeColor = System.Drawing.Color.White;
            this.btnGoToTop.Location = new System.Drawing.Point(393, 628);
            this.btnGoToTop.Name = "btnGoToTop";
            this.btnGoToTop.Size = new System.Drawing.Size(50, 50);
            this.btnGoToTop.TabIndex = 19;
            this.btnGoToTop.UseVisualStyleBackColor = true;
            this.btnGoToTop.Click += new System.EventHandler(this.btnGoToTop_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(374, 27);
            this.tbSearch.TabIndex = 20;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panelDetail
            // 
            this.panelDetail.AutoScroll = true;
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.Location = new System.Drawing.Point(393, 13);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(301, 233);
            this.panelDetail.TabIndex = 21;
            // 
            // gridPayment
            // 
            this.gridPayment.AllowUserToAddRows = false;
            this.gridPayment.AllowUserToDeleteRows = false;
            this.gridPayment.AllowUserToResizeColumns = false;
            this.gridPayment.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.gridPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridPayment.BackgroundColor = System.Drawing.Color.White;
            this.gridPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPayment.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridPayment.Location = new System.Drawing.Point(700, 12);
            this.gridPayment.Name = "gridPayment";
            this.gridPayment.ReadOnly = true;
            this.gridPayment.RowHeadersVisible = false;
            this.gridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPayment.Size = new System.Drawing.Size(350, 140);
            this.gridPayment.TabIndex = 18;
            // 
            // nudBayar
            // 
            this.nudBayar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nudBayar.Location = new System.Drawing.Point(907, 214);
            this.nudBayar.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudBayar.Name = "nudBayar";
            this.nudBayar.Size = new System.Drawing.Size(159, 32);
            this.nudBayar.TabIndex = 22;
            this.nudBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBayar.ThousandsSeparator = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1050, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(763, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "TOTAL BAYAR";
            // 
            // nudTotal
            // 
            this.nudTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nudTotal.Location = new System.Drawing.Point(551, 252);
            this.nudTotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(159, 32);
            this.nudTotal.TabIndex = 22;
            this.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(694, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 35);
            this.panel2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "TOTAL BELANJA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(743, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "TOTAL HUTANG";
            // 
            // tbHutang
            // 
            this.tbHutang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbHutang.Location = new System.Drawing.Point(907, 252);
            this.tbHutang.Name = "tbHutang";
            this.tbHutang.Size = new System.Drawing.Size(143, 32);
            this.tbHutang.TabIndex = 25;
            this.tbHutang.TextChanged += new System.EventHandler(this.tbHutang_TextChanged);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbCustomerName.Location = new System.Drawing.Point(117, 11);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(137, 29);
            this.tbCustomerName.TabIndex = 26;
            // 
            // tbTotalHutang
            // 
            this.tbTotalHutang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbTotalHutang.Location = new System.Drawing.Point(117, 46);
            this.tbTotalHutang.Name = "tbTotalHutang";
            this.tbTotalHutang.Size = new System.Drawing.Size(168, 29);
            this.tbTotalHutang.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hutang";
            // 
            // btnPayPerCustomer
            // 
            this.btnPayPerCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayPerCustomer.BackgroundImage")));
            this.btnPayPerCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayPerCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayPerCustomer.ForeColor = System.Drawing.Color.White;
            this.btnPayPerCustomer.Location = new System.Drawing.Point(155, 138);
            this.btnPayPerCustomer.Name = "btnPayPerCustomer";
            this.btnPayPerCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnPayPerCustomer.TabIndex = 19;
            this.btnPayPerCustomer.UseVisualStyleBackColor = true;
            this.btnPayPerCustomer.Click += new System.EventHandler(this.btnPayPerCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.BackgroundImage")));
            this.btnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Location = new System.Drawing.Point(258, 11);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(29, 29);
            this.btnSearchCustomer.TabIndex = 27;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowAll.BackgroundImage")));
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(49, 138);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 50);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnSearchCustomer);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbPhone);
            this.panel3.Controls.Add(this.tbTotalHutang);
            this.panel3.Controls.Add(this.btnShowAll);
            this.panel3.Controls.Add(this.tbCustomerName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnPayPerCustomer);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(393, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 314);
            this.panel3.TabIndex = 28;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbPhone.Location = new System.Drawing.Point(117, 81);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(168, 29);
            this.tbPhone.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone 1";
            // 
            // btnBayar
            // 
            this.btnBayar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBayar.BackgroundImage")));
            this.btnBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(825, 158);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(100, 50);
            this.btnBayar.TabIndex = 19;
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnBayar2
            // 
            this.btnBayar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBayar2.BackgroundImage")));
            this.btnBayar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBayar2.Enabled = false;
            this.btnBayar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar2.ForeColor = System.Drawing.Color.White;
            this.btnBayar2.Location = new System.Drawing.Point(825, 158);
            this.btnBayar2.Name = "btnBayar2";
            this.btnBayar2.Size = new System.Drawing.Size(100, 50);
            this.btnBayar2.TabIndex = 29;
            this.btnBayar2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(950, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 29;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteHeader.BackgroundImage")));
            this.btnDeleteHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHeader.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHeader.Location = new System.Drawing.Point(449, 684);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteHeader.TabIndex = 19;
            this.btnDeleteHeader.UseVisualStyleBackColor = true;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateDetail.BackgroundImage")));
            this.btnUpdateDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDetail.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDetail.Location = new System.Drawing.Point(719, 158);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateDetail.TabIndex = 19;
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePayment.BackgroundImage")));
            this.btnDeletePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePayment.ForeColor = System.Drawing.Color.White;
            this.btnDeletePayment.Location = new System.Drawing.Point(931, 158);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(100, 50);
            this.btnDeletePayment.TabIndex = 19;
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000000;
            // 
            // btnTransferPVC
            // 
            this.btnTransferPVC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransferPVC.BackgroundImage")));
            this.btnTransferPVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransferPVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferPVC.ForeColor = System.Drawing.Color.White;
            this.btnTransferPVC.Location = new System.Drawing.Point(555, 684);
            this.btnTransferPVC.Name = "btnTransferPVC";
            this.btnTransferPVC.Size = new System.Drawing.Size(100, 50);
            this.btnTransferPVC.TabIndex = 19;
            this.btnTransferPVC.UseVisualStyleBackColor = true;
            this.btnTransferPVC.Click += new System.EventHandler(this.btnTransferPVC_Click);
            // 
            // btnCreateSales
            // 
            this.btnCreateSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateSales.BackgroundImage")));
            this.btnCreateSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSales.ForeColor = System.Drawing.Color.White;
            this.btnCreateSales.Location = new System.Drawing.Point(661, 684);
            this.btnCreateSales.Name = "btnCreateSales";
            this.btnCreateSales.Size = new System.Drawing.Size(100, 50);
            this.btnCreateSales.TabIndex = 19;
            this.btnCreateSales.UseVisualStyleBackColor = true;
            this.btnCreateSales.Click += new System.EventHandler(this.btnCreateSales_Click);
            // 
            // btnPrintNota
            // 
            this.btnPrintNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintNota.ForeColor = System.Drawing.Color.White;
            this.btnPrintNota.Location = new System.Drawing.Point(449, 628);
            this.btnPrintNota.Name = "btnPrintNota";
            this.btnPrintNota.Size = new System.Drawing.Size(100, 50);
            this.btnPrintNota.TabIndex = 19;
            this.btnPrintNota.Text = "PRINT NOTA";
            this.btnPrintNota.UseVisualStyleBackColor = true;
            this.btnPrintNota.Click += new System.EventHandler(this.btnPrintNota_Click);
            // 
            // btnRefreshHeader
            // 
            this.btnRefreshHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshHeader.ForeColor = System.Drawing.Color.White;
            this.btnRefreshHeader.Location = new System.Drawing.Point(555, 628);
            this.btnRefreshHeader.Name = "btnRefreshHeader";
            this.btnRefreshHeader.Size = new System.Drawing.Size(100, 50);
            this.btnRefreshHeader.TabIndex = 19;
            this.btnRefreshHeader.Text = "REFRESH Header";
            this.btnRefreshHeader.UseVisualStyleBackColor = true;
            this.btnRefreshHeader.Click += new System.EventHandler(this.btnRefreshHeader_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cetak Daftar Hutang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAllSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1062, 746);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbHutang);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.btnCreateSales);
            this.Controls.Add(this.btnTransferPVC);
            this.Controls.Add(this.btnRefreshHeader);
            this.Controls.Add(this.btnPrintNota);
            this.Controls.Add(this.btnDeleteHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.nudBayar);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnGoToTop);
            this.Controls.Add(this.btnGoToBottom);
            this.Controls.Add(this.gridPayment);
            this.Controls.Add(this.gridHeader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBayar2);
            this.Controls.Add(this.btnBayar);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewAllSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllSales";
            this.Activated += new System.EventHandler(this.ViewAllSales_Activated);
            this.Load += new System.EventHandler(this.ViewAllSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHeader;
        private System.Windows.Forms.Button btnGoToBottom;
        private System.Windows.Forms.Button btnGoToTop;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridView gridPayment;
        private System.Windows.Forms.NumericUpDown nudBayar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHutang;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbTotalHutang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPayPerCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBayar2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteHeader;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTransferPVC;
        private System.Windows.Forms.Button btnCreateSales;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrintNota;
        private System.Windows.Forms.Button btnRefreshHeader;
        private System.Windows.Forms.Button button1;

    }
}