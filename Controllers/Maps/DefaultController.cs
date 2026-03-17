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
        // GET: Default
        public ActionResult Default()
        {                       
            List<DataSource> data = new List<DataSource>();
            data.Add(new DataSource("North America", "#71B081"));
            data.Add(new DataSource("South America", "#5A9A77"));
            data.Add(new DataSource("Africa", "#498770"));
            data.Add(new DataSource("Europe", "#39776C"));
            data.Add(new DataSource("Asia", "#266665"));
            data.Add(new DataSource("Australia", "#124F5E"));
            ViewData["shapeData"] = this.GetWorldMap();
            ViewData["dataSource"] = data;
            return View();
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
    [Serializable]
    public class DataSource
    {
        public DataSource(string cont, string col)
        {
            this.continent = cont;
            this.color = col;
        }
        public string continent
        {
            get;
            set;
        }
        public string color
        {
            get;
            set;
        }        

    }

    public class marketData
    {
        public marketData(double lat, double lon, string name) {
            this.latitude = lat;
            this.longitude = lon;
            this.name = name;
        }
        public double latitude
        {
            get;set;
        }
        public double longitude
        {
            get;set;
        }
        public string name
        {
            get;set;
        }
    }
}