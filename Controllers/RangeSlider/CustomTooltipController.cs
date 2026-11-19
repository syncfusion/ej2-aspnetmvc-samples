using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RangeSliderController : Controller
    {
        public ActionResult CustomTooltip()
        {
            ViewData["sliderValue"] = new int[] { 30, 70 };
            ViewData["timeValue"] = new decimal[] { 1373697000000, 1373718600000 };
            return View();
        }
    }
}
