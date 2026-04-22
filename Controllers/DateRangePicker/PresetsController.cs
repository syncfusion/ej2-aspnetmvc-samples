#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DateRangePickerController : Controller
    {
        // GET: Presets
        public ActionResult Presets()
        {
            int days = (int)DateTime.Now.DayOfWeek;
            DateTime lastMonth = DateTime.Now.AddMonths(-1);
            ViewData["weekStart"] = DateTime.Now.AddDays(-days);
            ViewData["weekEnd"] = ((DateTime)ViewData["weekStart"]).AddDays(6);
            ViewData["monthStart"] = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            ViewData["monthEnd"] = ((DateTime)ViewData["monthStart"]).AddMonths(1).AddDays(-1);
            ViewData["lastMonthStart"] = new DateTime(lastMonth.Year, lastMonth.Month, 1);
            ViewData["lastMonthEnd"] = ((DateTime)ViewData["lastMonthStart"]).AddMonths(1).AddDays(-1);
            ViewData["lastYearStart"] = new DateTime(DateTime.Now.Year - 1, 1, 1);
            ViewData["lastYearEnd"] = new DateTime(DateTime.Now.Year - 1, 12, 31);
            return View();
        }
    }
}