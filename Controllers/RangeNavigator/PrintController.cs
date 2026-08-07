using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.RangeNavigator
{
    public partial class RangeNavigatorController : Controller
    {
        // GET: Print
        public ActionResult Print()
        {
            ViewData["lineWidth"] = new { width = 0.00001 };
            ViewData["border"] = new { width = 0.0001 };
            ViewData["animation"] = new { enable = false };
            return View();
        }
    }
}