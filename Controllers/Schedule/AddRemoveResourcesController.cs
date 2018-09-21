using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Schedule;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult AddRemoveResources()
        {
            List<CalendarRes> calendarCollections = new List<CalendarRes>();
            calendarCollections.Add(new CalendarRes { CalendarName = "My Calendar", CalendarId = 1, CalendarColor = "#c43081" });
            ViewBag.Calendars = calendarCollections;

            ScheduleData data = new ScheduleData();
            List<ScheduleData.ResourceEventsData> holidayData = data.GetHolidayData();
            List<ScheduleData.ResourceEventsData> birthdayData = data.GetBirthdayData();
            List<ScheduleData.ResourceEventsData> companyData = data.GetCompanyData();
            List<ScheduleData.ResourceEventsData> personalData = data.GetPersonalData();
            ViewBag.datasource = holidayData.Concat(birthdayData).Concat(companyData).Concat(personalData);

            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineMonth }
            };
            ViewBag.view = viewOption;

            string[] resources = new string[] { "Calendars" };
            ViewBag.Resources = resources;

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