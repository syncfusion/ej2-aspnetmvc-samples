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
        public ActionResult Ticks()
        {
            ViewBag.sliderValue = new int[] { 30, 70 };
            List<object> data = new List<object>();
            data.Add(new { text = "Before", id = "Before" });
            data.Add(new { text = "After", id = "After" });
            data.Add(new { text = "Both", id = "Both" });
            data.Add(new { text = "None", id = "None" });
            ViewBag.dataSource = data;
            return View();
        }
    }
}
