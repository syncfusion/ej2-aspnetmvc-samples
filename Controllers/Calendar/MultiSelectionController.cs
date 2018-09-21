using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class CalendarController : Controller
    {
        // GET: MultiSelection
        public ActionResult MultiSelection()
        {
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            ViewBag.multiValue = new DateTime[] { new DateTime(year, month, 10), new DateTime(year, month, 15), new DateTime(year, month, 25) };
            return View();
        }
    }
}