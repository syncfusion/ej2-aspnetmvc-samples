#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        List<TabTabItem> headerItems = new List<TabTabItem>();
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

            ViewBag.headerTextOne = new TabHeader { Text = "New Booking" };
            ViewBag.headerTextTwo = new TabHeader { Text = "Train List" };
            ViewBag.headerTextThree = new TabHeader { Text = "Add Passenger" };
            ViewBag.headerTextFour = new TabHeader { Text = "Make Payment" };

            ViewBag.quota = quotaData;
            ViewBag.gender = genderData;
            ViewBag.berth = berthData;
            ViewBag.citiesData = citiesData;

            ViewBag.content1 = "#booking";
            ViewBag.content2 = "#selectTrain";
            ViewBag.content3 = "#details";
            ViewBag.content4 = "#confirm";

            ViewBag.min = DateTime.Now;
            ViewBag.max = DateTime.Now.AddMonths(3);
			ViewBag.value = DateTime.Now;

            headerItems.Add(new TabTabItem { Header = ViewBag.headerTextOne , Content = ViewBag.content1 });
            headerItems.Add(new TabTabItem { Header = ViewBag.headerTextTwo , Content = ViewBag.content2, Disabled = true });
            headerItems.Add(new TabTabItem { Header = ViewBag.headerTextThree , Content = ViewBag.content3, Disabled = true });
            headerItems.Add(new TabTabItem { Header = ViewBag.headerTextFour , Content = ViewBag.content4, Disabled = true  });
            ViewBag.headeritems = headerItems;

            ticketGrid.Add(new GridColumn { Field = "TrainNo", HeaderText = "Train No", Width = "120", Type = "number"});
            ticketGrid.Add(new GridColumn { Field = "PassName", HeaderText = "Name", Width = "140"});
            ticketGrid.Add(new GridColumn { Field = "Gender", HeaderText = "Gender", Width = "120"});
            ticketGrid.Add(new GridColumn { Field = "Berth", HeaderText = "Berth", Width = "140"});
            ViewBag.ticketgrid = ticketGrid;

            availableTrain.Add(new GridColumn { Field = "TrainNo", HeaderText = "Train No", Width = "120", Type = "number" });
            availableTrain.Add(new GridColumn { Field = "Name", HeaderText = "Name", Width = "140" });
            availableTrain.Add(new GridColumn { Field = "Departure", HeaderText = "Departure", Width = "120" });
            availableTrain.Add(new GridColumn { Field = "Arrival", HeaderText = "Arrival", Width = "140" });
            availableTrain.Add(new GridColumn { Field = "Availability", HeaderText = "Availability", Width = "140", Type = "number" });
            ViewBag.availabletrain = availableTrain;

            return View();
        }
    }
}
