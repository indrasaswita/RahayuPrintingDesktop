namespace Rahayu_Program.Search
{
    partial class SearchBarangStationery
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
            this.gridBarangStationery = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarangStationery)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBarangStationery
            // 
            this.gridBarangStationery.AllowUserToAddRows = false;
            this.gridBarangStationery.AllowUserToDeleteRows = false;
            this.gridBarangStationery.AllowUserToResizeColumns = false;
            this.gridBarangStationery.AllowUserToResizeRows = false;
            this.gridBarangStationery.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gridBarangStationery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBarangStationery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBarangStationery.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridBarangStationery.Location = new System.Drawing.Point(14, 14);
            this.gridBarangStationery.Margin = new System.Windows.Forms.Padding(5);
            this.gridBarangStationery.Name = "gridBarangStationery";
            this.gridBarangStationery.ReadOnly = true;
            this.gridBarangStationery.RowHeadersVisible = false;
            this.gridBarangStationery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBarangStationery.Size = new System.Drawing.Size(520, 536);
            this.gridBarangStationery.TabIndex = 1;
            this.gridBarangStationery.DoubleClick += new System.EventHandler(this.gridBarangStationery_DoubleClick);
            this.gridBarangStationery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridBarangStationery_KeyDown);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.tbSearch.Location = new System.Drawing.Point(12, 558);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(524, 43);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // SearchBarangStationery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(548, 613);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gridBarangStationery);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchBarangStationery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBarangStationery";
            this.Load += new System.EventHandler(this.SearchBarangStationery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBarangStationery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBarangStationery;
        private System.Windows.Forms.TextBox tbSearch;
    }
}