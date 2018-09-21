using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DateTimePickerController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DateRange()
        {
            ViewBag.value = DateTime.Now;
            ViewBag.minDate =new DateTime(DateTime.Now.Year, DateTime.Now.Month, 07, 10, 00, 00);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27, 22, 30, 00);
            return View();
        }
    }
}
