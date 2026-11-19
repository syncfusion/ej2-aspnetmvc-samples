using System;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult EventActionButtons()
        {
            ViewData["datasource"] = new ScheduleData().GetZooEventData();
            return View();
        }
    }
}