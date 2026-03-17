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
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: FlightRoutes
        public ActionResult FlightRoutes()
        {
            ViewData["ShapeData"] = this.getWorldMap();
            List<object> data = new List<object>();
            data.Add(new { name = "India" });
            data.Add(new { name = "China" });
            ViewData["DataSource"] = data;
            List<MapsColorMapping> color = new List<MapsColorMapping>();
            color.Add(new MapsColorMapping { Value = "China", Color = "#f7d083", Label = null });
            color.Add(new MapsColorMapping { Value = "India", Color = "#FFFE99", Label = null });
            ViewData["ColorMapping"] = color;
            return View();
        }
    }
}