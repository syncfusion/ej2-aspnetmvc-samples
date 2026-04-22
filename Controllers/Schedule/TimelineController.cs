#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Timeline()
        {
            ScheduleData data = new ScheduleData();
            List<ScheduleData.AppointmentData> scheduleData = data.GetScheduleData();
            List<ScheduleData.AppointmentData> timelineData = data.GetTimelineData();
            ViewData["appointments"] = scheduleData.Concat(timelineData);
            ViewData["workDays"] = new int[] { 0, 1, 2, 3, 4, 5 };
            return View();
        }
    }
}