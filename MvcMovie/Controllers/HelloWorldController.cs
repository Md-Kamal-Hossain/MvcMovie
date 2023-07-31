using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index(string name, int numtimes = 1)
        {
            //return View();
            //return HttpUtility.HtmlEncode("Hello"+name+",Numtimes is"+numtimes);
            ViewBag.Message = name;
            ViewBag.NumTimes = numtimes;
            return View();
        }
        public ActionResult Welcome(string name, int numtimes = 1)
        {
            ////return HttpUtility.HtmlEncode("Hello"+name+",Numtimes is"+numtimes);
            ViewBag.Message = name;
            ViewBag.NumTimes = numtimes;
            return View();
        }
    }
}