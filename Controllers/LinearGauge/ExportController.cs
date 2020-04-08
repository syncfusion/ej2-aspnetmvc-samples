using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
    {
        // GET: Default
        public ActionResult Export()
        {
            ViewBag.format = new string[] { "JPEG", "PNG", "SVG", "PDF" };
            return View();
        }
    }
}