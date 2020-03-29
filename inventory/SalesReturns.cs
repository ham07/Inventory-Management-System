using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class SalesReturns : Sample2
    {
        public SalesReturns()
        {
            InitializeComponent();
        }


        retrieval r = new retrieval();
        Regex rg = new Regex("^[0-9]+$");

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (salesIDTxt.Text != "")
            {
                if (rg.Match(salesIDTxt.Text).Success)
                {

                    r.showProductWRTInvoice(Convert.ToInt64(salesIDTxt.Text),dataGridView1,salIDGV,barcodeGV,ProductGV,quantityGV,disGV,grossGV,cashRecGV,cashBackGV,totGV,dateGV,pupGV,userGV,payGV,proIDGV);

                    //foreach(DataGridViewRow row in dataGridView1.Rows)
                    //{
                    //    row.Cells["pupGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["pupGV"].Value));
                    //}

                    dateTimePicker1.Value = Convert.ToDateTime( dataGridView1.Rows[0].Cells["dateGV"].Value);
                    userTxt.Text = dataGridView1.Rows[0].Cells["userGV"].Value.ToString();
                    payTxt.Text = dataGridView1.Rows[0].Cells["payGV"].Value.ToString();
                    cashRecTxt.Text = dataGridView1.Rows[0].Cells["cashRecGV"].Value.ToString();
                    cashRetTxt.Text = dataGridView1.Rows[0].Cells["cashBackGV"].Value.ToString();
                    disTxt.Text = dataGridView1.Rows[0].Cells["disGV"].Value.ToString();
                    grossTxt.Text = dataGridView1.Rows[0].Cells["grossGV"].Value.ToString();
                }
                else
                {
                    salesIDTxt.Text = "";
                    salesIDTxt.Focus();
                    dateTimePicker1.Value = DateTime.Now;
                    userTxt.Text = "";
                    payTxt.Text = "";
                    cashRecTxt.Text = "";
                    cashRetTxt.Text = "";
                    disTxt.Text = "";
                    grossTxt.Text = "";
                }
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                userTxt.Text = "";
                payTxt.Text = "";
                cashRecTxt.Text = "";
                cashRetTxt.Text = "";
                disTxt.Text = "";
                grossTxt.Text = "";
            }
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
