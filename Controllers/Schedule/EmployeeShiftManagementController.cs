#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;
using Syncfusion.EJ2.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using static EJ2MVCSampleBrowser.Models.EmployeeShiftManagement;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        // GET: EmployeeShiftManagement
        public ActionResult EmployeeShiftManagement()
        {
            ViewData["datasource"] = new EmployeeShiftManagement().GetEmployeeShiftManagementData();

            // Employee Roles
            List<RoleData> employeeRoles = new List<RoleData>();
            employeeRoles.Add(new RoleData { text = "Doctors", RoleId = 1 });
            employeeRoles.Add(new RoleData { text = "Nurses", RoleId = 2 });
            employeeRoles.Add(new RoleData { text = "Support Staffs", RoleId = 3 });
            ViewData["EmployeeRoles"] = employeeRoles;

            // Designations
            List<DesignationData> designations = new List<DesignationData>();
            designations.Add(new DesignationData { text = "Attending Physician", DesignationId = 1, groupId = 1 });
            designations.Add(new DesignationData { text = "Hospitalist", DesignationId = 2, groupId = 1 });
            designations.Add(new DesignationData { text = "General Pediatrician", DesignationId = 3, groupId = 1 });
            designations.Add(new DesignationData { text = "Resident Doctor", DesignationId = 4, groupId = 1 });
            designations.Add(new DesignationData { text = "Senior Nurse", DesignationId = 5, groupId = 2 });
            designations.Add(new DesignationData { text = "Nurse Practitioner", DesignationId = 6, groupId = 2 });
            designations.Add(new DesignationData { text = "Medical Assistant", DesignationId = 7, groupId = 3 });
            designations.Add(new DesignationData { text = "Receptionist", DesignationId = 8, groupId = 3 });

            ViewData["Designations"] = designations;
            ViewData["Resources"] = new string[] { "EmployeeRoles", "Designations" };

            var serializer = new JavaScriptSerializer();
            ViewBag.EmployeeRolesJson = serializer.Serialize(employeeRoles);
            ViewBag.DesignationsJson = serializer.Serialize(designations);

            EmployeeImage employeeImage = new EmployeeImage();
            List<EmployeeImage> employeeImages = employeeImage.GetEmployeeImage();

            ViewData["EmployeeImages"] = employeeImages;
            ViewBag.EmployeeImagesJson = serializer.Serialize(employeeImages);

            List<Staff> doctors = new List<Staff>();
            doctors.Add(new Staff { Id = 1, Name = "Mark", Description = "Attending Physician", Role = "Doctors" });
            doctors.Add(new Staff { Id = 2, Name = "Brian", Description = "Hospitalist", Role = "Doctors" });
            doctors.Add(new Staff { Id = 3, Name = "Kevin", Description = "General Pediatrician", Role = "Doctors" });
            doctors.Add(new Staff { Id = 4, Name = "Salman", Description = "Resident Doctor", Role = "Doctors" });
            ViewData["Doctors"] = doctors;

            List<Staff> nurses = new List<Staff>();
            nurses.Add(new Staff { Id = 5, Name = "Olivia", Description = "Senior Nurse", Role = "Nurses" });
            nurses.Add(new Staff { Id = 6, Name = "Zoe", Description = "Nurse Practitioner", Role = "Nurses" });
            ViewData["Nurses"] = nurses;

            List<Staff> supportStaffs = new List<Staff>();
            supportStaffs.Add(new Staff { Id = 7, Name = "Ricky", Description = "Medical Assistant", Role = "Support Staffs" });
            supportStaffs.Add(new Staff { Id = 8, Name = "Jake", Description = "Receptionist", Role = "Support Staffs" });
            ViewData["SupportStaffs"] = supportStaffs;

            // Combine all
            var allStaffs = doctors.Concat(nurses).Concat(supportStaffs).ToList();
            ViewData["All"] = allStaffs;

            ViewBag.AllStaffsJson = serializer.Serialize(allStaffs);
            ViewBag.DoctorsJson = serializer.Serialize(doctors);
            ViewBag.NursesJson = serializer.Serialize(nurses);
            ViewBag.SupportStaffsJson = serializer.Serialize(supportStaffs);

            ViewBag.EmployeeShiftDataJson = serializer.Serialize(new EmployeeShiftManagement().GetEmployeeShiftManagementData());

            List<ToolbarItem> templateItems = new List<ToolbarItem>();
            templateItems.Add(new ToolbarItem { Template = "#chip", Type = ItemType.Input, CssClass = "tooltip-chips", Align = ItemAlign.Left, Overflow = OverflowOption.Show });
            templateItems.Add(new ToolbarItem { Template = "#dropdownlist", Type = ItemType.Input, CssClass = "tooltip-ddl", Align = ItemAlign.Right, Overflow = OverflowOption.Show });

            ViewData["templateItems"] = templateItems;

            return View();
        }

        public class RoleData
        {
            public string text { get; set; }
            public int RoleId { get; set; }
        }

        public class DesignationData
        {
            public string text { get; set; }
            public int DesignationId { get; set; }
            public int groupId { get; set; }
        }

        public class Staff
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Role { get; set; }
        }
    }
}