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
        // GET: Range
        public ActionResult Range()
        {
            // Annotations //
            List<CircularGaugeAnnotation> annotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation1 = new CircularGaugeAnnotation();
            annotation1.Content = "<div><span style=font-size:14px; font-family:Regular>Speedometer</span></div>";
            annotation1.Radius = "30%";
            annotation1.Angle = 0;
            annotation1.ZIndex = "1";
            annotations.Add(annotation1);
            CircularGaugeAnnotation annotation2 = new CircularGaugeAnnotation();
            annotation2.Content = "<div><span style=font-size:20px; font-family:Regular>65 MPH</span></div>";
            annotation2.Radius = "40%";
            annotation2.Angle = 180;
            annotation2.ZIndex = "1";
            annotations.Add(annotation2);
            ViewBag.Annotations = annotations;

            //Pointers //
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 65;
            pointer1.Radius = "60%";
            pointer1.PointerWidth = 8;
            pointer1.Cap = new CircularGaugeCap
            {
                Radius = 7
            };
            pointer1.NeedleTail = new CircularGaugeNeedleTail
            {
                 Length = "18%"
            };
            pointers.Add(pointer1);
            ViewBag.Pointers = pointers;

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 40;
            range1.Color = "#30B32D";
            ranges.Add(range1);

            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 40;
            range2.End = 80;
            range2.Color = "#FFDD00";
            ranges.Add(range2);

            CircularGaugeRange range3 = new CircularGaugeRange();
            range3.Start = 80;
            range3.End = 120;
            range3.Color = "#F03E3E";
            ranges.Add(range3);
            ViewBag.Ranges = ranges;
            return View();
        }
    }
}