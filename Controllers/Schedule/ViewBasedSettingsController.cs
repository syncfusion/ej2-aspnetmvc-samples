using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult ViewBasedSettings()
        {
            // Datasource for events
            ViewBag.datasource = new ScheduleData().GetFifaEventsData();

            //Datasource for Resources
            List<ResourceFields> Resources = new List<ResourceFields>();
            Resources.Add(new ResourceFields { GroupText = "Group A", GroupId = 1, GroupColor = "#1aaa55" });
            Resources.Add(new ResourceFields { GroupText = "Group B", GroupId = 2, GroupColor = "#357cd2" });
            ViewBag.resourceData = Resources;

            return View();
        }
    }

    public class ResourceFields
    {
        public string GroupText { set; get; }
        public int GroupId { set; get; }
        public string GroupColor { set; get; }
    }
}