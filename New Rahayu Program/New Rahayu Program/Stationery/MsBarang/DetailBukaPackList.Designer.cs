namespace Rahayu_Program.Stationery.MsBarang
{
    partial class DetailBukaPackList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailBukaPackList));
            this.tbBarangID = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPerPack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamaBarangEceran = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBarangID
            // 
            this.tbBarangID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBarangID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tbBarangID.Location = new System.Drawing.Point(4, 5);
            this.tbBarangID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBarangID.Name = "tbBarangID";
            this.tbBarangID.Size = new System.Drawing.Size(87, 29);
            this.tbBarangID.TabIndex = 0;
            this.tbBarangID.Text = "500003";
            this.tbBarangID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaBarang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tbNamaBarang.Location = new System.Drawing.Point(93, 5);
            this.tbNamaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(318, 29);
            this.tbNamaBarang.TabIndex = 0;
            this.tbNamaBarang.Text = "1234567890123456789012345";
            this.tbNamaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISI";
            // 
            // tbPerPack
            // 
            this.tbPerPack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPerPack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbPerPack.Location = new System.Drawing.Point(30, 36);
            this.tbPerPack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPerPack.Name = "tbPerPack";
            this.tbPerPack.Size = new System.Drawing.Size(56, 25);
            this.tbPerPack.TabIndex = 0;
            this.tbPerPack.Text = "1000";
            this.tbPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "pcs";
            // 
            // tbNamaBarangEceran
            // 
            this.tbNamaBarangEceran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaBarangEceran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbNamaBarangEceran.Location = new System.Drawing.Point(130, 39);
            this.tbNamaBarangEceran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamaBarangEceran.Name = "tbNamaBarangEceran";
            this.tbNamaBarangEceran.Size = new System.Drawing.Size(248, 22);
            this.tbNamaBarangEceran.TabIndex = 0;
            this.tbNamaBarangEceran.Text = "1234567890123456789012345";
            this.tbNamaBarangEceran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(384, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailBukaPackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPerPack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaBarangEceran);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.tbBarangID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailBukaPackList";
            this.Size = new System.Drawing.Size(415, 65);
            this.Load += new System.EventHandler(this.DetailBukaPackList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBarangID;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPerPack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamaBarangEceran;
        private System.Windows.Forms.Button button1;
    }
}
