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
        public ActionResult ExternalDragDrop()
        {
            ViewData["treeDataSource"] = new ScheduleData().GetWaitingListData();
            ViewData["datasource"] = new ScheduleData().GetHospitalData();

            List<ResourceDataSourceModel> departments = new List<ResourceDataSourceModel>();
            departments.Add(new ResourceDataSourceModel { text = "GENERAL", id = 1, color = "#bbdc00" });
            departments.Add(new ResourceDataSourceModel { text = "DENTAL", id = 2, color = "#9e5fff" });
            ViewData["Departments"] = departments;

            List<ConsultantDataSourceModel> consultants = new List<ConsultantDataSourceModel>();
            consultants.Add(new ConsultantDataSourceModel { text = "Alice", id = 1, groupId = 1, color = "#bbdc00", designation = "Cardiologist" });
            consultants.Add(new ConsultantDataSourceModel { text = "Nancy", id = 2, groupId = 2, color = "#9e5fff", designation = "Orthodontist" });
            consultants.Add(new ConsultantDataSourceModel { text = "Robert", id = 3, groupId = 1, color = "#bbdc00", designation = "Optometrist" });
            consultants.Add(new ConsultantDataSourceModel { text = "Robson", id = 4, groupId = 2, color = "#9e5fff", designation = "Periodontist" });
            consultants.Add(new ConsultantDataSourceModel { text = "Laura", id = 5, groupId = 1, color = "#bbdc00", designation = "Orthopedic" });
            consultants.Add(new ConsultantDataSourceModel { text = "Margaret", id = 6, groupId = 2, color = "#9e5fff", designation = "Endodontist" });
            ViewData["Consultants"] = consultants;

            ViewData["Resources"] = new string[] { "Departments", "Consultants" };
            return View();
        }
    }
}