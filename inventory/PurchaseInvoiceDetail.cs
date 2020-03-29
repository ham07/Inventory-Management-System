using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace inventory
{
    public partial class PurchaseInvoiceDetail : Form
    {
        public PurchaseInvoiceDetail()
        {
            InitializeComponent();
        }
        ReportDocument rd;
        private void PurchaseInvoiceDetail_Load(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
            rd = new ReportDocument();
            r.showPurchaseInvoiceRecipt(rd, crystalReportViewer1, "st_PurchaseInvoiceRecipt", "@user", retrieval.User_ID);
        }
    }
}
