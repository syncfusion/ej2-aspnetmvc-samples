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
using System.Threading.Tasks;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;
using Syncfusion.EJ2.Grids;

namespace EJ2MVCSampleBrowser.Controllers.Tab
{
    public partial class TabController : Controller
    {
        public class DataFields
        {
            public string ID { get; set; }
            public string Text { get; set; }
        }
        public class CitiesFields
        {
            public string Name { get; set; }
            public int Fare { get; set; }
        }

        List<GridColumn> ticketGrid = new List<GridColumn>();
        List<GridColumn> availableTrain = new List<GridColumn>();
        List<DataFields> quotaData = new List<DataFields>();
        List<DataFields> genderData = new List<DataFields>();
        List<DataFields> berthData = new List<DataFields>();
        List<CitiesFields> citiesData = new List<CitiesFields>();
        List<TabItem> headerItems = new List<TabItem>();
        public ActionResult Wizard()
        {
            quotaData.Add(new DataFields { ID = "1", Text = "Business Class" });
            quotaData.Add(new DataFields { ID = "2", Text = "Economy Class" });
            quotaData.Add(new DataFields { ID = "3", Text = "Common Class" });

            genderData.Add(new DataFields { ID = "1", Text = "Male" });
            genderData.Add(new DataFields { ID = "2", Text = "Female" });

            berthData.Add(new DataFields { ID = "1", Text = "Upper" });
            berthData.Add(new DataFields { ID = "2", Text = "Lower" });
            berthData.Add(new DataFields { ID = "3", Text = "Middle" });
            berthData.Add(new DataFields { ID = "4", Text = "Window" });
            berthData.Add(new DataFields { ID = "5", Text = "Aisle" });

            citiesData.Add(new CitiesFields { Name = "Chicago", Fare = 300 });
            citiesData.Add(new CitiesFields { Name = "San Francisco", Fare = 125 });
            citiesData.Add(new CitiesFields { Name = "Los Angeles", Fare = 175 });
            citiesData.Add(new CitiesFields { Name = "Seattle", Fare = 250 });
            citiesData.Add(new CitiesFields { Name = "Florida", Fare = 150 });

            ViewData["headerTextOne"] = new TabHeader { Text = "New Booking" };
            ViewData["headerTextTwo"] = new TabHeader { Text = "Train List" };
            ViewData["headerTextThree"] = new TabHeader { Text = "Add Passenger" };
            ViewData["headerTextFour"] = new TabHeader { Text = "Make Payment" };

            ViewData["quota"] = quotaData;
            ViewData["gender"] = genderData;
            ViewData["berth"] = berthData;
            ViewData["citiesData"] = citiesData;

            ViewData["content1"] = "#booking";
            ViewData["content2"] = "#selectTrain";
            ViewData["content3"] = "#details";
            ViewData["content4"] = "#confirm";

            ViewData["min"] = DateTime.Now;
            ViewData["max"] = DateTime.Now.AddMonths(3);
			ViewData["value"] = DateTime.Now;

            headerItems.Add(new TabItem { Header = (TabHeader)ViewData["headerTextOne"] , Content = (String)ViewData["content1"] });
            headerItems.Add(new TabItem { Header = (TabHeader)ViewData["headerTextTwo"] , Content = (String)ViewData["content2"], Disabled = true });
            headerItems.Add(new TabItem { Header = (TabHeader)ViewData["headerTextThree"] , Content = (String)ViewData["content3"], Disabled = true });
            headerItems.Add(new TabItem { Header = (TabHeader)ViewData["headerTextFour"] , Content = (String)ViewData["content4"], Disabled = true  });
            ViewData["headeritems"] = headerItems;

            ticketGrid.Add(new GridColumn { Field = "TrainNo", HeaderText = "Train No", Width = "120", Type = "number"});
            ticketGrid.Add(new GridColumn { Field = "PassName", HeaderText = "Name", Width = "140"});
            ticketGrid.Add(new GridColumn { Field = "Gender", HeaderText = "Gender", Width = "120"});
            ticketGrid.Add(new GridColumn { Field = "Berth", HeaderText = "Berth", Width = "140"});
            ViewData["ticketgrid"] = ticketGrid;

            availableTrain.Add(new GridColumn { Field = "TrainNo", HeaderText = "Train No", Width = "120", Type = "number" });
            availableTrain.Add(new GridColumn { Field = "Name", HeaderText = "Name", Width = "140" });
            availableTrain.Add(new GridColumn { Field = "Departure", HeaderText = "Departure", Width = "120" });
            availableTrain.Add(new GridColumn { Field = "Arrival", HeaderText = "Arrival", Width = "140" });
            availableTrain.Add(new GridColumn { Field = "Availability", HeaderText = "Availability", Width = "140", Type = "number" });
            ViewData["availabletrain"] = availableTrain;

            return View();
        }
    }
}
