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

namespace EJ2MVCSampleBrowser.Controllers.Sparkline
{
    public partial class SparklineController : Controller
    {
        // GET: Customization
        public ActionResult Customization()
        {
            ViewData["datasource"] = CustomData.GetData();
            return View();
        }

        public class CustomData
        {
            public string xval;
            public double yval;
            public double yval1;

            public static List<CustomData> GetData()
            {
                List<CustomData> data = new List<CustomData>();
                data.Add(new CustomData() { xval = "AUDI", yval1 = 1847613, yval = 1 });
                data.Add(new CustomData() { xval = "BMW", yval1 = 2030331, yval = 5 });
                data.Add(new CustomData() { xval = "BUICK", yval1 = 1465823, yval = -1 });
                data.Add(new CustomData() { xval = "CETROE", yval1 = 999888, yval = -6 });
                data.Add(new CustomData() { xval = "CHEVROLE", yval1 = 3857388, yval = 0 });
                data.Add(new CustomData() { xval = "FIAT", yval1 = 1503806, yval = 1 });
                data.Add(new CustomData() { xval = "FORD", yval1 = 5953122, yval = -2 });
                data.Add(new CustomData() { xval = "HONDA", yval1 = 4967689, yval = 7 });
                data.Add(new CustomData() { xval = "HYUNDAI", yval1 = 3951176, yval = -9 });
                data.Add(new CustomData() { xval = "JEEP", yval1 = 1390130, yval=0 });
                data.Add(new CustomData() { xval = "KIA", yval1 = 2511293, yval=-10 });
                data.Add(new CustomData() { xval = "MAZDA", yval1 = 1495557, yval=3 });
                data.Add(new CustomData() { xval = "MERCEDES", yval1 = 2834181, yval=13 });
                data.Add(new CustomData() { xval = "NISSAN", yval1 = 4834694, yval=5 });
                data.Add(new CustomData() { xval = "OPEL/VHALL", yval1 = 996559, yval=-6 });
                data.Add(new CustomData() { xval = "PEUGEOT", yval1 = 1590300, yval = 0 });
                data.Add(new CustomData() { xval = "RENAULT", yval1 = 2275227, yval = 7 });
                data.Add(new CustomData() { xval = "SKODA", yval1 = 1180672, yval=5 });
                data.Add(new CustomData() { xval = "SUBARU", yval1 = 1050390,yval=5 });
                data.Add(new CustomData() { xval = "SUZUKI", yval1 = 2891415,yval=11 });
                data.Add(new CustomData() { xval = "TOYOTA", yval1 = 7843423,yval=5 });
                data.Add(new CustomData() { xval = "VOLKSWAGEN", yval1 = 6639250,yval=3 });
                return data;
            }
        }
    }
}