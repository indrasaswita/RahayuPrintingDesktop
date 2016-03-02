namespace Rahayu_Program.Master.Customer
{
    partial class SearchCustomerPVC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerPVC));
            this.treeCust = new System.Windows.Forms.TreeView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbParentName = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbParentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompanyID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.btnUpdateParent = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnDeleteParent = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbCompanyPhone = new System.Windows.Forms.TextBox();
            this.tbCompanyAddress = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.btnUpdateParentName = new System.Windows.Forms.Button();
            this.btnUpdateCompanyName = new System.Windows.Forms.Button();
            this.btnUpdateCompanyAddress = new System.Windows.Forms.Button();
            this.btnUpdateCustomerName = new System.Windows.Forms.Button();
            this.btnUpdateCustomerAddress = new System.Windows.Forms.Button();
            this.btnUpdateCompanyPhone = new System.Windows.Forms.Button();
            this.btnUpdateCustomerPhone = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeCust
            // 
            this.treeCust.ForeColor = System.Drawing.Color.Black;
            this.treeCust.Location = new System.Drawing.Point(12, 12);
            this.treeCust.Name = "treeCust";
            this.treeCust.Size = new System.Drawing.Size(492, 682);
            this.treeCust.TabIndex = 1;
            this.treeCust.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCust_AfterSelect);
            this.treeCust.DoubleClick += new System.EventHandler(this.treeCust_DoubleClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 700);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(457, 29);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // tbParentName
            // 
            this.tbParentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbParentName.Location = new System.Drawing.Point(511, 65);
            this.tbParentName.Name = "tbParentName";
            this.tbParentName.ReadOnly = true;
            this.tbParentName.Size = new System.Drawing.Size(334, 29);
            this.tbParentName.TabIndex = 5;
            this.tbParentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbCompanyName.Location = new System.Drawing.Point(511, 209);
            this.tbCompanyName.Multiline = true;
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.ReadOnly = true;
            this.tbCompanyName.Size = new System.Drawing.Size(334, 51);
            this.tbCompanyName.TabIndex = 11;
            this.tbCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbCustomerName.Location = new System.Drawing.Point(511, 469);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.ReadOnly = true;
            this.tbCustomerName.Size = new System.Drawing.Size(334, 29);
            this.tbCustomerName.TabIndex = 17;
            this.tbCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbParentID
            // 
            this.tbParentID.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.tbParentID.Location = new System.Drawing.Point(724, 12);
            this.tbParentID.Name = "tbParentID";
            this.tbParentID.ReadOnly = true;
            this.tbParentID.Size = new System.Drawing.Size(121, 47);
            this.tbParentID.TabIndex = 4;
            this.tbParentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(552, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parent ID :";
            // 
            // tbCompanyID
            // 
            this.tbCompanyID.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.tbCompanyID.Location = new System.Drawing.Point(724, 156);
            this.tbCompanyID.Name = "tbCompanyID";
            this.tbCompanyID.ReadOnly = true;
            this.tbCompanyID.Size = new System.Drawing.Size(121, 47);
            this.tbCompanyID.TabIndex = 10;
            this.tbCompanyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCompanyID.TextChanged += new System.EventHandler(this.tbCompanyID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(511, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Company ID :";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.tbCustomerID.Location = new System.Drawing.Point(724, 416);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.ReadOnly = true;
            this.tbCustomerID.Size = new System.Drawing.Size(121, 47);
            this.tbCustomerID.TabIndex = 16;
            this.tbCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustomerID.TextChanged += new System.EventHandler(this.tbCustomerID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(509, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 41);
            this.label3.TabIndex = 15;
            this.label3.Text = "Customer ID :";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(722, 679);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 23;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCompany.BackgroundImage")));
            this.btnAddCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompany.ForeColor = System.Drawing.Color.White;
            this.btnAddCompany.Location = new System.Drawing.Point(522, 360);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(100, 50);
            this.btnAddCompany.TabIndex = 12;
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(522, 598);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnAddCustomer.TabIndex = 18;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCompany.BackgroundImage")));
            this.btnUpdateCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCompany.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCompany.Location = new System.Drawing.Point(628, 360);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateCompany.TabIndex = 13;
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // btnUpdateParent
            // 
            this.btnUpdateParent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateParent.BackgroundImage")));
            this.btnUpdateParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateParent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateParent.Location = new System.Drawing.Point(628, 100);
            this.btnUpdateParent.Name = "btnUpdateParent";
            this.btnUpdateParent.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateParent.TabIndex = 7;
            this.btnUpdateParent.UseVisualStyleBackColor = true;
            this.btnUpdateParent.Click += new System.EventHandler(this.btnUpdateParent_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.BackgroundImage")));
            this.btnUpdateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(628, 598);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateCustomer.TabIndex = 19;
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddParent
            // 
            this.btnAddParent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddParent.BackgroundImage")));
            this.btnAddParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParent.ForeColor = System.Drawing.Color.White;
            this.btnAddParent.Location = new System.Drawing.Point(522, 100);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(100, 50);
            this.btnAddParent.TabIndex = 6;
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.BackgroundImage")));
            this.btnDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(734, 598);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteCustomer.TabIndex = 20;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Visible = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCompany.BackgroundImage")));
            this.btnDeleteCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCompany.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCompany.Location = new System.Drawing.Point(734, 360);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteCompany.TabIndex = 14;
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Visible = false;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnDeleteParent
            // 
            this.btnDeleteParent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteParent.BackgroundImage")));
            this.btnDeleteParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteParent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteParent.Location = new System.Drawing.Point(734, 100);
            this.btnDeleteParent.Name = "btnDeleteParent";
            this.btnDeleteParent.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteParent.TabIndex = 8;
            this.btnDeleteParent.UseVisualStyleBackColor = true;
            this.btnDeleteParent.Visible = false;
            this.btnDeleteParent.Click += new System.EventHandler(this.btnDeleteParent_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(641, 654);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 75);
            this.btnOK.TabIndex = 22;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(535, 679);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 50);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbCompanyPhone
            // 
            this.tbCompanyPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbCompanyPhone.Location = new System.Drawing.Point(511, 266);
            this.tbCompanyPhone.Name = "tbCompanyPhone";
            this.tbCompanyPhone.ReadOnly = true;
            this.tbCompanyPhone.Size = new System.Drawing.Size(334, 25);
            this.tbCompanyPhone.TabIndex = 24;
            this.tbCompanyPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCompanyAddress
            // 
            this.tbCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbCompanyAddress.Location = new System.Drawing.Point(511, 297);
            this.tbCompanyAddress.Multiline = true;
            this.tbCompanyAddress.Name = "tbCompanyAddress";
            this.tbCompanyAddress.ReadOnly = true;
            this.tbCompanyAddress.Size = new System.Drawing.Size(334, 57);
            this.tbCompanyAddress.TabIndex = 24;
            this.tbCompanyAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbCustomerPhone.Location = new System.Drawing.Point(510, 504);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.ReadOnly = true;
            this.tbCustomerPhone.Size = new System.Drawing.Size(334, 25);
            this.tbCustomerPhone.TabIndex = 24;
            this.tbCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbCustomerAddress.Location = new System.Drawing.Point(510, 535);
            this.tbCustomerAddress.Multiline = true;
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.ReadOnly = true;
            this.tbCustomerAddress.Size = new System.Drawing.Size(334, 57);
            this.tbCustomerAddress.TabIndex = 24;
            this.tbCustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateParentName
            // 
            this.btnUpdateParentName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateParentName.BackgroundImage")));
            this.btnUpdateParentName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateParentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateParentName.ForeColor = System.Drawing.Color.White;
            this.btnUpdateParentName.Location = new System.Drawing.Point(851, 65);
            this.btnUpdateParentName.Name = "btnUpdateParentName";
            this.btnUpdateParentName.Size = new System.Drawing.Size(29, 29);
            this.btnUpdateParentName.TabIndex = 25;
            this.btnUpdateParentName.UseVisualStyleBackColor = true;
            this.btnUpdateParentName.Visible = false;
            this.btnUpdateParentName.Click += new System.EventHandler(this.btnUpdateParentName_Click);
            // 
            // btnUpdateCompanyName
            // 
            this.btnUpdateCompanyName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCompanyName.BackgroundImage")));
            this.btnUpdateCompanyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCompanyName.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCompanyName.Location = new System.Drawing.Point(851, 209);
            this.btnUpdateCompanyName.Name = "btnUpdateCompanyName";
            this.btnUpdateCompanyName.Size = new System.Drawing.Size(29, 29);
            this.btnUpdateCompanyName.TabIndex = 25;
            this.btnUpdateCompanyName.UseVisualStyleBackColor = true;
            this.btnUpdateCompanyName.Click += new System.EventHandler(this.btnUpdateCompanyName_Click);
            // 
            // btnUpdateCompanyAddress
            // 
            this.btnUpdateCompanyAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCompanyAddress.BackgroundImage")));
            this.btnUpdateCompanyAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCompanyAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCompanyAddress.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCompanyAddress.Location = new System.Drawing.Point(851, 297);
            this.btnUpdateCompanyAddress.Name = "btnUpdateCompanyAddress";
            this.btnUpdateCompanyAddress.Size = new System.Drawing.Size(25, 25);
            this.btnUpdateCompanyAddress.TabIndex = 25;
            this.btnUpdateCompanyAddress.UseVisualStyleBackColor = true;
            this.btnUpdateCompanyAddress.Click += new System.EventHandler(this.btnUpdateCompanyAddress_Click);
            // 
            // btnUpdateCustomerName
            // 
            this.btnUpdateCustomerName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomerName.BackgroundImage")));
            this.btnUpdateCustomerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomerName.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomerName.Location = new System.Drawing.Point(851, 469);
            this.btnUpdateCustomerName.Name = "btnUpdateCustomerName";
            this.btnUpdateCustomerName.Size = new System.Drawing.Size(29, 29);
            this.btnUpdateCustomerName.TabIndex = 25;
            this.btnUpdateCustomerName.UseVisualStyleBackColor = true;
            this.btnUpdateCustomerName.Visible = false;
            this.btnUpdateCustomerName.Click += new System.EventHandler(this.btnUpdateCustomerName_Click);
            // 
            // btnUpdateCustomerAddress
            // 
            this.btnUpdateCustomerAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomerAddress.BackgroundImage")));
            this.btnUpdateCustomerAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCustomerAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomerAddress.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomerAddress.Location = new System.Drawing.Point(851, 535);
            this.btnUpdateCustomerAddress.Name = "btnUpdateCustomerAddress";
            this.btnUpdateCustomerAddress.Size = new System.Drawing.Size(25, 25);
            this.btnUpdateCustomerAddress.TabIndex = 25;
            this.btnUpdateCustomerAddress.UseVisualStyleBackColor = true;
            this.btnUpdateCustomerAddress.Visible = false;
            this.btnUpdateCustomerAddress.Click += new System.EventHandler(this.btnUpdateCustomerAddress_Click);
            // 
            // btnUpdateCompanyPhone
            // 
            this.btnUpdateCompanyPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCompanyPhone.BackgroundImage")));
            this.btnUpdateCompanyPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCompanyPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCompanyPhone.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCompanyPhone.Location = new System.Drawing.Point(851, 266);
            this.btnUpdateCompanyPhone.Name = "btnUpdateCompanyPhone";
            this.btnUpdateCompanyPhone.Size = new System.Drawing.Size(25, 25);
            this.btnUpdateCompanyPhone.TabIndex = 25;
            this.btnUpdateCompanyPhone.UseVisualStyleBackColor = true;
            this.btnUpdateCompanyPhone.Click += new System.EventHandler(this.btnUpdateCompanyPhone_Click);
            // 
            // btnUpdateCustomerPhone
            // 
            this.btnUpdateCustomerPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomerPhone.BackgroundImage")));
            this.btnUpdateCustomerPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCustomerPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomerPhone.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomerPhone.Location = new System.Drawing.Point(851, 504);
            this.btnUpdateCustomerPhone.Name = "btnUpdateCustomerPhone";
            this.btnUpdateCustomerPhone.Size = new System.Drawing.Size(25, 25);
            this.btnUpdateCustomerPhone.TabIndex = 25;
            this.btnUpdateCustomerPhone.UseVisualStyleBackColor = true;
            this.btnUpdateCustomerPhone.Visible = false;
            this.btnUpdateCustomerPhone.Click += new System.EventHandler(this.btnUpdateCustomerPhone_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(475, 699);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 29);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchCustomerPVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(890, 741);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdateCustomerAddress);
            this.Controls.Add(this.btnUpdateCustomerName);
            this.Controls.Add(this.btnUpdateCompanyAddress);
            this.Controls.Add(this.btnUpdateCustomerPhone);
            this.Controls.Add(this.btnUpdateCompanyPhone);
            this.Controls.Add(this.btnUpdateCompanyName);
            this.Controls.Add(this.btnUpdateParentName);
            this.Controls.Add(this.tbCustomerAddress);
            this.Controls.Add(this.tbCompanyAddress);
            this.Controls.Add(this.tbCustomerPhone);
            this.Controls.Add(this.tbCompanyPhone);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.btnDeleteParent);
            this.Controls.Add(this.btnUpdateParent);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.tbCompanyID);
            this.Controls.Add(this.tbParentID);
            this.Controls.Add(this.tbParentName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.treeCust);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchCustomerPVC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchCustomerPVC";
            this.Load += new System.EventHandler(this.SearchCustomerPVC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeCust;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbParentName;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbParentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompanyID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnUpdateParent;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnDeleteParent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbCompanyPhone;
        private System.Windows.Forms.TextBox tbCompanyAddress;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Button btnUpdateParentName;
        private System.Windows.Forms.Button btnUpdateCompanyName;
        private System.Windows.Forms.Button btnUpdateCompanyAddress;
        private System.Windows.Forms.Button btnUpdateCustomerName;
        private System.Windows.Forms.Button btnUpdateCustomerAddress;
        private System.Windows.Forms.Button btnUpdateCompanyPhone;
        private System.Windows.Forms.Button btnUpdateCustomerPhone;
        private System.Windows.Forms.Button btnSearch;
    }
}