using Syncfusion.EJ2.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Layouts;
namespace EJ2MVCSampleBrowser.Controllers.Timeline
{
    public partial class TimelineController : Controller
    {
        public ActionResult API()
        {
            List<object> orientationData = new List<object>();
            orientationData.Add(new { text = "Vertical", value = "vertical" });
            orientationData.Add(new { text = "Horizontal", value = "horizontal" });
            ViewData["OrientationData"] = orientationData;

            List<object> alignData = new List<object>();
            alignData.Add(new { text = "Before", value = "before" });
            alignData.Add(new { text = "After", value = "after" });
            alignData.Add(new { text = "Alternate", value = "alternate" });
            alignData.Add(new { text = "Alternate reverse", value = "alternatereverse" });
            ViewData["AlignData"] = alignData;

            return View();
        }
    }
}