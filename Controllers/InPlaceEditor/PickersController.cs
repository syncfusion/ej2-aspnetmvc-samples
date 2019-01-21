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
            ViewBag.modeData = new string[] { "Inline", "Popup" };
            ViewBag.dateData = new { placeholder = "Select a date" };
            ViewBag.timeData = new { placeholder = "Select a time" };
            ViewBag.dateTimeData = new { placeholder = "Select a date and time" };
            ViewBag.dateRangeData = new { placeholder = "Select a date range" };
            ViewBag.dateRangeValue = new DateTime[2] { new DateTime(2017, 05, 23), new DateTime(2017, 07, 05) };
            ViewBag.dateValue =new DateTime(2017, 05, 23);
            return View();
        }
    }
}
