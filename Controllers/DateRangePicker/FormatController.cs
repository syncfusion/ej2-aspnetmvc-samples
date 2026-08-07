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
            public ActionResult Format()
        {
            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddDays(20);
            ViewData["start"] = startDate;
            ViewData["end"] = endDate;
            ViewData["data"] = new DateRangeFormats().GetDateFormatsWithId();
            ViewData["formatData"] = new DateRangeFormats().GetInputFormats();
            return View();
        }
    }
}
