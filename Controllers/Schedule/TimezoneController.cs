using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Timezone()
        {
            ViewBag.datasource = new ScheduleData().GetFifaEventsData();
            ViewBag.data = TimezoneData();
            return View();
        }

        public List<TimezoneData> TimezoneData()
        {
            List<TimezoneData> timeZone = new List<TimezoneData>();
            timeZone.Add(new TimezoneData { Name = "(UTC-05:00) Eastern Time", Value = "America/New_York" });
            timeZone.Add(new TimezoneData { Name = "UTC", Value = "Coordinated Universal Time" });
            timeZone.Add(new TimezoneData { Name = "(UTC+03:00) Moscow+00 - Moscow", Value = "Europe/Moscow" });
            timeZone.Add(new TimezoneData { Name = "(UTC+05:30) India Standard Time", Value = "Asia/Kolkata" });
            timeZone.Add(new TimezoneData { Name = "(UTC+08:00) Western Time - Perth", Value = "Australia/Perth" });
            return timeZone;
        }
    }

    public class TimezoneData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}