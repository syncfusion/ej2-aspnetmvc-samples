using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DatePickerController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DateRange()
        {
            ViewData["value"] = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10);
            ViewData["minDate"] = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 05);
            ViewData["maxDate"] = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27);
            return View();
        }
    }
}
