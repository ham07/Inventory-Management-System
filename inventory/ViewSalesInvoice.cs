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
    public partial class ViewSalesInvoice : Sample
    {
        public ViewSalesInvoice()
        {
            InitializeComponent();
        }


        retrieval r = new retrieval();
        private void payBtn_Click(object sender, EventArgs e)
        {
            r.showDailySales( dateTimePicker1.Value,dataGridView1,salIDGV,userGV,totGV,disGV,AmoGiveGV,AmoRetGV, UserIDGV);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen u = new HomeScreen();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        public static int SalesID=0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1 && e.ColumnIndex !=-1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SalesID = Convert.ToInt32(row.Cells["salIDGV"].Value.ToString());
                Reciept sr = new Reciept();
                sr.Show();
            }
        }

        private void ViewSalesInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
