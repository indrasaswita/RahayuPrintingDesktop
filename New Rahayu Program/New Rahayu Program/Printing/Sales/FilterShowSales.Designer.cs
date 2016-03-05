namespace Rahayu_Program.Printing.Sales
{
    partial class FilterShowSales
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
            this.ckbLunas = new System.Windows.Forms.CheckBox();
            this.ckbJatuhTempo = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbLunas
            // 
            this.ckbLunas.AutoSize = true;
            this.ckbLunas.Location = new System.Drawing.Point(86, 225);
            this.ckbLunas.Margin = new System.Windows.Forms.Padding(5);
            this.ckbLunas.Name = "ckbLunas";
            this.ckbLunas.Size = new System.Drawing.Size(125, 25);
            this.ckbLunas.TabIndex = 44;
            this.ckbLunas.Text = "Sudah Lunas";
            this.ckbLunas.UseVisualStyleBackColor = true;
            // 
            // ckbJatuhTempo
            // 
            this.ckbJatuhTempo.AutoSize = true;
            this.ckbJatuhTempo.Checked = true;
            this.ckbJatuhTempo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbJatuhTempo.Location = new System.Drawing.Point(86, 250);
            this.ckbJatuhTempo.Margin = new System.Windows.Forms.Padding(5);
            this.ckbJatuhTempo.Name = "ckbJatuhTempo";
            this.ckbJatuhTempo.Size = new System.Drawing.Size(128, 25);
            this.ckbJatuhTempo.TabIndex = 43;
            this.ckbJatuhTempo.Text = "Jatuh Tempo";
            this.ckbJatuhTempo.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(84, 286);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "DONE!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FilterShowSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ckbLunas);
            this.Controls.Add(this.ckbJatuhTempo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FilterShowSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterShowSales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbLunas;
        private System.Windows.Forms.CheckBox ckbJatuhTempo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}