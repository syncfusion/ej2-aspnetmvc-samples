using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class CalendarController : Controller
    {
        // GET: SpecialDates
        public ActionResult IslamicCalendar()
        {
            return View();
        }
    }
}