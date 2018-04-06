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
    public class CartController : ApiController
    {
        //public IEnumerable<ProductModel> SaveItemForUser(int id)
        //{
        //    ProductsDAL dal = new ProductsDAL();
        //    UserInfoProductsDAL udal = new UserInfoProductsDAL();
        //    if (Session["User"] != null)
        //    {
        //        UserInfoModel user = Session["User"] as UserInfoModel;
        //        dal.AddProductForUser(user.Id, productId);

        //        var products = dal.GetAllProductsForList(id);
        //    return products;
        //}
    }
}
