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
        public ActionResult Selection()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewData["datasource"] = treeData;            
            ViewData["typedata"] = new List<object>() {
               new { id= "Single", type= "Single" },
               new { id= "Multiple", type= "Multiple" }
            };
            ViewData["modedata"] = new List<object>() {
               new { id= "Row", mode= "Row" },
               new { id= "Cell", mode= "Cell" }
            };
            ViewData["cellmodedata"] = new List<object>() {
               new { id= "Flow", cellmode= "Flow" },
               new { id= "Box", cellmode= "Box" }
            };

            return View();
        }
    }
}