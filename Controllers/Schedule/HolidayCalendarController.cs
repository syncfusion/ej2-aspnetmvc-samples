#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult HolidayCalendar()
        {
            ScheduleEventsData scheduleEvents = new ScheduleEventsData();
            HolidayList holidayEvents = new HolidayList();

            // Get current year
            int currentYear = DateTime.Now.Year;

            // Get appointment and holiday data
            var appointments = scheduleEvents.GetAppointmentData();
            var holidays = holidayEvents.GetHolidayData(currentYear);

            // Combine the data
            var combinedData = new List<IScheduleEvent>();
            combinedData.AddRange(holidays);
            combinedData.AddRange(appointments);

            // Serialize combined data to JSON
            ViewData["datasource"] = JsonConvert.SerializeObject(combinedData);
            return View();
        }
    }
}