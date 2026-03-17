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
    public partial class SidebarController : Controller
    {
        // GET: API
        public ActionResult API()
        {
            List<object> dataList = new List<object>();
            dataList.Add(new { Type = "Over", value = "Over" });
            dataList.Add(new { Type = "Push", value = "Push" });
            dataList.Add(new { Type = "Slide", value = "Slide" });
            dataList.Add(new { Type = "Auto", value = "Auto" });
            Dictionary<string, object> HtmlAttribute = new Dictionary<string, object>()
            {   {"class", "default-sidebar" } };
            ViewData["HtmlAttribute"] = HtmlAttribute;
            ViewData["Types"] = dataList;
            return View();
        }
    }
}