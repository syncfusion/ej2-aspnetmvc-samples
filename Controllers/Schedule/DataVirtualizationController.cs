using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult DataVirtualization()
        {
            ViewData["resources"] = this.GenerateResourceData(1, 1000);
            string[] resources = new string[] { "Resources" };
            ViewData["Resource"] = resources;
            return View();
        }
    }
}