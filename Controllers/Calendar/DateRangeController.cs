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
            ViewData["minDate"] = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 05);
            ViewData["maxDate"] = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27);
            return View();
        }
    }
}