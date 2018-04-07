using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using BlueChip.Models;


namespace BlueChip.DAL
{

    public class UserInfoProductsDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private const string SQL_GetProductsForUser = "select * from userInfoProducts where userInfoId = @userInfoId";
        private const string SQL_AddProductForUser = "insert into userInfoProducts values(@userInfoId, @productsId)";
        private const string SQL_RemoveProductForUser = "delete from userInfoProducts where userInfoId = @userInfoId and productsId = @productsId";


        public List<ProductModel> GetProductsForUser(int userInfoId)
        {
            ProductsDAL pdal = new ProductsDAL();
            List<UserInfoProductsModel> infoList = new List<UserInfoProductsModel>();
            List<ProductModel> output = new List<ProductModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetProductsForUser, conn);
                    cmd.Parameters.AddWithValue("@userInfoId", userInfoId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserInfoProductsModel model = new UserInfoProductsModel();
                        model.Id = Convert.ToInt32(reader["id"]);
                        model.ProductsId = Convert.ToInt32(reader["productsId"]);
                        model.UserInfoId = Convert.ToInt32(reader["userInfoId"]);
                        infoList.Add(model);
                    }
                }
                foreach (var i in infoList)
                {
                    output.Add(pdal.GetSingleProduct(i.ProductsId));
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return output;
        }

        public bool AddProductForUser(int userInfoId, int productId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_AddProductForUser, conn);
                    cmd.Parameters.AddWithValue("@userInfoId", userInfoId);
                    cmd.Parameters.AddWithValue("@productsId", productId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public bool DeleteProductForUser(int userInfoId, int productId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_RemoveProductForUser, conn);
                    cmd.Parameters.AddWithValue("@userInfoId", userInfoId);
                    cmd.Parameters.AddWithValue("@productsId", productId);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }

}