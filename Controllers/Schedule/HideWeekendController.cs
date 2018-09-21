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
        public ActionResult HideWeekend()
        {
            ViewBag.datasource = new ScheduleData().GetEmployeeEventData();
            ViewBag.dropdown = DayList();
            ViewBag.values = new string[] { "1", "3", "4", "5" };
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineMonth }
            };
            ViewBag.view = viewOption;
            return View();
        }

        public List<GetData> DayList()
        {
            List<GetData> dayData = new List<GetData>();
            dayData.Add(new GetData { DayValue = "0", DayText = "Sunday" });
            dayData.Add(new GetData { DayValue = "1", DayText = "Monday" });
            dayData.Add(new GetData { DayValue = "2", DayText = "Tuesday" });
            dayData.Add(new GetData { DayValue = "3", DayText = "Wednesday" });
            dayData.Add(new GetData { DayValue = "4", DayText = "Thursday" });
            dayData.Add(new GetData { DayValue = "5", DayText = "Friday" });
            dayData.Add(new GetData { DayValue = "6", DayText = "Saturday" });

            return dayData;
        }
    }

    public class GetData
    {
        public string DayText { get; set; }
        public string DayValue { get; set; }
    }
}