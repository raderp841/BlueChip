using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueChip.Models;
using BlueChip.DAL;
using System.Data.SqlClient;
using System.Configuration;


namespace BlueChip.Controllers
{
    public class HomeController : Controller
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public ActionResult Index()
        {
            ProductsDAL dal = new ProductsDAL(connectionString);
            var model = dal.GetAllProducts();
            return View("Index", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}