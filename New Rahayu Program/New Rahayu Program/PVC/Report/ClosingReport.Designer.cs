namespace Rahayu_Program.PVC.Report
{
    partial class ClosingReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHarian = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAkhir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAwal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHarianGroup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrintStock = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnOpnameAkhir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHarian
            // 
            this.btnHarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarian.Location = new System.Drawing.Point(244, 538);
            this.btnHarian.Name = "btnHarian";
            this.btnHarian.Size = new System.Drawing.Size(223, 37);
            this.btnHarian.TabIndex = 0;
            this.btnHarian.Text = "HARIAN";
            this.btnHarian.UseVisualStyleBackColor = true;
            this.btnHarian.Click += new System.EventHandler(this.btnHarian_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(358, 276);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 35);
            this.button9.TabIndex = 16;
            this.button9.Text = "AKHIR";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(263, 276);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 35);
            this.button8.TabIndex = 17;
            this.button8.Text = "AWAL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(366, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 38);
            this.button5.TabIndex = 14;
            this.button5.Text = "REFRESH";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(246, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "SET STAMP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "TANGGAL AKHIR LAPORAN";
            // 
            // tbAkhir
            // 
            this.tbAkhir.Location = new System.Drawing.Point(243, 216);
            this.tbAkhir.Name = "tbAkhir";
            this.tbAkhir.Size = new System.Drawing.Size(225, 29);
            this.tbAkhir.TabIndex = 10;
            this.tbAkhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "TANGGAL AWAL LAPORAN";
            // 
            // tbAwal
            // 
            this.tbAwal.Location = new System.Drawing.Point(242, 121);
            this.tbAwal.Name = "tbAwal";
            this.tbAwal.Size = new System.Drawing.Size(225, 29);
            this.tbAwal.TabIndex = 11;
            this.tbAwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(220, 680);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(388, 657);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 37);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHarianGroup
            // 
            this.btnHarianGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarianGroup.Location = new System.Drawing.Point(244, 581);
            this.btnHarianGroup.Name = "btnHarianGroup";
            this.btnHarianGroup.Size = new System.Drawing.Size(223, 37);
            this.btnHarianGroup.TabIndex = 0;
            this.btnHarianGroup.Text = "HARIAN GROUPING";
            this.btnHarianGroup.UseVisualStyleBackColor = true;
            this.btnHarianGroup.Click += new System.EventHandler(this.btnHarianGroup_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(244, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "HARIAN INCOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrintStock
            // 
            this.btnPrintStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintStock.Location = new System.Drawing.Point(244, 452);
            this.btnPrintStock.Name = "btnPrintStock";
            this.btnPrintStock.Size = new System.Drawing.Size(223, 37);
            this.btnPrintStock.TabIndex = 0;
            this.btnPrintStock.Text = "PRINT STOCK AWAL";
            this.btnPrintStock.UseVisualStyleBackColor = true;
            this.btnPrintStock.Click += new System.EventHandler(this.btnPrintStock_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Location = new System.Drawing.Point(244, 366);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(223, 37);
            this.btnTransfer.TabIndex = 18;
            this.btnTransfer.Text = "TRANSFER STOCK";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnOpnameAkhir
            // 
            this.btnOpnameAkhir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpnameAkhir.Location = new System.Drawing.Point(244, 409);
            this.btnOpnameAkhir.Name = "btnOpnameAkhir";
            this.btnOpnameAkhir.Size = new System.Drawing.Size(223, 37);
            this.btnOpnameAkhir.TabIndex = 0;
            this.btnOpnameAkhir.Text = "PRINT STOCK AKHIR";
            this.btnOpnameAkhir.UseVisualStyleBackColor = true;
            this.btnOpnameAkhir.Click += new System.EventHandler(this.btnOpnameAkhir_Click);
            // 
            // ClosingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(481, 708);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAkhir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAwal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpnameAkhir);
            this.Controls.Add(this.btnPrintStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHarianGroup);
            this.Controls.Add(this.btnHarian);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClosingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClosingReport";
            this.Load += new System.EventHandler(this.ClosingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHarian;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAkhir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAwal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHarianGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrintStock;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnOpnameAkhir;
    }
}