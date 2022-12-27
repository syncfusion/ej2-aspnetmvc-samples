#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        // GET: Ticks
        public ActionResult TicksAndLabels()
        {
            List<CircularGaugeAnnotation> annotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation1 = new CircularGaugeAnnotation();
            annotation1.Content = "<div id=content style=color:#518C03;font-size:20px;font-family:Segoe UI;font-weight:semibold;>145</div>";
            annotation1.Radius = "0%";
            annotation1.Angle = 0;
            annotation1.ZIndex = "1";
            annotations.Add(annotation1);
            ViewBag.Annotations = annotations;

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 145;
            range1.Radius = "60%";
            range1.Color = "#8BC34A";
            ranges.Add(range1);
            ViewBag.Ranges = ranges;

            // Pointers //
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.PointerWidth = 0;
            pointer1.NeedleTail = new CircularGaugeNeedleTail
            {
                Color = "transparent",
                Length = "0%"
            };
            ViewBag.Pointers = pointers;
            return View();
        }
    }
}