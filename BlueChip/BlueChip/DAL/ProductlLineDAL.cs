using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using BlueChip.Models;

namespace BlueChip.DAL
{
    public class ProductlLineDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private const string SQL_SelectAllProductLines = "select * from productLine";
        private const string SQL_SelectSingleProductLine = "select * from productLine where id = @id";

        public ProductLineModel SelectSingleProductLine(int id)
        {
            ProductLineModel productLine = new ProductLineModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_SelectSingleProductLine, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        productLine.Id = Convert.ToInt32(reader["id"]);
                        productLine.LongDescription = Convert.ToString(reader["longDescription"]);
                        productLine.Named = Convert.ToString(reader["named"]);
                        productLine.pictureURL = Convert.ToString(reader["pictureURL"]);
                        productLine.ShortDescription = Convert.ToString(reader["shortDescription"]);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return productLine;
        }

        public List<ProductLineModel> GetAllProductLines()
        {
            List<ProductLineModel> output = new List<ProductLineModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_SelectAllProductLines, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductLineModel productLine = new ProductLineModel();
                        productLine.Id = Convert.ToInt32(reader["id"]);
                        productLine.LongDescription = Convert.ToString(reader["longDescription"]);
                        productLine.Named = Convert.ToString(reader["named"]);
                        productLine.pictureURL = Convert.ToString(reader["pictureURL"]);
                        productLine.ShortDescription = Convert.ToString(reader["shortDescription"]);

                        output.Add(productLine);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return output;
        }
    }
}