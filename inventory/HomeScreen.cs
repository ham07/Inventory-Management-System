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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u,this,MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            categories u = new categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            products u = new products();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI m = new MDI();
            m.logoutToolStripMenuItem.Enabled = true;
            userLabel.Text = retrieval.EMP_NAME;


        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            Suppliers u = new Suppliers();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice u = new PurchaseInvoice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stocks u = new Stocks();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales u = new Sales();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductPricing  u = new ProductPricing();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewSalesInvoice u = new ViewSalesInvoice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesReturns u = new SalesReturns();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }
    }
}
