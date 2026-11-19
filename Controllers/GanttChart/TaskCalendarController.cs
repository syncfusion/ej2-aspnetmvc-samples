using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: TaskCalendar
        public ActionResult TaskCalendar()
        {
            ViewData["DataSource"] = GanttData.TaskCalendarData();

            var projectCalendar = new {
                workingTime = new object[] {
                    new { from = 8, to = 12 },
                    new { from = 13, to = 17 }
                },
                holidays = new object[] {
                    new { from = "07/06/2026", to = "07/06/2026", label = "Company Foundation Day" }
                },
                exceptions = new object[] {
                    new { from = "07/05/2026", to = "07/05/2026", label = "Extended Work Day" }
                }
            };

            var taskCalendars = new object[] {
                new {
                    calendarId = "Steering-committee",
                    holidays = new object[] {
                        new { from = "07/07/2026", to = "07/07/2026", label = "SC Strategy Day" },
                        new { from = "07/22/2026", to = "07/22/2026", label = "Board Offsite" }
                    },
                    exceptions = new object[] {
                        new { from = "07/05/2026", to = "07/05/2026", label = "Compensatory Working" },
                        new { from = "07/19/2026", to = "07/19/2026", label = "Compensatory Working" }
                    }
                },
                new {
                    calendarId = "Tech-review",
                    holidays = new object[] {
                        new { from = "07/16/2026", to = "07/17/2026", label = "Architecture Review Freeze" }
                    },
                    exceptions = new object[] {
                        new { from = "07/26/2026", to = "07/26/2026", label = "Extra Review Slot" }
                    }
                },
                 new {
                    calendarId = "Compliance-audit",
                    holidays = new object[] {
                        new { from = "07/09/2026", to = "07/10/2026", label = "Compliance Blackout" }
                    },
                    exceptions = new object[] {
                        new { from = "07/25/2026", to = "07/25/2026", label = "Mandatory Audit Working Day" }
                    }
                }
            };

            ViewData["CalendarSettings"] = new {
                projectCalendar,
                taskCalendars
            };

            return View();
        }
    }
}