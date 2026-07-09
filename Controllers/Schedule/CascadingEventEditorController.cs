using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult CascadingEventEditor()
        {
            // ✅ EVENTS DATA
            List<object> eventsData = new List<object>()
            {
                new {
                    Id = 1,
                    Subject = "Meeting",
                    Type = "Meeting",
                    StartTime = new DateTime(2026, 5, 11, 9, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 12, 0, 0),
                    StaffId = 1,
                    FloorId = 1,
                    RoomId = 101
                },
                new {
                    Id = 2,
                    Subject = "Appointment",
                    Type = "Appointment",
                    StartTime = new DateTime(2026, 5, 11, 13, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 14, 0, 0),
                    StaffId = 2
                },
                new {
                    Id = 3,
                    Subject = "Internal Review",
                    Type = "Internal",
                    StartTime = new DateTime(2026, 5, 11, 10, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 11, 0, 0),
                    StaffId = 3
                },
                new {
                    Id = 4,
                    Subject = "Planning",
                    Type = "Meeting",
                    StartTime = new DateTime(2026, 5, 11, 15, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 17, 0, 0),
                    StaffId = 4,
                    FloorId = 1,
                    RoomId = 101
                },
                new {
                    Id = 5,
                    Subject = "Discussion",
                    Type = "Meeting",
                    StartTime = new DateTime(2026, 5, 11, 11, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 12, 30, 0),
                    StaffId = 5,
                    FloorId = 2,
                    RoomId = 201
                },
                new {
                    Id = 6,
                    Subject = "Morning Sync",
                    Type = "Meeting",
                    StartTime = new DateTime(2026, 5, 11, 8, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 9, 0, 0),
                    StaffId = 1,
                    FloorId = 1,
                    RoomId = 101
                },
                new {
                    Id = 7,
                    Subject = "Follow-up Call",
                    Type = "Appointment",
                    StartTime = new DateTime(2026, 5, 11, 12, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 13, 0, 0),
                    StaffId = 1
                },
                new {
                    Id = 8,
                    Subject = "Client Discussion",
                    Type = "Appointment",
                    StartTime = new DateTime(2026, 5, 11, 10, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 11, 0, 0),
                    StaffId = 2
                },
                new {
                    Id = 9,
                    Subject = "Demo Presentation",
                    Type = "Meeting",
                    StartTime = new DateTime(2026, 5, 11, 14, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 15, 0, 0),
                    StaffId = 2,
                    FloorId = 1,
                    RoomId = 102
                },
                new {
                    Id = 10,
                    Subject = "Code Refactoring",
                    Type = "Internal",
                    StartTime = new DateTime(2026, 5, 11, 8, 30, 0),
                    EndTime = new DateTime(2026, 5, 11, 9, 30, 0),
                    StaffId = 3
                },
                new {
                    Id = 11,
                    Subject = "System Testing",
                    Type = "Internal",
                    StartTime = new DateTime(2026, 5, 11, 11, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 12, 0, 0),
                    StaffId = 3
                },
                new {
                    Id = 12,
                    Subject = "Project Review",
                    Type = "Meeting",
                    StartTime = new DateTime(2026, 5, 11, 13, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 14, 0, 0),
                    StaffId = 4,
                    FloorId = 1,
                    RoomId = 101
                },
                new {
                    Id = 13,
                    Subject = "Wrap-up Meeting",
                    Type = "Meeting",
                    StartTime = new DateTime(2026, 5, 11, 17, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 18, 0, 0),
                    StaffId = 4,
                    FloorId = 1,
                    RoomId = 101
                },
                new {
                    Id = 14,
                    Subject = "Bug Fixing",
                    Type = "Internal",
                    StartTime = new DateTime(2026, 5, 11, 9, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 10, 30, 0),
                    StaffId = 5
                },
                new {
                    Id = 15,
                    Subject = "QA Review",
                    Type = "Internal",
                    StartTime = new DateTime(2026, 5, 11, 13, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 14, 0, 0),
                    StaffId = 5
                }
            };

            // ✅ STAFF DATA
            List<object> staffData = new List<object>()
            {
                new { id = 1, text = "Mike Anderson", color = "#1aaa55", type = "Consultants", initial = "M" },
                new { id = 2, text = "Kevin Larson", color = "#357cd2", type = "Sales", initial = "K" },
                new { id = 3, text = "Sarah Johnson", color = "#f57f17", type = "Sales", initial = "S" },
                new { id = 4, text = "David Miller", color = "#7fa900", type = "Testers", initial = "D" },
                new { id = 5, text = "Emma Wilson", color = "#df5286", type = "Testers", initial = "E" }
            };

            // ✅ RESOURCE NAME
            string[] resources = new string[] { "Staff" };

            // ✅ PASS DATA TO VIEW
            ViewData["datasource"] = eventsData;
            ViewData["staffData"] = staffData;
            ViewData["ResourceNames"] = resources;

            return View();
        }
    }
}