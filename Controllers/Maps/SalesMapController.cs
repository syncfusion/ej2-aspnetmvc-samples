#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Marker
        public ActionResult SalesMap()
        {
            ViewData["shapeData"] = this.GetWorldMap();
            string population = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/ProductWorth.js"));
            object datasrc = JsonConvert.DeserializeObject(population, typeof(object));
            MapsMarker marker = new MapsMarker();
            marker.Visible = true;
            marker.DataSource = JsonConvert.DeserializeObject(population, typeof(object));
            marker.AnimationDuration = 0;
            marker.Shape = MarkerType.Image;
            marker.Width = 15;
            marker.Height = 15;
            marker.TooltipSettings = new MapsTooltipSettings { Visible = true, ValuePath = "area", Format = "<b>Name</b> : ${name}<br><b>Product</b> : ${product}<br><b>Total purchase</b> : ${worth}" };
            List<MapsMarker> markerSettings = new List<MapsMarker>();
            markerSettings.Add(marker);
            ViewData["markerSettings"] = markerSettings;
            return View();
        }
    }
}