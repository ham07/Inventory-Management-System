using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class deletion
    {
        public void delete(object id, string proc, string param)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG("data deleted  successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void deletecat(object id, string proc, string param)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG("data deleted  successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }



        }
        public void deleteProducts(object id, string proc, string param)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_productDelete", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG("data deleted  successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void deletesup(object id, string proc, string param)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteSuppliers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG("data deleted  successfully", "Success", "Success");
            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }

        }

        public void deleteFromPurchaseInvoice(object id, string proc, string param)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteProductFromPID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG("data deleted  successfully", "Success", "Success");
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
