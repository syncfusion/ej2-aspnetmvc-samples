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
        public ActionResult Format()
        {
            ViewData["value"] = DateTime.Now;
            ViewData["data"] = new DateTimeFormats().GetDateTimeFormatsWithId();
            ViewData["formatData"] = new DateTimeFormats().GetDateTimeInputFormats();
            return View();
        }
    }
}
