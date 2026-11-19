using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        public ActionResult Highlight()
        {
            ViewData["countries"] = new Countries().CountriesList();
            ViewData["data"] = new string[] { "Contains", "StartsWith", "EndsWith" };
            return View();
        }
    }
}