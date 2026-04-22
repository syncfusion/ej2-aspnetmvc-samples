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
        public ActionResult GroupCustomWorkdays()
        {
            ViewData["datasource"] = new ScheduleData().GetDoctorData();
            List<DoctorRes> doctors = new List<DoctorRes>();
            doctors.Add(new DoctorRes { text = "Will Smith", id = 1, color = "#ea7a57", workDays = new List<int> { 1, 2, 4, 5 }, startHour = "08:00", endHour = "15:00" });
            doctors.Add(new DoctorRes { text = "Alice", id = 2, color = "rgb(53, 124, 210)", workDays = new List<int> { 1, 3, 5 }, startHour = "08:00", endHour = "17:00" });
            doctors.Add(new DoctorRes { text = "Robson", id = 3, color = "#7fa900", startHour = "08:00", endHour = "16:00" });
            ViewData["Doctors"] = doctors;

            string[] resources = new string[] { "Doctors" };
            ViewData["Resources"] = resources;
            return View();
        }
    }

    public class DoctorRes
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
        public List<int> workDays { set; get; }
        public string startHour { set; get; }
        public string endHour { set; get; }
    }
}