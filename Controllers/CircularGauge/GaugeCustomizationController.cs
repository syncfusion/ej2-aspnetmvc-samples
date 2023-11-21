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
        // GET: Customization
        public ActionResult GaugeCustomization()
        {

            List<CircularGaugeAnnotation> annotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation1 = new CircularGaugeAnnotation();
            annotation1.Content = "<div style=color:#666666;font-size:35px;>1800</div";
            annotation1.Radius = "110%";
            annotation1.Angle = 0;
            annotation1.ZIndex = "1";
            annotations.Add(annotation1);
            ViewBag.Annotations = annotations;

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 1000;
            range1.End = 2000;
            range1.StartWidth = "30";
            range1.EndWidth = "30";
            range1.Radius = "90%";
            range1.Color = "#E0E0E0";
            ranges.Add(range1);
            ViewBag.Ranges = ranges;

            // Pointers //
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Type = PointerType.RangeBar;
            pointer1.Value = 1800;
            pointer1.Radius = "90%";
            pointer1.Color = "#FFDD00";
            pointer1.Animation = new CircularGaugeAnimation{ Duration = 0 };
            pointer1.PointerWidth = 30;
            pointers.Add(pointer1);

            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.Value = 1800;
            pointer2.Radius = "90%";
            pointer2.Color = "#424242";
            pointer2.Animation = new CircularGaugeAnimation{ Duration = 0 };
            pointer2.PointerWidth = 9;
            pointer2.Cap = new CircularGaugeCap { Radius = 10, Color = "#424242", Border = new CircularGaugeBorder { Width = 0 } };
            pointers.Add(pointer2);
            ViewBag.Pointers = pointers;

            return View();
        }
    }
}