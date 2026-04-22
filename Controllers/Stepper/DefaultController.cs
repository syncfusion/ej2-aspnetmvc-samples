#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Buttons;
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
        public ActionResult Default()
        {       

            List<Step> customText = new List<Step>();
            customText.Add(new Step { Text = "1" });
            customText.Add(new Step { Text = "2" });
            customText.Add(new Step { Text = "3" });
            customText.Add(new Step { Text = "4" });
            customText.Add(new Step { Text = "5" });
            ViewData["CustomText"] = customText;

            List<Step> iconOnly = new List<Step>();
            iconOnly.Add(new Step { IconCss = "sf-icon-cart" });
            iconOnly.Add(new Step { IconCss = "sf-icon-user" });
            iconOnly.Add(new Step { IconCss = "sf-icon-transport" });
            iconOnly.Add(new Step { IconCss = "sf-icon-payment" });
            iconOnly.Add(new Step { IconCss = "sf-icon-success" });
            ViewData["IconOnly"] = iconOnly;

            List<Step> labelOnly = new List<Step>();
            labelOnly.Add(new Step { Label = "Cart" });
            labelOnly.Add(new Step { Label = "Address" });
            labelOnly.Add(new Step { Label = "Delivery" });
            labelOnly.Add(new Step { Label = "Payment" });
            labelOnly.Add(new Step { Label = "Ordered" });
            ViewData["LabelOnly"] = labelOnly;

            List<Step> iconWithLabel = new List<Step>();
            iconWithLabel.Add(new Step { Label = "Cart", IconCss = "sf-icon-cart" });
            iconWithLabel.Add(new Step { Label = "Address", IconCss = "sf-icon-user" });
            iconWithLabel.Add(new Step { Label = "Delivery", IconCss = "sf-icon-transport" });
            iconWithLabel.Add(new Step { Label = "Payment", IconCss = "sf-icon-payment", Optional = true });
            iconWithLabel.Add(new Step { Label = "Ordered", IconCss = "sf-icon-success" });
            ViewData["IconWithLabel"] = iconWithLabel;

            return View();
        }
    }
}