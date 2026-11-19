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
            ViewData["state"] = new State().StateList();
            ViewData["country"] = new Country().CountryList();
            ViewData["cities"] = new Cities().CitiesList();
            ViewData["popupHeight"] = "auto";
            return View();
        }
    }
}