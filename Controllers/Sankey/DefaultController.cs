#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Sankey
{
    public partial class SankeyController : Controller
    {
        // GET: Sankey (Default)
        public ActionResult Default()
        {
            List<SankeyNode> nodes = new List<SankeyNode>
            {
                new SankeyNode { Id = "Electricity Generation", Offset = -120 },
                new SankeyNode { Id = "Residential", Offset = 38 },
                new SankeyNode { Id = "Commercial", Offset = 36 },
                new SankeyNode { Id = "Industrial", Offset = 34 },
                new SankeyNode { Id = "Transportation", Offset = 32 },
                new SankeyNode { Id = "Rejected Energy", Offset = -40 },
                new SankeyNode { Id = "Energy Services", Offset = 0 },
                new SankeyNode { Id = "Solar", Offset = 0 },
                new SankeyNode { Id = "Nuclear", Offset = 0 },
                new SankeyNode { Id = "Wind", Offset = 0 },
                new SankeyNode { Id = "Geothermal", Offset = 0 },
                new SankeyNode { Id = "Natural Gas", Offset = 0 },
                new SankeyNode { Id = "Coal", Offset = 0 },
                new SankeyNode { Id = "Biomass", Offset = 0 },
                new SankeyNode { Id = "Petroleum", Offset = -10 }
            };

            List<SankeyLink> links = new List<SankeyLink>
            {
                // Generation inputs
                new SankeyLink { SourceId = "Solar", TargetId = "Electricity Generation", Value = 454.0 },
                new SankeyLink { SourceId = "Nuclear", TargetId = "Electricity Generation", Value = 185.0 },
                new SankeyLink { SourceId = "Wind", TargetId = "Electricity Generation", Value = 47.8 },
                new SankeyLink { SourceId = "Geothermal", TargetId = "Electricity Generation", Value = 40.0 },
                new SankeyLink { SourceId = "Natural Gas", TargetId = "Electricity Generation", Value = 800.0 },
                new SankeyLink { SourceId = "Coal", TargetId = "Electricity Generation", Value = 28.7 },
                new SankeyLink { SourceId = "Biomass", TargetId = "Electricity Generation", Value = 50.0 },
                
                // To Residential
                new SankeyLink { SourceId = "Electricity Generation", TargetId = "Residential", Value = 182.0 },
                new SankeyLink { SourceId = "Natural Gas", TargetId = "Residential", Value = 400.0 },
                new SankeyLink { SourceId = "Petroleum", TargetId = "Residential", Value = 50.0 },
                
                // To Commercial
                new SankeyLink { SourceId = "Electricity Generation", TargetId = "Commercial", Value = 351.0 },
                new SankeyLink { SourceId = "Natural Gas", TargetId = "Commercial", Value = 300.0 },
                
                // To Industrial
                new SankeyLink { SourceId = "Electricity Generation", TargetId = "Industrial", Value = 641.0 },
                new SankeyLink { SourceId = "Natural Gas", TargetId = "Industrial", Value = 786.0 },
                new SankeyLink { SourceId = "Biomass", TargetId = "Industrial", Value = 563.0 },
                new SankeyLink { SourceId = "Petroleum", TargetId = "Industrial", Value = 300.0 },
                
                // To Transportation
                new SankeyLink { SourceId = "Electricity Generation", TargetId = "Transportation", Value = 20.0 },
                new SankeyLink { SourceId = "Natural Gas", TargetId = "Transportation", Value = 51.0 },
                new SankeyLink { SourceId = "Biomass", TargetId = "Transportation", Value = 71.0 },
                new SankeyLink { SourceId = "Petroleum", TargetId = "Transportation", Value = 2486.0 },
                
                // Sectors → Rejected Energy
                new SankeyLink { SourceId = "Residential", TargetId = "Rejected Energy", Value = 432.0 },
                new SankeyLink { SourceId = "Commercial", TargetId = "Rejected Energy", Value = 351.0 },
                new SankeyLink { SourceId = "Industrial", TargetId = "Rejected Energy", Value = 972.0 },
                new SankeyLink { SourceId = "Transportation", TargetId = "Rejected Energy", Value = 1920.0 },
                
                // Sectors → Energy Services
                new SankeyLink { SourceId = "Residential", TargetId = "Energy Services", Value = 200.0 },
                new SankeyLink { SourceId = "Commercial", TargetId = "Energy Services", Value = 300.0 },
                new SankeyLink { SourceId = "Industrial", TargetId = "Energy Services", Value = 755.0 },
                new SankeyLink { SourceId = "Transportation", TargetId = "Energy Services", Value = 637.0 }
            };

            ViewData["SankeyNodes"] = nodes;
            ViewData["SankeyLinks"] = links;
            return View();
        }
    }
}
