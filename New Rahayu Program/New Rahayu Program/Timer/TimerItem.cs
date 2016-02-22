using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Rahayu_Program.Timer
{
    public partial class TimerItem : UserControl
    {
        Double totalSec;
        DateTime awal;
        int timerID;
        int customerID, employeeID;
        MainForm main;
        public static int HARGA_PER_JAM = 80000;
        int selisihDetikServer = 0;

        public TimerItem(MainForm main)
        {
            this.main = main;
            
            awal = GetNowTime();
            if (awal != DateTime.MinValue)
            {
                totalSec = 0;
                InitializeComponent();

                tbState.Text = "STOP";
                tbState.BackColor = Color.Red;
            }
        }

        private DateTime GetNowTime()
        {
            //AMBIL JAM SEKARANG DARI SERVER
            DataTable dt = ExecuteQuery("SELECT DATE_FORMAT(now(), '%d/%m/%Y %H:%i:%s') AS sekarang");
            if (dt == null)
            {
                main.SetMessage("SELECT NOW() FROM DATABASE ISNOT RETURN ANY VALUE (NULL)");
                return DateTime.MinValue;
            }
            else
            {
                DateTime temp = Other.Parser.TimeFromString(dt.Rows[0]["sekarang"].ToString());
                selisihDetikServer = Convert.ToInt32((DateTime.Now - temp).TotalSeconds);
                return temp;
            }
        }

        public TimerItem(MainForm main, int timerID, int employeeID, string employeeName, int customerID, string customerName, string keterangan, DateTime awal)
        {
            this.main = main;
            this.employeeID = employeeID;
            this.customerID = customerID;
            this.timerID = timerID;
            this.awal = awal;
            DateTime sekarang = GetNowTime();
            if (sekarang != DateTime.MinValue)
            {
                totalSec = 0; // (sekarang - awal).TotalSeconds;
                //this.awal = GetNowTime();

                InitializeComponent();

                tbState.Text = "PLAY";
                tbState.BackColor = Color.Yellow;
                tbEmployee.Text = employeeName;
                tbCustomer.Text = customerName;
                tbKeterangan.Text = keterangan;
            }
        }

        public TimerItem(MainForm main, int timerID, int employeeID, string employeeName, int customerID, string customerName, string keterangan, DateTime awal, double sec)
        {
            this.main = main;
            this.employeeID = employeeID;
            this.customerID = customerID;
            this.timerID = timerID;
            this.awal = awal;
            DateTime sekarang = GetNowTime();
            if (sekarang != DateTime.MinValue)
            {
                //MessageBox.Show(sekarang.ToLongTimeString() + " & " + awal.ToLongTimeString() + " -----  " + (sekarang - awal).TotalSeconds + " + " + sec);
                totalSec = sec;
                //totalSec = (sekarang - awal).TotalSeconds + sec; // ga boleh, soalnya kan awalnya uda di itung di timer (jadi 2 x)
                //this.awal = GetNowTime();

                InitializeComponent();

                tbState.Text = "PLAY";
                tbState.BackColor = Color.Yellow;
                tbEmployee.Text = employeeName;
                tbCustomer.Text = customerName;
                tbKeterangan.Text = keterangan;
            }
        }

        public TimerItem(MainForm main, int timerID, int employeeID, string employeeName, int customerID, string customerName, string keterangan, double sec)
        {
            this.main = main;
            this.employeeID = employeeID;
            this.customerID = customerID;
            this.timerID = timerID;
            DateTime sekarang = GetNowTime();
            if (sekarang != DateTime.MinValue)
            {
                this.awal = sekarang;
                totalSec = sec;

                InitializeComponent();

                tbState.Text = "PAUSE";
                tbState.BackColor = Color.OrangeRed;
                tbEmployee.Text = employeeName;
                tbCustomer.Text = customerName;
                tbKeterangan.Text = keterangan;
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);    
        }

        private void setTime(Double sec)
        {
            if (tbState.Text != "STOP")
            {
                long detik = Convert.ToInt64(sec);
                long harga = detik * (HARGA_PER_JAM / 3600);
                //tbHarga.Text = harga < HARGA_PER_JAM / 2 ? (HARGA_PER_JAM/2).ToString("#,##0") : harga.ToString("#,##0");
                tbHarga.Text = harga.ToString("#,##0");

                if (tbJam.Text != Convert.ToInt64(detik / 60 / 60) + "")
                    tbJam.Text = Convert.ToInt64(detik / 60 / 60) + "";
                detik = detik - (Int32.Parse(tbJam.Text) * 60 * 60);

                if (tbMenit.Text != Convert.ToInt64(detik / 60) + "")
                    tbMenit.Text = Convert.ToInt64(detik / 60) + "";
                detik = detik - (Int32.Parse(tbMenit.Text) * 60);

                tbDetik.Text = detik + "";
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            tbKeterangan.Focus();
            tbKeterangan.SelectAll();
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            tbKeterangan.Focus();
            tbKeterangan.SelectAll();
        }

        private void TimerItem_Load(object sender, EventArgs e)
        {
            if (tbState.Text == "PLAY")
                timer.Enabled = true;

            tbTimerID.Text = String.Format("{0:D7}", timerID);

            tbHarga.Text = "0";
            setTime(totalSec);
        }

        private void tbTimerID_Enter(object sender, EventArgs e)
        {
            btnSearchEmp.Focus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //tbCustomer.Text = ("NOW - AWAL : " + ((DateTime.Now - awal).TotalSeconds / 60) + " : " + (DateTime.Now - awal).TotalSeconds + "");
            //tbEmployee.Text = ("totalSec : " + (totalSec / 60) + " : " + totalSec + "");
            setTime((DateTime.Now - awal).TotalSeconds + totalSec - selisihDetikServer);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (tbState.Text != "PLAY")
            {
                if (customerID != 0 && employeeID != 0)
                {
                    tbState.Text = "PLAY";
                    tbState.BackColor = Color.Yellow;
                    timer.Enabled = true;
                    DateTime sekarang = GetNowTime();
                    if (sekarang != DateTime.MinValue)
                    {
                        if (totalSec != 0)
                        {
                            ExecuteQuery("UPDATE MsTimer SET awal = '" + sekarang.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE timerID = " + timerID + "");
                        }
                        else
                        {
                            DataTable dt = ExecuteQuery("SELECT printingTimerID FROM PrintingTimerHeader ORDER BY printingTimerID DESC LIMIT 0, 1");
                            if (dt != null)
                            {
                                timerID = Int32.Parse(dt.Rows[0]["printingTimerID"].ToString()) + 1;
                                ExecuteQuery("INSERT INTO MsTimer (timerID, employeeID, customerID, keterangan, awal, stored) VALUES (" + timerID + ", " + employeeID + ", " + customerID + ", '" + GetKeterangan() + "', '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "', " + 0 + ")");
                                ExecuteQuery("INSERT INTO PrintingTimerHeader VALUES (" + timerID + ", " + customerID + ", " + employeeID + ", '" + GetKeterangan() + "', 0)");
                                tbTimerID.Text = String.Format("{0:D7}", timerID);
                            }
                        }
                        awal = sekarang;
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (tbState.Text == "PLAY")
            {
                DateTime sekarang = GetNowTime();
                if (sekarang != DateTime.MinValue)
                {
                    tbState.Text = "PAUSE";
                    tbState.BackColor = Color.OrangeRed;
                    timer.Enabled = false;

                    totalSec = totalSec + (sekarang - awal).TotalSeconds;

                    ExecuteQuery("UPDATE MsTimer SET awal = '1900-01-01 00:00:00', stored = '" + Convert.ToInt64(totalSec) + "' WHERE timerID = " + timerID + "");
                    ExecuteQuery("INSERT INTO PrintingTimerDetail VALUES (" + timerID + ", '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + sekarang.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (tbState.Text == "PLAY")
            {
                DateTime sekarang = GetNowTime();
                if (sekarang != DateTime.MinValue)
                {
                    tbState.Text = "STOP";
                    tbState.BackColor = Color.Red;
                    timer.Enabled = false;
                    totalSec = totalSec + (sekarang - awal).TotalSeconds;

                    ExecuteQuery("DELETE FROM MsTimer WHERE timerID = " + timerID + "");
                    ExecuteQuery("INSERT INTO PrintingTimerDetail VALUES ('" + timerID + "', '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + sekarang.ToString("yyyy-MM-dd HH:mm:ss") + "')");

                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(printPage);
                    pd.PrinterSettings.PrinterName = @"\\RHY-SERVER-PC\EPSON TM-U220 Receipt";
                    pd.PrintController = new StandardPrintController();

                    try
                    {
                        pd.Print();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "Settings to access printer '" + pd.PrinterSettings.PrinterName + "' are not valid.")
                        {
                            MessageBox.Show("Printer IS NOT INSTALLED YET");
                        }
                        else
                            MessageBox.Show(ex.Message);
                    }

                    timerID = 0;
                    awal = sekarang;
                    totalSec = 0;
                    tbTimerID.Text = String.Format("{0:D7}", 0);
                    tbJam.Text = "00";
                    tbMenit.Text = "00";
                    tbDetik.Text = "00";
                    tbEmployee.Text = "";
                    tbCustomer.Text = "";
                    employeeID = 0;
                    customerID = 0;
                    tbHarga.Text = "0";
                }
            }
        }

        private void printPage(object o, PrintPageEventArgs e)
        {
            DataTable header = ExecuteQuery("SELECT customerName, mc.phone, employeeName, keterangan FROM MsCustomer mc, MsEmployee me, PrintingTimerHeader pth WHERE pth.customerID = mc.customerID AND pth.employeeID = me.employeeID AND printingTimerID = '" + timerID + "'");
            DataTable detail = ExecuteQuery("SELECT DATE_FORMAT(awal, '%d/%m/%Y %H:%i:%s') AS awal, DATE_FORMAT(akhir, '%d/%m/%Y %H:%i:%s') AS akhir FROM PrintingTimerDetail ptd WHERE printingTimerID = '" + timerID + "'");

            Util.PrintingTimerNota.printTimerReceipt(e.Graphics, new Font("Courier New", 9, FontStyle.Regular), timerID, HARGA_PER_JAM, header, detail);
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            Master.Customer.SearchCustomerPVC searchCustomer = new Master.Customer.SearchCustomerPVC(main);
            DialogResult result = searchCustomer.ShowDialog();
            if (result == DialogResult.OK)
            {
                customerID = main.globalCustomerID;
                tbCustomer.Text = main.globalCustomerName;
            }
        }

        private void tbKeterangan_TextChanged(object sender, EventArgs e)
        {
            ExecuteQuery("UPDATE PrintingTimerHeader SET keterangan = '" + GetKeterangan() + "' WHERE printingTimerID = '" + timerID + "'");
        }

        private string GetKeterangan()
        {
            return tbKeterangan.Text == "Keterangan Cetak" ? "" : tbKeterangan.Text; 
        }

        private void tbKeterangan_Leave(object sender, EventArgs e)
        {
            if (tbKeterangan.Text == "")
            {
                tbKeterangan.Text = "Keterangan Cetak";
            }
        }

        private void tbKeterangan_Enter(object sender, EventArgs e)
        {
            if (tbKeterangan.Text == "Keterangan Cetak")
            {
                tbKeterangan.Text = "";
            }
        }

        private void btnRudi_Click(object sender, EventArgs e)
        {
            employeeID = 7;
            tbEmployee.Text = "Rudi Sukradi";
        }

        private void btnToing_Click(object sender, EventArgs e)
        {
            employeeID = 5;
            tbEmployee.Text = "Irfan Sukradi";
        }

        private void btnWawan_Click(object sender, EventArgs e)
        {
            employeeID = 8;
            tbEmployee.Text = "Ikhwanudin";
        }

        private void btnBoy_Click(object sender, EventArgs e)
        {
            employeeID = 1;
            tbEmployee.Text = "Indra Saswita";
        }
    }
}
