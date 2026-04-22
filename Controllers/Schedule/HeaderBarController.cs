#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using Syncfusion.EJ2.Navigations;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult HeaderBar()
        {
            ViewData["datasource"] = new ScheduleData().GetEmployeeEventData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month}
            };
            ViewData["view"] = viewOption;
            List<ScheduleToolbarItem> toolbarItems = new List<ScheduleToolbarItem>()
            {
                new ScheduleToolbarItem { Name = ToolbarName.Previous, Align = ItemAlign.Left },
                new ScheduleToolbarItem { Name = ToolbarName.Next, Align = ItemAlign.Left },
                new ScheduleToolbarItem { Name = ToolbarName.DateRangeText, Align = ItemAlign.Left },
                new ScheduleToolbarItem { Name = ToolbarName.Today, Align = ItemAlign.Right },
                new ScheduleToolbarItem { Align = ItemAlign.Right, PrefixIcon = "user-icon", Text = "Nancy", CssClass = "e-schedule-user-icon", Click = "onIconClick" },
            };
            ViewData["toolbarItems"] = toolbarItems;
            return View();
        }
    }
}