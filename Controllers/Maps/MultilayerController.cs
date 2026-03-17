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


namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Multilayer
        public ActionResult Multilayer()
        {
            ViewData["shapeData"] = this.getusMap();
            ViewData["africa"] = this.GetCalifornia();
            MapsMarker marker = new MapsMarker();
            List<marketData> markData = new List<marketData>();
            markData.Add(new marketData(50.32087157990324, 90.015625, "Asia"));
            markData.Add(new marketData(-25.88583769986199, 134.296875, "Australia"));
            markData.Add(new marketData(16.97274101999902, 16.390625, "Africa"));
            markData.Add(new marketData(49.95121990866204, 18.468749999999998, "Europe"));
            markData.Add(new marketData(59.88893689676585, -109.3359375, "North America"));
            markData.Add(new marketData(-6.64607562172573, -55.54687499999999, "South America"));
            marker.DataSource = markData;
            marker.Visible = true;
            marker.Template = "<div id=" + "marker1" + " class=markerTemplate" + ">{{:name}}" + "</div>";
            marker.AnimationDuration = 0;
            List<MapsMarker> markerSettings = new List<MapsMarker>();
            markerSettings.Add(marker);
            ViewData["markerSettings"] = markerSettings;
            return View();
        }
        
        public object GetCalifornia()
        {
            string africa = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/California.js"));
            return JsonConvert.DeserializeObject(africa, typeof(object));
        }
        
    }
}