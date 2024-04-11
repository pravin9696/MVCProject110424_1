using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject110424_1.Controllers
{
    public class GTHController : Controller
    {
        // GET: GTH
        public ActionResult Index()
        {
            return View("My_index");
        }
        public ActionResult showPage()
        {
            return View();
        }
    }
}