namespace Rahayu_Program.PVC.Report
{
    partial class OpnameList
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
            this.btnNext = new System.Windows.Forms.Button();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.tbPVCName = new System.Windows.Forms.TextBox();
            this.nudPerPack = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTypeUnit1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.tbTypeUnit2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(460, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 30);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // nudQty
            // 
            this.nudQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nudQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudQty.Location = new System.Drawing.Point(3, 25);
            this.nudQty.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(118, 32);
            this.nudQty.TabIndex = 2;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQty.ThousandsSeparator = true;
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            this.nudQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudQty_KeyDown);
            // 
            // tbPVCName
            // 
            this.tbPVCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbPVCName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPVCName.Location = new System.Drawing.Point(3, 3);
            this.tbPVCName.Multiline = true;
            this.tbPVCName.Name = "tbPVCName";
            this.tbPVCName.ReadOnly = true;
            this.tbPVCName.Size = new System.Drawing.Size(451, 22);
            this.tbPVCName.TabIndex = 1;
            this.tbPVCName.TabStop = false;
            this.tbPVCName.Text = "PVC Core 0.3 HK (10.5)";
            // 
            // nudPerPack
            // 
            this.nudPerPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nudPerPack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPerPack.DecimalPlaces = 2;
            this.nudPerPack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudPerPack.Location = new System.Drawing.Point(127, 25);
            this.nudPerPack.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPerPack.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.nudPerPack.Name = "nudPerPack";
            this.nudPerPack.ReadOnly = true;
            this.nudPerPack.Size = new System.Drawing.Size(97, 32);
            this.nudPerPack.TabIndex = 5;
            this.nudPerPack.TabStop = false;
            this.nudPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPerPack.ThousandsSeparator = true;
            this.nudPerPack.ValueChanged += new System.EventHandler(this.nudPerPack_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(105, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 43);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(208, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 43);
            this.panel1.TabIndex = 6;
            // 
            // tbTypeUnit1
            // 
            this.tbTypeUnit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbTypeUnit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeUnit1.Location = new System.Drawing.Point(208, 29);
            this.tbTypeUnit1.Multiline = true;
            this.tbTypeUnit1.Name = "tbTypeUnit1";
            this.tbTypeUnit1.ReadOnly = true;
            this.tbTypeUnit1.Size = new System.Drawing.Size(75, 22);
            this.tbTypeUnit1.TabIndex = 7;
            this.tbTypeUnit1.TabStop = false;
            this.tbTypeUnit1.Text = "lembar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "=";
            // 
            // nudTotal
            // 
            this.nudTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nudTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudTotal.Location = new System.Drawing.Point(298, 25);
            this.nudTotal.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudTotal.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(97, 32);
            this.nudTotal.TabIndex = 9;
            this.nudTotal.TabStop = false;
            this.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // tbTypeUnit2
            // 
            this.tbTypeUnit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbTypeUnit2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeUnit2.Location = new System.Drawing.Point(379, 29);
            this.tbTypeUnit2.Multiline = true;
            this.tbTypeUnit2.Name = "tbTypeUnit2";
            this.tbTypeUnit2.ReadOnly = true;
            this.tbTypeUnit2.Size = new System.Drawing.Size(75, 22);
            this.tbTypeUnit2.TabIndex = 11;
            this.tbTypeUnit2.TabStop = false;
            this.tbTypeUnit2.Text = "lembar";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(379, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 43);
            this.panel3.TabIndex = 10;
            // 
            // OpnameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.tbTypeUnit2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbTypeUnit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.nudPerPack);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.tbPVCName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OpnameList";
            this.Size = new System.Drawing.Size(535, 60);
            this.Load += new System.EventHandler(this.OpnameList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.TextBox tbPVCName;
        private System.Windows.Forms.NumericUpDown nudPerPack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTypeUnit1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.TextBox tbTypeUnit2;
        private System.Windows.Forms.Panel panel3;
    }
}
