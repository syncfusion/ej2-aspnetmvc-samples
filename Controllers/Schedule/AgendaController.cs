using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Agenda()
        {
            ViewBag.datasource = new ScheduleData().GetFifaEventsData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Agenda, AllowVirtualScrolling=false }
            };
            ViewBag.view = viewOption;
            ViewBag.data = GetScrollData();
            return View();
        }

        public List<ScrollData> GetScrollData()
        {
            List<ScrollData> view = new List<ScrollData>();
            view.Add(new ScrollData { Name = "False", Value = "false" });
            view.Add(new ScrollData { Name = "True", Value = "true" });
            return view;
        }
    }

    public class ScrollData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}