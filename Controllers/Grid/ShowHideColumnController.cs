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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: ShowHideColumn
        public ActionResult ShowHideColumn()
        {
            var product = Categories.GetAllRecords().ToList();
            ViewData["datasource"] = product;
            List<object> dd = new List<object>();
            dd.Add(new { text = "Category Name", value = "CategoryName" });
            dd.Add(new { text = "Product Name", value = "ProductName" });
            dd.Add(new { text = "Units In Stock", value = "UnitsInStock" });
            dd.Add(new { text = "Discontinued", value = "Discontinued" });
            ViewData["columns"] = dd;
            return View();
        }
    }
}