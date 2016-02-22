namespace Rahayu_Program.PVC.Sales
{
    partial class PVCSalesPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVCSalesPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnGiro = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnTransfer2 = new System.Windows.Forms.Button();
            this.btnGiro2 = new System.Windows.Forms.Button();
            this.btnDebit2 = new System.Windows.Forms.Button();
            this.btnCash2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKembali = new System.Windows.Forms.NumericUpDown();
            this.nudBayar = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKembali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBayar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.nudTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 127);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(558, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 80);
            this.panel3.TabIndex = 2;
            // 
            // nudTotal
            // 
            this.nudTotal.BackColor = System.Drawing.Color.Black;
            this.nudTotal.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.nudTotal.ForeColor = System.Drawing.Color.Yellow;
            this.nudTotal.Location = new System.Drawing.Point(15, 48);
            this.nudTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(559, 64);
            this.nudTotal.TabIndex = 1;
            this.nudTotal.TabStop = false;
            this.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTotal.ThousandsSeparator = true;
            this.nudTotal.Enter += new System.EventHandler(this.nudTotal_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total PemBELIan PVC";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnTransfer);
            this.panel2.Controls.Add(this.btnGiro);
            this.panel2.Controls.Add(this.btnDebit);
            this.panel2.Controls.Add(this.btnCash);
            this.panel2.Controls.Add(this.btnTransfer2);
            this.panel2.Controls.Add(this.btnGiro2);
            this.panel2.Controls.Add(this.btnDebit2);
            this.panel2.Controls.Add(this.btnCash2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nudKembali);
            this.panel2.Controls.Add(this.nudBayar);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-5, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 314);
            this.panel2.TabIndex = 2;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.BackgroundImage")));
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Location = new System.Drawing.Point(397, 129);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 50);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Visible = false;
            // 
            // btnGiro
            // 
            this.btnGiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiro.BackgroundImage")));
            this.btnGiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiro.Location = new System.Drawing.Point(291, 129);
            this.btnGiro.Name = "btnGiro";
            this.btnGiro.Size = new System.Drawing.Size(100, 50);
            this.btnGiro.TabIndex = 7;
            this.btnGiro.UseVisualStyleBackColor = true;
            this.btnGiro.Visible = false;
            // 
            // btnDebit
            // 
            this.btnDebit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDebit.BackgroundImage")));
            this.btnDebit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebit.Location = new System.Drawing.Point(185, 129);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(100, 50);
            this.btnDebit.TabIndex = 5;
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Visible = false;
            // 
            // btnCash
            // 
            this.btnCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCash.BackgroundImage")));
            this.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Location = new System.Drawing.Point(79, 129);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(100, 50);
            this.btnCash.TabIndex = 3;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Visible = false;
            // 
            // btnTransfer2
            // 
            this.btnTransfer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer2.BackgroundImage")));
            this.btnTransfer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransfer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer2.Location = new System.Drawing.Point(397, 134);
            this.btnTransfer2.Name = "btnTransfer2";
            this.btnTransfer2.Size = new System.Drawing.Size(100, 50);
            this.btnTransfer2.TabIndex = 10;
            this.btnTransfer2.UseVisualStyleBackColor = true;
            this.btnTransfer2.Click += new System.EventHandler(this.btnTransfer2_Click);
            // 
            // btnGiro2
            // 
            this.btnGiro2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiro2.BackgroundImage")));
            this.btnGiro2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiro2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiro2.Location = new System.Drawing.Point(291, 134);
            this.btnGiro2.Name = "btnGiro2";
            this.btnGiro2.Size = new System.Drawing.Size(100, 50);
            this.btnGiro2.TabIndex = 8;
            this.btnGiro2.UseVisualStyleBackColor = true;
            this.btnGiro2.Click += new System.EventHandler(this.btnGiro2_Click);
            // 
            // btnDebit2
            // 
            this.btnDebit2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDebit2.BackgroundImage")));
            this.btnDebit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDebit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebit2.Location = new System.Drawing.Point(185, 134);
            this.btnDebit2.Name = "btnDebit2";
            this.btnDebit2.Size = new System.Drawing.Size(100, 50);
            this.btnDebit2.TabIndex = 6;
            this.btnDebit2.UseVisualStyleBackColor = true;
            this.btnDebit2.Click += new System.EventHandler(this.btnDebit2_Click);
            // 
            // btnCash2
            // 
            this.btnCash2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCash2.BackgroundImage")));
            this.btnCash2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCash2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash2.Location = new System.Drawing.Point(79, 134);
            this.btnCash2.Name = "btnCash2";
            this.btnCash2.Size = new System.Drawing.Size(100, 50);
            this.btnCash2.TabIndex = 4;
            this.btnCash2.UseVisualStyleBackColor = true;
            this.btnCash2.Click += new System.EventHandler(this.btnCash2_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(560, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 80);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(560, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 80);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "KEMBALI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total PemBAYARan";
            // 
            // nudKembali
            // 
            this.nudKembali.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.nudKembali.Location = new System.Drawing.Point(17, 237);
            this.nudKembali.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudKembali.Name = "nudKembali";
            this.nudKembali.ReadOnly = true;
            this.nudKembali.Size = new System.Drawing.Size(559, 64);
            this.nudKembali.TabIndex = 12;
            this.nudKembali.TabStop = false;
            this.nudKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKembali.ThousandsSeparator = true;
            this.nudKembali.Enter += new System.EventHandler(this.nudTotal_Enter);
            // 
            // nudBayar
            // 
            this.nudBayar.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.nudBayar.Location = new System.Drawing.Point(17, 49);
            this.nudBayar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudBayar.Name = "nudBayar";
            this.nudBayar.Size = new System.Drawing.Size(559, 64);
            this.nudBayar.TabIndex = 1;
            this.nudBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBayar.ThousandsSeparator = true;
            this.nudBayar.ValueChanged += new System.EventHandler(this.nudBayar_ValueChanged);
            this.nudBayar.Enter += new System.EventHandler(this.nudBayar_Enter);
            this.nudBayar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudBayar_KeyDown2);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(180, 443);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudBayar_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(287, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(233, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClose_KeyDown);
            // 
            // PVCSalesPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(567, 503);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PVCSalesPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PVCSalesPayment";
            this.Load += new System.EventHandler(this.PVCSalesPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKembali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBayar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudKembali;
        private System.Windows.Forms.NumericUpDown nudBayar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnGiro;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnTransfer2;
        private System.Windows.Forms.Button btnGiro2;
        private System.Windows.Forms.Button btnDebit2;
        private System.Windows.Forms.Button btnCash2;
    }
}