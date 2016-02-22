namespace Rahayu_Program.Timer
{
    partial class TimerItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerItem));
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.btnSearchCust = new System.Windows.Forms.Button();
            this.tbJam = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMenit = new System.Windows.Forms.TextBox();
            this.tbDetik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKeterangan = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.tbTimerID = new System.Windows.Forms.TextBox();
            this.btnRudi = new System.Windows.Forms.Button();
            this.btnToing = new System.Windows.Forms.Button();
            this.btnWawan = new System.Windows.Forms.Button();
            this.btnBoy = new System.Windows.Forms.Button();
            this.tbState = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCustomer
            // 
            this.tbCustomer.BackColor = System.Drawing.Color.Chartreuse;
            this.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbCustomer.ForeColor = System.Drawing.Color.Black;
            this.tbCustomer.Location = new System.Drawing.Point(4, 124);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(210, 32);
            this.tbCustomer.TabIndex = 2;
            this.tbCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchCust
            // 
            this.btnSearchCust.BackColor = System.Drawing.Color.Black;
            this.btnSearchCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCust.BackgroundImage")));
            this.btnSearchCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCust.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCust.Location = new System.Drawing.Point(216, 123);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Size = new System.Drawing.Size(32, 32);
            this.btnSearchCust.TabIndex = 3;
            this.btnSearchCust.UseVisualStyleBackColor = false;
            this.btnSearchCust.Click += new System.EventHandler(this.btnSearchCust_Click);
            // 
            // tbJam
            // 
            this.tbJam.BackColor = System.Drawing.Color.Chartreuse;
            this.tbJam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbJam.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.tbJam.Location = new System.Drawing.Point(5, 266);
            this.tbJam.Name = "tbJam";
            this.tbJam.Size = new System.Drawing.Size(76, 64);
            this.tbJam.TabIndex = 8;
            this.tbJam.Text = "00";
            this.tbJam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbJam.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // tbHarga
            // 
            this.tbHarga.BackColor = System.Drawing.Color.Yellow;
            this.tbHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHarga.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.tbHarga.ForeColor = System.Drawing.Color.Black;
            this.tbHarga.Location = new System.Drawing.Point(-1, 163);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(252, 71);
            this.tbHarga.TabIndex = 4;
            this.tbHarga.Text = "9,999,999";
            this.tbHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHarga.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(22, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "JAM";
            this.label1.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(95, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENIT";
            this.label2.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // tbMenit
            // 
            this.tbMenit.BackColor = System.Drawing.Color.Chartreuse;
            this.tbMenit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMenit.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.tbMenit.Location = new System.Drawing.Point(87, 266);
            this.tbMenit.Name = "tbMenit";
            this.tbMenit.Size = new System.Drawing.Size(76, 64);
            this.tbMenit.TabIndex = 9;
            this.tbMenit.Text = "00";
            this.tbMenit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMenit.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // tbDetik
            // 
            this.tbDetik.BackColor = System.Drawing.Color.Chartreuse;
            this.tbDetik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDetik.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.tbDetik.Location = new System.Drawing.Point(169, 266);
            this.tbDetik.Name = "tbDetik";
            this.tbDetik.Size = new System.Drawing.Size(76, 64);
            this.tbDetik.TabIndex = 10;
            this.tbDetik.Text = "00";
            this.tbDetik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDetik.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(180, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "DETIK";
            this.label3.Enter += new System.EventHandler(this.textBox6_Enter);
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.BackColor = System.Drawing.Color.Yellow;
            this.tbKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKeterangan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbKeterangan.ForeColor = System.Drawing.Color.Black;
            this.tbKeterangan.Location = new System.Drawing.Point(0, 367);
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(250, 49);
            this.tbKeterangan.TabIndex = 15;
            this.tbKeterangan.Text = "Keterangan Cetak";
            this.tbKeterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKeterangan.TextChanged += new System.EventHandler(this.tbKeterangan_TextChanged);
            this.tbKeterangan.Enter += new System.EventHandler(this.tbKeterangan_Enter);
            this.tbKeterangan.Leave += new System.EventHandler(this.tbKeterangan_Leave);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(4, 425);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(77, 45);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Location = new System.Drawing.Point(86, 425);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(77, 45);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Chartreuse;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(168, 425);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 45);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 26);
            this.panel1.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(2, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(250, 22);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "Tulis Keterangan Disini:";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.Enter += new System.EventHandler(this.textBox8_Enter);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbEmployee
            // 
            this.tbEmployee.BackColor = System.Drawing.Color.Chartreuse;
            this.tbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbEmployee.ForeColor = System.Drawing.Color.Black;
            this.tbEmployee.Location = new System.Drawing.Point(4, 89);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(210, 32);
            this.tbEmployee.TabIndex = 0;
            this.tbEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.Black;
            this.btnSearchEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchEmp.BackgroundImage")));
            this.btnSearchEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmp.ForeColor = System.Drawing.Color.Black;
            this.btnSearchEmp.Location = new System.Drawing.Point(216, 88);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(32, 32);
            this.btnSearchEmp.TabIndex = 1;
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // tbTimerID
            // 
            this.tbTimerID.BackColor = System.Drawing.Color.Black;
            this.tbTimerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTimerID.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.tbTimerID.ForeColor = System.Drawing.Color.Yellow;
            this.tbTimerID.Location = new System.Drawing.Point(4, 4);
            this.tbTimerID.Name = "tbTimerID";
            this.tbTimerID.Size = new System.Drawing.Size(242, 36);
            this.tbTimerID.TabIndex = 16;
            this.tbTimerID.Text = "Timer ID";
            this.tbTimerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTimerID.Enter += new System.EventHandler(this.tbTimerID_Enter);
            // 
            // btnRudi
            // 
            this.btnRudi.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRudi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRudi.ForeColor = System.Drawing.Color.Black;
            this.btnRudi.Location = new System.Drawing.Point(-1, 47);
            this.btnRudi.Name = "btnRudi";
            this.btnRudi.Size = new System.Drawing.Size(63, 37);
            this.btnRudi.TabIndex = 12;
            this.btnRudi.Text = "RUDI";
            this.btnRudi.UseVisualStyleBackColor = false;
            this.btnRudi.Click += new System.EventHandler(this.btnRudi_Click);
            // 
            // btnToing
            // 
            this.btnToing.BackColor = System.Drawing.Color.Chartreuse;
            this.btnToing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnToing.ForeColor = System.Drawing.Color.Black;
            this.btnToing.Location = new System.Drawing.Point(62, 47);
            this.btnToing.Name = "btnToing";
            this.btnToing.Size = new System.Drawing.Size(63, 37);
            this.btnToing.TabIndex = 12;
            this.btnToing.Text = "TOING";
            this.btnToing.UseVisualStyleBackColor = false;
            this.btnToing.Click += new System.EventHandler(this.btnToing_Click);
            // 
            // btnWawan
            // 
            this.btnWawan.BackColor = System.Drawing.Color.Chartreuse;
            this.btnWawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWawan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnWawan.ForeColor = System.Drawing.Color.Black;
            this.btnWawan.Location = new System.Drawing.Point(125, 47);
            this.btnWawan.Name = "btnWawan";
            this.btnWawan.Size = new System.Drawing.Size(63, 37);
            this.btnWawan.TabIndex = 12;
            this.btnWawan.Text = "WA2N";
            this.btnWawan.UseVisualStyleBackColor = false;
            this.btnWawan.Click += new System.EventHandler(this.btnWawan_Click);
            // 
            // btnBoy
            // 
            this.btnBoy.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoy.ForeColor = System.Drawing.Color.Black;
            this.btnBoy.Location = new System.Drawing.Point(188, 47);
            this.btnBoy.Name = "btnBoy";
            this.btnBoy.Size = new System.Drawing.Size(63, 37);
            this.btnBoy.TabIndex = 12;
            this.btnBoy.Text = "BOY";
            this.btnBoy.UseVisualStyleBackColor = false;
            this.btnBoy.Click += new System.EventHandler(this.btnBoy_Click);
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.Color.Yellow;
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbState.ForeColor = System.Drawing.Color.Black;
            this.tbState.Location = new System.Drawing.Point(-1, 479);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(252, 22);
            this.tbState.TabIndex = 17;
            this.tbState.Text = "STATUS";
            this.tbState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbTimerID);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnBoy);
            this.Controls.Add(this.btnWawan);
            this.Controls.Add(this.btnToing);
            this.Controls.Add(this.btnRudi);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDetik);
            this.Controls.Add(this.tbMenit);
            this.Controls.Add(this.tbJam);
            this.Controls.Add(this.btnSearchCust);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.tbEmployee);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TimerItem";
            this.Size = new System.Drawing.Size(250, 501);
            this.Load += new System.EventHandler(this.TimerItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Button btnSearchCust;
        private System.Windows.Forms.TextBox tbJam;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMenit;
        private System.Windows.Forms.TextBox tbDetik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKeterangan;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox tbTimerID;
        private System.Windows.Forms.Button btnRudi;
        private System.Windows.Forms.Button btnToing;
        private System.Windows.Forms.Button btnWawan;
        private System.Windows.Forms.Button btnBoy;
        private System.Windows.Forms.TextBox tbState;
    }
}
