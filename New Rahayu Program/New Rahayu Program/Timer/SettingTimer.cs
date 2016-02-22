using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Timer
{
    public partial class SettingTimer : Form
    {
        List<TimerItem> list;
        const int JUMLAH_TIMER = 4;
        MainForm main;

        public SettingTimer(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            list = new List<TimerItem>();

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void SettingTimer_Load(object sender, EventArgs e)
        {
            DataTable dt = ExecuteQuery("SELECT timerID, mt.employeeID, employeeName, mt.customerID, customerName, keterangan, DATE_FORMAT(awal, '%d/%m/%Y %H:%i:%s') AS awal, stored, mt.keterangan FROM MsTimer mt, MsEmployee me, MsCustomer mc WHERE mt.customerID = mc.customerID AND me.employeeID = mt.employeeID ORDER BY timerID");

            for (int i = 0; i < JUMLAH_TIMER; i++)
            {
                if (i < dt.Rows.Count)
                {
                    int timerID = Int32.Parse(dt.Rows[i]["timerID"].ToString());
                    int employeeID = Int32.Parse(dt.Rows[i]["employeeID"].ToString());
                    string employeeName = dt.Rows[i]["employeeName"].ToString();
                    int customerID = Int32.Parse(dt.Rows[i]["customerID"].ToString());
                    string customerName = dt.Rows[i]["customerName"].ToString();
                    string keterangan = dt.Rows[i]["keterangan"].ToString();
                    DateTime awal = Other.Parser.TimeFromString(dt.Rows[i]["awal"].ToString());
                    Double stored = Double.Parse(dt.Rows[i]["stored"].ToString());

                    if (awal.ToString("yyyy-MM-dd") == "1900-01-01")
                    {
                        //MessageBox.Show("AWAL : NULL + STORE : " + stored);
                        list.Add(new TimerItem(main, timerID, employeeID, employeeName, customerID, customerName, keterangan, stored));
                    }
                    else if (stored == 0)
                    {
                        //MessageBox.Show("AWAL : " + awal.ToLongTimeString() + " + STORE : NULL");
                        list.Add(new TimerItem(main, timerID, employeeID, employeeName, customerID, customerName, keterangan, awal));
                    }
                    else
                    {
                        //MessageBox.Show("AWAL : " + awal.ToLongTimeString() + " + STORE : " + stored);
                        list.Add(new TimerItem(main, timerID, employeeID, employeeName, customerID, customerName, keterangan, awal, stored));
                    }
                }
                else
                    list.Add(new TimerItem(main));
                list[i].Location = new Point(2 + (i * (list[i].Width + 2)), 2);
                panel1.Controls.Add(list[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
