using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using BlueChip.Models;
using BlueChip.DAL;

namespace BlueChip.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<ProductModel> GetProductsByList(int id)
        {
            ProductsDAL dal = new ProductsDAL();
            var products = dal.GetAllProductsForList(id);
            return products;
        }

    }
}
