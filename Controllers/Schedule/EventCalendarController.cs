#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using EJ2MVCSampleBrowser.Models;
namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult EventCalendar()
        {
            ViewBag.Resources = new string[] { "Owner" };
            var CalendarCollections= new List<CalendarData>
            {
                new CalendarData { Name = "My Calendar", Id = 1, IsChecked = true, Color = "#c43081" },
                new CalendarData { Name = "Company", Id = 2, IsChecked = true, Color = "#ff7f50" },
                new CalendarData { Name = "Birthday", Id = 3, IsChecked = true, Color = "#AF27CD" },
                new CalendarData { Name = "Holiday", Id = 4, IsChecked = true, Color = "#808000" }
            };
            ViewData["CalendarCollections"] = CalendarCollections;
            var ownerData = new List<ResourceData>
            {
                new ResourceData { Text = "Nancy", Id = 1, Color = "#df5286" },
                new ResourceData { Text = "Steven", Id = 2, Color = "#7fa900" },
                new ResourceData { Text = "Robert", Id = 3, Color = "#ea7a57" },
                new ResourceData { Text = "Smith", Id = 4, Color = "#5978ee" },
                new ResourceData { Text = "Micheal", Id = 5, Color = "#df5286" },
                new ResourceData { Text = "Root", Id = 6, Color = "#00bdae" }
            };
            ViewBag.OwnerData = ownerData;
            var holidayData = new ScheduleData().GetHolidayData();
            var birthdayData = new ScheduleData().GetBirthdayData();
            var companyData = new ScheduleData().GetCompanyData();
            var personalData = new ScheduleData().GetPersonalData();
            var nonAlldayData = GetNonAllDayData();
            List<ScheduleData.ResourceEventsData> allEvents = holidayData.Concat(birthdayData).Concat(companyData).Concat(personalData).Concat(nonAlldayData).ToList();
            Random random = new Random();
            foreach (var item in allEvents)
            {
                item.OwnerId = random.Next(1, 6);
            }
            var selectedCalendars = CalendarCollections.Where(c => c.IsChecked).Select(c => c.Id).ToArray();
            List<ScheduleData.ResourceEventsData> plannedEvents = allEvents.Where(e=>e.IsPlanned && selectedCalendars.Contains(e.CalendarId)).ToList();
            List<ScheduleData.ResourceEventsData> unPlannedEvents= allEvents.Where(e=>!e.IsPlanned && selectedCalendars.Contains(e.CalendarId)).ToList();
            ViewBag.PlannedEvents = plannedEvents;
            ViewBag.UnPlannedEvents = unPlannedEvents;
            ViewBag.SelectedCalendars = selectedCalendars;
            return View();
        }

        private List<ScheduleData.ResourceEventsData> GetNonAllDayData()
        {
            List<ScheduleData.ResourceEventsData> nonAllDayData = new List<ScheduleData.ResourceEventsData>();
            DateTime currentDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            Random random = new Random();
            string[] subjects = new string[] {
            "Team Meeting", "Client Call", "Product Launch", "Training Session",
            "Strategy Planning", "Marketing Meeting", "Team Building",
            "Quarterly Review", "Budget Planning", "Project Kickoff"
            };
            for (int i = 0; i < 20; i++)
            {
                int hour = random.Next(9, 15);
                int minute = random.Next(0, 60);
                DateTime startTime = currentDate.AddDays(i).AddHours(hour).AddMinutes(minute);
                DateTime endTime = startTime.AddHours(1);
                nonAllDayData.Add(new ScheduleData.ResourceEventsData
                {
                    Id = 406 + i,
                    Subject = subjects[random.Next(subjects.Length)],
                    StartTime = startTime,
                    EndTime = endTime,
                    IsAllDay = false,
                    CalendarId = random.Next(1, 5),
                    IsPlanned = true,
                    OwnerId = random.Next(1, 6)
                });
            }
            return nonAllDayData;
        }
    }

    public class CalendarData
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public string Color { get; set; }
    }
}