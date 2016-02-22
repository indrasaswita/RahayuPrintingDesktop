namespace Rahayu_Program.Stationery.MsBarang
{
    partial class StationeryBukaPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationeryBukaPack));
            this.panelBukaPak = new System.Windows.Forms.Panel();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.tbNamaBarangPak = new System.Windows.Forms.TextBox();
            this.tbNamaBarangRetail = new System.Windows.Forms.TextBox();
            this.nudPak = new System.Windows.Forms.NumericUpDown();
            this.nudPerPak = new System.Windows.Forms.NumericUpDown();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBukaPak
            // 
            this.panelBukaPak.AutoScroll = true;
            this.panelBukaPak.BackColor = System.Drawing.Color.White;
            this.panelBukaPak.Location = new System.Drawing.Point(13, 62);
            this.panelBukaPak.Name = "panelBukaPak";
            this.panelBukaPak.Size = new System.Drawing.Size(435, 559);
            this.panelBukaPak.TabIndex = 1;
            // 
            // gridCart
            // 
            this.gridCart.AllowUserToAddRows = false;
            this.gridCart.AllowUserToDeleteRows = false;
            this.gridCart.AllowUserToResizeColumns = false;
            this.gridCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCart.BackgroundColor = System.Drawing.Color.White;
            this.gridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridCart.Location = new System.Drawing.Point(454, 187);
            this.gridCart.Name = "gridCart";
            this.gridCart.ReadOnly = true;
            this.gridCart.RowHeadersVisible = false;
            this.gridCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCart.Size = new System.Drawing.Size(405, 378);
            this.gridCart.TabIndex = 19;
            // 
            // tbNamaBarangPak
            // 
            this.tbNamaBarangPak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbNamaBarangPak.Location = new System.Drawing.Point(547, 62);
            this.tbNamaBarangPak.Name = "tbNamaBarangPak";
            this.tbNamaBarangPak.ReadOnly = true;
            this.tbNamaBarangPak.Size = new System.Drawing.Size(312, 32);
            this.tbNamaBarangPak.TabIndex = 20;
            this.tbNamaBarangPak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNamaBarangPak.Enter += new System.EventHandler(this.tbNamaBarangRetail_Enter);
            // 
            // tbNamaBarangRetail
            // 
            this.tbNamaBarangRetail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbNamaBarangRetail.Location = new System.Drawing.Point(547, 100);
            this.tbNamaBarangRetail.Name = "tbNamaBarangRetail";
            this.tbNamaBarangRetail.ReadOnly = true;
            this.tbNamaBarangRetail.Size = new System.Drawing.Size(312, 32);
            this.tbNamaBarangRetail.TabIndex = 20;
            this.tbNamaBarangRetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNamaBarangRetail.Enter += new System.EventHandler(this.tbNamaBarangRetail_Enter);
            // 
            // nudPak
            // 
            this.nudPak.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.nudPak.Location = new System.Drawing.Point(453, 138);
            this.nudPak.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPak.Name = "nudPak";
            this.nudPak.Size = new System.Drawing.Size(82, 43);
            this.nudPak.TabIndex = 21;
            this.nudPak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPak.ValueChanged += new System.EventHandler(this.nudPak_ValueChanged);
            // 
            // nudPerPak
            // 
            this.nudPerPak.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.nudPerPak.Location = new System.Drawing.Point(542, 138);
            this.nudPerPak.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPerPak.Name = "nudPerPak";
            this.nudPerPak.Size = new System.Drawing.Size(106, 43);
            this.nudPerPak.TabIndex = 21;
            this.nudPerPak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPerPak.ThousandsSeparator = true;
            this.nudPerPak.ValueChanged += new System.EventHandler(this.nudPerPak_ValueChanged);
            // 
            // nudJumlah
            // 
            this.nudJumlah.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.nudJumlah.Location = new System.Drawing.Point(659, 138);
            this.nudJumlah.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(120, 43);
            this.nudJumlah.TabIndex = 21;
            this.nudJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudJumlah.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(520, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "x";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(519, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 43);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(632, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 43);
            this.panel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(633, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "=";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(764, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 43);
            this.panel4.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(767, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(816, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 43);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(473, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Pack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(465, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Retail";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(759, 571);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(653, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buka Pak Dari Stock";
            // 
            // StationeryBukaPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nudPerPak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nudPak);
            this.Controls.Add(this.tbNamaBarangRetail);
            this.Controls.Add(this.tbNamaBarangPak);
            this.Controls.Add(this.gridCart);
            this.Controls.Add(this.panelBukaPak);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StationeryBukaPack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StationeryBukaPack";
            this.Load += new System.EventHandler(this.StationeryBukaPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBukaPak;
        private System.Windows.Forms.DataGridView gridCart;
        private System.Windows.Forms.TextBox tbNamaBarangPak;
        private System.Windows.Forms.TextBox tbNamaBarangRetail;
        private System.Windows.Forms.NumericUpDown nudPak;
        private System.Windows.Forms.NumericUpDown nudPerPak;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}