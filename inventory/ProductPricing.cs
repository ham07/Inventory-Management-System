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
    public partial class ProductPricing : Sample2
    {
        retrieval r = new retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public ProductPricing()
        {
            InitializeComponent();
            r.getList("st_getCategoryList", categoryCB, "Category", "ID");
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryCB.SelectedIndex !=-1 && categoryCB.SelectedIndex !=0)
            {
                r.showproductsWRTCategories(Convert.ToInt32(categoryCB.SelectedValue.ToString()),dataGridView1,proIDGV,proGV,BuyingPriceGV, FinalPriceGV, discountGV, ProfitMarginGV  );
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["ProfitMarginGV"].Value !=null  && rg.Match(row.Cells["ProfitMarginGV"].Value.ToString()).Success)
                {

                    float buyingprice = Convert.ToSingle(row.Cells["BuyingPriceGV"].Value.ToString());
                    float profitmargin = Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString())/100;
                    float amounttoIncrease = profitmargin * buyingprice;
                    float discountPer;
                   
                    float finalSellingPrice = buyingprice + amounttoIncrease ;

                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountPer = 0;
                    }
                    row.Cells["FinalPriceGV"].Value = finalSellingPrice-discountPer;
                }
                else
                {
                    row.Cells["FinalPriceGV"].Value = null;
                    row.Cells["ProfitMarginGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                }
             }

        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }
        updation u = new updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            int check=0;
            if (categoryCB.SelectedIndex != -1 && categoryCB.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        check++;
                        float disc, profitMar, sp, bp;
                        //turnury operator
                        disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        profitMar = row.Cells["ProfitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());

                        if (disc == 0 && profitMar == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["FinalPriceGV"].Value.ToString());
                        }

                        u.updateProductPrice(Convert.ToInt64(row.Cells["proIDGV"].Value.ToString()),
                        bp, sp, disc, profitMar);

                    }
                }
                if (check > 0)
                {
                    MainClass.ShowMSG("Product Pricing updated Successfully", "Success", "Success");
                    check = 0;
                }
                else
                {
                    MainClass.ShowMSG("Please check the box to save", "Error", "Error");
                    check = 0;
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        //private void ProductPricing_Load(object sender, EventArgs e)
        //{
        //    if(dataGridView1.CurrentCell.ColumnIndex == 4)
        //    {
        //        dataGridView1.BeginEdit(true);
        //    }
        //}
    }

}
