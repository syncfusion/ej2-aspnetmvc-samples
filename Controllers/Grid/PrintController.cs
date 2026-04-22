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
        // GET: Print
        public ActionResult Print()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewData["Datasource"] = order;
            ViewData["EmpDataSource"] = EmployeeView.GetAllRecords();
            ViewData["CustomerDataSource"] = Customer.GetAllRecords();
            ViewData["data"] = new List<string>() { "Expanded", "All", "None" };

            return View();
        }
    }
}