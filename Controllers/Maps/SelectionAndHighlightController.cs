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
        // GET: SelectionAndHighlight
        public ActionResult SelectionAndHighlight()
        {
            ViewData["ShapeData"] = this.getUSAMap();
            ViewData["DataSource"] = this.getElectionData();
            List<MapsColorMapping> colorMapping = new List<MapsColorMapping>();
            colorMapping.Add(new MapsColorMapping { Value = "Trump", Color = "#D84444", Label = null });
            colorMapping.Add(new MapsColorMapping { Value = "Clinton", Color = "#316DB5", Label = null });
            ViewData["ColorMapping"] = colorMapping;
            return View();
        }

        public object getUSAMap()
        {
            JObject usa = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/USA.json")));
            return usa;
        }

        public object getElectionData()
        {
            JObject data = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/ElectionData.json")));
            return data["ElectionData"];
        }
    }
}