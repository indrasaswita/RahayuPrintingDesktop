namespace Rahayu_Program.PVC.Transfer
{
    partial class TransferPVCList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferPVCList));
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.nudPerPack = new System.Windows.Forms.NumericUpDown();
            this.nudPack = new System.Windows.Forms.NumericUpDown();
            this.tbNamaPVC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPack)).BeginInit();
            this.SuspendLayout();
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
            this.btnDelete.TabIndex = 20;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "x";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(285, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 34);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(285, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 42);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(125, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 37);
            this.panel1.TabIndex = 16;
            // 
            // nudQty
            // 
            this.nudQty.DecimalPlaces = 2;
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudQty.Location = new System.Drawing.Point(134, 69);
            this.nudQty.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.ReadOnly = true;
            this.nudQty.Size = new System.Drawing.Size(167, 36);
            this.nudQty.TabIndex = 13;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQty.ThousandsSeparator = true;
            this.nudQty.Value = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            // 
            // nudPerPack
            // 
            this.nudPerPack.DecimalPlaces = 2;
            this.nudPerPack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudPerPack.Location = new System.Drawing.Point(152, 33);
            this.nudPerPack.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPerPack.Name = "nudPerPack";
            this.nudPerPack.ReadOnly = true;
            this.nudPerPack.Size = new System.Drawing.Size(149, 36);
            this.nudPerPack.TabIndex = 12;
            this.nudPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPerPack.ThousandsSeparator = true;
            this.nudPerPack.Value = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            // 
            // nudPack
            // 
            this.nudPack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudPack.Location = new System.Drawing.Point(5, 33);
            this.nudPack.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPack.Name = "nudPack";
            this.nudPack.ReadOnly = true;
            this.nudPack.Size = new System.Drawing.Size(120, 36);
            this.nudPack.TabIndex = 14;
            this.nudPack.TabStop = false;
            this.nudPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPack.ThousandsSeparator = true;
            this.nudPack.Value = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPack.ValueChanged += new System.EventHandler(this.nudPack_ValueChanged);
            // 
            // tbNamaPVC
            // 
            this.tbNamaPVC.Location = new System.Drawing.Point(5, 4);
            this.tbNamaPVC.Margin = new System.Windows.Forms.Padding(5);
            this.tbNamaPVC.Name = "tbNamaPVC";
            this.tbNamaPVC.ReadOnly = true;
            this.tbNamaPVC.Size = new System.Drawing.Size(280, 29);
            this.tbNamaPVC.TabIndex = 11;
            this.tbNamaPVC.Text = "PRINT DIGITAL (TANPA OVERLAY)";
            this.tbNamaPVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "=";
            // 
            // TransferPVCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.nudPerPack);
            this.Controls.Add(this.nudPack);
            this.Controls.Add(this.tbNamaPVC);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TransferPVCList";
            this.Size = new System.Drawing.Size(290, 109);
            this.Load += new System.EventHandler(this.TransferPVCList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.NumericUpDown nudPerPack;
        private System.Windows.Forms.NumericUpDown nudPack;
        private System.Windows.Forms.TextBox tbNamaPVC;
        private System.Windows.Forms.Label label2;

    }
}
