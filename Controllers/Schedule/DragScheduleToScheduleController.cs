#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult DragScheduleToSchedule()
        {
            ViewBag.firstScheduleData = new ScheduleData().GetResourceData();

            ViewBag.secondScheduleData = new ScheduleData().GetTimelineResourceData();

            ViewBag.firstScheduleResourceDataSource = new[]
            {
                new { text = "Steven", id = 1, color = "#7fa900" }
            };

            ViewBag.secondScheduleResourceDataSource = new[]
            {
                new { text = "John", id = 2, color = "#ffb74d" }
            };

            ViewBag.ResourceNames = new string[] { "Employees" };

            return View();
        }
    }
}