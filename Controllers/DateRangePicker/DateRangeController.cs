using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DateRangePickerController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DateRange()
        {
            ViewBag.minDate = new DateTime(2017, 01, 05);
            ViewBag.maxDate = new DateTime(2017, 12, 20);
            return View();
        }
    }
}
