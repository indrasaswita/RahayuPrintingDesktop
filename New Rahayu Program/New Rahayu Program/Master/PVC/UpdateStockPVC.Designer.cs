namespace Rahayu_Program.Master.PVC
{
    partial class UpdateStockPVC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStockPVC));
            this.btnSearchPVC = new System.Windows.Forms.Button();
            this.tbNamaPVC = new System.Windows.Forms.TextBox();
            this.btnEnterQty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nudPack = new System.Windows.Forms.NumericUpDown();
            this.nudPerPack = new System.Windows.Forms.NumericUpDown();
            this.nudTotalQty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.LblPVCType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRahayu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPVC
            // 
            this.btnSearchPVC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPVC.BackgroundImage")));
            this.btnSearchPVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPVC.ForeColor = System.Drawing.Color.White;
            this.btnSearchPVC.Location = new System.Drawing.Point(347, 12);
            this.btnSearchPVC.Name = "btnSearchPVC";
            this.btnSearchPVC.Size = new System.Drawing.Size(45, 45);
            this.btnSearchPVC.TabIndex = 19;
            this.btnSearchPVC.UseVisualStyleBackColor = true;
            this.btnSearchPVC.Click += new System.EventHandler(this.btnSearchPVC_Click);
            // 
            // tbNamaPVC
            // 
            this.tbNamaPVC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbNamaPVC.Location = new System.Drawing.Point(12, 63);
            this.tbNamaPVC.Name = "tbNamaPVC";
            this.tbNamaPVC.ReadOnly = true;
            this.tbNamaPVC.Size = new System.Drawing.Size(380, 32);
            this.tbNamaPVC.TabIndex = 31;
            this.tbNamaPVC.TabStop = false;
            this.tbNamaPVC.Text = "PRINT DIGITAL (TANPA OVERLAY)";
            this.tbNamaPVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnterQty
            // 
            this.btnEnterQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnterQty.BackgroundImage")));
            this.btnEnterQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnterQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterQty.ForeColor = System.Drawing.Color.White;
            this.btnEnterQty.Location = new System.Drawing.Point(180, 207);
            this.btnEnterQty.Name = "btnEnterQty";
            this.btnEnterQty.Size = new System.Drawing.Size(39, 39);
            this.btnEnterQty.TabIndex = 41;
            this.btnEnterQty.UseVisualStyleBackColor = true;
            this.btnEnterQty.Click += new System.EventHandler(this.btnEnterQty_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(198, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "x";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(196, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 39);
            this.panel5.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(307, 117);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 39);
            this.panel6.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(307, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 39);
            this.panel7.TabIndex = 42;
            // 
            // nudPack
            // 
            this.nudPack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nudPack.Location = new System.Drawing.Point(88, 117);
            this.nudPack.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPack.Name = "nudPack";
            this.nudPack.Size = new System.Drawing.Size(124, 39);
            this.nudPack.TabIndex = 33;
            this.nudPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPack.ThousandsSeparator = true;
            this.nudPack.ValueChanged += new System.EventHandler(this.nudPack_ValueChanged);
            this.nudPack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudPack_KeyDown);
            // 
            // nudPerPack
            // 
            this.nudPerPack.DecimalPlaces = 2;
            this.nudPerPack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nudPerPack.Location = new System.Drawing.Point(218, 117);
            this.nudPerPack.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPerPack.Name = "nudPerPack";
            this.nudPerPack.ReadOnly = true;
            this.nudPerPack.Size = new System.Drawing.Size(105, 39);
            this.nudPerPack.TabIndex = 37;
            this.nudPerPack.TabStop = false;
            this.nudPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPerPack.ThousandsSeparator = true;
            this.nudPerPack.ValueChanged += new System.EventHandler(this.nudPerPack_ValueChanged);
            // 
            // nudTotalQty
            // 
            this.nudTotalQty.DecimalPlaces = 2;
            this.nudTotalQty.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nudTotalQty.Location = new System.Drawing.Point(170, 162);
            this.nudTotalQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudTotalQty.Name = "nudTotalQty";
            this.nudTotalQty.ReadOnly = true;
            this.nudTotalQty.Size = new System.Drawing.Size(153, 39);
            this.nudTotalQty.TabIndex = 40;
            this.nudTotalQty.TabStop = false;
            this.nudTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalQty.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(146, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(218, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Isi PerPack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Pack";
            // 
            // nudQty
            // 
            this.nudQty.DecimalPlaces = 2;
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nudQty.Location = new System.Drawing.Point(88, 252);
            this.nudQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.ReadOnly = true;
            this.nudQty.Size = new System.Drawing.Size(235, 39);
            this.nudQty.TabIndex = 43;
            this.nudQty.TabStop = false;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQty.ThousandsSeparator = true;
            // 
            // LblPVCType
            // 
            this.LblPVCType.AutoSize = true;
            this.LblPVCType.ForeColor = System.Drawing.Color.White;
            this.LblPVCType.Location = new System.Drawing.Point(210, 291);
            this.LblPVCType.Name = "LblPVCType";
            this.LblPVCType.Size = new System.Drawing.Size(78, 21);
            this.LblPVCType.TabIndex = 44;
            this.LblPVCType.Text = "pvc Type";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(307, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 39);
            this.panel1.TabIndex = 42;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(186, 323);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 46;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(292, 323);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 46;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 341);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(82, 32);
            this.btnHome.TabIndex = 47;
            this.btnHome.Text = "Rumah";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRahayu
            // 
            this.btnRahayu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRahayu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRahayu.ForeColor = System.Drawing.Color.White;
            this.btnRahayu.Location = new System.Drawing.Point(94, 341);
            this.btnRahayu.Name = "btnRahayu";
            this.btnRahayu.Size = new System.Drawing.Size(82, 32);
            this.btnRahayu.TabIndex = 47;
            this.btnRahayu.Text = "Rahayu";
            this.btnRahayu.UseVisualStyleBackColor = true;
            this.btnRahayu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UpdateStockPVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(404, 386);
            this.Controls.Add(this.btnRahayu);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.LblPVCType);
            this.Controls.Add(this.btnEnterQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.nudPack);
            this.Controls.Add(this.nudPerPack);
            this.Controls.Add(this.nudTotalQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNamaPVC);
            this.Controls.Add(this.btnSearchPVC);
            this.Controls.Add(this.nudQty);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdateStockPVC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStockPVC";
            this.Load += new System.EventHandler(this.UpdateStockPVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPVC;
        private System.Windows.Forms.TextBox tbNamaPVC;
        private System.Windows.Forms.Button btnEnterQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown nudPack;
        private System.Windows.Forms.NumericUpDown nudPerPack;
        private System.Windows.Forms.NumericUpDown nudTotalQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label LblPVCType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRahayu;
    }
}