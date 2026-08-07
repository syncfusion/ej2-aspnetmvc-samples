using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class TimePickerController : Controller
    {
        // GET: TimeFormat
        public ActionResult TimeFormat()
        {
            ViewData["value"] = DateTime.Now;
            return View();
        }
    }
}