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

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SplitterController : Controller
    {
        // GET: DetailsView
        public ActionResult DetailsView()
        {
            List<object> data = new List<object>();
            data.Add(new { name = "Margaret", imgUrl = @Url.Content("~/Content/splitter/images/margaret.png"), id = "1" });
            data.Add(new { name = "Laura", imgUrl = @Url.Content("~/Content/splitter/images/laura.png"), id = "2" });
            data.Add(new { name = "Robert", imgUrl = @Url.Content("~/Content/splitter/images/robert.png"), id = "3" });
            data.Add(new { name = "Michale", imgUrl = @Url.Content("~/Content/splitter/images/michale.png"), id = "4" });
            data.Add(new { name = "Albert", imgUrl = @Url.Content("~/Content/splitter/images/albert.png"), id = "5" });
            ViewData["DataSource"] = data;
            return View();
        }
    }
}