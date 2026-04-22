#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2;
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
        // GET: Virtualization
        public ActionResult Virtualization()
        {
            ViewData["Data"] = GetAllRecords();
            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-ddb-icons e-zoomin", Text = "Zoom In", TooltipText = "ZoomIn", Type = ItemType.Button });
                items.Add(new ToolbarItem { PrefixIcon = "e-ddb-icons e-zoomout", Text = "Zoom Out", TooltipText = "ZoomOut", Type = ItemType.Button });
                items.Add(new ToolbarItem { PrefixIcon = "e-diagram-icons e-diagram-reset", Text = "Reset", TooltipText = "Reset", Type = ItemType.Button });
            }
            ViewData["tbItems"] = items;
            return View();
        }
        public List<VirtualizationDetails> GetAllRecords()
        {
            List<VirtualizationDetails> data = new List<VirtualizationDetails>();

            int i = 0;
            string name;
            string parentName;
            string[] virtualData = VirtualizationData.GetNames();
            data.Add(new VirtualizationDetails() { Id = virtualData[0], ParentId = "" });
            i++;
            parentName = virtualData[0];
            for (var j = 1; j < 100; j++)
            {
                name = virtualData[i];
                data.Add(new VirtualizationDetails() { Id = name, ParentId = parentName });
                i++;
                for (var k = 0; k < 2; k++)
                {
                    data.Add(new VirtualizationDetails() { Id = virtualData[i], ParentId = name });
                    i++;
                }
            }
            return data;
        }
    }
    public partial class VirtualizationDetails
    {
        public string Id { get; set; }
        public string ParentId { get; set; }

    }
}
