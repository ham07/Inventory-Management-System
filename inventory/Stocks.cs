using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            base.addBtn.Enabled = false;
            base.editBtn.Enabled = false;
            base.saveBtn.Enabled = false;
            base.deleteBtn.Enabled = false;
            

        }
        retrieval r = new retrieval();
        public override void viewBtn_Click(object sender,EventArgs e)
        {
            r.showStocks(dataGridView1,proIDGV,proGV,barcodeGV,bpGV,spGV,expiryGV,catGV,quanGV,statusGV,finalGV);
        }
    }
}
