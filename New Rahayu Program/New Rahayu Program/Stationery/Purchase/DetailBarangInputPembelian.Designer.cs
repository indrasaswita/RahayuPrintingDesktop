namespace Rahayu_Program.Stationery.Purchase
{
    partial class DetailBarangInputPembelian
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
            this.tbNomorBarang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHargaBeli = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomorBarang
            // 
            this.tbNomorBarang.BackColor = System.Drawing.Color.White;
            this.tbNomorBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomorBarang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tbNomorBarang.Location = new System.Drawing.Point(3, 30);
            this.tbNomorBarang.Name = "tbNomorBarang";
            this.tbNomorBarang.ReadOnly = true;
            this.tbNomorBarang.Size = new System.Drawing.Size(161, 29);
            this.tbNomorBarang.TabIndex = 4;
            this.tbNomorBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Supplier!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.BackColor = System.Drawing.Color.White;
            this.tbNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaBarang.Location = new System.Drawing.Point(3, 3);
            this.tbNamaBarang.Multiline = true;
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.ReadOnly = true;
            this.tbNamaBarang.Size = new System.Drawing.Size(267, 22);
            this.tbNamaBarang.TabIndex = 3;
            this.tbNamaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(1, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 2);
            this.panel1.TabIndex = 6;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudQty.Location = new System.Drawing.Point(5, 83);
            this.nudQty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(97, 36);
            this.nudQty.TabIndex = 9;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQty.ThousandsSeparator = true;
            this.nudQty.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            this.nudQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudQty_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Qty:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(86, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 36);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Harga :";
            // 
            // nudHargaBeli
            // 
            this.nudHargaBeli.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudHargaBeli.Location = new System.Drawing.Point(92, 83);
            this.nudHargaBeli.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudHargaBeli.Name = "nudHargaBeli";
            this.nudHargaBeli.Size = new System.Drawing.Size(125, 36);
            this.nudHargaBeli.TabIndex = 9;
            this.nudHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHargaBeli.ThousandsSeparator = true;
            this.nudHargaBeli.Value = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudHargaBeli.ValueChanged += new System.EventHandler(this.nudHargaBeli_ValueChanged);
            this.nudHargaBeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudHargaBeli_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(201, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 36);
            this.panel3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(207, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "NEXT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DetailBarangInputPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbNomorBarang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nudHargaBeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DetailBarangInputPembelian";
            this.Size = new System.Drawing.Size(276, 122);
            this.Load += new System.EventHandler(this.DetailBarangInputPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaBeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomorBarang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHargaBeli;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;

    }
}
