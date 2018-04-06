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
        private const int Register = 0;
        private const int Login = 1;

        public ActionResult Index()
        {
            ProductlLineDAL dal = new ProductlLineDAL();
            var model = dal.GetAllProductLines();
            return View("Index", model);
        }

        [Route("login")]
        public ActionResult LoginRegister()
        {
            if (Session["User"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                UserInfoModel model = new UserInfoModel();
                return View("LoginRegister", model);
            }
        }

        [HttpPost]
        [Route("login")]
        public ActionResult LoginRegister(UserInfoModel newUser, int logCode)
        {
            UserInfoDAL userInfoDAL = new UserInfoDAL();

            if (logCode == Register)
            {
                if (ModelState.IsValid)
                {


                    userInfoDAL.SaveNewUser(newUser);
                    var user = userInfoDAL.SelectUserByEmail(newUser.Email);
                    Session["User"] = user;

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View("LoginRegister");
                }
            }
            if (logCode == Login)
            {
                string providedPassword = newUser.Password;

                if (userInfoDAL.CheckAvailability(newUser.Email) == false)
                {
                    UserInfoModel user = userInfoDAL.SelectUserByEmail(newUser.Email);

                    if (user.Password == providedPassword)
                    {
                        Session["User"] = user;
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ViewBag.LoginError = "Login or password was incorrect.";
                }
            }
            return View("LoginRegister");
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

        public ActionResult Cart()
        {
            UserInfoProductsDAL dal = new UserInfoProductsDAL();
            List<ProductModel> model = new List<ProductModel>();
            if(Session["User"] != null)
            {
                UserInfoModel user = Session["User"] as UserInfoModel;
                model = dal.GetProductsForUser(user.Id);
            }
            Session["Cart"] = model;

            foreach(var product in model)
            {
                product.PriceDec = Convert.ToDouble(product.Price);
            }

            return RedirectToAction("Index");
        }

        public ActionResult SaveItemForUser(int productId)
        {
            UserInfoProductsDAL dal = new UserInfoProductsDAL();

            if (Session["User"] != null)
            {
                UserInfoModel user = Session["User"] as UserInfoModel;
                dal.AddProductForUser(user.Id, productId);

                return RedirectToAction("Cart");
            }
            else
            {
               return  RedirectToAction("LoginRegister");
            }

        }

        public ActionResult LogOut()
        {
            Session["User"] = null;

            return RedirectToAction("LoginRegister");
        }
    }
}