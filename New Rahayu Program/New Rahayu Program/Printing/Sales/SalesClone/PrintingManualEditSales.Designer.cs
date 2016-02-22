namespace Rahayu_Program.Printing.Sales.SalesClone
{
    partial class PrintingManualEditSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridHeader = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPurchaseNo = new System.Windows.Forms.TextBox();
            this.tbTerbilang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomerUp = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEditHeader = new System.Windows.Forms.Button();
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.btnAddNota = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJudul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTipe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudMaterial = new System.Windows.Forms.NumericUpDown();
            this.nudOngkosCetak = new System.Windows.Forms.NumericUpDown();
            this.nudTotalHarga = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOngkosCetak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buat NOTA MANUAL";
            // 
            // gridHeader
            // 
            this.gridHeader.AllowUserToAddRows = false;
            this.gridHeader.AllowUserToDeleteRows = false;
            this.gridHeader.AllowUserToResizeColumns = false;
            this.gridHeader.AllowUserToResizeRows = false;
            this.gridHeader.BackgroundColor = System.Drawing.Color.Cyan;
            this.gridHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHeader.Location = new System.Drawing.Point(12, 57);
            this.gridHeader.Name = "gridHeader";
            this.gridHeader.ReadOnly = true;
            this.gridHeader.RowHeadersVisible = false;
            this.gridHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHeader.Size = new System.Drawing.Size(480, 440);
            this.gridHeader.TabIndex = 2;
            this.gridHeader.SelectionChanged += new System.EventHandler(this.gridHeader_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "PO";
            // 
            // tbPurchaseNo
            // 
            this.tbPurchaseNo.Location = new System.Drawing.Point(103, 502);
            this.tbPurchaseNo.Name = "tbPurchaseNo";
            this.tbPurchaseNo.Size = new System.Drawing.Size(389, 29);
            this.tbPurchaseNo.TabIndex = 4;
            // 
            // tbTerbilang
            // 
            this.tbTerbilang.BackColor = System.Drawing.Color.Yellow;
            this.tbTerbilang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTerbilang.Location = new System.Drawing.Point(752, 465);
            this.tbTerbilang.Multiline = true;
            this.tbTerbilang.Name = "tbTerbilang";
            this.tbTerbilang.Size = new System.Drawing.Size(427, 50);
            this.tbTerbilang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "U/p.";
            // 
            // tbCustomerUp
            // 
            this.tbCustomerUp.Location = new System.Drawing.Point(103, 537);
            this.tbCustomerUp.Name = "tbCustomerUp";
            this.tbCustomerUp.Size = new System.Drawing.Size(389, 29);
            this.tbCustomerUp.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(417, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            this.gridDetail.AllowUserToResizeColumns = false;
            this.gridDetail.AllowUserToResizeRows = false;
            this.gridDetail.BackgroundColor = System.Drawing.Color.Cyan;
            this.gridDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetail.Location = new System.Drawing.Point(498, 57);
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.ReadOnly = true;
            this.gridDetail.RowHeadersVisible = false;
            this.gridDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetail.Size = new System.Drawing.Size(680, 196);
            this.gridDetail.TabIndex = 2;
            this.gridDetail.SelectionChanged += new System.EventHandler(this.gridDetail_SelectionChanged);
            this.gridDetail.DoubleClick += new System.EventHandler(this.gridDetail_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Deskripsi";
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(601, 329);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.ReadOnly = true;
            this.tbDeskripsi.Size = new System.Drawing.Size(577, 50);
            this.tbDeskripsi.TabIndex = 4;
            this.tbDeskripsi.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(632, 528);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 38);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print!";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEditHeader
            // 
            this.btnEditHeader.Location = new System.Drawing.Point(785, 528);
            this.btnEditHeader.Name = "btnEditHeader";
            this.btnEditHeader.Size = new System.Drawing.Size(147, 38);
            this.btnEditHeader.TabIndex = 6;
            this.btnEditHeader.Text = "Edit Nota";
            this.btnEditHeader.UseVisualStyleBackColor = true;
            this.btnEditHeader.Click += new System.EventHandler(this.btnEditHeader_Click);
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Location = new System.Drawing.Point(938, 528);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(147, 38);
            this.btnEditDetail.TabIndex = 6;
            this.btnEditDetail.Text = "Edit Detil";
            this.btnEditDetail.UseVisualStyleBackColor = true;
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnAddNota
            // 
            this.btnAddNota.Location = new System.Drawing.Point(1017, 16);
            this.btnAddNota.Name = "btnAddNota";
            this.btnAddNota.Size = new System.Drawing.Size(161, 35);
            this.btnAddNota.TabIndex = 5;
            this.btnAddNota.Text = "Tambah Nota Baru";
            this.btnAddNota.UseVisualStyleBackColor = true;
            this.btnAddNota.Click += new System.EventHandler(this.btnAddNota_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1091, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Judul Job";
            // 
            // tbJudul
            // 
            this.tbJudul.Location = new System.Drawing.Point(601, 259);
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.ReadOnly = true;
            this.tbJudul.Size = new System.Drawing.Size(577, 29);
            this.tbJudul.TabIndex = 4;
            this.tbJudul.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tipe Job";
            // 
            // tbTipe
            // 
            this.tbTipe.Location = new System.Drawing.Point(601, 294);
            this.tbTipe.Name = "tbTipe";
            this.tbTipe.ReadOnly = true;
            this.tbTipe.Size = new System.Drawing.Size(577, 29);
            this.tbTipe.TabIndex = 4;
            this.tbTipe.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "TOTAL HARGA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "MATERIAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "ONGKOS CETAK";
            // 
            // nudMaterial
            // 
            this.nudMaterial.BackColor = System.Drawing.Color.Yellow;
            this.nudMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMaterial.Location = new System.Drawing.Point(642, 396);
            this.nudMaterial.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudMaterial.Name = "nudMaterial";
            this.nudMaterial.ReadOnly = true;
            this.nudMaterial.Size = new System.Drawing.Size(113, 25);
            this.nudMaterial.TabIndex = 7;
            this.nudMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaterial.ThousandsSeparator = true;
            // 
            // nudOngkosCetak
            // 
            this.nudOngkosCetak.BackColor = System.Drawing.Color.Yellow;
            this.nudOngkosCetak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudOngkosCetak.Location = new System.Drawing.Point(642, 426);
            this.nudOngkosCetak.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudOngkosCetak.Name = "nudOngkosCetak";
            this.nudOngkosCetak.ReadOnly = true;
            this.nudOngkosCetak.Size = new System.Drawing.Size(113, 25);
            this.nudOngkosCetak.TabIndex = 7;
            this.nudOngkosCetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOngkosCetak.ThousandsSeparator = true;
            // 
            // nudTotalHarga
            // 
            this.nudTotalHarga.BackColor = System.Drawing.Color.Yellow;
            this.nudTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTotalHarga.Location = new System.Drawing.Point(642, 466);
            this.nudTotalHarga.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudTotalHarga.Name = "nudTotalHarga";
            this.nudTotalHarga.ReadOnly = true;
            this.nudTotalHarga.Size = new System.Drawing.Size(113, 25);
            this.nudTotalHarga.TabIndex = 7;
            this.nudTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalHarga.ThousandsSeparator = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(739, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 101);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(504, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 1);
            this.panel2.TabIndex = 9;
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(1024, 389);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(147, 50);
            this.btnDeleteDetail.TabIndex = 6;
            this.btnDeleteDetail.Text = "Delete Detil Terpilih";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // PrintingManualEditSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1192, 579);
            this.Controls.Add(this.tbTerbilang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudTotalHarga);
            this.Controls.Add(this.nudOngkosCetak);
            this.Controls.Add(this.nudMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnEditDetail);
            this.Controls.Add(this.btnEditHeader);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAddNota);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbCustomerUp);
            this.Controls.Add(this.tbTipe);
            this.Controls.Add(this.tbJudul);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPurchaseNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDetail);
            this.Controls.Add(this.gridHeader);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PrintingManualEditSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintingManualEditSales";
            this.Load += new System.EventHandler(this.PrintingManualEditSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOngkosCetak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPurchaseNo;
        private System.Windows.Forms.TextBox tbTerbilang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomerUp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gridDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEditHeader;
        private System.Windows.Forms.Button btnEditDetail;
        private System.Windows.Forms.Button btnAddNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJudul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTipe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudMaterial;
        private System.Windows.Forms.NumericUpDown nudOngkosCetak;
        private System.Windows.Forms.NumericUpDown nudTotalHarga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteDetail;
    }
}