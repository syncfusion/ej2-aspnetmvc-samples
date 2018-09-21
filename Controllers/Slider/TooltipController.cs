using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SliderController : Controller
    {
        public ActionResult Tooltip()
        {
            ViewBag.sliderValue = new int[] { 30, 70 };
            List<object> placement = new List<object>();
            placement.Add(new { text = "Before", id = "Before" });
            placement.Add(new { text = "After", id = "After" });
            ViewBag.placement = placement;
            List<object> showon = new List<object>();
            showon.Add(new { text = "Auto", id = "Auto" });
            showon.Add(new { text = "Focus", id = "Focus" });
            showon.Add(new { text = "Hover", id = "Hover" });
            showon.Add(new { text = "Always", id = "Always" });
            ViewBag.showon = showon;
            return View();
        }
    }
}
