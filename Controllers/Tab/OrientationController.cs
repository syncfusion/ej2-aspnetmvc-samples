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
using Syncfusion.EJ2.Lists;

namespace EJ2MVCSampleBrowser.Controllers.Tab
{
    public partial class TabController : Controller
    {
        List<TabItem> orientationItems = new List<TabItem>();
        public ActionResult Orientation()
        {
            List<object> rome = new List<object>();
            rome.Add(new { Id = "1", Name = "Anne Dodsworth", Role = "Product Manager", imgSrc = Url.Content("~/Content/tab/1.png") });
            rome.Add(new { Id = "2", Name = "Laura Callahan", Role = "Team Lead", imgSrc = Url.Content("~/Content/tab/2.png") });
            rome.Add(new { Id = "3", Name = "Andrew Fuller", Role = "Developer", imgSrc = Url.Content("~/Content/tab/3.png") });
            ViewData["romeData"] = rome;

            List<object> paris = new List<object>();
            paris.Add(new { Id = "4", Name = "Robert King", Role = "Team Lead", imgSrc = Url.Content("~/Content/tab/4.png") });
            paris.Add(new { Id = "5", Name = "Michael Suyama", Role = "Developer", imgSrc = Url.Content("~/Content/tab/5.png") });
            paris.Add(new { Id = "6", Name = "Margaret Peacock", Role = "Developer", imgSrc = Url.Content("~/Content/tab/6.png") });
            ViewData["parisData"] = paris;

            List<object> london = new List<object>();
            london.Add(new { Id = "7", Name = "Janet Leverling", Role = "CEO", imgSrc = Url.Content("~/Content/tab/7.png") });
            london.Add(new { Id = "8", Name = "Steven Buchanan", Role = "HR", imgSrc = Url.Content("~/Content/tab/8.png") });
            london.Add(new { Id = "9", Name = "Nancy Davolio", Role = "Product Manager", imgSrc = Url.Content("~/Content/tab/9.png") });
            ViewData["londonData"] = london;

            orientationItems.Add(new TabItem { Header = new TabHeader { Text = "Rome" }, Content = "#rome" });
            orientationItems.Add(new TabItem { Header = new TabHeader { Text = "Paris" }, Content = "#paris" });
            orientationItems.Add(new TabItem { Header = new TabHeader { Text = "London" }, Content = "#london" });
            ViewData["orientationItems"] = orientationItems;

            ViewData["styleData"] = new string[] { "Default", "Fill", "Accent" };
            ViewData["orientationData"] = new string[] { "Top", "Bottom", "Left", "Right" };

            return View();
        }
    }

}