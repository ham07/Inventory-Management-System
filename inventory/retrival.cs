using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    class retrieval
    {
        public void showUsers(DataGridView gv,DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn userNameGV, DataGridViewColumn passGV , DataGridViewColumn emailGV , DataGridViewColumn phoneGV, DataGridViewColumn  statusGV, string data=null)//null it is an optional it is always come in the end not in the middle or first
        {
            try
            {
                SqlCommand cmd;

                if (data == null)
                {
                     cmd = new SqlCommand("st_getUsersDataUsers", MainClass.con);
                }
                else
                {
                     cmd = new SqlCommand("st_getUsersDataUsersLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data",data);
                }
                
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                userNameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch(Exception)
            {

            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd= new SqlCommand("st_getCategoryData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["status"].ToString();
  
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error","Error");
            }
        }

        public void getList(string proc, ComboBox cb,string displayMember,string valueMember )
        {
            try
            {
              // cb.Items.Clear();
                cb.DataSource = null;
               // cb.Items.Insert ( 0, "Select...." );

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "select...." };
                dt.Rows.InsertAt(dr, 0);


               
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;


            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1 , object val1,string param2,object val2 )
        {
            try
            {
               // cb.Items.Clear();
                cb.DataSource = null;
                // cb.Items.Insert ( 0, "Select...." );

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1,val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "select...." };
                dt.Rows.InsertAt(dr, 0);



                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;


            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void showProduct(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV,  DataGridViewColumn barcodeGV,DataGridViewColumn catGV, DataGridViewColumn catIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();

                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
               MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void showSuppliers(DataGridView gv, DataGridViewColumn supIDGV, DataGridViewColumn comNameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSuppliersData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                supIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                comNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["ContactPerson"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.con.Open();
                //sql dataAdapter is a two way stream data mugwa bi sakte hai or data dalwa bi sakte hai
                //sql dataReader se sirf data magwate hai
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        User_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }

                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                            MainClass.ShowMSG("Invalid username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Paassword", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Paassword and Username", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return checkLogin;
        }

        private object productStockCount = 0;
        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return productStockCount;
        }

        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                productStockCount = cmd.ExecuteScalar();
             

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return productStockCount;
        }

        public void showpurchaseInvoiceDetails(Int64 pid, DataGridView gv,DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantityGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid",pid);
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["product"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }


        public void showproductsWRTCategories(int catID, DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn buyingPriceGV, DataGridViewColumn spGV, DataGridViewColumn disGV, DataGridViewColumn proMarGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                buyingPriceGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                proMarGV.DataPropertyName = dt.Columns["Profit Margin"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void showStocks(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn quanGV, DataGridViewColumn statusGV, DataGridViewColumn finalGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getallStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                quanGV.DataPropertyName = dt.Columns["Avalible Stock"].ToString();
                finalGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
            

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        private bool checkProductPExist;
        public bool checkProductPriceExist( Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    checkProductPExist = true;
                }
                else
                {
                    checkProductPExist = false;
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return checkProductPExist;
        }


        //things that we are bringing
        private string[] productsData1= new string[3];
        public string[] getProductBYBarcode1(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode1", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                if (da.HasRows)
                {
                    while (da.Read())
                    {
                        productsData1[0] = da[0].ToString();//product id
                        productsData1[1] = da[1].ToString();//product
                        productsData1[2] = da[2].ToString();//barcode
                      // productsData[3] = da[3].ToString();//selling price
                                                           // productsData[4] = dr[4].ToString();//discount
                                                           // productsData[5] = dr[5].ToString();//final price

                    }

                }
                else
                {
                   
                }
            MainClass.con.Close();
            }
            catch(Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");

            }
            return productsData1;
        }

        private string[] productsData = new string[4];
        public string[] getProductBYBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                if (da.HasRows)
                {
                    while (da.Read())
                    {
                        productsData[0] = da[0].ToString();//product id
                        productsData[1] = da[1].ToString();//product
                        productsData[2] = da[2].ToString();//barcode
                        productsData[3] = da[3].ToString();//selling price
                                                           // productsData[4] = dr[4].ToString();//discount
                                                           // productsData[5] = dr[5].ToString();//final price

                    }

                }
                else
                {
                    Array.Clear(productsData, 0, productsData.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");

            }
            return productsData;
        }


        public void showDailySales(DateTime date, DataGridView gv, DataGridViewColumn salIDGV, DataGridViewColumn userGV, DataGridViewColumn totGV, DataGridViewColumn disGV, DataGridViewColumn   AmouGivGV, DataGridViewColumn AmounRetGV, DataGridViewColumn userIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);
                cmd.Parameters.AddWithValue("@date",date);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                userGV.DataPropertyName = dt.Columns["Sales Done By"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();

                disGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                AmouGivGV.DataPropertyName = dt.Columns["Cash Recieved"].ToString();
                AmounRetGV.DataPropertyName = dt.Columns["Cash Back"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }


        public void showReport(ReportDocument rd,CrystalReportViewer crv, string proc,string param1,object val1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //it is a class for crystal report
                //it is a property jdr bi Application ki exe save hogi whan se path utha k le aya ga
                rd.Load(Application.StartupPath+"\\Reports\\SalesRecipt.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();

            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
          
        }
        public void showPurchaseInvoiceRecipt(ReportDocument rd, CrystalReportViewer crv, string proc, string param1, object val1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //it is a class for crystal report
                //it is a property jdr bi Application ki exe save hogi whan se path utha k le aya ga
                rd.Load(Application.StartupPath + "\\Reports\\PurchaseInvoiceRecipt.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();

            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }

        }

        public void showProductWRTInvoice(Int64 salesID, DataGridView gv, DataGridViewColumn salesIDGV, DataGridViewColumn barcodeGV, DataGridViewColumn proGV, DataGridViewColumn quanGV, DataGridViewColumn disGV, DataGridViewColumn grossGV, DataGridViewColumn cashRecGV, DataGridViewColumn cashRetGV, DataGridViewColumn totGV, DataGridViewColumn dateGV, DataGridViewColumn pupGV, DataGridViewColumn userGV, DataGridViewColumn payGV, DataGridViewColumn proIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSalesReciptWRTSalesID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salesIDGV.DataPropertyName    = dt.Columns["Sales ID"].ToString();
                barcodeGV.DataPropertyName    = dt.Columns["Barcode"].ToString();
                proGV.DataPropertyName     = dt.Columns["Product"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                disGV.DataPropertyName = dt.Columns["Total discount"].ToString();

                grossGV.DataPropertyName    = dt.Columns["Gross Total"].ToString();
                cashRecGV.DataPropertyName        = dt.Columns["Cash Recieved"].ToString();
                cashRetGV.DataPropertyName      = dt.Columns["Cash Return"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per unit Price"].ToString();
                userGV.DataPropertyName = dt.Columns["Sales Done By"].ToString();
                payGV.DataPropertyName = dt.Columns["Payment Type"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        //for login
        public static int User_ID
        {
            //abstract property
            get;
            private set;
        }
        public static string EMP_NAME
        {
            //abstract property
            get;
            private set;
        }
        private static string user_name=null, pass_word=null;
        private static bool checkLogin;

       
    }
}
