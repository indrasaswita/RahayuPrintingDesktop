namespace Rahayu_Program.Printing.Sales.SubSales
{
    partial class ChangePaymentSalesPrinting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSalesID = new System.Windows.Forms.TextBox();
            this.tbPaymentID = new System.Windows.Forms.TextBox();
            this.nudAmmount = new System.Windows.Forms.NumericUpDown();
            this.dtpPaymentTime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAmmount2 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Payment ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Waktu Bayar : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jumlah Bayar : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Metode Bayar : ";
            // 
            // tbSalesID
            // 
            this.tbSalesID.Location = new System.Drawing.Point(173, 63);
            this.tbSalesID.Name = "tbSalesID";
            this.tbSalesID.ReadOnly = true;
            this.tbSalesID.Size = new System.Drawing.Size(243, 29);
            this.tbSalesID.TabIndex = 1;
            this.tbSalesID.TabStop = false;
            this.tbSalesID.Enter += new System.EventHandler(this.tbSalesID_Enter);
            // 
            // tbPaymentID
            // 
            this.tbPaymentID.Location = new System.Drawing.Point(173, 98);
            this.tbPaymentID.Name = "tbPaymentID";
            this.tbPaymentID.ReadOnly = true;
            this.tbPaymentID.Size = new System.Drawing.Size(243, 29);
            this.tbPaymentID.TabIndex = 1;
            this.tbPaymentID.TabStop = false;
            this.tbPaymentID.Enter += new System.EventHandler(this.tbSalesID_Enter);
            // 
            // nudAmmount
            // 
            this.nudAmmount.Location = new System.Drawing.Point(173, 169);
            this.nudAmmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudAmmount.Name = "nudAmmount";
            this.nudAmmount.Size = new System.Drawing.Size(259, 29);
            this.nudAmmount.TabIndex = 2;
            // 
            // dtpPaymentTime
            // 
            this.dtpPaymentTime.CustomFormat = "ddd dd/MM/yyyy HH:mm";
            this.dtpPaymentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentTime.Location = new System.Drawing.Point(173, 134);
            this.dtpPaymentTime.Name = "dtpPaymentTime";
            this.dtpPaymentTime.Size = new System.Drawing.Size(243, 29);
            this.dtpPaymentTime.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(416, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 32);
            this.panel1.TabIndex = 4;
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "CASH",
            "TRANSFER",
            "DEBIT",
            "GIRO"});
            this.cbMethod.Location = new System.Drawing.Point(173, 239);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(243, 29);
            this.cbMethod.TabIndex = 5;
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(109, 288);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(104, 32);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Ganti";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(220, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Perubahan Pembayaran";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jumlah Bayar 2 : ";
            // 
            // nudAmmount2
            // 
            this.nudAmmount2.Location = new System.Drawing.Point(173, 204);
            this.nudAmmount2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudAmmount2.Name = "nudAmmount2";
            this.nudAmmount2.Size = new System.Drawing.Size(259, 29);
            this.nudAmmount2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(416, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 32);
            this.panel2.TabIndex = 4;
            // 
            // ChangePaymentSalesPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(430, 332);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpPaymentTime);
            this.Controls.Add(this.nudAmmount2);
            this.Controls.Add(this.nudAmmount);
            this.Controls.Add(this.tbPaymentID);
            this.Controls.Add(this.tbSalesID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChangePaymentSalesPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePaymentSalesPrinting";
            this.Load += new System.EventHandler(this.ChangePaymentSalesPrinting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmmount2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSalesID;
        private System.Windows.Forms.TextBox tbPaymentID;
        private System.Windows.Forms.NumericUpDown nudAmmount;
        private System.Windows.Forms.DateTimePicker dtpPaymentTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAmmount2;
        private System.Windows.Forms.Panel panel2;
    }
}