namespace Rahayu_Program.Master.PVC
{
    partial class AddNewPVC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPVC));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPVCTypeName = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPVCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeUnit = new System.Windows.Forms.ComboBox();
            this.nudSellPrice = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudPerPack = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipe PVC";
            // 
            // tbPVCTypeName
            // 
            this.tbPVCTypeName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tbPVCTypeName.Location = new System.Drawing.Point(125, 13);
            this.tbPVCTypeName.Name = "tbPVCTypeName";
            this.tbPVCTypeName.ReadOnly = true;
            this.tbPVCTypeName.Size = new System.Drawing.Size(402, 36);
            this.tbPVCTypeName.TabIndex = 1;
            this.tbPVCTypeName.TabStop = false;
            this.tbPVCTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.Location = new System.Drawing.Point(12, 55);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 26;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(515, 262);
            this.gridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama PVC";
            // 
            // tbPVCName
            // 
            this.tbPVCName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbPVCName.Location = new System.Drawing.Point(203, 323);
            this.tbPVCName.Name = "tbPVCName";
            this.tbPVCName.ReadOnly = true;
            this.tbPVCName.Size = new System.Drawing.Size(324, 29);
            this.tbPVCName.TabIndex = 1;
            this.tbPVCName.TabStop = false;
            this.tbPVCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPVCName.TextChanged += new System.EventHandler(this.tbPVCName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Satuan Per Pak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Jual Standard";
            // 
            // cbTypeUnit
            // 
            this.cbTypeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeUnit.FormattingEnabled = true;
            this.cbTypeUnit.Items.AddRange(new object[] {
            "lembar",
            "kg",
            "dus",
            "kartu",
            "roll",
            "kali",
            "ember",
            "cetak"});
            this.cbTypeUnit.Location = new System.Drawing.Point(379, 358);
            this.cbTypeUnit.Name = "cbTypeUnit";
            this.cbTypeUnit.Size = new System.Drawing.Size(148, 29);
            this.cbTypeUnit.TabIndex = 4;
            // 
            // nudSellPrice
            // 
            this.nudSellPrice.Location = new System.Drawing.Point(203, 393);
            this.nudSellPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudSellPrice.Name = "nudSellPrice";
            this.nudSellPrice.Size = new System.Drawing.Size(340, 29);
            this.nudSellPrice.TabIndex = 5;
            this.nudSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSellPrice.ThousandsSeparator = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(527, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 33);
            this.panel1.TabIndex = 6;
            // 
            // nudPerPack
            // 
            this.nudPerPack.DecimalPlaces = 2;
            this.nudPerPack.Location = new System.Drawing.Point(203, 358);
            this.nudPerPack.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPerPack.Name = "nudPerPack";
            this.nudPerPack.Size = new System.Drawing.Size(189, 29);
            this.nudPerPack.TabIndex = 5;
            this.nudPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(376, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 33);
            this.panel2.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(273, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(167, 428);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewPVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(539, 490);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbTypeUnit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudPerPack);
            this.Controls.Add(this.nudSellPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.tbPVCName);
            this.Controls.Add(this.tbPVCTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddNewPVC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewPVC";
            this.Load += new System.EventHandler(this.AddNewPVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerPack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPVCTypeName;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPVCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeUnit;
        private System.Windows.Forms.NumericUpDown nudSellPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPerPack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}