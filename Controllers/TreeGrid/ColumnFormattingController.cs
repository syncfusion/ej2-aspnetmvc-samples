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

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult ColumnFormatting()
        {
            var treeData = TreeDataFormat.GetDataFormat();
            ViewData["datasource"] = treeData;
            var columns = new List<Object>() {
                new { id= "price", name= "Price" },
                new { id= "shippedDate", name= "Shipped Date" }
            };
            ViewData["columns"] = columns;

            var numberFormats = new List<Object>() {
               new { id= "n2", format= "n2" },
               new { id= "n3", format= "n3" },
               new { id= "c2", format= "c2" },
               new { id= "c3", format= "c3" },
               new { id= "p2", format= "p2" },
               new { id= "p3", format= "p3" }
            };
            ViewData["numberFormats"] = numberFormats;

            var dateFormats = new List<Object>() {
               new { id= "M/d/yyyy", format= "Short Date" },
               new { id= "dddd, MMMM dd, yyyy", format= "Long Date" },
               new { id= "MMMM, yyyy", format= "Month/Year" },
               new { id= "MMMM, dd", format= "Month/Day" }
            };
            ViewData["dateFormats"] = dateFormats;

            return View();
        }
    }
}