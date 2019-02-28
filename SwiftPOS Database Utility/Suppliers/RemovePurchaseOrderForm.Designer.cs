namespace SwiftPOS_Database_Utility.Suppliers
{
    partial class RemovePurchaseOrderForm
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
            this.btnPODelete = new System.Windows.Forms.Button();
            this.dgvRPO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRPO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPODelete
            // 
            this.btnPODelete.Location = new System.Drawing.Point(713, 415);
            this.btnPODelete.Name = "btnPODelete";
            this.btnPODelete.Size = new System.Drawing.Size(75, 23);
            this.btnPODelete.TabIndex = 0;
            this.btnPODelete.Text = "Delete";
            this.btnPODelete.UseVisualStyleBackColor = true;
            this.btnPODelete.Click += new System.EventHandler(this.btnPODelete_Click);
            // 
            // dgvRPO
            // 
            this.dgvRPO.AllowUserToAddRows = false;
            this.dgvRPO.AllowUserToDeleteRows = false;
            this.dgvRPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRPO.Location = new System.Drawing.Point(12, 12);
            this.dgvRPO.Name = "dgvRPO";
            this.dgvRPO.ReadOnly = true;
            this.dgvRPO.Size = new System.Drawing.Size(776, 397);
            this.dgvRPO.TabIndex = 1;
            // 
            // RemovePurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRPO);
            this.Controls.Add(this.btnPODelete);
            this.Name = "RemovePurchaseOrderForm";
            this.Text = "Remove Purchase Order";
            this.Load += new System.EventHandler(this.RemovePurchaseOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRPO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPODelete;
        private System.Windows.Forms.DataGridView dgvRPO;
    }
}