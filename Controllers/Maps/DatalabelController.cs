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
using Newtonsoft.Json;
using Syncfusion.EJ2.Maps;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Datalabel
        public ActionResult Datalabel()
        {
            ViewData["usmap"] = getusMap();
            return View();
        }
        public object getusMap()
        {
            string usmap = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.js"));
            return JsonConvert.DeserializeObject(usmap);
        }
    }
}