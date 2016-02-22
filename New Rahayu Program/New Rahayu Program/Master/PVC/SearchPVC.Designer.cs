namespace Rahayu_Program.Master.PVC
{
    partial class SearchPVC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPVC));
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeletePVC = new System.Windows.Forms.Button();
            this.btnUpdatePVC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPVCID = new System.Windows.Forms.TextBox();
            this.tbPVCName = new System.Windows.Forms.TextBox();
            this.btnAddPVC = new System.Windows.Forms.Button();
            this.tbPVCPerPack = new System.Windows.Forms.TextBox();
            this.tbPVCTypeUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPVCTypeName = new System.Windows.Forms.TextBox();
            this.tbPVCTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPVCType = new System.Windows.Forms.Button();
            this.btnUpdatePVCType = new System.Windows.Forms.Button();
            this.btnDeletePVCType = new System.Windows.Forms.Button();
            this.treePVC = new System.Windows.Forms.TreeView();
            this.nudSellPrice = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(371, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "SELECT PVC";
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(499, 632);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 100);
            this.btnOK.TabIndex = 13;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(605, 682);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeletePVC
            // 
            this.btnDeletePVC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePVC.BackgroundImage")));
            this.btnDeletePVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePVC.ForeColor = System.Drawing.Color.White;
            this.btnDeletePVC.Location = new System.Drawing.Point(594, 461);
            this.btnDeletePVC.Name = "btnDeletePVC";
            this.btnDeletePVC.Size = new System.Drawing.Size(100, 50);
            this.btnDeletePVC.TabIndex = 19;
            this.btnDeletePVC.UseVisualStyleBackColor = true;
            this.btnDeletePVC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // btnUpdatePVC
            // 
            this.btnUpdatePVC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePVC.BackgroundImage")));
            this.btnUpdatePVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdatePVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePVC.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePVC.Location = new System.Drawing.Point(488, 461);
            this.btnUpdatePVC.Name = "btnUpdatePVC";
            this.btnUpdatePVC.Size = new System.Drawing.Size(100, 50);
            this.btnUpdatePVC.TabIndex = 20;
            this.btnUpdatePVC.UseVisualStyleBackColor = true;
            this.btnUpdatePVC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(453, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "PVC ID :";
            // 
            // tbPVCID
            // 
            this.tbPVCID.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.tbPVCID.Location = new System.Drawing.Point(584, 295);
            this.tbPVCID.Name = "tbPVCID";
            this.tbPVCID.ReadOnly = true;
            this.tbPVCID.Size = new System.Drawing.Size(121, 47);
            this.tbPVCID.TabIndex = 15;
            this.tbPVCID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // tbPVCName
            // 
            this.tbPVCName.Location = new System.Drawing.Point(371, 348);
            this.tbPVCName.Name = "tbPVCName";
            this.tbPVCName.ReadOnly = true;
            this.tbPVCName.Size = new System.Drawing.Size(334, 29);
            this.tbPVCName.TabIndex = 16;
            this.tbPVCName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // btnAddPVC
            // 
            this.btnAddPVC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPVC.BackgroundImage")));
            this.btnAddPVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPVC.ForeColor = System.Drawing.Color.White;
            this.btnAddPVC.Location = new System.Drawing.Point(382, 461);
            this.btnAddPVC.Name = "btnAddPVC";
            this.btnAddPVC.Size = new System.Drawing.Size(100, 50);
            this.btnAddPVC.TabIndex = 13;
            this.btnAddPVC.UseVisualStyleBackColor = true;
            this.btnAddPVC.Click += new System.EventHandler(this.btnAddPVC_Click);
            this.btnAddPVC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // tbPVCPerPack
            // 
            this.tbPVCPerPack.Location = new System.Drawing.Point(495, 383);
            this.tbPVCPerPack.Name = "tbPVCPerPack";
            this.tbPVCPerPack.ReadOnly = true;
            this.tbPVCPerPack.Size = new System.Drawing.Size(93, 29);
            this.tbPVCPerPack.TabIndex = 16;
            this.tbPVCPerPack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // tbPVCTypeUnit
            // 
            this.tbPVCTypeUnit.Location = new System.Drawing.Point(594, 383);
            this.tbPVCTypeUnit.Name = "tbPVCTypeUnit";
            this.tbPVCTypeUnit.ReadOnly = true;
            this.tbPVCTypeUnit.Size = new System.Drawing.Size(111, 29);
            this.tbPVCTypeUnit.TabIndex = 16;
            this.tbPVCTypeUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Minimum BELI:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPVCTypeName
            // 
            this.tbPVCTypeName.Location = new System.Drawing.Point(371, 170);
            this.tbPVCTypeName.Name = "tbPVCTypeName";
            this.tbPVCTypeName.ReadOnly = true;
            this.tbPVCTypeName.Size = new System.Drawing.Size(334, 29);
            this.tbPVCTypeName.TabIndex = 16;
            this.tbPVCTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // tbPVCTypeID
            // 
            this.tbPVCTypeID.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.tbPVCTypeID.Location = new System.Drawing.Point(584, 117);
            this.tbPVCTypeID.Name = "tbPVCTypeID";
            this.tbPVCTypeID.ReadOnly = true;
            this.tbPVCTypeID.Size = new System.Drawing.Size(121, 47);
            this.tbPVCTypeID.TabIndex = 15;
            this.tbPVCTypeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(375, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "PVC Type ID :";
            // 
            // btnAddPVCType
            // 
            this.btnAddPVCType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPVCType.BackgroundImage")));
            this.btnAddPVCType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPVCType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPVCType.ForeColor = System.Drawing.Color.White;
            this.btnAddPVCType.Location = new System.Drawing.Point(382, 205);
            this.btnAddPVCType.Name = "btnAddPVCType";
            this.btnAddPVCType.Size = new System.Drawing.Size(100, 50);
            this.btnAddPVCType.TabIndex = 13;
            this.btnAddPVCType.UseVisualStyleBackColor = true;
            this.btnAddPVCType.Click += new System.EventHandler(this.btnAddPVC_Click);
            this.btnAddPVCType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // btnUpdatePVCType
            // 
            this.btnUpdatePVCType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePVCType.BackgroundImage")));
            this.btnUpdatePVCType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdatePVCType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePVCType.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePVCType.Location = new System.Drawing.Point(488, 205);
            this.btnUpdatePVCType.Name = "btnUpdatePVCType";
            this.btnUpdatePVCType.Size = new System.Drawing.Size(100, 50);
            this.btnUpdatePVCType.TabIndex = 20;
            this.btnUpdatePVCType.UseVisualStyleBackColor = true;
            this.btnUpdatePVCType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // btnDeletePVCType
            // 
            this.btnDeletePVCType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePVCType.BackgroundImage")));
            this.btnDeletePVCType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePVCType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePVCType.ForeColor = System.Drawing.Color.White;
            this.btnDeletePVCType.Location = new System.Drawing.Point(594, 205);
            this.btnDeletePVCType.Name = "btnDeletePVCType";
            this.btnDeletePVCType.Size = new System.Drawing.Size(100, 50);
            this.btnDeletePVCType.TabIndex = 19;
            this.btnDeletePVCType.UseVisualStyleBackColor = true;
            this.btnDeletePVCType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // treePVC
            // 
            this.treePVC.Location = new System.Drawing.Point(13, 13);
            this.treePVC.Name = "treePVC";
            this.treePVC.Size = new System.Drawing.Size(352, 692);
            this.treePVC.TabIndex = 22;
            this.treePVC.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treePVC_AfterSelect);
            this.treePVC.DoubleClick += new System.EventHandler(this.treePVC_DoubleClick);
            this.treePVC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treePVC_KeyDown);
            // 
            // nudSellPrice
            // 
            this.nudSellPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.nudSellPrice.Location = new System.Drawing.Point(495, 419);
            this.nudSellPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSellPrice.Name = "nudSellPrice";
            this.nudSellPrice.Size = new System.Drawing.Size(226, 36);
            this.nudSellPrice.TabIndex = 23;
            this.nudSellPrice.ThousandsSeparator = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(705, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 46);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Harga Jual:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 710);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "* Tulisan Merah = STOCK HABIS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchPVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(715, 744);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudSellPrice);
            this.Controls.Add(this.treePVC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletePVCType);
            this.Controls.Add(this.btnUpdatePVCType);
            this.Controls.Add(this.btnDeletePVC);
            this.Controls.Add(this.btnUpdatePVC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPVCTypeID);
            this.Controls.Add(this.tbPVCID);
            this.Controls.Add(this.tbPVCTypeUnit);
            this.Controls.Add(this.tbPVCTypeName);
            this.Controls.Add(this.tbPVCPerPack);
            this.Controls.Add(this.tbPVCName);
            this.Controls.Add(this.btnAddPVCType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPVC);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchPVC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchPVC";
            this.Load += new System.EventHandler(this.SearchPVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeletePVC;
        private System.Windows.Forms.Button btnUpdatePVC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPVCID;
        private System.Windows.Forms.TextBox tbPVCName;
        private System.Windows.Forms.Button btnAddPVC;
        private System.Windows.Forms.TextBox tbPVCPerPack;
        private System.Windows.Forms.TextBox tbPVCTypeUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPVCTypeName;
        private System.Windows.Forms.TextBox tbPVCTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPVCType;
        private System.Windows.Forms.Button btnUpdatePVCType;
        private System.Windows.Forms.Button btnDeletePVCType;
        private System.Windows.Forms.TreeView treePVC;
        private System.Windows.Forms.NumericUpDown nudSellPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}