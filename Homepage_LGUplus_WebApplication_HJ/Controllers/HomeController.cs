using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LGUplus.Common.ClassLibrary.HJ01;

namespace Homepage_LGUplus_WebApplication_HJ.Controllers
{
    /// <summary>
    /// 메인 페이지 호출 메소드
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserService service = new UserService();
            var user = service.GetUserData("Early");

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
    }
}