using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Stepper
{
    public partial class StepperController : Controller
    {
        public ActionResult Orientation()
        {
            List<Step> iconWithLabel = new List<Step>();
            iconWithLabel.Add(new Step { IconCss = "sf-icon-ordered", Label = "Orders" });
            iconWithLabel.Add(new Step { IconCss = "sf-icon-review", Label = "Review" });
            iconWithLabel.Add(new Step { IconCss = "sf-icon-package", Label = "Packing" });
            iconWithLabel.Add(new Step { IconCss = "sf-icon-delivery", Label = "Shipping" });
            ViewData["IconWithLabel"] = iconWithLabel;
            return View();
        }
    }
}