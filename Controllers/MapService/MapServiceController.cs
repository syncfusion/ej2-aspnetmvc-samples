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

namespace EJ2MVCSampleBrowser.Controllers.MapService
{
    public class MapServiceController : Controller
    {
        // GET: MapService
        public JsonResult GetMapJsonResult(DataModel model)
        {
            string jsonText = "";
            if (model.shapeData != null)
            {
                string fileName = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data/MapData/" + model.shapeData + ".json";
                jsonText = System.IO.File.ReadAllText(fileName);
            }
            return Json(jsonText, JsonRequestBehavior.AllowGet);
        }
        public class DataModel
        {
            public string shapeData { get; set; }
        }

    }
}