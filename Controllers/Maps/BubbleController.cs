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
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Bubble
        public ActionResult Bubble()
        {
            ViewData["shapeData"] = this.GetWorldMap();
            MapsBubble bubble = new MapsBubble();
            bubble.Visible = true;
            bubble.ValuePath = "value";
            bubble.ColorValuePath = "color";
            bubble.MinRadius = 3;
            bubble.MaxRadius = 70;
            bubble.Opacity = 0.8;
            bubble.TooltipSettings = new MapsTooltipSettings{ Visible = true, ValuePath = "population", Template = "#template" };
            List<MapsBubble> bubbleSettings = new List<MapsBubble>();
            bubbleSettings.Add(bubble);
            ViewData["bubbleSettings"] = bubbleSettings;
            return View();
        }
    }
}