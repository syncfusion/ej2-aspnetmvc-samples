using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Print()
        {
            ViewData["datasource"] = new ScheduleData().GetScheduleData();
            ViewData["printHeightAndWidthData"] = new List<string> { "auto", "100%", "500px" };
            return View();
        }
    }
}