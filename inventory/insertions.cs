using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace inventory
{
    class insertions
    {
        public void insertUser( string name,string username,string pass,string email,string phone,  Int16 status)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@username",username);
                cmd.Parameters.AddWithValue("@pwd",pass);
                cmd.Parameters.AddWithValue("@phone",phone);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name+"added to the system successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message,"Error","Error");
            }
        }


        public void insertCat(string name, Int16 status)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + "added to the system successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void insertproducts(string product, string barcode, int catID,DateTime? expiry=null)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_productInsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if(expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry",expiry);
                }
                
                cmd.Parameters.AddWithValue("@catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + "added to the system successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void insertSuppliers(string company, string person, string phone1, string address, Int16 status, string phone2=null,string ntn = null)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSuppliers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@conPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 ==null)
                {

                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                
                if (ntn == null)
                {

                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(company + " added to the system successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        private Int64 purchaseInvoiceID;
        //we use int to return last invoice id
        public Int64 insertPurchaseInvoice(DateTime date,int doneBy,int suppID)
        {
            //it is use to catch logical error
            try
            {
                
                
                    SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doneBy", doneBy);
                    cmd.Parameters.AddWithValue("@suppID", suppID);
                    MainClass.con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "st_getLatestPurchaseID";
                    cmd.Parameters.Clear();
                    purchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
                    MainClass.con.Close();

                    
 
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return purchaseInvoiceID;
        }

        int pidCount;

        public int insertPurchaseInvoiceDetails(Int64 purID, Int64 proID, int quan, float tPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertpurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID", purID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@totPrice", tPrice);
                MainClass.con.Open();
               pidCount =  cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return pidCount;
        }

        public void insertStock(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            
        }

        public void insertdeleteditems(Int64 pid,Int64 proid,int quan,int userid,DateTime date)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@usrID", userid);
                cmd.Parameters.AddWithValue("@proID", proid);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);
                
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
              
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        //? nullable variable
        public void insertProductPrice(Int64 proID, float buyingamount)
        {
            //it is use to catch logical error
            try
            {


                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingamount);
             
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();



            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }


        int salCount = 0;
        Int64 salesID;
        retrieval r = new retrieval();
        updation u=new updation();

        public void insertSales(DataGridView gv,string proIDGV,string proQuanGV, int doneBy, DateTime dt, float tAmount, float Discount,float cashRec,float cashBack ,string payType,string pupGV )
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totAmount", tAmount);
                    cmd.Parameters.AddWithValue("@discount", Discount);
                    cmd.Parameters.AddWithValue("@cashRec", cashRec);
                    cmd.Parameters.AddWithValue("@cashBack", cashBack);
                    if(payType =="Cash")
                    {
                        cmd.Parameters.AddWithValue("@payType", 0);
                    }
                   else if (payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 1);
                    }
                   else if (payType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 2);
                    }

                    MainClass.con.Open();
                    salCount = cmd.ExecuteNonQuery();
                    //sales ko count kaa rahe hai
                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //ExecuteScalar is se ik(1) hi value uth kar ati hai
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());
                       

                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuanGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@sellinPrice", Convert.ToSingle(row.Cells[pupGV].Value.ToString()));
                            cmd3.ExecuteNonQuery();

                            int stockOfProduct = Convert.ToInt32 (r.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString())));
                            int currentQuantityProduct= Convert.ToInt32(row.Cells[proQuanGV].Value.ToString());
                            int finalProductQuan = stockOfProduct - currentQuantityProduct;

                            u.updateStockWithoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString()),finalProductQuan);
                        }

                    }
                    MainClass.con.Close();
                    MainClass.ShowMSG("Sales Successful", "Success", "Success");
                    sc.Complete();
                }
                   

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            
        }
    }
}
