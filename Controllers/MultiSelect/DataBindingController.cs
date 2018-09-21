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
        public ActionResult DataBinding()
        {
            ViewBag.localdata = new Countries().CountriesList();
            ViewBag.sort = "Ascending";
            ViewBag.query = "new ej.data.Query().select(['ContactName', 'CustomerID']).take(25)";
            return View();
        }
    }
}