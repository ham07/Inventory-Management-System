using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class updation
    {
        public void updateUser(int id, string name, string username, string pass, string email, string phone, Int16 status)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + "updated to the system successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void updateCat(int id, string name, Int16 status)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + "updated successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void updateProducts(Int64 proID, string product, string barcode,  int catID, DateTime? expiry = null)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_productUpdate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + "updated to the system successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void updateSuppliers(int supID, string company, string person, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSuppliers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@conPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
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
                cmd.Parameters.AddWithValue("@suppID", supID);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(company + " updated to the system successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void updateStock(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
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

        public void updateStockWithoutConnection(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
               
                cmd.ExecuteNonQuery();
              

            }
            //exception handlini
            catch (Exception ex)
            {
               
            }

        }

        public void updateProductPrice(Int64 proID, float bp,float sp,float dis,float profitPer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", bp);
                cmd.Parameters.AddWithValue("@sp", sp);
                cmd.Parameters.AddWithValue("@dis", dis);
                cmd.Parameters.AddWithValue("@proPer", profitPer);
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

        public void updateProductPriceWRTPI(int proID, float bp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProductPriceInPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", bp);
               
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

    }
}
