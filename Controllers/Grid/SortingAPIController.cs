#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: SortingAPI
        public ActionResult SortingAPI()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewData["datasource"] = order;
            List<object> dd = new List<object>();
            dd.Add(new { text = "Order ID", value = "OrderID" });
            dd.Add(new { text = "Customer Name", value = "CustomerID" });
            dd.Add(new { text = "Order Date", value = "OrderDate" });
            dd.Add(new { text = "Freight", value = "Freight" });

            ViewData["columns"] = dd;
            List<object> direction = new List<object>();
            direction.Add(new { text = "Ascending", value = "Ascending" });
            direction.Add(new { text = "Descending", value = "Descending" });

            ViewData["Direction"] = direction;
            return View();
        }
    }
}