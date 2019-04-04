using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult RecurrenceRuleGenerator()
        {
            return View();
        }
    }
}