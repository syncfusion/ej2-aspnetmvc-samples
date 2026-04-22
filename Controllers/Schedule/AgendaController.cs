#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Agenda()
        {
            ViewData["datasource"] = new ScheduleData().GetFifaEventsData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Agenda, AllowVirtualScrolling=false }
            };
            ViewData["view"] = viewOption;
            ViewData["data"] = GetScrollData();
            return View();
        }

        public List<ScrollData> GetScrollData()
        {
            List<ScrollData> view = new List<ScrollData>();
            view.Add(new ScrollData { Name = "False", Value = "false" });
            view.Add(new ScrollData { Name = "True", Value = "true" });
            return view;
        }
    }

    public class ScrollData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}