#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
        public ActionResult Tooltip()
        {
            ViewBag.datasource = new ScheduleData().GetEventsData();
            return View();
        }
    }
}