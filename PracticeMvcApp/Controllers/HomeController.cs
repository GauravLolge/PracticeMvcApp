namespace PracticeMvcApp.Controllers
{
    using PracticeMvcApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            return View(new User());
        }

        [HttpPost]
        public ActionResult SaveData(User user)
        {
            if(ModelState.IsValid)
            {

            }

            return View(user);
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