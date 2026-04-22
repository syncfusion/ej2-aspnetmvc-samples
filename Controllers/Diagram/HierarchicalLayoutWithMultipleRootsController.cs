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
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: HierarchicalLayoutWithMultipleRoots
        public ActionResult HierarchicalLayoutWithMultipleRoots()
        {
            ViewData["Nodes"] = HierarchicalMultipleRoots.GetAllRecords();
            ViewData["getConnectorDefaults"] = "ConnectorDefaults";
            ViewData["getNodeDefaults"] = "nodeDefaults";
            return View();
        }

    }
    public class HierarchicalMultipleRoots
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string ParentId { get; set; }

        public HierarchicalMultipleRoots(string id, string label, string parentId)
        {
            this.Id = id;
            this.Label = label;
            this.ParentId = parentId;
        }

        public static List<HierarchicalMultipleRoots> GetAllRecords()
        {
            List<HierarchicalMultipleRoots> hierarchicaldetails = new List<HierarchicalMultipleRoots>();

            hierarchicaldetails.Add(new HierarchicalMultipleRoots("1", "Production Manager", ""));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("2", "Control Room", "1"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("3", "Plant Operator", "1"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("4", "Foreman", "2"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("5", "Foreman", "3"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("6", "Craft Personnel", "4"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("7", "Craft Personnel", "4"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("8", "Craft Personnel", "5"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("9", "Craft Personnel", "5"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("10", "Administrative Officer", ""));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("11", "Security Supervisor", "10"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("12", "HR Supervisor", "10"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("13", "Reception Supervisor", "10"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("14", "Securities", "11"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("15", "HR Officer", "12"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("16", "Receptionist", "13"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("17", "Maintainence Manager", ""));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("18", "Electrical Supervisor", "17"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("19", "Mechanical Supervisor", "17"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("20", "Craft Personnel", "18"));
            hierarchicaldetails.Add(new HierarchicalMultipleRoots("21", "Craft Personnel", "19"));

            return hierarchicaldetails;
        }
    }
}