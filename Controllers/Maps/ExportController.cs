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
        public ActionResult Export()
        {
            ViewData["shapeData"] = this.WorldMap();
            ViewData["dataSource"] = this.getUNOData();
            ViewData["format"] = new string[] { "JPEG", "PNG", "SVG", "PDF" };
            ViewData["format1"] = new string[] { "Geometry", "OSM" };
            return View();
        }
    }

}