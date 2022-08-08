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
        public ActionResult DataBinding()
        {
            ViewBag.localdata = new Countries().CountriesList();
            ViewBag.sort = "Ascending";
            return View();
        }
    }
}