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
using System.Linq;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult AddRemoveResources()
        {
            List<CalendarRes> calendarCollections = new List<CalendarRes>();
            calendarCollections.Add(new CalendarRes { CalendarName = "My Calendar", CalendarId = 1, CalendarColor = "#c43081" });
            ViewData["Calendars"] = calendarCollections;

            ScheduleData data = new ScheduleData();
            List<ScheduleData.ResourceEventsData> holidayData = data.GetHolidayData();
            List<ScheduleData.ResourceEventsData> birthdayData = data.GetBirthdayData();
            List<ScheduleData.ResourceEventsData> companyData = data.GetCompanyData();
            List<ScheduleData.ResourceEventsData> personalData = data.GetPersonalData();
            ViewData["datasource"] = holidayData.Concat(birthdayData).Concat(companyData).Concat(personalData);

            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineMonth }
            };
            ViewData["view"] = viewOption;

            string[] resources = new string[] { "Calendars" };
            ViewData["Resources"] = resources;

            return View();
        }

        public class CalendarRes
        {
            public string CalendarName { set; get; }
            public int CalendarId { set; get; }
            public string CalendarColor { set; get; }
        }
    }
}