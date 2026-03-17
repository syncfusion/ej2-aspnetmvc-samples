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
        public ActionResult Views()
        {
            ViewData["datasource"] = new ScheduleData().GetZooEventData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month }
            };
            ViewData["view"] = viewOption;
            ViewData["ddl"] = GetViewData();
            return View();
        }

        public List<ViewData> GetViewData()
        {
            List<ViewData> view = new List<ViewData>();
            view.Add(new ViewData { Name = "Day", Value = "Day" });
            view.Add(new ViewData { Name = "Week", Value = "Week" });
            view.Add(new ViewData { Name = "Work Week", Value = "WorkWeek" });
            view.Add(new ViewData { Name = "Month", Value = "Month" });
            return view;
        }
    }

    public class ViewData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}