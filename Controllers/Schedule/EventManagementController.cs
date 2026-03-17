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
using System.Web.Script.Serialization;
using static EJ2MVCSampleBrowser.Models.EventManagement;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult EventManagement()
        {
            ViewData["datasource"] = new EventManagement().GetEventData();
            var cloudData = new EventManagement().GetCloudSecurityEventData();
            ViewData["CloudData"] = cloudData;
            var serializer = new JavaScriptSerializer();
            ViewBag.CloudDataJson = serializer.Serialize(cloudData);
            var aiData = new EventManagement().GetAIAutomationEventData();
            ViewData["AIData"] = aiData;
            ViewBag.AIDataJson = serializer.Serialize(aiData);
            var allData = cloudData.Concat(aiData).ToList();
            ViewData["AllData"] = allData;

            List<Rooms> rooms = new List<Rooms>();
            rooms.Add(new Rooms { RoomId = 1, RoomName = "Room A", RoomCapacity = 100, RoomColor = "#0F6CBD" });
            rooms.Add(new Rooms { RoomId = 2, RoomName = "Room B", RoomCapacity = 200, RoomColor = "#B71C1C" });
            rooms.Add(new Rooms { RoomId = 3, RoomName = "Room C", RoomCapacity = 300, RoomColor = "#E65100" });
            rooms.Add(new Rooms { RoomId = 4, RoomName = "Room D", RoomCapacity = 400, RoomColor = "#558B2F" });
            ViewData["Rooms"] = rooms;
            ViewData["Resources"] = new string[] { "Rooms" };
            ViewBag.RoomsJson = serializer.Serialize(rooms);

            List<RoomsData> roomData = new List<RoomsData>();
            roomData.Add(new RoomsData { RoomId = 0, RoomName = "All" });
            roomData.Add(new RoomsData { RoomId = 1, RoomName = "Room A" });
            roomData.Add(new RoomsData { RoomId = 2, RoomName = "Room B" });
            roomData.Add(new RoomsData { RoomId = 3, RoomName = "Room C" });
            roomData.Add(new RoomsData { RoomId = 4, RoomName = "Room D" });
            ViewData["RoomsData"] = roomData;

            List<object> printExportItems = new List<object>();
            printExportItems.Add(new { text = "Print", id = "print" });
            printExportItems.Add(new { text = "Export", id = "export" });
            ViewData["PrintExportItems"] = printExportItems;

            List<DropDownItem> unPlannedEventsList = new List<DropDownItem>();
            unPlannedEventsList.Add(new DropDownItem { Id = "0", Name = "All" });
            unPlannedEventsList.Add(new DropDownItem { Id = "1", Name = "Cloud Security Essentials" });
            unPlannedEventsList.Add(new DropDownItem { Id = "2", Name = "AI for Automation" });
            ViewData["UnPlannedEventsList"] = unPlannedEventsList;

            return View();
        }

        public class Rooms
        {
            public int RoomId { get; set; }
            public string RoomName { get; set; }
            public int RoomCapacity { get; set; }
            public string RoomColor { get; set; }
        }
        public class RoomsData
        {
            public int RoomId { get; set; }
            public string RoomName { get; set; }

        }
        public class PrintExportItem
        {
            public string Text { get; set; }
            public string Id { get; set; }
        }

        public class DropDownItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

    }
}

