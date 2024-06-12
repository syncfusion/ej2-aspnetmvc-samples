#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: Gantt
        public ActionResult ResourceAllocation()
        {
            ViewBag.DataSource = this.ResourceData();
            ViewBag.Resources = this.GetResources();
            return View();
        }
        public class GanttResourceSample
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public string TaskType { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
            public int? Duration { get; set; }
            public bool IsManual { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public List<GanttResourceSample> SubTasks { get; set; }
            public int[] ResourceId { get; set; }
            public List<ResourceModel> Resources { get; set; }
            public string Notes { get; set; }
            public int? Work { get; set; }
            public int ParentID { get; set; }
            
        }

        public class ResourceModel
        {
            public int ResourceId { get; set; }
            public Nullable<int> ResourceUnit { get; set; }
        }
        public class GanttResources
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
            public int Unit { get; set; }
        }
        public List<GanttResources> GetResources()
        {
            List<GanttResources> GanttResourcesCollection = new List<GanttResources>();

            GanttResources Record1 = new GanttResources()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer"
            };
            GanttResources Record2 = new GanttResources()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller"
            };
            GanttResources Record3 = new GanttResources()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan"
            };
            GanttResources Record4 = new GanttResources()
            {
                ResourceId = 4,
                ResourceName = "Fuller King"
            };
            GanttResources Record5 = new GanttResources()
            {
                ResourceId = 5,
                ResourceName = "Davolio Fuller"
            };
            GanttResources Record6 = new GanttResources()
            {
                ResourceId = 6,
                ResourceName = "Van Jack"
            };
            GanttResources Record7 = new GanttResources()
            {
                ResourceId = 7,
                ResourceName = "Fuller Buchanan"
            };
            GanttResources Record8 = new GanttResources()
            {
                ResourceId = 8,
                ResourceName = "Jack Davolio"
            };
            GanttResources Record9 = new GanttResources()
            {
                ResourceId = 9,
                ResourceName = "Tamer Vinet"
            };
            GanttResources Record10 = new GanttResources()
            {
                ResourceId = 10,
                ResourceName = "Vinet Fuller"
            };
            GanttResources Record11 = new GanttResources()
            {
                ResourceId = 11,
                ResourceName = "Bergs Anton"
            };
            GanttResources Record12 = new GanttResources()
            {
                ResourceId = 12,
                ResourceName = "Construction Supervisor"
            };
            GanttResourcesCollection.Add(Record1);
            GanttResourcesCollection.Add(Record2);
            GanttResourcesCollection.Add(Record3);
            GanttResourcesCollection.Add(Record4);
            GanttResourcesCollection.Add(Record5);
            GanttResourcesCollection.Add(Record6);
            GanttResourcesCollection.Add(Record7);
            GanttResourcesCollection.Add(Record8);
            GanttResourcesCollection.Add(Record9);
            GanttResourcesCollection.Add(Record10);
            GanttResourcesCollection.Add(Record11);
            GanttResourcesCollection.Add(Record12);
            return GanttResourcesCollection;
        }
        public  List<GanttResourceSample> ResourceData()
        {
            List<GanttResourceSample> GanttResourceSampleCollection = new List<GanttResourceSample>();

            GanttResourceSample Record1 = new GanttResourceSample()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2024, 03, 29),
                EndDate = new DateTime(2024, 04, 21),
                SubTasks = new List<GanttResourceSample>(),
            };
            GanttResourceSample Record1Child1 = new GanttResourceSample()
            {
                TaskId = 2,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2024, 03, 29),
                Duration = 2,
                Progress = 30,
                Work = 16,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70 },
                   new ResourceModel { ResourceId = 6 }
                }
            };
            GanttResourceSample Record1Child2 = new GanttResourceSample()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2024, 03, 29),
                Duration = 4,
                Work = 96,
                Resources = new List<ResourceModel>
                {
                    new ResourceModel { ResourceId = 2 },
                    new ResourceModel{ ResourceId = 3 },
                    new ResourceModel{ ResourceId = 5 }
                }
            };
            GanttResourceSample Record1Child3 = new GanttResourceSample()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2024, 03, 29),
                Duration = 1,
                Progress = 30,
                Work = 16,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 8 },
                new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                }
            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);

            GanttResourceSample Record2 = new GanttResourceSample()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2024, 03, 29),
                EndDate = new DateTime(2024, 04, 21),
                SubTasks = new List<GanttResourceSample>(),
            };
            GanttResourceSample Record2Child1 = new GanttResourceSample()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2024, 03, 29),
                Duration = 3,
                Progress = 30,
                Work = 30,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 4, ResourceUnit = 50 }
                }
            };
            GanttResourceSample Record2Child2 = new GanttResourceSample()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2024, 04, 01),
                Duration = 3,
                Work = 48,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 8 },
                 new ResourceModel{ ResourceId = 4 }
                }
            };
            GanttResourceSample Record2Child3 = new GanttResourceSample()
            {
                TaskId = 8,
                TaskName = "Estimation approval",
                StartDate = new DateTime(2024, 04, 01),
                Duration = 2,
                Work = 60,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 12 },
                 new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                }
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);

            GanttResourceSample Record3 = new GanttResourceSample()
            {
                TaskId = 9,
                TaskName = "Sign contract",
                StartDate = new DateTime(2024, 04, 01),
                Duration = 1,
                Predecessor = "8",
                Progress = 30,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 12 }
            }
            };
            GanttResourceSampleCollection.Add(Record1);
            GanttResourceSampleCollection.Add(Record2);
            GanttResourceSampleCollection.Add(Record3);
            return GanttResourceSampleCollection;
        }
    }
}