using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Rahayu_Program.Config
{
    class Conn
    {
        private String connString;
        private MySqlConnection mySqlConnection;
        private DataTable dt;
        private DataSet ds;
        private ConnectionState connState;

        public void Connect()
        {
            string path = Application.StartupPath + @"\config\conn\connstr.is";
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("CONNSTR TIDAK KETEMU");
                Application.Exit();
            }
            else
            {
                connString = System.IO.File.ReadAllText(path);
            }

            mySqlConnection = new MySqlConnection();
            mySqlConnection.ConnectionString = connString;

            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                {
                    mySqlConnection.Open();
                }
                else
                {
                    mySqlConnection.Close();
                }
                connState = mySqlConnection.State;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Connection ERROR (in FUNCTION: Connect) -> " + ex.Message);
            }

        }

        public Boolean isOpen()
        {
            if (connState == ConnectionState.Open)
                return true;
            else if (connState == ConnectionState.Closed)
                return false;
            else
                return false;
        }

        public DataTable ExecuteQuery(String query)
        {
            dt = new DataTable(); 
            MySqlDataAdapter adapter;
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            adapter = new MySqlDataAdapter(command);

            mySqlConnection.Close();
            mySqlConnection.Dispose();
            adapter.Fill(dt);
            return dt;
        }

        public DataSet ExecuteQueryDS(String query)
        {
            ds = new DataSet();
            MySqlDataAdapter adapter;
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            adapter = new MySqlDataAdapter(command);

            mySqlConnection.Close();
            mySqlConnection.Dispose();
            adapter.Fill(ds);
            return ds;
        }

    }
}
