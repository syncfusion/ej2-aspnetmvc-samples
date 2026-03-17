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
namespace EJ2MVCSampleBrowser.Controllers.Sparkline
{
    public partial class SparklineController : Controller
    {
        // GET: Sparkgrid
        public ActionResult Sparkgrid()
        {
            ViewData["dataSource"] = this.getDataSource("OrderData");
            return View();
        }
        public object getDataSource(string filename)
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/OrderData.js"));
            return JsonConvert.DeserializeObject(allText);
        }
    }
}