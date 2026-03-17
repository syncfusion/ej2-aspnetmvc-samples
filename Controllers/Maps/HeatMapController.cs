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
        // GET: HeatMap
        public ActionResult HeatMap()
        {
            ViewData["ShapeData"] = this.getIndiaMap();
            ViewData["DataSource"] = this.getIndiaData();
            List<MapsColorMapping> colorMapping = new List<MapsColorMapping>();
            colorMapping.Add(new MapsColorMapping { From = 60000, To = 400000, Color = "#9fdfdf", Label = "<0.4M" });
            colorMapping.Add(new MapsColorMapping { From = 400000, To = 10000000, Color = "#79d2d2", Label = "0.4-10M" });
            colorMapping.Add(new MapsColorMapping { From = 10000000, To = 20000000, Color = "#53C6C6", Label = "10-20M" });
            colorMapping.Add(new MapsColorMapping { From = 20000000, To = 70000000, Color = "#39acac", Label = "20-70M" });
            colorMapping.Add(new MapsColorMapping { From = 70000000, To = 100000000, Color = "#339999", Label = "70-100M" });
            colorMapping.Add(new MapsColorMapping { From = 100000000, To = 200000000, Color = "#2d8686", Label = ">100M" });
            ViewData["ColorMapping"] = colorMapping;
            return View();
        }
        public object getIndiaData()
        {
            JObject data = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/Population.json")));
            return data["Population"];
        }

        public object getIndiaMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/India.json")));
            return world;
        }
    }
}