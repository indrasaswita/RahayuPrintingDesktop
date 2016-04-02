namespace Rahayu_Program.Stationery.Purchase
{
    partial class ViewAllPembelianByPurchaseID
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPurchaseHeader = new System.Windows.Forms.DataGridView();
            this.gridPurchaseDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPurchaseHeader
            // 
            this.gridPurchaseHeader.AllowUserToAddRows = false;
            this.gridPurchaseHeader.AllowUserToDeleteRows = false;
            this.gridPurchaseHeader.BackgroundColor = System.Drawing.Color.White;
            this.gridPurchaseHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPurchaseHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPurchaseHeader.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridPurchaseHeader.Location = new System.Drawing.Point(14, 14);
            this.gridPurchaseHeader.Margin = new System.Windows.Forms.Padding(5);
            this.gridPurchaseHeader.Name = "gridPurchaseHeader";
            this.gridPurchaseHeader.ReadOnly = true;
            this.gridPurchaseHeader.RowHeadersVisible = false;
            this.gridPurchaseHeader.RowTemplate.Height = 26;
            this.gridPurchaseHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchaseHeader.Size = new System.Drawing.Size(210, 675);
            this.gridPurchaseHeader.TabIndex = 3;
            this.gridPurchaseHeader.SelectionChanged += new System.EventHandler(this.gridPurchaseHeader_SelectionChanged);
            // 
            // gridPurchaseDetail
            // 
            this.gridPurchaseDetail.AllowUserToAddRows = false;
            this.gridPurchaseDetail.AllowUserToDeleteRows = false;
            this.gridPurchaseDetail.BackgroundColor = System.Drawing.Color.White;
            this.gridPurchaseDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPurchaseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPurchaseDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPurchaseDetail.Location = new System.Drawing.Point(234, 14);
            this.gridPurchaseDetail.Margin = new System.Windows.Forms.Padding(5);
            this.gridPurchaseDetail.Name = "gridPurchaseDetail";
            this.gridPurchaseDetail.ReadOnly = true;
            this.gridPurchaseDetail.RowHeadersVisible = false;
            this.gridPurchaseDetail.RowTemplate.Height = 26;
            this.gridPurchaseDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchaseDetail.Size = new System.Drawing.Size(500, 618);
            this.gridPurchaseDetail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewAllPembelianByPurchaseID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(748, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPurchaseDetail);
            this.Controls.Add(this.gridPurchaseHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewAllPembelianByPurchaseID";
            this.Text = "ViewAllPembelianByPurchaseID";
            this.Load += new System.EventHandler(this.ViewAllPembelianByPurchaseID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPurchaseHeader;
        private System.Windows.Forms.DataGridView gridPurchaseDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}