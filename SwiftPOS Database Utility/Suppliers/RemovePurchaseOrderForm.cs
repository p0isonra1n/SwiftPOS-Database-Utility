using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftPOS_Database_Utility.Suppliers
{
    public partial class RemovePurchaseOrderForm : Form
    {

        DBHelper dbHelper = new DBHelper();
        DataTable dtPO;
        public RemovePurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void RemovePurchaseOrderForm_Load(object sender, EventArgs e)
        {
            dbHelper.Connect();
            loadTable();
        }

        private void loadTable()
        {
            dtPO = dbHelper.GetQuery("SELECT * FROM " + "dbo.PurchaseOrderTable");
            dgvRPO.DataSource = dtPO;
        }

        private void btnPODelete_Click(object sender, EventArgs e)
        {
            DataRow dr = dtPO.Rows[dgvRPO.CurrentCell.RowIndex];
            int PurchaseOrder = int.Parse(dr["PurchaseOrder"].ToString());

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete purchase order " + PurchaseOrder.ToString() + " from the database?", "Remove Purchase Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dbHelper.SendQuery("DELETE FROM dbo.PurchaseOrderTable WHERE PurchaseOrder=" + PurchaseOrder);
                MessageBox.Show("Purchase Order " + PurchaseOrder.ToString() + " has been deleted");
                loadTable();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }
    }
}
