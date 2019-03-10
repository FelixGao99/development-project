using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "回到首页";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "关于我们页面.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系页面.";

            return View();
        }
        //国内新闻视图
        public ActionResult ShowGN()
        {

            return View();
        }
        //国际新闻视图
        public ActionResult ShowGJ()
        {

            return View();
        }
        //娱乐新闻视图
        public ActionResult ShowYL()
        {

            return View();
        }
        //财经新闻视图
        public ActionResult ShowCJ()
        {

            return View();
        }
        //体育新闻视图
        public ActionResult ShowTY()
        {

            return View();
        }
        //后台入口视图
        public ActionResult Enter()
        {

            return View();
        }
        public ActionResult Feiji()
        {
            return View();

        }
        public ActionResult Shouji()
        {
            return View();

        }
        public ActionResult Juedi()
        {
            return View();

        }
    }
}
