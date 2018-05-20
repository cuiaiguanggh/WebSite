using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "产品与服务";

            return View();
        }
        public ActionResult Honor()
        {
            ViewBag.Message = "企业荣誉";

            return View();
        }

        public ActionResult Show()
        {
            ViewBag.Message = "企业展示";

            return View();

        }
    }
}