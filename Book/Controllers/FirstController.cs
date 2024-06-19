using Book.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            // 业务逻辑计算

            // 暂时结果
            ViewBag.User1 = "Fish1";
            ViewData["User2"] = "Fish2";
            TempData["User3"] = "Fish3";
            HttpContext.Session["User4"] = "Fish4";
            object User5 = "Fish5";

            return View(User5);
        }

        public ActionResult SecondPage()
        {
            LogHelper.Info("This is info");
            ViewBag.BigFish = "BigFish";
            return View();
        }
    }
}