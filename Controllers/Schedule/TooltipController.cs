using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Tooltip()
        {
            ViewBag.datasource = new ScheduleData().GetEventsData();
            return View();
        }
    }
}