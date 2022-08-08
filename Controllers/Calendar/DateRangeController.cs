using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class CalendarController : Controller
    {
        // GET: DateRange
        public ActionResult DateRange()
        {
            ViewBag.minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 05);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27);
            return View();
        }
    }
}