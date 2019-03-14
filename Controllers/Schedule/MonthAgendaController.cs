using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult MonthAgenda()
        {
            ViewBag.datasource = new ScheduleData().GetFifaEventsData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.MonthAgenda }
            };
            ViewBag.view = viewOption;
            return View();
        }
    }
}