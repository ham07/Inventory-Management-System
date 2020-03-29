using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace inventory


{
    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        int productID;
        float gt,tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
    private void backBtn_Click_1(object sender, EventArgs e)
    {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        int CO;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                insertions i = new insertions();
                updation u = new updation();
                //transaction is use jab tak ap ka sara code successfull ni chal jata excecute ni hota or agar ik code ni chalta tou dusre ko bi roll back kar deta hai jo successfull chala ho 
                //transaction rokti hai invalid operations ko
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrieval.User_ID, Convert.ToInt32(SupplierDD.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                       CO += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["TotGV"].Value.ToString()));
                      
                        if (r.checkProductPriceExist(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString())))
                        {
                            u.updateProductPriceWRTPI(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }

                        //for stocks
                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        if(ob !=null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            i.insertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        }
                        
                    }
                    if (CO > 0)
                    {
                        MainClass.ShowMSG("Purchase Invoice Created SuccessFully", "Success", "Success");
                        PurchaseInvoiceDetail sr = new PurchaseInvoiceDetail();
                            sr.Show();
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable to create Purchase Invoice", "Error", "Error");
                    }
                   
                    sc.Complete();

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
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid,this,MDI.ActiveForm);
        }
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            
            r.getList("st_getSupplierList", SupplierDD, "Company", "ID");
        }


       



        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            if(quantityTxt.Text !="")
            {

               if(rg.Match(quantityTxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quantityTxt.Text);
                    price = Convert.ToSingle(pupTxt.Text);
                    tot = quan * price;
                    totLabel.Text = tot.ToString("##########.##");
                }
                else
                {
                    quantityTxt.SelectAll();
                }
            }
            else
            {
                totLabel.Text = "0.00";
            }
        }

        

        private void CartBtn_Click(object sender, EventArgs e)
        {
            
            if (SupplierDD.SelectedIndex == -1) { supplierErrorLabel.Visible = true; } else { supplierErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "" ) { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (quantityTxt.Text == "") { quantityErrorLabel.Visible = true; } else { quantityErrorLabel.Visible = false; }

            if (supplierErrorLabel.Visible || barcodeErrorLabel.Visible || quantityErrorLabel.Visible)
            {
                MainClass.ShowMSG("Feild with * are mandatory", "Stop", "Error");//error is a type of message
            }
            else
            {
  
                dataGridView1.Rows.Add(productID, productTxt.Text, quantityTxt.Text, pupTxt.Text, totLabel.Text);
                gt += Convert.ToSingle(totLabel.Text);
                grossLabel.Text = gt.ToString();
                productID = 0;
                productTxt.Text = "";
                pupTxt.Text = "";
                barcodeTxt.Text = "";
                totLabel.Text = "0.00";
                quantityTxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);


            }

        }

        private void pupTxt_TextChanged(object sender, EventArgs e)
        {
            if(pupTxt.Text !="")
            {
                if(!rg.Match(pupTxt.Text).Success)
                {
                    pupTxt.Text = "";
                    pupTxt.Focus();
                }
            }
        }
        string[] prodARR = new string[5];
        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
                                {
           
                if (barcodeTxt.Text != "")
                {
                    prodARR = r.getProductBYBarcode1(barcodeTxt.Text);
                    productID = Convert.ToInt32(prodARR[0]);
                    productTxt.Text = prodARR[1];
                    string barco = prodARR[2];
                    productTxt.Enabled = false;


                    if (barco != null)
                    {
                        pupTxt.Focus();
                    }


                }
                else
                {
                    productID = 0;
                    productTxt.Text = "";
                    pupTxt.Text = "";
                    Array.Clear(prodARR, 0, prodARR.Length);

                }
            
    
           
        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1 && e.ColumnIndex !=-1)
            {
                if(e.ColumnIndex== 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                    grossLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);


                }
            }
        }


    }
}
