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

namespace EJ2MVCSampleBrowser.Controllers.ListBox
{
    public partial class ListBoxController : Controller
    {
        public ActionResult DefaultFunctionalities()
        {
            List<object> data = new List<object>();
            data.Add(new { text = "Hennessey Venom", id = "list-01" });
            data.Add(new { text = "Bugatti Chiron", id = "list-02" });
            data.Add(new { text = "Bugatti Veyron Super Sport", id = "list-03" });
            data.Add(new { text = "SSC Ultimate Aero", id = "list-04" });
            data.Add(new { text = "Koenigsegg CCR", id = "list-05" });
            data.Add(new { text = "McLaren F1", id = "list-06" });
            data.Add(new { text = "Aston Martin One- 77", id = "list-07" });
            data.Add(new { text = "Jaguar XJ220", id = "list-08" });
            data.Add(new { text = "McLaren P1", id = "list-09" });
            data.Add(new { text = "Ferrari LaFerrari", id = "list-10" });
            ViewData["data"] = data;
            return View();
        }
    }

}