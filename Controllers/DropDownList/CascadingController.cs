using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DropDownListController : Controller
    {
        public ActionResult Cascading()
        {
            ViewBag.state = new State().StateList();
            ViewBag.country = new Country().CountryList();
            ViewBag.cities = new Cities().CitiesList();
            ViewBag.popupHeight = "auto";
            return View();
        }
    }
}