namespace Rahayu_Program.Stationery.Report
{
    partial class RekapInputList
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
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
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
            this.tbNomorBarang.TabIndex = 1;
            this.tbNomorBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tbNamaBarang.TabIndex = 0;
            this.tbNamaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudQty.Location = new System.Drawing.Point(282, 23);
            this.nudQty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(97, 36);
            this.nudQty.TabIndex = 5;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQty.ThousandsSeparator = true;
            this.nudQty.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQty.Enter += new System.EventHandler(this.nudQty_Enter);
            this.nudQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudQty_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qty:";
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(382, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(168, 30);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(100, 29);
            this.btnBarcode.TabIndex = 2;
            this.btnBarcode.Text = "Barcode!";
            this.btnBarcode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(275, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 71);
            this.panel1.TabIndex = 4;
            // 
            // RekapInputList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.tbNomorBarang);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RekapInputList";
            this.Size = new System.Drawing.Size(449, 62);
            this.Load += new System.EventHandler(this.RekapInputList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomorBarang;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Panel panel1;

    }
}
