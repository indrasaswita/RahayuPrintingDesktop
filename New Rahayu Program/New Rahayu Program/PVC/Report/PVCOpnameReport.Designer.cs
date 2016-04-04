namespace Rahayu_Program.PVC.Report
{
    partial class PVCOpnameReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRekapAkhir = new System.Windows.Forms.Button();
            this.btnBedaStock = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 640);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(562, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRekapAkhir
            // 
            this.btnRekapAkhir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRekapAkhir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRekapAkhir.ForeColor = System.Drawing.Color.White;
            this.btnRekapAkhir.Location = new System.Drawing.Point(562, 12);
            this.btnRekapAkhir.Name = "btnRekapAkhir";
            this.btnRekapAkhir.Size = new System.Drawing.Size(143, 32);
            this.btnRekapAkhir.TabIndex = 3;
            this.btnRekapAkhir.Text = "Rekap Akhir";
            this.btnRekapAkhir.UseVisualStyleBackColor = true;
            this.btnRekapAkhir.Click += new System.EventHandler(this.btnRekapAkhir_Click);
            // 
            // btnBedaStock
            // 
            this.btnBedaStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBedaStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBedaStock.ForeColor = System.Drawing.Color.White;
            this.btnBedaStock.Location = new System.Drawing.Point(562, 50);
            this.btnBedaStock.Name = "btnBedaStock";
            this.btnBedaStock.Size = new System.Drawing.Size(143, 54);
            this.btnBedaStock.TabIndex = 3;
            this.btnBedaStock.Text = "Laporan Beda Stock";
            this.btnBedaStock.UseVisualStyleBackColor = true;
            this.btnBedaStock.Click += new System.EventHandler(this.btnBedaRekap_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(562, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(143, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Submit";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // PVCOpnameReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(717, 642);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBedaStock);
            this.Controls.Add(this.btnRekapAkhir);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PVCOpnameReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PVCOpnameReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PVCOpnameReport_FormClosed);
            this.Load += new System.EventHandler(this.PVCOpnameReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRekapAkhir;
        private System.Windows.Forms.Button btnBedaStock;
        private System.Windows.Forms.Button btnOK;
    }
}