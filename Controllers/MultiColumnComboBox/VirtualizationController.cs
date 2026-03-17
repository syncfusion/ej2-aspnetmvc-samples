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
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.MultiColumnComboBox
{
    public partial class MultiColumnComboBoxController : Controller
    {
        public ActionResult Virtualization()
        {
            MultiColumnComboBoxRecord model = new MultiColumnComboBoxRecord();
            model.Records = new MultiColumnComboBoxRecord().GenerateTasks(150);
            return View(model);
        }
    }

    public class MultiColumnComboBoxRecord
    {
        public string Name { get; set; }
        public string Departments { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }

        public List<MultiColumnComboBoxRecord> Records { get; set; }

        public List<MultiColumnComboBoxRecord> GenerateTasks(int count)
        {
            var names = new List<string> { "John Doe", "Jane Smith", "Alice Johnson", "Bob Brown", "Emily Davis" };
            var departments = new List<string> { "HR", "IT", "Finance", "Marketing", "Sales" };
            var roles = new List<string> { "Manager", "Developer", "Analyst", "Consultant", "Executive" };
            var locations = new List<string> { "New York", "San Francisco", "London", "Berlin", "Tokyo" };
            var result = new List<MultiColumnComboBoxRecord>();
            for (var i = 0; i < count; i++)
            {
                result.Add(new MultiColumnComboBoxRecord
                {
                    Name = names[new Random().Next(names.Count)],
                    Departments = departments[new Random().Next(departments.Count)],
                    Role = roles[new Random().Next(roles.Count)],
                    Location = locations[new Random().Next(locations.Count)]
                });
            }
            return result;
        }
    }
}