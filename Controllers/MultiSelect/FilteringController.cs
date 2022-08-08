using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class MultiSelectController : Controller
    {
        public ActionResult Filtering()
        {
            ViewBag.data = new Countries().CountriesList();
            ViewBag.query = "new ej.data.Query()";
            return View();
        }
    }
}