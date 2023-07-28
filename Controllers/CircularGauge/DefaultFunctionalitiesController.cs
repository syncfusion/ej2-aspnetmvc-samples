#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.CircularGauge;

namespace EJ2MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        // GET: Default
        public ActionResult DefaultFunctionalities()
        {
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 60;
            pointer1.Radius = "60%";
            pointer1.PointerWidth = 7;
            pointer1.Cap = new CircularGaugeCap
            {
                Radius = 7,
                Color = "#757575",
                Border = new  CircularGaugeBorder{ Width = 0 }
            };
            pointer1.NeedleTail = new CircularGaugeNeedleTail
            {
                Length="25%"
            };
            pointers.Add(pointer1);
            ViewBag.Pointers = pointers;
            ViewBag.labelFont = new CircularGaugeFont
            {
                FontFamily = "Roboto",
                Size = "12px",
                Opacity = 1,
                FontWeight = "Regular"
            };
            return View();
        }
    }
}