#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        // GET: Campass
        public ActionResult DirectionCompass()
        {

            // Pointers //
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 7;
            pointer1.Radius = "50%";
            pointer1.Color = "#f03e3e";
            pointer1.PointerWidth = 20;
            pointer1.Cap = new CircularGaugeCap{ Radius = 0 };
            pointer1.Animation = new CircularGaugeAnimation{ Enable = false };
            pointers.Add(pointer1);

            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.Value = 3;
            pointer2.Radius = "50%";
            pointer2.Color = "#9E9E9E";
            pointer2.PointerWidth = 20;
            pointer2.Cap = new CircularGaugeCap { Radius = 0 };
            pointer2.Animation = new CircularGaugeAnimation { Enable = false };
            pointers.Add(pointer2);
            ViewBag.Pointers = pointers;
            return View();
        }
    }
}