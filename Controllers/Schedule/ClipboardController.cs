using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Clipboard()
        {
            ViewData["datasource"] = new ScheduleData().GetScheduleData();

            List<object> menuItems = new List<object>();
            menuItems.Add(new { text = "Cut Event", iconCss = "e-icons e-cut", id = "Cut" });
            menuItems.Add(new { text = "Copy Event", iconCss = "e-icons e-copy", id = "Copy" });
            menuItems.Add(new { text = "Paste", iconCss = "e-icons e-paste", id = "Paste" });

            ViewData["menuItems"] = menuItems;
            return View();
        }
    }
}
