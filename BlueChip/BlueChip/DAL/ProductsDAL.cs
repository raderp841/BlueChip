using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using BlueChip.Models;

namespace BlueChip.DAL
{
    
    public class ProductsDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private const string SQL_GetAllProductsByLine = "select * from products where productLineId = @productLineId";
        private const string SQL_GetSingleProduct = "select * from products where id = @id";
        private const string SQL_GetAllProducts = "select * from products";

       

        public ProductModel GetSingleProduct(int id)
        {
            ProductModel product = new ProductModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetSingleProduct, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        product.Id = Convert.ToInt32(reader["id"]);
                        product.LongDescription = Convert.ToString(reader["longDescription"]);
                        product.Named = Convert.ToString(reader["named"]);
                        product.PictureURL = Convert.ToString(reader["pictureURL"]);
                        product.Price = Convert.ToString(reader["price"]);
                        product.ProductLineId = Convert.ToInt32(reader["productLineId"]);
                        product.ShortDescription = Convert.ToString(reader["shortDescription"]);

                    }

                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return product;
        }

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllProducts, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductModel product = new ProductModel();
                        product.Id = Convert.ToInt32(reader["id"]);
                        product.LongDescription = Convert.ToString(reader["longDescription"]);
                        product.Named = Convert.ToString(reader["named"]);
                        product.PictureURL = Convert.ToString(reader["pictureURL"]);
                        product.Price = Convert.ToString(reader["price"]);
                        product.ProductLineId = Convert.ToInt32(reader["productLineId"]);
                        product.ShortDescription = Convert.ToString(reader["shortDescription"]);

                        products.Add(product);
                    }
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            return products;
        }

        public List<ProductModel> GetAllProductsForList(int productListId)
        {
            List<ProductModel> products = new List<ProductModel>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllProductsByLine, conn);
                    cmd.Parameters.AddWithValue("@productLineId", productListId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductModel product = new ProductModel();
                        product.Id = Convert.ToInt32(reader["id"]);
                        product.LongDescription = Convert.ToString(reader["longDescription"]);
                        product.Named = Convert.ToString(reader["named"]);
                        product.PictureURL = Convert.ToString(reader["pictureURL"]);
                        product.Price = Convert.ToString(reader["price"]);
                        product.ProductLineId = Convert.ToInt32(reader["productLineId"]);
                        product.ShortDescription = Convert.ToString(reader["shortDescription"]);

                        products.Add(product);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return products;
        }
    }
}