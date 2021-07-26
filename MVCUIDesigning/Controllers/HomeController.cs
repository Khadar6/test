using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class HomeController : Controller
    {
        
        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Validate(FormCollection fc)
        {
            if (fc["txtName"] == "Raju" && fc["txtPwd"] == "admin#123")
            {
                Session["User"] = fc["txtName"];//All Pages
                return View("Success");
            }
            else
            {
                ViewBag.User = fc["txtName"];//Only one page
                return View("Failure");
            }

        }
    }
}