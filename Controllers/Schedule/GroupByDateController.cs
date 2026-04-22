#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult GroupByDate()
        {
            ViewData["datasource"] = new ScheduleData().GetResourceData();

            List<ResourceDataSourceModel> owners = new List<ResourceDataSourceModel>();
            owners.Add(new ResourceDataSourceModel { text = "Alice", id = 1, color = "#df5286", workDays = new List<int> { 1, 2, 3, 4 } });
            owners.Add(new ResourceDataSourceModel { text = "Smith", id = 2, color = "#7fa900", workDays = new List<int> { 2, 3, 5 } });
            ViewData["Owners"] = owners;

            string[] resources = new string[] { "Owners" };
            ViewData["Resources"] = resources;
            return View();
        }
    }
}