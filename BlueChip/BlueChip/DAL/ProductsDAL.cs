using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using BlueChip.Models;
using BlueChip.Helpers;

namespace BlueChip.DAL
{
    
    public class ProductsDAL
    {
        private const string SQL_GetAllProductsByLine = "select * from products where productLineId = @productLineId";
        private const string SQL_GetSingleProduct = "select * from products where id = @id";
        private const string SQL_GetAllProducts = "select * from products";

        private readonly DalHelper dalHelper;

        public ProductsDAL(string connectionString)
        {
            dalHelper = new DalHelper(connectionString);
        }

        public IList<ProductModel> GetAllProductsByLine(int productLineId)
        {
            return dalHelper.SelectList<ProductModel>(SQL_GetAllProductsByLine, "productLineId", productLineId);
        }

        public ProductModel GetSingleProduct(int id)
        {
            Dictionary<string, object> injectionDictionary = new Dictionary<string, object>();
            injectionDictionary.Add("id", id);

            return dalHelper.SelectSingle<ProductModel>(SQL_GetSingleProduct, injectionDictionary);
        }

        public IList<ProductModel> GetAllProducts()
        {
            return dalHelper.SelectList<ProductModel>(SQL_GetAllProducts);
        }
    }
}