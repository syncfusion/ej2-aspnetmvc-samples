using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult HeaderRows()
        {
            ViewBag.datasource = new ScheduleData().GetHeaderRowData();
            return View();
        }
    }
}