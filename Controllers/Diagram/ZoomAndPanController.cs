#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: ZoomAndPan
        public ActionResult ZoomAndPan()
        {
            List<OverviewData1> data = new List<OverviewData1>();
            data.Add(new OverviewData1("parent", "Maria Anders", "Managing Director", "", "../Content/images/diagram/employees/Image1.png"));
            data.Add(new OverviewData1("1", "Ana Trujillo", "Project Manager", "parent", "../Content/images/diagram/employees/Image2.png"));
            data.Add(new OverviewData1("2", "Anto Moreno", "Project Lead", "1", "../Content/images/diagram/employees/Image3.png"));
            data.Add(new OverviewData1("3", "Thomas Hardy", "Senior S/w Engg", "2", "../Content/images/diagram/employees/Image4.png"));
            data.Add(new OverviewData1("4", "Christina kaff", "S/w Engg", "3", "../Content/images/diagram/employees/Image5.png"));
            data.Add(new OverviewData1("5", "Hanna Moos", "Project Trainee", "4", "../Content/images/diagram/employees/Image6.png"));
            data.Add(new OverviewData1("6", "Peter Citeaux", "S/w Engg", "5", "../Content/images/diagram/employees/Image7.png"));
            data.Add(new OverviewData1("7", "Martín Kloss", "Project Trainee", "6", "../Content/images/diagram/employees/Image8.png"));
            data.Add(new OverviewData1("8", "Elizabeth Mary", "Project Trainee", "6", "../Content/images/diagram/employees/Image9.png"));
            data.Add(new OverviewData1("9", "Victoria Ash", "Senior S/w Engg", "5", "../Content/images/diagram/employees/Image10.png"));
            data.Add(new OverviewData1("10", "Francisco Yang", "Senior S/w Engg", "3", "../Content/images/diagram/employees/Image11.png"));
            data.Add(new OverviewData1("11", "Yang Wang", "Project Manager", "parent", "../Content/images/diagram/employees/Image12.png"));
            data.Add(new OverviewData1("12", "Lino Rodri", "Project Manager", "11", "../Content/images/diagram/employees/Image13.png"));
            data.Add(new OverviewData1("13", "Philip Cramer", "Senior S/w Engg", "24", "../Content/images/diagram/employees/Image14.png"));
            data.Add(new OverviewData1("14", "Pedro Afonso", "Project Trainee", "15", "../Content/images/diagram/employees/Image15.png"));
            data.Add(new OverviewData1("15", "Elizabeth Roel", "S/w Engg", "13", "../Content/images/diagram/employees/Image16.png"));
            data.Add(new OverviewData1("16", "Janine Labrune", "Project Lead", "12", "../Content/images/diagram/employees/Image17.png"));
            data.Add(new OverviewData1("17", "Ann Devon", "Project Manager", "25", "../Content/images/diagram/employees/Image18.png"));
            data.Add(new OverviewData1("18", "Roland Mendel", "Project Lead", "17", "../Content/images/diagram/employees/Image19.png"));
            data.Add(new OverviewData1("19", "Aria Cruz", "Senior S/w Engg", "18", "../Content/images/diagram/employees/Image20.png"));
            data.Add(new OverviewData1("20", "Martine Rancé", "S/w Engg", "18", "../Content/images/diagram/employees/Image21.png"));
            data.Add(new OverviewData1("21", "Maria Larsson", "Project Trainee", "19", "../Content/images/diagram/employees/Image1.png"));
            data.Add(new OverviewData1("22", "Diego Roel", "Project Trainee", "21", "../Content/images/diagram/employees/Image2.png"));
            data.Add(new OverviewData1("23", "Peter Franken", "Project Trainee", "21", "../Content/images/diagram/employees/Image3.png"));
            data.Add(new OverviewData1("24", "Howard Snyder", "Project Lead", "16", "../Content/images/diagram/employees/Image4.png"));
            data.Add(new OverviewData1("25", "Howard Snyder", "Project Manager", "parent", "../Content/images/diagram/employees/Image5.png"));
            data.Add(new OverviewData1("26", "Paolo Accorti", "Project Lead", "36", "../Content/images/diagram/employees/Image20.png"));
            data.Add(new OverviewData1("27", "Eduardo Roel", "Senior S/w Engg", "26", "../Content/images/diagram/employees/Image7.png"));
            data.Add(new OverviewData1("28", "José Pedro", "Senior S/w Engg", "27", "../Content/images/diagram/employees/Image8.png"));
            data.Add(new OverviewData1("29", "André Fonseca", "Senior S/w Engg", "28", "../Content/images/diagram/employees/Image9.png"));
            data.Add(new OverviewData1("30", "Howard Snyd", "S/w Engg", "29", "../Content/images/diagram/employees/Image10.png"));
            data.Add(new OverviewData1("31", "Manu Pereira", "Project Trainee", "29", "../Content/images/diagram/employees/Image11.png"));
            data.Add(new OverviewData1("32", "Mario Pontes", "S/w Engg", "29", "../Content/images/diagram/employees/Image12.png"));
            data.Add(new OverviewData1("33", "Carlos Schmitt", "Project Trainee", "29", "../Content/images/diagram/employees/Image13.png"));
            data.Add(new OverviewData1("34", "Yoshi Latimer", "Project Trainee", "29", "../Content/images/diagram/employees/Image14.png"));
            data.Add(new OverviewData1("35", "Patricia Kenna", "Project Trainee", "29", "../Content/images/diagram/employees/Image15.png"));
            data.Add(new OverviewData1("36", "Helen Bennett", "Project Lead", "25", "../Content/images/diagram/employees/Image16.png"));
            data.Add(new OverviewData1("37", "Daniel Tonini", "Project Manager", "parent", "../Content/images/diagram/employees/Image17.png"));
            data.Add(new OverviewData1("38", "Annette Roel", "Project Lead", "37", "../Content/images/diagram/employees/Image18.png"));
            data.Add(new OverviewData1("39", "Yoshi Wilson", "Senior S/w Engg", "38", "../Content/images/diagram/employees/Image19.png"));
            data.Add(new OverviewData1("40", "John Steel", "Project Lead", "38", "../Content/images/diagram/employees/Image20.png"));
            data.Add(new OverviewData1("41", "Renate Jose", "Senior S/w Engg", "40", "../Content/images/diagram/employees/Image21.png"));
            data.Add(new OverviewData1("42", "Renate Jose", "SR", "41", "../Content/images/diagram/employees/Image1.png"));
            data.Add(new OverviewData1("43", "Carlos Nagy", "SR", "42", "../Content/images/diagram/employees/Image2.png"));
            data.Add(new OverviewData1("44", "Felipe Kloss", "S/w Engg", "43", "../Content/images/diagram/employees/Image3.png"));
            data.Add(new OverviewData1("45", "Fran Wilson", "SR", "43", "../Content/images/diagram/employees/Image4.png"));
            data.Add(new OverviewData1("46", "John Rovelli", "S/w Engg", "43", "../Content/images/diagram/employees/Image5.png"));
            data.Add(new OverviewData1("47", "Catherine Kaff", "SR", "43", "../Content/images/diagram/employees/Image6.png"));
            data.Add(new OverviewData1("48", "Jean Fresnière", "Project Trainee", "43", "../Content/images/diagram/employees/Image7.png"));
            data.Add(new OverviewData1("49", "Alex Feuer", "Project Trainee", "43", "../Content/images/diagram/employees/Image8.png"));
            data.Add(new OverviewData1("50", "Simon Roel", "Project Trainee", "41", "../Content/images/diagram/employees/Image9.png"));
            data.Add(new OverviewData1("51", "Yvonne Wong", "Project Trainee", "52", "../Content/images/diagram/employees/Image10.png"));
            data.Add(new OverviewData1("52", "Rene Phillips", "S/w Engg", "39", "../Content/images/diagram/employees/Image11.png"));
            data.Add(new OverviewData1("53", "Yoshi Kenna", "Project Trainee", "52", "../Content/images/diagram/employees/Image12.png"));
            data.Add(new OverviewData1("54", "Helen Marie", "Project Trainee", "52", "../Content/images/diagram/employees/Image13.png"));
            data.Add(new OverviewData1("55", "Joseph Kaff", "Project Trainee", "52", "../Content/images/diagram/employees/Image14.png"));
            data.Add(new OverviewData1("56", "Georg Pipps", "Senior S/w Engg", "57", "../Content/images/diagram/employees/Image15.png"));
            data.Add(new OverviewData1("57", "Nardo Batista", "Project Lead", "12", "../Content/images/diagram/employees/Image16.png"));
            data.Add(new OverviewData1("58", "Lúcia Carvalho", "Senior S/w Engg", "57", "../Content/images/diagram/employees/Image17.png"));
            data.Add(new OverviewData1("59", "Horst Kloss", "Project Trainee", "57", "../Content/images/diagram/employees/Image18.png"));
            data.Add(new OverviewData1("60", "Sergio roel", "CSR", "57", "../Content/images/diagram/employees/Image19.png"));
            data.Add(new OverviewData1("61", "Paula Wilson", "CSR", "57", "../Content/images/diagram/employees/Image20.png"));
            data.Add(new OverviewData1("62", "Mauri Moroni", "Senior S/w Engg", "57", "../Content/images/diagram/employees/Image21.png"));
            data.Add(new OverviewData1("63", "Janete Limeira", "Project Trainee", "57", "../Content/images/diagram/employees/Image1.png"));
            data.Add(new OverviewData1("64", "Michael Holz", "S/w Engg", "57", "../Content/images/diagram/employees/Image2.png"));
            data.Add(new OverviewData1("65", "Alej Camino", "Project Manager", "parent", "../Content/images/diagram/employees/Image3.png"));
            data.Add(new OverviewData1("66", "Jonas Bergsen", "Project Lead", "65", "../Content/images/diagram/employees/Image4.png"));
            data.Add(new OverviewData1("67", "Jose Pavarotti", "Project Trainee", "68", "../Content/images/diagram/employees/Image5.png"));
            data.Add(new OverviewData1("68", "Miguel Angel", "Senior S/w Engg", "66", "../Content/images/diagram/employees/Image6.png"));
            data.Add(new OverviewData1("69", "Jytte Petersen", "Senior S/w Engg", "68", "../Content/images/diagram/employees/Image7.png"));
            data.Add(new OverviewData1("70", "Kloss Perrier", "Project Lead", "72", "../Content/images/diagram/employees/Image8.png"));
            data.Add(new OverviewData1("71", "Art Nancy", "Senior S/w Engg", "27", "../Content/images/diagram/employees/Image9.png"));
            data.Add(new OverviewData1("72", "Pascal Cartrain", "Project Lead", "65", "../Content/images/diagram/employees/Image10.png"));
            data.Add(new OverviewData1("73", "Liz Nixon", "Senior S/w Engg", "68", "../Content/images/diagram/employees/Image11.png"));
            data.Add(new OverviewData1("74", "Liu Wong", "Project Manager", "parent", "../Content/images/diagram/employees/Image12.png"));
            data.Add(new OverviewData1("75", "Karin Josephs", "Project Lead", "74", "../Content/images/diagram/employees/Image13.png"));
            data.Add(new OverviewData1("76", "Ruby Anabela", "Senior S/w Engg", "75", "../Content/images/diagram/employees/Image14.png"));
            data.Add(new OverviewData1("77", "Helvetis Nagy", "Project Trainee", "82", "../Content/images/diagram/employees/Image15.png"));
            data.Add(new OverviewData1("78", "Palle Ibsen", "Senior S/w Engg", "76", "../Content/images/diagram/employees/Image16.png"));
            data.Add(new OverviewData1("79", "Mary Saveley", "SR", "82", "../Content/images/diagram/employees/Image17.png"));
            data.Add(new OverviewData1("80", "Paul Henriot", "SR", "79", "../Content/images/diagram/employees/Image18.png"));
            data.Add(new OverviewData1("81", "Rita Müller", "SR", "79", "../Content/images/diagram/employees/Image19.png"));
            data.Add(new OverviewData1("82", "Pirkko King", "Senior S/w Engg", "78", "../Content/images/diagram/employees/Image20.png"));
            data.Add(new OverviewData1("83", "Paula Parente", "Senior S/w Engg", "75", "../Content/images/diagram/employees/Image21.png"));
            data.Add(new OverviewData1("84", "Karl Jablonski", "S/w Engg", "83", "../Content/images/diagram/employees/Image1.png"));
            data.Add(new OverviewData1("34", "Matti Kenna", "Project Trainee", "84", "../Content/images/diagram/employees/Image2.png"));
            data.Add(new OverviewData1("35", "Zbyszek Yang", "Project Trainee", "84", "../Content/images/diagram/employees/Image3.png"));
            data.Add(new OverviewData1("85", "Karl Jablonski", "Project Lead", "74", "../Content/images/diagram/employees/Image4.png"));
            data.Add(new OverviewData1("86", "Matti Kenna", "Senior S/w Engg", "85", "../Content/images/diagram/employees/Image5.png"));
            data.Add(new OverviewData1("87", "Zbyszek Yang", "CSR", "88", "../Content/images/diagram/employees/Image6.png"));
            data.Add(new OverviewData1("88", "Anne", "CSR", "86", "../Content/images/diagram/employees/Image7.png"));
            data.Add(new OverviewData1("89", "Georg Pipps", "Senior S/w Engg", "parent", "../Content/images/diagram/employees/Image8.png"));
            data.Add(new OverviewData1("90", "Rene Phillips", "Project Trainee", "89", "../Content/images/diagram/employees/Image9.png"));
            data.Add(new OverviewData1("91", "Lúcia Carvalho", "Project Trainee", "89", "../Content/images/diagram/employees/Image10.png"));
            data.Add(new OverviewData1("92", "Horst Kloss", "Project Trainee", "89", "../Content/images/diagram/employees/Image11.png"));
            data.Add(new OverviewData1("93", "Simon Roel", "Project Lead", "98", "../Content/images/diagram/employees/Image12.png"));
            List<ToolbarItem> items = new List<ToolbarItem>();
            {
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-zoom-in", TooltipText = "Zoom In" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-zoom-out", TooltipText = "Zoom Out" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-mouse-pointer", TooltipText = "Pointer" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-pan", TooltipText = "Pan Tool" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-reset", TooltipText = "Reset" });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-zoom-to-fit", TooltipText = "Fit To Page" });
                items.Add(new ToolbarItem { Type = ItemType.Separator });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-bring-to-view", TooltipText = "Bring Into View" ,Disabled=true });
                items.Add(new ToolbarItem { PrefixIcon = "e-icons e-bring-to-center", TooltipText = "Bring Into Center", Disabled = true });
            }
            ViewData["tbItems"] = items;
            ViewData["Nodes"] = data;
            ViewData["getNodeDefaults"] = "getNodeDefaults";
            ViewData["getConnectorDefaults"] = "getConnectorDefaults";
            ViewData["getLayoutInfo"] = "getLayoutInfo";
            ViewData["setNodeTemplate"] = "setNodeTemplate";
            return View();
        }
    }
    public class OverviewData1
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ReportingPerson { get; set; }
        public string Image { get; set; }

        public OverviewData1(string id, string name, string designation, string reportingperson, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            this.ReportingPerson = reportingperson;
            this.Image = image;
        }
    }

}