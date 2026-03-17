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
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Accordion
{
    public partial class AccordionController : Controller
    {
        List<AccordionItem> rtlItems = new List<AccordionItem>();
        public ActionResult Rtl()
        {
            rtlItems.Add(new AccordionItem { Header = "Athletics", Expanded = true, Content = "#athletics", IconCss = "e-athletics e-acrdn-icons" });
            rtlItems.Add(new AccordionItem { Header = "Water Games", Content = "#water_games", IconCss = "e-water-game e-acrdn-icons" });
            rtlItems.Add(new AccordionItem { Header = "Racing", Content = "#racing_games", IconCss = "e-racing-games e-acrdn-icons" });
            rtlItems.Add(new AccordionItem { Header = "Indoor Games", Content = "#indoor_games", IconCss = "e-indoor-games e-acrdn-icons" });
            ViewData["rtlItems"] = rtlItems;
            return View();
        }
    }

}