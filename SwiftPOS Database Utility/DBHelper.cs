using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SwiftPOS_Database_Utility
{
    class DBHelper
    {

        SqlConnection dbConnection;

        public void Connect()
        {
            dbConnection = new SqlConnection("user id=" + Properties.Settings.Default.Username + ";" +
                                       "password=" + Properties.Settings.Default.Password + "; " +
                                       "server=" + Properties.Settings.Default.IP + ";" +
                                       
                                       "database=" + Properties.Settings.Default.DatabaseName + ";" +
                                       "connection timeout=30");
            try
            {
                dbConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                
            }
        }

        public void ConnectNoDB()
        {
            dbConnection = new SqlConnection("user id=" + Properties.Settings.Default.Username + ";" +
                                       "password=" + Properties.Settings.Default.Password + "; " +
                                       "server=" + Properties.Settings.Default.IP + ";" +
                                       "connection timeout=30");
            try
            {
                dbConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }

        public void CloseConnection()
        {
            dbConnection.Close();
        }

        public void SendQuery(String command)
        {
            SqlCommand dbCommand = new SqlCommand(command, dbConnection);
            dbCommand.ExecuteNonQuery();
        }

        public DataTable GetQuery(string command)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = dbConnection;
                sqlCmd.CommandType = CommandType.Text;
                //sqlCmd.CommandText = "Select * from titles";
                sqlCmd.CommandText = command;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                //dataGridView1.DataSource = dtRecord;
                return dtRecord;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

    }
}
