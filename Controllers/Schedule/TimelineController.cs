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
            ViewBag.appointments = scheduleData.Concat(timelineData);
            ViewBag.workDays = new int[] { 0, 1, 2, 3, 4, 5 };
            return View();
        }
    }
}