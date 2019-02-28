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
    public partial class MainForm : Form
    {

        DBHelper dbHelper = new DBHelper();

        public MainForm()
        {
            InitializeComponent();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.Show();
            dbc.FormClosed += new FormClosedEventHandler(DatabaseConnection_FormClosed);
        }

        private void DatabaseConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConnectSQL();
        }

        private void ConnectSQL()
        {
            dbHelper.Connect();
            dgvSQL.DataSource = dbHelper.GetQuery("SELECT * FROM " + "dbo.ProductTable");
            //dgvSQL.DataSource = dbHelper.GetQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'");
            PopulateTreeView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectSQL();
        }

        private void PopulateTreeView()
        {
            DataTable db = dbHelper.GetQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'");
            DataView dv = db.DefaultView;
            dv.Sort = "TABLE_NAME ASC";
            DataTable sortedDT = dv.ToTable();
            foreach (DataRow row in sortedDT.Rows)
            {
                TreeNode node = new TreeNode(row["TABLE_NAME"].ToString());
                tvTables.Nodes.Add(node);
            }
        }

        private void tvTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedTable = tvTables.SelectedNode.Text;
            dgvSQL.DataSource = dbHelper.GetQuery("SELECT * FROM " + "dbo." + selectedTable);
        }

        private void removePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers.RemovePurchaseOrderForm rpoForm = new Suppliers.RemovePurchaseOrderForm();
            rpoForm.Show();
        }
    }
}
