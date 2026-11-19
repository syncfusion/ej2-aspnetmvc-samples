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
        public ActionResult DateFormats()
        {
            ViewData["value"] = DateTime.Now;
            ViewData["data"] = new DateFormats().GetDateFormatsWithId();
            ViewData["formatData"] = new DateFormats().GetInputFormats();
            return View();
        }
    }
}
