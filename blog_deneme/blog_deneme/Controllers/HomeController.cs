using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

using PagedList.Mvc;
using blog_deneme.Veritabani;


namespace blog_deneme.Controllers
{
    public class HomeController : Controller
    {

     


        public ActionResult Index()
        {
            return View();
          
        }

        public ActionResult About()
        {
            ViewBag.Message = "Cigdem Uysal";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "page";

            return View();
        }
    }
}


