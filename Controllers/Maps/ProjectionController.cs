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
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Projection
        public ActionResult Projection()
        {
            ViewData["shapeData"] = this.WorldMap();
            ViewData["dataSource"] = this.getUNOData();
            List<MapsColorMapping> data = new List<MapsColorMapping>();
            data.Add(new MapsColorMapping { Value = "Permanent", Color = "#EDB46F", Label = null });
            data.Add(new MapsColorMapping { Value = "Non-Permanent", Color = "#F1931B", Label = null });
            ViewData["colorMappings"] = data;
            return View();
        }
        public object WorldMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }

        public object getUNOData()
        {
            string unText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/UNOCountries.js"));
            return JsonConvert.DeserializeObject(unText, typeof(object));
        }
        
    }
}