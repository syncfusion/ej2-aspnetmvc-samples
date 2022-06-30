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
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: ZoomingAndPanning
        public ActionResult ZoomingAndPanning()
        {
            ViewBag.ShapeData = this.getWorldMap();
            ViewBag.DataSource = this.getData();
            return View();
        }

        public object getData()
        {
            JObject data = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/RandomCountries.json")));
            return data["RandomCountries"];
        }
    }
}