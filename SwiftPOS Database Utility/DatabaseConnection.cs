using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftPOS_Database_Utility
{
    public partial class DatabaseConnection : Form
    {
        public DatabaseConnection()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = tbIPAddress.Text;
            Properties.Settings.Default.Username = tbUsername.Text;
            Properties.Settings.Default.Password = tbPassword.Text;
            Properties.Settings.Default.DatabaseName = cbDatabase.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            Close();
        }

        private void DatabaseConnection_Load(object sender, EventArgs e)
        {
            tbIPAddress.Text = Properties.Settings.Default.IP;
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;
            cbDatabase.Text = Properties.Settings.Default.DatabaseName;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            DBHelper dbHelper = new DBHelper();
            dbHelper.ConnectNoDB();
            DataTable dbList = dbHelper.GetQuery("SELECT name FROM master.sys.databases");
            foreach(DataRow dr in dbList.Rows)
            {
                //Yes this is ugly
                if(!dr["name"].ToString().Equals("master") && !dr["name"].ToString().Equals("tempdb") && !dr["name"].ToString().Equals("model") && !dr["name"].ToString().Equals("msdb"))
                {
                    cbDatabase.Items.Add(dr["name"]);
                }
            }
            dbHelper.CloseConnection();
        }
    }
}
