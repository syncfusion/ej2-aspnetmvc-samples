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
using Syncfusion.EJ2.Base;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {

        // GET: FlexibleDataBinding
        public ActionResult FlexibleData()
        {
            List<object> urlDataList = new List<object>();
            urlDataList.Add(new { text = "https://services.odata.org/V4/Northwind/Northwind.svc/Orders/", value = "ODataV4Adaptor" });
            urlDataList.Add(new { text = "https://services.syncfusion.com/aspnet/production/api/Orders", value = "WebApiAdaptor" });
            urlDataList.Add(new { text = "https://services.syncfusion.com/aspnet/production/api/UrlDataSource", value = "UrlAdaptor" });
            urlDataList.Add(new { text = "https://services.odata.org/V4/Northwind/Northwind.svc/Orders", value = "Custom Binding" });
            ViewData["UrlDataList"] = urlDataList;
            return View();
        }
    }
}
