namespace Rahayu_Program.Master.Customer
{
    partial class AddCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompany));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPhone2 = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbParentCompany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(239, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCompany.BackgroundImage")));
            this.btnAddCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompany.ForeColor = System.Drawing.Color.White;
            this.btnAddCompany.Location = new System.Drawing.Point(133, 639);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(100, 50);
            this.btnAddCompany.TabIndex = 8;
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbCompanyName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbCompanyName.Location = new System.Drawing.Point(12, 368);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(449, 39);
            this.tbCompanyName.TabIndex = 2;
            this.tbCompanyName.Text = "Company Name";
            this.tbCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCompanyName.TextChanged += new System.EventHandler(this.tbCompanyName_TextChanged);
            this.tbCompanyName.Enter += new System.EventHandler(this.tbCompanyName_Enter);
            this.tbCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCompanyName_KeyDown);
            this.tbCompanyName.Leave += new System.EventHandler(this.tbCompanyName_Leave);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.Location = new System.Drawing.Point(12, 59);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 26;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(449, 303);
            this.gridView.TabIndex = 1;
            // 
            // tbAlias
            // 
            this.tbAlias.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbAlias.ForeColor = System.Drawing.Color.DarkGray;
            this.tbAlias.Location = new System.Drawing.Point(12, 413);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(449, 39);
            this.tbAlias.TabIndex = 3;
            this.tbAlias.Text = "Alias";
            this.tbAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAlias.Enter += new System.EventHandler(this.tbAlias_Enter);
            this.tbAlias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAlias_KeyDown);
            this.tbAlias.Leave += new System.EventHandler(this.tbAlias_Leave);
            // 
            // tbFax
            // 
            this.tbFax.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbFax.ForeColor = System.Drawing.Color.DarkGray;
            this.tbFax.Location = new System.Drawing.Point(12, 458);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(449, 39);
            this.tbFax.TabIndex = 4;
            this.tbFax.Text = "Fax";
            this.tbFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFax.Enter += new System.EventHandler(this.tbFax_Enter);
            this.tbFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFax_KeyDown);
            this.tbFax.Leave += new System.EventHandler(this.tbFax_Leave);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbPhone.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPhone.Location = new System.Drawing.Point(12, 503);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(449, 39);
            this.tbPhone.TabIndex = 5;
            this.tbPhone.Text = "Phone 1";
            this.tbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhone.Enter += new System.EventHandler(this.tbPhone_Enter);
            this.tbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhone_KeyDown);
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
            // 
            // tbPhone2
            // 
            this.tbPhone2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbPhone2.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPhone2.Location = new System.Drawing.Point(12, 548);
            this.tbPhone2.Name = "tbPhone2";
            this.tbPhone2.Size = new System.Drawing.Size(449, 39);
            this.tbPhone2.TabIndex = 6;
            this.tbPhone2.Text = "Phone 2";
            this.tbPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhone2.Enter += new System.EventHandler(this.tbPhone2_Enter);
            this.tbPhone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhone2_KeyDown);
            this.tbPhone2.Leave += new System.EventHandler(this.tbPhone2_Leave);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbAddress.ForeColor = System.Drawing.Color.DarkGray;
            this.tbAddress.Location = new System.Drawing.Point(12, 593);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(449, 39);
            this.tbAddress.TabIndex = 7;
            this.tbAddress.Text = "Address";
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddress.Enter += new System.EventHandler(this.tbAddress_Enter);
            this.tbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddress_KeyDown);
            this.tbAddress.Leave += new System.EventHandler(this.tbAddress_Leave);
            // 
            // tbParentCompany
            // 
            this.tbParentCompany.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.tbParentCompany.Location = new System.Drawing.Point(12, 14);
            this.tbParentCompany.Name = "tbParentCompany";
            this.tbParentCompany.ReadOnly = true;
            this.tbParentCompany.Size = new System.Drawing.Size(449, 39);
            this.tbParentCompany.TabIndex = 0;
            this.tbParentCompany.Text = "Parent Company Name";
            this.tbParentCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbParentCompany.Enter += new System.EventHandler(this.tbParentCompany_Enter);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(473, 701);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone2);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbAlias);
            this.Controls.Add(this.tbParentCompany);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.gridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompany";
            this.Load += new System.EventHandler(this.AddCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPhone2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbParentCompany;
    }
}