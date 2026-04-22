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
using Newtonsoft.Json;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Annotation
        public ActionResult Annotation()
        {
            ViewData["shapeData"] = this.getAnnotation();
            
            return View();
        }

        public object getAnnotation() {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Africa_Continent.js"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}