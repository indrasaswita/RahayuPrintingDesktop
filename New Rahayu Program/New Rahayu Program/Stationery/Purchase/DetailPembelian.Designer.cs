namespace Rahayu_Program.Stationery.Purchase
{
    partial class DetailPembelian
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
            this.tb_namaBarang = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_namaBarang
            // 
            this.tb_namaBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_namaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_namaBarang.Location = new System.Drawing.Point(1, 2);
            this.tb_namaBarang.Name = "tb_namaBarang";
            this.tb_namaBarang.ReadOnly = true;
            this.tb_namaBarang.Size = new System.Drawing.Size(256, 22);
            this.tb_namaBarang.TabIndex = 1;
            this.tb_namaBarang.Text = "SPIDOL SNOWMAN 12W /PAK";
            this.tb_namaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbQty
            // 
            this.tbQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQty.Location = new System.Drawing.Point(1, 26);
            this.tbQty.Name = "tbQty";
            this.tbQty.ReadOnly = true;
            this.tbQty.Size = new System.Drawing.Size(67, 22);
            this.tbQty.TabIndex = 1;
            this.tbQty.Text = "999,999";
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHarga
            // 
            this.tbHarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHarga.Location = new System.Drawing.Point(147, 26);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(45, 22);
            this.tbHarga.TabIndex = 1;
            this.tbHarga.Text = "3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(199, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "KODE :";
            // 
            // DetailPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.tb_namaBarang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DetailPembelian";
            this.Size = new System.Drawing.Size(258, 49);
            this.Load += new System.EventHandler(this.DetailPembelian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_namaBarang;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

    }
}
