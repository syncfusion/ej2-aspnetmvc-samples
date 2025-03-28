#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult ExcelExport()
        {
            ViewData["datasource"] = new ScheduleData().GetScheduleData();
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week}
            };
            ViewData["view"] = viewOption;
            return View();
        }
    }
}