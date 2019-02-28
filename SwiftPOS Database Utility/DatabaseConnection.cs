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
            Properties.Settings.Default.DatabaseName = tbDatabase.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void DatabaseConnection_Load(object sender, EventArgs e)
        {
            tbIPAddress.Text = Properties.Settings.Default.IP;
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;
            tbDatabase.Text = Properties.Settings.Default.DatabaseName;
        }
    }
}
