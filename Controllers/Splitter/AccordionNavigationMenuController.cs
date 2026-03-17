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
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SplitterController : Controller
    {
        List<AccordionItem> accItems = new List<AccordionItem>();
        // GET: AccordionNavigation
        public ActionResult AccordionNavigationMenu()
        {
            accItems.Add(new AccordionItem { Header = "ASP.NET", Expanded = true, Content = "<div id='nested_Acc1'></div>" });
            accItems.Add(new AccordionItem { Header = "ASP.NET MVC", Content = "<div id='nested_Acc2'></div>" });
            accItems.Add(new AccordionItem { Header = "JavaScript", Content = "<div id='nested_Acc3'></div>" });
            ViewData["AccordionItems"] = accItems;
            return View();
        }
    }
}