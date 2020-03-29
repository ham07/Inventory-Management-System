﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace inventory
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        public override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj,this,MDI.ActiveForm);
        }

            private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", PurchaseinvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", PurchaseinvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void PurchaseinvoiceDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PurchaseinvoiceDD.SelectedIndex !=-1 && PurchaseinvoiceDD.SelectedIndex !=0)
            {
                float gt = 0;
                r.showpurchaseInvoiceDetails(Convert.ToInt64(PurchaseinvoiceDD.SelectedValue.ToString()),dataGridView1,mPIDGV,proIDGV,proNameGV,quantityGV,pupGV,totGV);
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                }
                grossLabel.Text = gt.ToString();
                gt = 0;
            }
        }
        insertions i = new insertions();
        updation u = new updation();
        deletion d = new deletion();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex !=-1 && e.ColumnIndex !=-1)
            {
                if(e.ColumnIndex ==6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete" + row.Cells["proNameGV"].Value.ToString() + "from purchase invoice?\n\t\t\tWarning\nDeletion of product will effect stock","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertdeleteditems(Convert.ToInt64(PurchaseinvoiceDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), retrieval.User_ID, DateTime.Today);
                            int q;
                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text) - Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                                grossLabel.Text = tot.ToString();
                                d.deleteFromPurchaseInvoice(Convert.ToInt64(row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFromPID","@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                            
                     
                    }
                }
            }
        }
    }
}
