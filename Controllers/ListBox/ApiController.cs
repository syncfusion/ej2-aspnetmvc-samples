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

namespace EJ2MVCSampleBrowser.Controllers.ListBox
{
    public partial class ListBoxController : Controller
    {
        public ActionResult Api()
        {

            ViewData["vegetableData"] = new Vegetables().VegetablesList();

            List<object> sortOrder = new List<object>();
            sortOrder.Add(new { Text = "None"});
            sortOrder.Add(new { Text = "Ascending"});
            sortOrder.Add(new { Text = "Descending" });
            ViewData["sortOrder"] = sortOrder;

            List<object> selectionType = new List<object>();
            selectionType.Add(new { Text = "Single" });
            selectionType.Add(new { Text = "Multiple" });
            ViewData["selectionType"] = selectionType;
            return View();
        }
    }

}