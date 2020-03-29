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
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();
        }
        ReportDocument rd;
        private void Reciept_Load(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
            rd = new ReportDocument();
            if (ViewSalesInvoice.SalesID ==0)
            {
              
                r.showReport(rd, crystalReportViewer2, "st_getSalesRecipt", "@user", retrieval.User_ID);
            }
            else
            {
                r.showReport(rd, crystalReportViewer2, "st_getSalesReciptWRTSalesID", "@salesID", ViewSalesInvoice.SalesID);
                ViewSalesInvoice.SalesID = 0;
            }
           
        }

        private void Reciept_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rd != null)
            {
                rd.Close();
            }
        }
    }
}
