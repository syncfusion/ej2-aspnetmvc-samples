﻿using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult WorkHours()
        {
            ViewBag.datasource = new ScheduleData().GetEmployeeEventData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineMonth }
            };
            ViewBag.view = viewOption;
            return View();
        }
    }
}