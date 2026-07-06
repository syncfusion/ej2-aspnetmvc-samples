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
            ViewData["Nodes"] = RadialTreeDetails.GetAllRecords();
            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "diagram-radial-icons e-zoomin", Text="Zoom In",TooltipText="ZoomIn",Type= ItemType.Button});                   
                items.Add(new ToolbarItem { PrefixIcon = "diagram-radial-icons e-zoomout", Text = "Zoom Out", TooltipText = "ZoomOut", Type = ItemType.Button });
                items.Add(new ToolbarItem { PrefixIcon = "e-diagram-icons e-diagram-reset", Text = "Reset", TooltipText = "Reset", Type = ItemType.Button});
            }
            ViewData["tbItems"] = items;
            return View();
        }
    }
}