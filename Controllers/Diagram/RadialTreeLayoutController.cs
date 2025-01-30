#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: RadialTreeLayout
        public ActionResult RadialTreeLayout()
        {
            ViewBag.Nodes = RadialTreeDetails.GetAllRecords();
            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-ddb-icons e-zoomin",Text="Zoom In",TooltipText="ZoomIn",Type= ItemType.Button});                   
                items.Add(new ToolbarItem { PrefixIcon = "e-ddb-icons e-zoomout", Text = "Zoom Out", TooltipText = "ZoomOut", Type = ItemType.Button });
                items.Add(new ToolbarItem { PrefixIcon = "e-diagram-icons e-diagram-reset", Text = "Reset", TooltipText = "Reset", Type = ItemType.Button});
            }
            ViewBag.tbItems = items;
            return View();
        }
    }
}