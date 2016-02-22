namespace Rahayu_Program.PVC.Sales
{
    partial class SalesPVCList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPVCList));
            this.tbNamaPVC = new System.Windows.Forms.TextBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNamaPVC
            // 
            this.tbNamaPVC.Location = new System.Drawing.Point(5, 4);
            this.tbNamaPVC.Margin = new System.Windows.Forms.Padding(5);
            this.tbNamaPVC.Name = "tbNamaPVC";
            this.tbNamaPVC.ReadOnly = true;
            this.tbNamaPVC.Size = new System.Drawing.Size(280, 29);
            this.tbNamaPVC.TabIndex = 0;
            this.tbNamaPVC.TabStop = false;
            this.tbNamaPVC.Text = "PRINT DIGITAL (TANPA OVERLAY)";
            this.tbNamaPVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNamaPVC.Enter += new System.EventHandler(this.tbNamaPVC_Enter);
            // 
            // nudQty
            // 
            this.nudQty.DecimalPlaces = 2;
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudQty.Location = new System.Drawing.Point(5, 33);
            this.nudQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.ReadOnly = true;
            this.nudQty.Size = new System.Drawing.Size(139, 36);
            this.nudQty.TabIndex = 1;
            this.nudQty.TabStop = false;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQty.ThousandsSeparator = true;
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(144, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 37);
            this.panel1.TabIndex = 5;
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudPrice.Location = new System.Drawing.Point(174, 33);
            this.nudPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ReadOnly = true;
            this.nudPrice.Size = new System.Drawing.Size(127, 36);
            this.nudPrice.TabIndex = 1;
            this.nudPrice.TabStop = false;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrice.ThousandsSeparator = true;
            this.nudPrice.Enter += new System.EventHandler(this.tbNamaPVC_Enter);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(285, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 42);
            this.panel2.TabIndex = 5;
            // 
            // nudTotal
            // 
            this.nudTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudTotal.Location = new System.Drawing.Point(134, 69);
            this.nudTotal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(167, 36);
            this.nudTotal.TabIndex = 1;
            this.nudTotal.TabStop = false;
            this.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotal.ThousandsSeparator = true;
            this.nudTotal.ValueChanged += new System.EventHandler(this.nudTotal_ValueChanged);
            this.nudTotal.Enter += new System.EventHandler(this.tbNamaPVC_Enter);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(285, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 34);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(5, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SalesPVCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.tbNamaPVC);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalesPVCList";
            this.Size = new System.Drawing.Size(290, 109);
            this.Load += new System.EventHandler(this.SalesPVCList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNamaPVC;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
    }
}
