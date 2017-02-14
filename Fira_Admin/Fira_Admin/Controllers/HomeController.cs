using ConnectionLayer.Repositories;
using ConnectionLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fira_Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult _LoginTest()
        {
            var accounts = Account_Repository.GetAccounts();
            Account_Repository.Clear();
            return View(accounts);
        }
        [HttpPost]
        public ActionResult _LoginTest(string email,string password)
        {
            var acc = new tbl_Account()
            {
                Email = email,
                Admin = false,
            };
            Account_Repository.AddAcc(acc);

            var accounts = Account_Repository.GetAccounts();

            return View(accounts);
        }
    }
}