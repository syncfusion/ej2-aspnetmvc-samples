using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult FareCalendar()
        {
            List<AirelineData> airlines = new List<AirelineData>();
            airlines.Add(new AirelineData { Text = "Airways 1", Id = 1 });
            airlines.Add(new AirelineData { Text = "Airways 2", Id = 2 });
            airlines.Add(new AirelineData { Text = "Airways 3", Id = 3 });
            ViewBag.airlines = airlines;
            return View();
        }
    }

    internal class AirelineData
    {
        public string Text { set; get; }
        public int Id { set; get; }
    }
}