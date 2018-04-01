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
                }
            }
            catch(SqlException ex)
            {

            }
            return productLine;
        }
    }
}