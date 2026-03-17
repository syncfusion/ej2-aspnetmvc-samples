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

namespace EJ2MVCSampleBrowser.Controllers.ListView
{
    public partial class ListViewController : Controller
    {

        public ActionResult Virtualization()
        {
            List<object> ddlData = new List<object>();
            ddlData.Add(new { value = "1", text = "1k" });
            ddlData.Add(new { value = "5", text = "5k" });
            ddlData.Add(new { value = "10", text = "10k" });
            ddlData.Add(new { value = "25", text = "25k" });

            List<object> listdata = new List<object>();
            listdata.Add(new { id = "1", text = "1" });

            ViewData["ddlData"] = ddlData;
            ViewData["listData"] = listdata;
            return View();
        }
    }
}