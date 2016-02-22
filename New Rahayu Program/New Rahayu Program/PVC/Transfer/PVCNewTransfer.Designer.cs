namespace Rahayu_Program.PVC.Transfer
{
    partial class PVCNewTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVCNewTransfer));
            this.btnSearchPVC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNamaPVC = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nudPack = new System.Windows.Forms.NumericUpDown();
            this.nudPerPack = new System.Windows.Forms.NumericUpDown();
            this.nudTotalQty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearField = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.panelCart = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbTypeUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPengirim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalQty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPVC
            // 
            this.btnSearchPVC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPVC.BackgroundImage")));
            this.btnSearchPVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPVC.ForeColor = System.Drawing.Color.White;
            this.btnSearchPVC.Location = new System.Drawing.Point(619, 11);
            this.btnSearchPVC.Name = "btnSearchPVC";
            this.btnSearchPVC.Size = new System.Drawing.Size(45, 45);
            this.btnSearchPVC.TabIndex = 40;
            this.btnSearchPVC.UseVisualStyleBackColor = true;
            this.btnSearchPVC.Click += new System.EventHandler(this.btnSearchPVC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(553, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "x";
            // 
            // tbNamaPVC
            // 
            this.tbNamaPVC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbNamaPVC.Location = new System.Drawing.Point(326, 62);
            this.tbNamaPVC.Name = "tbNamaPVC";
            this.tbNamaPVC.ReadOnly = true;
            this.tbNamaPVC.Size = new System.Drawing.Size(338, 32);
            this.tbNamaPVC.TabIndex = 52;
            this.tbNamaPVC.TabStop = false;
            this.tbNamaPVC.Text = "PRINT DIGITAL (TANPA OVERLAY)";
            this.tbNamaPVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(550, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 39);
            this.panel5.TabIndex = 43;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(661, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 39);
            this.panel7.TabIndex = 51;
            // 
            // nudPack
            // 
            this.nudPack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nudPack.Location = new System.Drawing.Point(442, 116);
            this.nudPack.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPack.Name = "nudPack";
            this.nudPack.Size = new System.Drawing.Size(124, 39);
            this.nudPack.TabIndex = 42;
            this.nudPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPack.ThousandsSeparator = true;
            this.nudPack.ValueChanged += new System.EventHandler(this.nudPack_ValueChanged);
            this.nudPack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudPack_KeyDown);
            // 
            // nudPerPack
            // 
            this.nudPerPack.DecimalPlaces = 2;
            this.nudPerPack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nudPerPack.Location = new System.Drawing.Point(572, 116);
            this.nudPerPack.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPerPack.Name = "nudPerPack";
            this.nudPerPack.ReadOnly = true;
            this.nudPerPack.Size = new System.Drawing.Size(105, 39);
            this.nudPerPack.TabIndex = 46;
            this.nudPerPack.TabStop = false;
            this.nudPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPerPack.ThousandsSeparator = true;
            // 
            // nudTotalQty
            // 
            this.nudTotalQty.DecimalPlaces = 2;
            this.nudTotalQty.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nudTotalQty.Location = new System.Drawing.Point(524, 161);
            this.nudTotalQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudTotalQty.Name = "nudTotalQty";
            this.nudTotalQty.ReadOnly = true;
            this.nudTotalQty.Size = new System.Drawing.Size(153, 39);
            this.nudTotalQty.TabIndex = 49;
            this.nudTotalQty.TabStop = false;
            this.nudTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalQty.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(500, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(572, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Isi PerPack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(442, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Pack";
            // 
            // btnClearField
            // 
            this.btnClearField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearField.BackgroundImage")));
            this.btnClearField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearField.ForeColor = System.Drawing.Color.White;
            this.btnClearField.Location = new System.Drawing.Point(512, 227);
            this.btnClearField.Name = "btnClearField";
            this.btnClearField.Size = new System.Drawing.Size(60, 60);
            this.btnClearField.TabIndex = 63;
            this.btnClearField.UseVisualStyleBackColor = true;
            this.btnClearField.Click += new System.EventHandler(this.btnClearField_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(446, 227);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(60, 60);
            this.btnAddToCart.TabIndex = 62;
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.panelCart.BackColor = System.Drawing.Color.White;
            this.panelCart.Location = new System.Drawing.Point(12, 12);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(308, 722);
            this.panelCart.TabIndex = 64;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(564, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 66;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(458, 684);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 65;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(661, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 39);
            this.panel6.TabIndex = 47;
            // 
            // tbTypeUnit
            // 
            this.tbTypeUnit.BackColor = System.Drawing.Color.DeepPink;
            this.tbTypeUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbTypeUnit.ForeColor = System.Drawing.Color.White;
            this.tbTypeUnit.Location = new System.Drawing.Point(524, 200);
            this.tbTypeUnit.Name = "tbTypeUnit";
            this.tbTypeUnit.Size = new System.Drawing.Size(137, 18);
            this.tbTypeUnit.TabIndex = 67;
            this.tbTypeUnit.Text = "Type Unit";
            this.tbTypeUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTypeUnit.Enter += new System.EventHandler(this.tbTypeUnit_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "KIRIM PVC dr Sunter -> Rahayu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "1. Pilih Dulu PVCnya di Kaca Pembesar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(333, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 21);
            this.label7.TabIndex = 68;
            this.label7.Text = "2. Input Jumlah Packnya";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(333, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 21);
            this.label8.TabIndex = 68;
            this.label8.Text = "3. Cek Jumlah Total Unitnya";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(333, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 21);
            this.label9.TabIndex = 68;
            this.label9.Text = "4. Bila sudah OK, masukkan barangnya";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(333, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 21);
            this.label10.TabIndex = 68;
            this.label10.Text = "5. Ulangi langkah ini hingga selesai";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(333, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 21);
            this.label11.TabIndex = 68;
            this.label11.Text = "6. Masukkan Nama Pengirim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(333, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(309, 21);
            this.label12.TabIndex = 68;
            this.label12.Text = "7. Klik \"Submit\", untuk print surat jalan";
            // 
            // tbPengirim
            // 
            this.tbPengirim.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbPengirim.Location = new System.Drawing.Point(326, 598);
            this.tbPengirim.Name = "tbPengirim";
            this.tbPengirim.Size = new System.Drawing.Size(338, 32);
            this.tbPengirim.TabIndex = 52;
            this.tbPengirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(333, 574);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 21);
            this.label13.TabIndex = 41;
            this.label13.Text = "NAMA PENGIRIM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(437, 633);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 21);
            this.label14.TabIndex = 41;
            this.label14.Text = "- Harus Diisi! -";
            // 
            // PVCNewTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(675, 746);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTypeUnit);
            this.Controls.Add(this.tbPengirim);
            this.Controls.Add(this.tbNamaPVC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.nudPack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.btnClearField);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnSearchPVC);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.nudTotalQty);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.nudPerPack);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PVCNewTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PVCNewTransfer";
            this.Load += new System.EventHandler(this.PVCNewTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPVC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNamaPVC;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown nudPack;
        private System.Windows.Forms.NumericUpDown nudPerPack;
        private System.Windows.Forms.NumericUpDown nudTotalQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearField;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbTypeUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPengirim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

    }
}