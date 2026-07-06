using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult DragScheduleToSchedule()
        {
            ViewData["firstScheduleData"] = new ScheduleData().GetResourceData();

            ViewData["secondScheduleData"] = new ScheduleData().GetTimelineResourceData();

            ViewData["firstScheduleResourceDataSource"] = new[]
            {
                new { text = "Steven", id = 1, color = "#7fa900" }
            };

            ViewData["secondScheduleResourceDataSource"] = new[]
            {
                new { text = "John", id = 2, color = "#ffb74d" }
            };

            ViewData["ResourceNames"] = new string[] { "Employees" };

            return View();
        }
    }
}