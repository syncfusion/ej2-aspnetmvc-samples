using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.InPlaceEditor
{
    public partial class InPlaceEditorController : Controller
    {
        // GET: Pickers
        public ActionResult Pickers()
        {
            ViewBag.ModeData = new string[] { "Inline", "Popup" };
            ViewBag.DateData = new { placeholder = "Select a date" };
            ViewBag.TimeData = new { placeholder = "Select a time" };
            ViewBag.DateTimeData = new { placeholder = "Select a date and time" };
            ViewBag.DateRangeData = new { placeholder = "Select a date range" };
            ViewBag.DateRangeValue = new DateTime[2] { new DateTime(2017, 05, 23), new DateTime(2017, 07, 05) };
            ViewBag.DateValue =new DateTime(2017, 05, 23);
            return View();
        }
    }
}
