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
        [HttpPost]
        [Route("api/cart/{id}")]
        public IHttpActionResult Delitem(string id)
        {
            
            string[] arr = id.Split('a');
            UserInfoProductsDAL dal = new UserInfoProductsDAL();
            dal.DeleteProductForUser(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]));
            return  Ok();
        }
    }
}
