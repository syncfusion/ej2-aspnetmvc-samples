#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Year()
        {
            List<ResourceDataSourceModel> categories = new List<ResourceDataSourceModel>();
            categories.Add(new ResourceDataSourceModel { text = "Nancy", id = 1, groupId = 1, color = "#df5286" });
            categories.Add(new ResourceDataSourceModel { text = "Steven", id = 2, groupId = 1, color = "#7fa900" });
            categories.Add(new ResourceDataSourceModel { text = "Robert", id = 3, groupId = 2, color = "#ea7a57" });
            categories.Add(new ResourceDataSourceModel { text = "Smith", id = 4, groupId = 2, color = "#5978ee" });
            categories.Add(new ResourceDataSourceModel { text = "Michael", id = 5, groupId = 3, color = "#df5286" });
            categories.Add(new ResourceDataSourceModel { text = "Root", id = 6, groupId = 3, color = "#00bdae" });
            ViewData["Categories"] = categories;

            ViewData["Resources"] = new string[] { "Categories" };

            List<MonthData> months = new List<MonthData>();
            months.Add(new MonthData() { text = "January", value = 0 });
            months.Add(new MonthData() { text = "February", value = 1 });
            months.Add(new MonthData() { text = "March", value = 2 });
            months.Add(new MonthData() { text = "April", value = 3 });
            months.Add(new MonthData() { text = "May", value = 4 });
            months.Add(new MonthData() { text = "June", value = 5 });
            months.Add(new MonthData() { text = "July", value = 6 });
            months.Add(new MonthData() { text = "August", value = 7 });
            months.Add(new MonthData() { text = "September", value = 8 });
            months.Add(new MonthData() { text = "October", value = 9 });
            months.Add(new MonthData() { text = "November", value = 10 });
            months.Add(new MonthData() { text = "December", value = 11 });

            ViewData["Months"] = months;
            return View();
        }
    }

    internal class MonthData
    {
        public string text { get; set; }
        public int value { get; set; }
    }
}