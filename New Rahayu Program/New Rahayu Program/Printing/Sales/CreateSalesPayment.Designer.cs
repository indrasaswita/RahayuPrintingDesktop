namespace Rahayu_Program.Printing.Sales
{
    partial class CreateSalesPayment
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
            this.tbViewSalesID = new System.Windows.Forms.TextBox();
            this.nudHargaAsli = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nudPembayaran = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnGiro = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nudKembali = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudPembayaran2 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.nudHargaPalsu = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLunas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaAsli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPembayaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKembali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPembayaran2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaPalsu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbViewSalesID
            // 
            this.tbViewSalesID.BackColor = System.Drawing.Color.Green;
            this.tbViewSalesID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbViewSalesID.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.tbViewSalesID.ForeColor = System.Drawing.Color.White;
            this.tbViewSalesID.Location = new System.Drawing.Point(4, 8);
            this.tbViewSalesID.Name = "tbViewSalesID";
            this.tbViewSalesID.Size = new System.Drawing.Size(765, 36);
            this.tbViewSalesID.TabIndex = 0;
            this.tbViewSalesID.TabStop = false;
            this.tbViewSalesID.Text = "No. Nota : 0000000000";
            this.tbViewSalesID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbViewSalesID.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // nudHargaAsli
            // 
            this.nudHargaAsli.BackColor = System.Drawing.Color.Green;
            this.nudHargaAsli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudHargaAsli.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.nudHargaAsli.ForeColor = System.Drawing.Color.White;
            this.nudHargaAsli.Location = new System.Drawing.Point(4, 78);
            this.nudHargaAsli.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudHargaAsli.Name = "nudHargaAsli";
            this.nudHargaAsli.ReadOnly = true;
            this.nudHargaAsli.Size = new System.Drawing.Size(399, 67);
            this.nudHargaAsli.TabIndex = 2;
            this.nudHargaAsli.TabStop = false;
            this.nudHargaAsli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHargaAsli.ThousandsSeparator = true;
            this.nudHargaAsli.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(386, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 100);
            this.panel1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(4, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(383, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Jumlah Belanja / Total Harga Asli";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(4, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(383, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Jumlah Pembayaran Asli";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // nudPembayaran
            // 
            this.nudPembayaran.BackColor = System.Drawing.Color.Green;
            this.nudPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPembayaran.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.nudPembayaran.ForeColor = System.Drawing.Color.White;
            this.nudPembayaran.Location = new System.Drawing.Point(4, 180);
            this.nudPembayaran.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPembayaran.Name = "nudPembayaran";
            this.nudPembayaran.Size = new System.Drawing.Size(399, 67);
            this.nudPembayaran.TabIndex = 4;
            this.nudPembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPembayaran.ThousandsSeparator = true;
            this.nudPembayaran.ValueChanged += new System.EventHandler(this.nudPembayaran_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(769, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 100);
            this.panel2.TabIndex = 14;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.ForeColor = System.Drawing.Color.Black;
            this.btnCash.Location = new System.Drawing.Point(4, 247);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(96, 51);
            this.btnCash.TabIndex = 5;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebit.ForeColor = System.Drawing.Color.Black;
            this.btnDebit.Location = new System.Drawing.Point(99, 247);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(96, 51);
            this.btnDebit.TabIndex = 6;
            this.btnDebit.Text = "DEBIT";
            this.btnDebit.UseVisualStyleBackColor = false;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.Location = new System.Drawing.Point(194, 247);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(96, 51);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "TRANSF\'R";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnGiro
            // 
            this.btnGiro.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiro.ForeColor = System.Drawing.Color.Black;
            this.btnGiro.Location = new System.Drawing.Point(289, 247);
            this.btnGiro.Name = "btnGiro";
            this.btnGiro.Size = new System.Drawing.Size(97, 51);
            this.btnGiro.TabIndex = 8;
            this.btnGiro.Text = "GIRO";
            this.btnGiro.UseVisualStyleBackColor = false;
            this.btnGiro.Click += new System.EventHandler(this.btnGiro_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(5, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(382, 25);
            this.textBox3.TabIndex = 9;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Kembali";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // nudKembali
            // 
            this.nudKembali.BackColor = System.Drawing.Color.Green;
            this.nudKembali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudKembali.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.nudKembali.ForeColor = System.Drawing.Color.White;
            this.nudKembali.Location = new System.Drawing.Point(5, 335);
            this.nudKembali.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudKembali.Name = "nudKembali";
            this.nudKembali.ReadOnly = true;
            this.nudKembali.Size = new System.Drawing.Size(398, 67);
            this.nudKembali.TabIndex = 10;
            this.nudKembali.TabStop = false;
            this.nudKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKembali.ThousandsSeparator = true;
            this.nudKembali.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(386, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 100);
            this.panel3.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(238, 426);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(148, 59);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "BAYAR";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(385, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 59);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "BATAL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(387, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(383, 25);
            this.textBox4.TabIndex = 3;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Jumlah Pembayaran Palsu";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(386, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 100);
            this.panel4.TabIndex = 14;
            // 
            // nudPembayaran2
            // 
            this.nudPembayaran2.BackColor = System.Drawing.Color.Green;
            this.nudPembayaran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPembayaran2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.nudPembayaran2.ForeColor = System.Drawing.Color.White;
            this.nudPembayaran2.Location = new System.Drawing.Point(386, 180);
            this.nudPembayaran2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPembayaran2.Name = "nudPembayaran2";
            this.nudPembayaran2.Size = new System.Drawing.Size(399, 67);
            this.nudPembayaran2.TabIndex = 4;
            this.nudPembayaran2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPembayaran2.ThousandsSeparator = true;
            this.nudPembayaran2.ValueChanged += new System.EventHandler(this.nudPembayaran_ValueChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(386, 53);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(383, 25);
            this.textBox5.TabIndex = 1;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Harga Total Palsu";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // nudHargaPalsu
            // 
            this.nudHargaPalsu.BackColor = System.Drawing.Color.Green;
            this.nudHargaPalsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudHargaPalsu.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.nudHargaPalsu.ForeColor = System.Drawing.Color.White;
            this.nudHargaPalsu.Location = new System.Drawing.Point(386, 78);
            this.nudHargaPalsu.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudHargaPalsu.Name = "nudHargaPalsu";
            this.nudHargaPalsu.ReadOnly = true;
            this.nudHargaPalsu.Size = new System.Drawing.Size(399, 67);
            this.nudHargaPalsu.TabIndex = 2;
            this.nudHargaPalsu.TabStop = false;
            this.nudHargaPalsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHargaPalsu.ThousandsSeparator = true;
            this.nudHargaPalsu.ValueChanged += new System.EventHandler(this.nudHargaPalsu_ValueChanged);
            this.nudHargaPalsu.Enter += new System.EventHandler(this.tbViewSalesID_Enter);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(768, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 100);
            this.panel5.TabIndex = 15;
            // 
            // btnLunas
            // 
            this.btnLunas.BackColor = System.Drawing.Color.GreenYellow;
            this.btnLunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLunas.ForeColor = System.Drawing.Color.Black;
            this.btnLunas.Location = new System.Drawing.Point(333, 155);
            this.btnLunas.Name = "btnLunas";
            this.btnLunas.Size = new System.Drawing.Size(107, 36);
            this.btnLunas.TabIndex = 16;
            this.btnLunas.Text = "LUNAS";
            this.btnLunas.UseVisualStyleBackColor = false;
            this.btnLunas.Click += new System.EventHandler(this.btnLunas_Click);
            // 
            // CreateSalesPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(773, 497);
            this.Controls.Add(this.btnLunas);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.nudHargaPalsu);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nudPembayaran2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGiro);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudPembayaran);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nudKembali);
            this.Controls.Add(this.nudHargaAsli);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbViewSalesID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateSalesPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateSalesPayment";
            this.Load += new System.EventHandler(this.CreateSalesPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaAsli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPembayaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKembali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPembayaran2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaPalsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbViewSalesID;
        private System.Windows.Forms.NumericUpDown nudHargaAsli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown nudPembayaran;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnGiro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown nudKembali;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudPembayaran2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown nudHargaPalsu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLunas;
    }
}