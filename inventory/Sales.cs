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
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }



        private void Sales_Load(object sender, EventArgs e)
        {
            barcodeTxt.Focus();
        }

        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        retrieval r = new retrieval();
        string[] prodARR = new string[6];
        float GROSS=0;
        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        bool check;
        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if(barcodeTxt.Text !="")
            {
                gosTotTxt.Text = "";
                CashBTXT.Text = "";
                CashRecTxt.Text = "";
           

                int quanCount =0,StockQuan=0,nCount=0;
                prodARR = r.getProductBYBarcode(barcodeTxt.Text);
                // stock check
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if( prodARR[0] ==row.Cells["proIDGV"].Value.ToString())
                    {
                        quanCount=quanCount+Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    }

                }

                StockQuan=Convert.ToInt32( r.getProductQuantity(Convert.ToInt64(prodARR[0])));
               
                nCount = StockQuan - quanCount;
                if (nCount<=0)
                {
                    MainClass.ShowMSG("Stock is finished", "Error", "Error");
                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), 0, Convert.ToSingle(prodARR[3]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            //quantity count agar product majjod hai tou us ki quantity add kari jau
                            if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                            {
                                check = true;
                                break;

                            }
                            else
                            {
                                check = false;

                            }
                        }
                        if (check == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["disGV"].Value.ToString() != null)
                                    {
                                        disc += Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                                        row.Cells["disGV"].Value.ToString();
                                    }
                                    float tot = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) - Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                                    row.Cells["totGV"].Value = tot;
                                }

                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), 0, prodARR[3]);
                        }
                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
   

                        GROSS += Convert.ToSingle(item.Cells["totGV"].Value.ToString());
                    }
                    //Math is a class
                    grossLabel.Text = Math.Round( GROSS,0).ToString();
                    GROSS = 0;
                    barcodeTxt.Focus();
                    barcodeTxt.Text = "";
                }
               
            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1 &&  e.ColumnIndex !=-1)
            {
                if(e.ColumnIndex ==6)
                {
                    gosTotTxt.Text = "";
                    CashBTXT.Text = "";
                    CashRecTxt.Text = "";
                    disTxt.Text = "";

                    float grandTot,tot;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int quan = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    if (quan == 1)
                    {
                        grandTot = Convert.ToSingle(grossLabel.Text);
                        grandTot = grandTot - Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                        grossLabel.Text = grandTot.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (quan > 1)
                    {
                        quan--;


                        tot = Convert.ToSingle(row.Cells["totGV"].Value.ToString()) - Convert.ToSingle(row.Cells["pupGV"].Value.ToString());
                        row.Cells["totGV"].Value = tot;
                        row.Cells["quantityGV"].Value = quan;
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["totGV"].Value.ToString());
                        }
                        grossLabel.Text = GROSS.ToString();
                        GROSS = 0;
                    }
                }
            }
        }

      

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {
                float gross = 0;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    gross = Convert.ToSingle(grossLabel.Text);
                }
                gosTotTxt.Text =Math.Round( gross,0).ToString();
            }
        }


        private void CashRecTxt_TextChanged(object sender, EventArgs e)
        {
            if(CashRecTxt.Text !="")
            {
                if(!rg.Match(CashRecTxt.Text).Success)
                {
                    CashRecTxt.Text = "";
                    CashRecTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(CashRecTxt.Text);
                    float amountReturn = amountGiven - Convert.ToSingle(grossLabel.Text);
                    CashBTXT.Text = Math.Round(amountReturn,0).ToString();
           
                }
            }
            else
            {
                CashBTXT.Text = "";
            }
        }

       

        private void CashRecTxt_Validating(object sender, CancelEventArgs e)
        {
            if (CashRecTxt.Text !="" && grossLabel.Text !="")
            {
                if (!(Convert.ToSingle(grossLabel.Text) <= Convert.ToSingle(CashRecTxt.Text)))
                {
                    CashRecTxt.Text = "";
                    CashBTXT.Text = "";
                    CashRecTxt.Focus();
                }
            }
        }




        insertions i = new insertions();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (CashBTXT.Text != "" && CashRecTxt.Text != "" && gosTotTxt.Text != "" && PaymentCB.SelectedIndex != -1 && disTxt.Text != "")
            {
                //  \n is used to go to next line
                DialogResult dr = MessageBox.Show("Are you sure you want to  submit cuurent sale? \n\n\t Total Amount: "+ gosTotTxt.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (dr ==DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "proIDGV", "quantityGV", retrieval.User_ID, DateTime.Now, Convert.ToSingle(gosTotTxt.Text), Convert.ToSingle(disTxt.Text), Convert.ToSingle(CashRecTxt.Text), Convert.ToSingle(CashBTXT.Text),PaymentCB.SelectedItem.ToString(), "pupGV");
                    MainClass.enable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                    grossLabel.Text = "0.00";
                    Reciept sr = new Reciept();
                    sr.Show();
                }
            }
          
        }

        float dis, gross, cal;
        private void disTxt_Validating(object sender, CancelEventArgs e)
        {
            
            if (disTxt.Text != "" )
            {
                dis = Convert.ToSingle(disTxt.Text);
                gross = Convert.ToSingle(grossLabel.Text);
                cal = gross - (gross * dis / 100);
                gosTotTxt.Text = "";
                CashRecTxt.Text = "";
                CashBTXT.Text = "";


            }
            //else if ( dis == 0)
            //{
            //    foreach (DataGridViewRow item in dataGridView1.Rows)
            //    {
            //        GROSS += Convert.ToSingle(item.Cells["totGV"].Value.ToString());
            //    }
            //    grossLabel.Text = GROSS.ToString();

            //}
            grossLabel.Text =Math.Round( cal,0).ToString();
        }

       
    }
    
}
