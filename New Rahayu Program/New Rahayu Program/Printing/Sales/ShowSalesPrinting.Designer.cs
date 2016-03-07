namespace Rahayu_Program.Printing.Sales
{
    partial class ShowSalesPrinting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridSalesHeader = new System.Windows.Forms.DataGridView();
            this.gridSalesDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalHargaAsli = new System.Windows.Forms.TextBox();
            this.tbTotalHargaMaterial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalHargaOngkosCetak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalHargaNota = new System.Windows.Forms.TextBox();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnShowTransaction = new System.Windows.Forms.Button();
            this.btnSudahCetak = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSudahFinishing = new System.Windows.Forms.Button();
            this.btnSudahPacking = new System.Windows.Forms.Button();
            this.btnSudahSelesai = new System.Windows.Forms.Button();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.gridSalesPayment = new System.Windows.Forms.DataGridView();
            this.btnFileSiap = new System.Windows.Forms.Button();
            this.tbStatusBayar = new System.Windows.Forms.TextBox();
            this.btnHapusBayar = new System.Windows.Forms.Button();
            this.btnUbahBayar = new System.Windows.Forms.Button();
            this.btnBuatBayar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefreshHeader = new System.Windows.Forms.Button();
            this.btnSearchHeader = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbViewSalesID = new System.Windows.Forms.TextBox();
            this.tbViewHargaMaterial = new System.Windows.Forms.TextBox();
            this.tbViewHargaOngkosCetak = new System.Windows.Forms.TextBox();
            this.tbViewHargaTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbViewHargaAsli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.pnlStatusBayar = new System.Windows.Forms.Panel();
            this.btnPrintWO = new System.Windows.Forms.Button();
            this.btnSuratJalan = new System.Windows.Forms.Button();
            this.btnPrintInvoiceKecil = new System.Windows.Forms.Button();
            this.btnTukerFaktur = new System.Windows.Forms.Button();
            this.btnOFFER = new System.Windows.Forms.Button();
            this.btnSALE = new System.Windows.Forms.Button();
            this.rbPPh21 = new System.Windows.Forms.RadioButton();
            this.rbPPh23 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHutangPerCust = new System.Windows.Forms.Button();
            this.btnPenawaranHarga = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.labelasd = new System.Windows.Forms.Label();
            this.tbTotalBayar = new System.Windows.Forms.TextBox();
            this.tbKurangBayar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesPayment)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSalesHeader
            // 
            this.gridSalesHeader.AllowUserToAddRows = false;
            this.gridSalesHeader.AllowUserToDeleteRows = false;
            this.gridSalesHeader.AllowUserToResizeColumns = false;
            this.gridSalesHeader.AllowUserToResizeRows = false;
            this.gridSalesHeader.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.gridSalesHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSalesHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesHeader.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridSalesHeader.GridColor = System.Drawing.Color.Green;
            this.gridSalesHeader.Location = new System.Drawing.Point(12, 86);
            this.gridSalesHeader.MultiSelect = false;
            this.gridSalesHeader.Name = "gridSalesHeader";
            this.gridSalesHeader.ReadOnly = true;
            this.gridSalesHeader.RowHeadersVisible = false;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesHeader.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridSalesHeader.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesHeader.RowTemplate.Height = 28;
            this.gridSalesHeader.RowTemplate.ReadOnly = true;
            this.gridSalesHeader.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSalesHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSalesHeader.Size = new System.Drawing.Size(480, 714);
            this.gridSalesHeader.TabIndex = 4;
            this.gridSalesHeader.TabStop = false;
            this.gridSalesHeader.SelectionChanged += new System.EventHandler(this.gridSalesHeader_SelectionChanged);
            // 
            // gridSalesDetail
            // 
            this.gridSalesDetail.AllowUserToAddRows = false;
            this.gridSalesDetail.AllowUserToDeleteRows = false;
            this.gridSalesDetail.AllowUserToResizeColumns = false;
            this.gridSalesDetail.AllowUserToResizeRows = false;
            this.gridSalesDetail.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.gridSalesDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSalesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridSalesDetail.GridColor = System.Drawing.Color.Green;
            this.gridSalesDetail.Location = new System.Drawing.Point(498, 122);
            this.gridSalesDetail.MultiSelect = false;
            this.gridSalesDetail.Name = "gridSalesDetail";
            this.gridSalesDetail.ReadOnly = true;
            this.gridSalesDetail.RowHeadersVisible = false;
            this.gridSalesDetail.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesDetail.RowTemplate.Height = 28;
            this.gridSalesDetail.RowTemplate.ReadOnly = true;
            this.gridSalesDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSalesDetail.Size = new System.Drawing.Size(810, 150);
            this.gridSalesDetail.TabIndex = 6;
            this.gridSalesDetail.TabStop = false;
            this.gridSalesDetail.SelectionChanged += new System.EventHandler(this.gridSalesDetail_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total Harga Asli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Total Harga Material";
            // 
            // tbTotalHargaAsli
            // 
            this.tbTotalHargaAsli.Location = new System.Drawing.Point(713, 679);
            this.tbTotalHargaAsli.Name = "tbTotalHargaAsli";
            this.tbTotalHargaAsli.Size = new System.Drawing.Size(193, 29);
            this.tbTotalHargaAsli.TabIndex = 33;
            // 
            // tbTotalHargaMaterial
            // 
            this.tbTotalHargaMaterial.Location = new System.Drawing.Point(713, 709);
            this.tbTotalHargaMaterial.Name = "tbTotalHargaMaterial";
            this.tbTotalHargaMaterial.Size = new System.Drawing.Size(193, 29);
            this.tbTotalHargaMaterial.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 742);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total Harga Ongkos Cetak";
            // 
            // tbTotalHargaOngkosCetak
            // 
            this.tbTotalHargaOngkosCetak.Location = new System.Drawing.Point(713, 739);
            this.tbTotalHargaOngkosCetak.Name = "tbTotalHargaOngkosCetak";
            this.tbTotalHargaOngkosCetak.Size = new System.Drawing.Size(193, 29);
            this.tbTotalHargaOngkosCetak.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 772);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total Harga Di Nota";
            // 
            // tbTotalHargaNota
            // 
            this.tbTotalHargaNota.Location = new System.Drawing.Point(713, 769);
            this.tbTotalHargaNota.Name = "tbTotalHargaNota";
            this.tbTotalHargaNota.Size = new System.Drawing.Size(193, 29);
            this.tbTotalHargaNota.TabIndex = 39;
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTransaction.Location = new System.Drawing.Point(501, 341);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(100, 55);
            this.btnDeleteTransaction.TabIndex = 8;
            this.btnDeleteTransaction.Text = "Hapus Transaksi";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Visible = false;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnShowTransaction
            // 
            this.btnShowTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTransaction.Location = new System.Drawing.Point(607, 341);
            this.btnShowTransaction.Name = "btnShowTransaction";
            this.btnShowTransaction.Size = new System.Drawing.Size(100, 55);
            this.btnShowTransaction.TabIndex = 9;
            this.btnShowTransaction.Text = "Lihat Transaksi";
            this.btnShowTransaction.UseVisualStyleBackColor = true;
            this.btnShowTransaction.Click += new System.EventHandler(this.btnShowTransaction_Click);
            // 
            // btnSudahCetak
            // 
            this.btnSudahCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSudahCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSudahCetak.Location = new System.Drawing.Point(607, 488);
            this.btnSudahCetak.Name = "btnSudahCetak";
            this.btnSudahCetak.Size = new System.Drawing.Size(100, 55);
            this.btnSudahCetak.TabIndex = 22;
            this.btnSudahCetak.Text = "Sudah Cetak";
            this.btnSudahCetak.UseVisualStyleBackColor = true;
            this.btnSudahCetak.Click += new System.EventHandler(this.btnSudahCetak_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "* Ubah Transaksi, pada menu Lihat Transaksi";
            // 
            // btnSudahFinishing
            // 
            this.btnSudahFinishing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSudahFinishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSudahFinishing.Location = new System.Drawing.Point(713, 488);
            this.btnSudahFinishing.Name = "btnSudahFinishing";
            this.btnSudahFinishing.Size = new System.Drawing.Size(100, 55);
            this.btnSudahFinishing.TabIndex = 23;
            this.btnSudahFinishing.Text = "Sudah Finishing";
            this.btnSudahFinishing.UseVisualStyleBackColor = true;
            this.btnSudahFinishing.Click += new System.EventHandler(this.btnSudahFinishing_Click);
            // 
            // btnSudahPacking
            // 
            this.btnSudahPacking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSudahPacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSudahPacking.Location = new System.Drawing.Point(819, 488);
            this.btnSudahPacking.Name = "btnSudahPacking";
            this.btnSudahPacking.Size = new System.Drawing.Size(100, 55);
            this.btnSudahPacking.TabIndex = 24;
            this.btnSudahPacking.Text = "Sudah Bungkus";
            this.btnSudahPacking.UseVisualStyleBackColor = true;
            this.btnSudahPacking.Click += new System.EventHandler(this.btnSudahPacking_Click);
            // 
            // btnSudahSelesai
            // 
            this.btnSudahSelesai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSudahSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSudahSelesai.Location = new System.Drawing.Point(925, 488);
            this.btnSudahSelesai.Name = "btnSudahSelesai";
            this.btnSudahSelesai.Size = new System.Drawing.Size(100, 55);
            this.btnSudahSelesai.TabIndex = 25;
            this.btnSudahSelesai.Text = "Sudah Diantar";
            this.btnSudahSelesai.UseVisualStyleBackColor = true;
            this.btnSudahSelesai.Click += new System.EventHandler(this.btnSudahSelesai_Click);
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTransaction.Location = new System.Drawing.Point(713, 341);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(100, 55);
            this.btnCreateTransaction.TabIndex = 10;
            this.btnCreateTransaction.Text = "Buat Transaksi";
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            this.btnCreateTransaction.Click += new System.EventHandler(this.btnCreateTransaction_Click);
            // 
            // gridSalesPayment
            // 
            this.gridSalesPayment.AllowUserToAddRows = false;
            this.gridSalesPayment.AllowUserToDeleteRows = false;
            this.gridSalesPayment.AllowUserToResizeColumns = false;
            this.gridSalesPayment.AllowUserToResizeRows = false;
            this.gridSalesPayment.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.gridSalesPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSalesPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesPayment.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridSalesPayment.GridColor = System.Drawing.Color.Green;
            this.gridSalesPayment.Location = new System.Drawing.Point(498, 549);
            this.gridSalesPayment.MultiSelect = false;
            this.gridSalesPayment.Name = "gridSalesPayment";
            this.gridSalesPayment.ReadOnly = true;
            this.gridSalesPayment.RowHeadersVisible = false;
            this.gridSalesPayment.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSalesPayment.RowTemplate.Height = 28;
            this.gridSalesPayment.RowTemplate.ReadOnly = true;
            this.gridSalesPayment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSalesPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSalesPayment.Size = new System.Drawing.Size(570, 103);
            this.gridSalesPayment.TabIndex = 26;
            this.gridSalesPayment.TabStop = false;
            this.gridSalesPayment.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridSalesPayment_RowStateChanged);
            // 
            // btnFileSiap
            // 
            this.btnFileSiap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFileSiap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSiap.Location = new System.Drawing.Point(501, 488);
            this.btnFileSiap.Name = "btnFileSiap";
            this.btnFileSiap.Size = new System.Drawing.Size(100, 55);
            this.btnFileSiap.TabIndex = 21;
            this.btnFileSiap.Text = "File Sudah Siap";
            this.btnFileSiap.UseVisualStyleBackColor = true;
            this.btnFileSiap.Click += new System.EventHandler(this.btnFileSiap_Click);
            // 
            // tbStatusBayar
            // 
            this.tbStatusBayar.BackColor = System.Drawing.Color.Green;
            this.tbStatusBayar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusBayar.ForeColor = System.Drawing.Color.White;
            this.tbStatusBayar.Location = new System.Drawing.Point(518, 652);
            this.tbStatusBayar.Name = "tbStatusBayar";
            this.tbStatusBayar.Size = new System.Drawing.Size(550, 22);
            this.tbStatusBayar.TabIndex = 28;
            this.tbStatusBayar.Text = "BELUM BAYAR";
            this.tbStatusBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHapusBayar
            // 
            this.btnHapusBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapusBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusBayar.Location = new System.Drawing.Point(1074, 550);
            this.btnHapusBayar.Name = "btnHapusBayar";
            this.btnHapusBayar.Size = new System.Drawing.Size(234, 37);
            this.btnHapusBayar.TabIndex = 29;
            this.btnHapusBayar.Text = "Hapus Pembayaran";
            this.btnHapusBayar.UseVisualStyleBackColor = true;
            this.btnHapusBayar.Click += new System.EventHandler(this.btnHapusBayar_Click);
            // 
            // btnUbahBayar
            // 
            this.btnUbahBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUbahBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbahBayar.Location = new System.Drawing.Point(1074, 593);
            this.btnUbahBayar.Name = "btnUbahBayar";
            this.btnUbahBayar.Size = new System.Drawing.Size(234, 37);
            this.btnUbahBayar.TabIndex = 30;
            this.btnUbahBayar.Text = "Ubah Pembayaran";
            this.btnUbahBayar.UseVisualStyleBackColor = true;
            this.btnUbahBayar.Click += new System.EventHandler(this.btnUbahBayar_Click);
            // 
            // btnBuatBayar
            // 
            this.btnBuatBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuatBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuatBayar.Location = new System.Drawing.Point(1074, 636);
            this.btnBuatBayar.Name = "btnBuatBayar";
            this.btnBuatBayar.Size = new System.Drawing.Size(234, 37);
            this.btnBuatBayar.TabIndex = 31;
            this.btnBuatBayar.Text = "Buat Pembayaran";
            this.btnBuatBayar.UseVisualStyleBackColor = true;
            this.btnBuatBayar.Click += new System.EventHandler(this.btnBuatBayar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Penjualan Cetak";
            // 
            // btnRefreshHeader
            // 
            this.btnRefreshHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshHeader.Location = new System.Drawing.Point(395, 49);
            this.btnRefreshHeader.Name = "btnRefreshHeader";
            this.btnRefreshHeader.Size = new System.Drawing.Size(81, 31);
            this.btnRefreshHeader.TabIndex = 3;
            this.btnRefreshHeader.Text = "Refresh";
            this.btnRefreshHeader.UseVisualStyleBackColor = true;
            this.btnRefreshHeader.Click += new System.EventHandler(this.btnRefreshHeader_Click);
            // 
            // btnSearchHeader
            // 
            this.btnSearchHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchHeader.Location = new System.Drawing.Point(395, 12);
            this.btnSearchHeader.Name = "btnSearchHeader";
            this.btnSearchHeader.Size = new System.Drawing.Size(81, 31);
            this.btnSearchHeader.TabIndex = 2;
            this.btnSearchHeader.Text = "Cari";
            this.btnSearchHeader.UseVisualStyleBackColor = true;
            this.btnSearchHeader.Click += new System.EventHandler(this.btnSearchHeader_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "* Cuma tampilkan transaksi selama 6 bulan";
            // 
            // tbViewSalesID
            // 
            this.tbViewSalesID.BackColor = System.Drawing.Color.Green;
            this.tbViewSalesID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbViewSalesID.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.tbViewSalesID.ForeColor = System.Drawing.Color.White;
            this.tbViewSalesID.Location = new System.Drawing.Point(498, 86);
            this.tbViewSalesID.Name = "tbViewSalesID";
            this.tbViewSalesID.Size = new System.Drawing.Size(810, 36);
            this.tbViewSalesID.TabIndex = 5;
            this.tbViewSalesID.Text = "No. Nota : 0000000001";
            this.tbViewSalesID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbViewHargaMaterial
            // 
            this.tbViewHargaMaterial.BackColor = System.Drawing.Color.Green;
            this.tbViewHargaMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbViewHargaMaterial.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbViewHargaMaterial.ForeColor = System.Drawing.Color.White;
            this.tbViewHargaMaterial.Location = new System.Drawing.Point(204, 29);
            this.tbViewHargaMaterial.Name = "tbViewHargaMaterial";
            this.tbViewHargaMaterial.Size = new System.Drawing.Size(201, 32);
            this.tbViewHargaMaterial.TabIndex = 5;
            this.tbViewHargaMaterial.Text = "0";
            this.tbViewHargaMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbViewHargaOngkosCetak
            // 
            this.tbViewHargaOngkosCetak.BackColor = System.Drawing.Color.Green;
            this.tbViewHargaOngkosCetak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbViewHargaOngkosCetak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbViewHargaOngkosCetak.ForeColor = System.Drawing.Color.White;
            this.tbViewHargaOngkosCetak.Location = new System.Drawing.Point(406, 29);
            this.tbViewHargaOngkosCetak.Name = "tbViewHargaOngkosCetak";
            this.tbViewHargaOngkosCetak.Size = new System.Drawing.Size(200, 32);
            this.tbViewHargaOngkosCetak.TabIndex = 6;
            this.tbViewHargaOngkosCetak.Text = "0";
            this.tbViewHargaOngkosCetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbViewHargaTotal
            // 
            this.tbViewHargaTotal.BackColor = System.Drawing.Color.Green;
            this.tbViewHargaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbViewHargaTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbViewHargaTotal.ForeColor = System.Drawing.Color.White;
            this.tbViewHargaTotal.Location = new System.Drawing.Point(607, 29);
            this.tbViewHargaTotal.Name = "tbViewHargaTotal";
            this.tbViewHargaTotal.Size = new System.Drawing.Size(200, 32);
            this.tbViewHargaTotal.TabIndex = 7;
            this.tbViewHargaTotal.Text = "0";
            this.tbViewHargaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Harga Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Harga Ongkos Cetak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Harga Total Di Nota";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1182, 761);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 39);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tbViewHargaAsli);
            this.panel1.Controls.Add(this.tbViewHargaMaterial);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbViewHargaTotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbViewHargaOngkosCetak);
            this.panel1.Controls.Add(this.label10);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(498, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 64);
            this.panel1.TabIndex = 7;
            // 
            // tbViewHargaAsli
            // 
            this.tbViewHargaAsli.BackColor = System.Drawing.Color.Green;
            this.tbViewHargaAsli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbViewHargaAsli.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbViewHargaAsli.ForeColor = System.Drawing.Color.White;
            this.tbViewHargaAsli.Location = new System.Drawing.Point(3, 29);
            this.tbViewHargaAsli.Name = "tbViewHargaAsli";
            this.tbViewHargaAsli.Size = new System.Drawing.Size(200, 32);
            this.tbViewHargaAsli.TabIndex = 4;
            this.tbViewHargaAsli.Text = "0";
            this.tbViewHargaAsli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Harga Asli";
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Location = new System.Drawing.Point(1036, 341);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(100, 55);
            this.btnPrintInvoice.TabIndex = 13;
            this.btnPrintInvoice.Text = "Cetak Nota";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // pnlStatusBayar
            // 
            this.pnlStatusBayar.BackColor = System.Drawing.Color.Green;
            this.pnlStatusBayar.Location = new System.Drawing.Point(498, 652);
            this.pnlStatusBayar.Name = "pnlStatusBayar";
            this.pnlStatusBayar.Size = new System.Drawing.Size(22, 22);
            this.pnlStatusBayar.TabIndex = 27;
            // 
            // btnPrintWO
            // 
            this.btnPrintWO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintWO.Location = new System.Drawing.Point(713, 402);
            this.btnPrintWO.Name = "btnPrintWO";
            this.btnPrintWO.Size = new System.Drawing.Size(100, 55);
            this.btnPrintWO.TabIndex = 17;
            this.btnPrintWO.Text = "Cetak WO / SPK";
            this.btnPrintWO.UseVisualStyleBackColor = true;
            this.btnPrintWO.Click += new System.EventHandler(this.btnPrintWO_Click);
            // 
            // btnSuratJalan
            // 
            this.btnSuratJalan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuratJalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuratJalan.Location = new System.Drawing.Point(819, 341);
            this.btnSuratJalan.Name = "btnSuratJalan";
            this.btnSuratJalan.Size = new System.Drawing.Size(105, 55);
            this.btnSuratJalan.TabIndex = 11;
            this.btnSuratJalan.Text = "Cetak Surat Jalan";
            this.btnSuratJalan.UseVisualStyleBackColor = true;
            this.btnSuratJalan.Click += new System.EventHandler(this.btnSuratJalan_Click);
            // 
            // btnPrintInvoiceKecil
            // 
            this.btnPrintInvoiceKecil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintInvoiceKecil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoiceKecil.Location = new System.Drawing.Point(1036, 402);
            this.btnPrintInvoiceKecil.Name = "btnPrintInvoiceKecil";
            this.btnPrintInvoiceKecil.Size = new System.Drawing.Size(100, 55);
            this.btnPrintInvoiceKecil.TabIndex = 19;
            this.btnPrintInvoiceKecil.Text = "Cetak Nota Kecil";
            this.btnPrintInvoiceKecil.UseVisualStyleBackColor = true;
            this.btnPrintInvoiceKecil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTukerFaktur
            // 
            this.btnTukerFaktur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTukerFaktur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTukerFaktur.Location = new System.Drawing.Point(930, 341);
            this.btnTukerFaktur.Name = "btnTukerFaktur";
            this.btnTukerFaktur.Size = new System.Drawing.Size(100, 55);
            this.btnTukerFaktur.TabIndex = 12;
            this.btnTukerFaktur.Text = "Tuker Faktur";
            this.btnTukerFaktur.UseVisualStyleBackColor = true;
            this.btnTukerFaktur.Click += new System.EventHandler(this.btnTukerFaktur_Click);
            // 
            // btnOFFER
            // 
            this.btnOFFER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOFFER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOFFER.Location = new System.Drawing.Point(607, 402);
            this.btnOFFER.Name = "btnOFFER";
            this.btnOFFER.Size = new System.Drawing.Size(100, 55);
            this.btnOFFER.TabIndex = 16;
            this.btnOFFER.Text = "To OFFER";
            this.btnOFFER.UseVisualStyleBackColor = true;
            this.btnOFFER.Click += new System.EventHandler(this.btnOFFER_Click);
            // 
            // btnSALE
            // 
            this.btnSALE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSALE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALE.Location = new System.Drawing.Point(501, 402);
            this.btnSALE.Name = "btnSALE";
            this.btnSALE.Size = new System.Drawing.Size(100, 55);
            this.btnSALE.TabIndex = 15;
            this.btnSALE.Text = "To SALE";
            this.btnSALE.UseVisualStyleBackColor = true;
            this.btnSALE.Click += new System.EventHandler(this.btnSALE_Click);
            // 
            // rbPPh21
            // 
            this.rbPPh21.AutoSize = true;
            this.rbPPh21.Location = new System.Drawing.Point(6, 3);
            this.rbPPh21.Name = "rbPPh21";
            this.rbPPh21.Size = new System.Drawing.Size(80, 25);
            this.rbPPh21.TabIndex = 0;
            this.rbPPh21.TabStop = true;
            this.rbPPh21.Text = "PPh 21";
            this.rbPPh21.UseVisualStyleBackColor = true;
            // 
            // rbPPh23
            // 
            this.rbPPh23.AutoSize = true;
            this.rbPPh23.Location = new System.Drawing.Point(6, 26);
            this.rbPPh23.Name = "rbPPh23";
            this.rbPPh23.Size = new System.Drawing.Size(80, 25);
            this.rbPPh23.TabIndex = 1;
            this.rbPPh23.TabStop = true;
            this.rbPPh23.Text = "PPh 23";
            this.rbPPh23.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.rbPPh21);
            this.panel2.Controls.Add(this.rbPPh23);
            this.panel2.Location = new System.Drawing.Point(1139, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 55);
            this.panel2.TabIndex = 14;
            // 
            // btnHutangPerCust
            // 
            this.btnHutangPerCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHutangPerCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHutangPerCust.Location = new System.Drawing.Point(930, 402);
            this.btnHutangPerCust.Name = "btnHutangPerCust";
            this.btnHutangPerCust.Size = new System.Drawing.Size(100, 55);
            this.btnHutangPerCust.TabIndex = 44;
            this.btnHutangPerCust.Text = "Hutang PerCust";
            this.btnHutangPerCust.UseVisualStyleBackColor = true;
            this.btnHutangPerCust.Click += new System.EventHandler(this.btnHutangPerCust_Click);
            // 
            // btnPenawaranHarga
            // 
            this.btnPenawaranHarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPenawaranHarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenawaranHarga.Location = new System.Drawing.Point(819, 402);
            this.btnPenawaranHarga.Name = "btnPenawaranHarga";
            this.btnPenawaranHarga.Size = new System.Drawing.Size(105, 55);
            this.btnPenawaranHarga.TabIndex = 18;
            this.btnPenawaranHarga.Text = "Penawaran Harga";
            this.btnPenawaranHarga.UseVisualStyleBackColor = true;
            this.btnPenawaranHarga.Click += new System.EventHandler(this.btnPenawaran_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(929, 682);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "Total BAYAR";
            // 
            // labelasd
            // 
            this.labelasd.AutoSize = true;
            this.labelasd.Location = new System.Drawing.Point(929, 721);
            this.labelasd.Name = "labelasd";
            this.labelasd.Size = new System.Drawing.Size(133, 21);
            this.labelasd.TabIndex = 34;
            this.labelasd.Text = "KURANG BAYAR";
            // 
            // tbTotalBayar
            // 
            this.tbTotalBayar.Location = new System.Drawing.Point(1074, 679);
            this.tbTotalBayar.Name = "tbTotalBayar";
            this.tbTotalBayar.Size = new System.Drawing.Size(193, 29);
            this.tbTotalBayar.TabIndex = 33;
            // 
            // tbKurangBayar
            // 
            this.tbKurangBayar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbKurangBayar.Location = new System.Drawing.Point(1074, 709);
            this.tbKurangBayar.Name = "tbKurangBayar";
            this.tbKurangBayar.Size = new System.Drawing.Size(193, 39);
            this.tbKurangBayar.TabIndex = 35;
            // 
            // ShowSalesPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1320, 812);
            this.Controls.Add(this.btnHutangPerCust);
            this.Controls.Add(this.btnPenawaranHarga);
            this.Controls.Add(this.btnOFFER);
            this.Controls.Add(this.btnSALE);
            this.Controls.Add(this.btnTukerFaktur);
            this.Controls.Add(this.btnPrintInvoiceKecil);
            this.Controls.Add(this.btnSuratJalan);
            this.Controls.Add(this.btnPrintWO);
            this.Controls.Add(this.pnlStatusBayar);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbViewSalesID);
            this.Controls.Add(this.tbStatusBayar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSudahSelesai);
            this.Controls.Add(this.btnSudahPacking);
            this.Controls.Add(this.btnSudahFinishing);
            this.Controls.Add(this.btnFileSiap);
            this.Controls.Add(this.btnSudahCetak);
            this.Controls.Add(this.btnBuatBayar);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.btnUbahBayar);
            this.Controls.Add(this.btnShowTransaction);
            this.Controls.Add(this.btnHapusBayar);
            this.Controls.Add(this.btnSearchHeader);
            this.Controls.Add(this.btnRefreshHeader);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.tbTotalHargaNota);
            this.Controls.Add(this.tbTotalHargaOngkosCetak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKurangBayar);
            this.Controls.Add(this.tbTotalHargaMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotalBayar);
            this.Controls.Add(this.tbTotalHargaAsli);
            this.Controls.Add(this.labelasd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSalesPayment);
            this.Controls.Add(this.gridSalesDetail);
            this.Controls.Add(this.gridSalesHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ShowSalesPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ShowSalesPrinting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesPayment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSalesHeader;
        private System.Windows.Forms.DataGridView gridSalesDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalHargaAsli;
        private System.Windows.Forms.TextBox tbTotalHargaMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalHargaOngkosCetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotalHargaNota;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnShowTransaction;
        private System.Windows.Forms.Button btnSudahCetak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSudahFinishing;
        private System.Windows.Forms.Button btnSudahPacking;
        private System.Windows.Forms.Button btnSudahSelesai;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.DataGridView gridSalesPayment;
        private System.Windows.Forms.Button btnFileSiap;
        private System.Windows.Forms.TextBox tbStatusBayar;
        private System.Windows.Forms.Button btnHapusBayar;
        private System.Windows.Forms.Button btnUbahBayar;
        private System.Windows.Forms.Button btnBuatBayar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefreshHeader;
        private System.Windows.Forms.Button btnSearchHeader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbViewSalesID;
        private System.Windows.Forms.TextBox tbViewHargaMaterial;
        private System.Windows.Forms.TextBox tbViewHargaOngkosCetak;
        private System.Windows.Forms.TextBox tbViewHargaTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbViewHargaAsli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Panel pnlStatusBayar;
        private System.Windows.Forms.Button btnPrintWO;
        private System.Windows.Forms.Button btnSuratJalan;
        private System.Windows.Forms.Button btnPrintInvoiceKecil;
        private System.Windows.Forms.Button btnTukerFaktur;
        private System.Windows.Forms.Button btnOFFER;
        private System.Windows.Forms.Button btnSALE;
        private System.Windows.Forms.RadioButton rbPPh21;
        private System.Windows.Forms.RadioButton rbPPh23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHutangPerCust;
        private System.Windows.Forms.Button btnPenawaranHarga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelasd;
        private System.Windows.Forms.TextBox tbTotalBayar;
        private System.Windows.Forms.TextBox tbKurangBayar;
    }
}