namespace Rahayu_Program.Stationery.MsBarang
{
    partial class DetailBarangInputStock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNomorBarang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudHarga = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.BackColor = System.Drawing.Color.White;
            this.tbNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaBarang.Location = new System.Drawing.Point(3, 7);
            this.tbNamaBarang.Multiline = true;
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.ReadOnly = true;
            this.tbNamaBarang.Size = new System.Drawing.Size(267, 22);
            this.tbNamaBarang.TabIndex = 0;
            this.tbNamaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNamaBarang.TextChanged += new System.EventHandler(this.tbNamaBarang_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Barcode!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNomorBarang
            // 
            this.tbNomorBarang.BackColor = System.Drawing.Color.White;
            this.tbNomorBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomorBarang.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.tbNomorBarang.Location = new System.Drawing.Point(3, 30);
            this.tbNomorBarang.Name = "tbNomorBarang";
            this.tbNomorBarang.ReadOnly = true;
            this.tbNomorBarang.Size = new System.Drawing.Size(161, 43);
            this.tbNomorBarang.TabIndex = 1;
            this.tbNomorBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(277, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 71);
            this.panel1.TabIndex = 3;
            // 
            // nudStock
            // 
            this.nudStock.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.nudStock.Location = new System.Drawing.Point(285, 24);
            this.nudStock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudStock.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(166, 50);
            this.nudStock.TabIndex = 7;
            this.nudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStock.ThousandsSeparator = true;
            this.nudStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudStock_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock Sekarang:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nudMin
            // 
            this.nudMin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.nudMin.Location = new System.Drawing.Point(443, 24);
            this.nudMin.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(77, 50);
            this.nudMin.TabIndex = 9;
            this.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMin.ThousandsSeparator = true;
            this.nudMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudMin_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(434, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 50);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(504, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 50);
            this.panel3.TabIndex = 10;
            // 
            // nudHarga
            // 
            this.nudHarga.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.nudHarga.Location = new System.Drawing.Point(513, 24);
            this.nudHarga.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudHarga.Name = "nudHarga";
            this.nudHarga.Size = new System.Drawing.Size(139, 50);
            this.nudHarga.TabIndex = 11;
            this.nudHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHarga.ThousandsSeparator = true;
            this.nudHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudHarga_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harga Jual:";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(635, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 50);
            this.panel4.TabIndex = 12;
            // 
            // DetailBarangInputStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.nudHarga);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbNomorBarang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DetailBarangInputStock";
            this.Size = new System.Drawing.Size(726, 77);
            this.Load += new System.EventHandler(this.DetailBarangInputStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNomorBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
    }
}
