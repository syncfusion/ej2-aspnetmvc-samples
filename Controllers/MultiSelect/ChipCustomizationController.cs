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
        public ActionResult ChipCustomization()
        {
            ViewBag.data = new ColorsData().GetColorsData();
            ViewBag.val = new string[] { "#2F5D81", "#D44FA3", "#4CD242", "#FE2A00", "#75523C"};
            return View();
        }
    }
}