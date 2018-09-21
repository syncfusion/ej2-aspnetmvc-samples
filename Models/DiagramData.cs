using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Models
{
    public class HierarchicalDetails
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string FillColor { get; set; }

        public HierarchicalDetails(string name, string category, string fillcolor)
        {
            this.Name = name;
            this.Category = category;
            this.FillColor = fillcolor;
        }

        public static List<HierarchicalDetails> GetAllRecords()
        {
            List<HierarchicalDetails> hierarchicaldetails = new List<HierarchicalDetails>();

            hierarchicaldetails.Add(new HierarchicalDetails("Diagram", "", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Layout", "Diagram", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Tree Layout", "Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Organizational Chart", "Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Hierarchical Tree", "Tree Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Radial Tree", "Tree Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Mind Map", "Hierarchical Tree", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Family Tree", "Hierarchical Tree", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Management", "Organizational Chart", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Human Resources", "Management", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("University", "Management", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Business", "Management", "#916DAF"));

            return hierarchicaldetails;
        }
    }

    public class OrganizationalDetails
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string Color { get; set; }
        public string Manager { get; set; }
        public string ChartType { get; set; }

        public OrganizationalDetails(string id, string role, string color, string manager, string chartType)
        {
            this.Id = id;
            this.Role = role;
            this.Color = color;
            this.Manager = manager;
            this.ChartType = chartType;
        }

        public static List<OrganizationalDetails> GetAllRecords()
        {
            List<OrganizationalDetails> organizationaldetails = new List<OrganizationalDetails>();
            organizationaldetails.Add(new OrganizationalDetails("parent", "Board", "#71AF17", "", ""));
            organizationaldetails.Add(new OrganizationalDetails("1", "General Manager", "#71AF17", "parent", "right"));
            organizationaldetails.Add(new OrganizationalDetails("11", "Assistant General Manager", "#71AF17", "1", ""));
            organizationaldetails.Add(new OrganizationalDetails("2", "Human Resource Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("3", "Trainers", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("4", "Recruiting Team", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("5", "Finance Asst. Manager", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("6", "Design Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("7", "Design Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("8", "Development Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("9", "Drafting Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("10", "Operations Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("11", "Statistics Department", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("12", "Logistics Department", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("16", "Marketing Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("17", "Oversea sales Manager", "#2E95D8", "16", ""));
            organizationaldetails.Add(new OrganizationalDetails("18", "Petroleum Manager", "#2E95D8", "16", ""));
            organizationaldetails.Add(new OrganizationalDetails("20", "Service Dept. Manager", "#2E95D8", "16", ""));
            organizationaldetails.Add(new OrganizationalDetails("21", "Quality Department", "#2E95D8", "16", ""));

            return organizationaldetails;
        }
    }
    public class RadialTreeDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ReportingPerson { get; set; }

        public RadialTreeDetails(string id, string name, string designation, string reportingPerson)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            this.ReportingPerson = reportingPerson;
        }

        public static List<RadialTreeDetails> GetAllRecords()
        {
            List<RadialTreeDetails> radialTreeDetails = new List<RadialTreeDetails>();
            radialTreeDetails.Add(new RadialTreeDetails("parent", "Maria Anders", "Managing Director", ""));
            radialTreeDetails.Add(new RadialTreeDetails("1", "Ana Trujillo", "Project Manager", "parent"));
            radialTreeDetails.Add(new RadialTreeDetails("2", "Lino Rodri", "Project Manager", "parent"));
            radialTreeDetails.Add(new RadialTreeDetails("3", "Philip Cramer", "Project Manager", "parent"));
            radialTreeDetails.Add(new RadialTreeDetails("4", "Pedro Afonso", "Project Manager", "parent"));
            radialTreeDetails.Add(new RadialTreeDetails("5", "Anto Moreno", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("6", "Elizabeth Roel", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("7", "Aria Cruz", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("8", "Eduardo Roel", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("9", "Howard Snyd", "Project Lead", "2"));
            radialTreeDetails.Add(new RadialTreeDetails("10", "Daniel Tonini", "Project Lead", "2"));
            radialTreeDetails.Add(new RadialTreeDetails("11", "Nardo Batista", "Project Lead", "89"));
            radialTreeDetails.Add(new RadialTreeDetails("12", "Michael Holz", "Project Lead", "89"));
            radialTreeDetails.Add(new RadialTreeDetails("13", "Kloss Perrier", "Project Lead", "90"));
            radialTreeDetails.Add(new RadialTreeDetails("14", "Liz Nixon", "Project Lead", "3"));
            radialTreeDetails.Add(new RadialTreeDetails("15", "Paul Henriot", "Project Lead", "3"));
            radialTreeDetails.Add(new RadialTreeDetails("16", "Paula Parente", "Project Lead", "90"));
            radialTreeDetails.Add(new RadialTreeDetails("17", "Matti Kenna", "Project Lead", "4"));
            radialTreeDetails.Add(new RadialTreeDetails("18", "Laura Callahan", "Project Lead", "4"));
            radialTreeDetails.Add(new RadialTreeDetails("19", "Simon Roel", "#Project Lead", "4"));

            radialTreeDetails.Add(new RadialTreeDetails("20", "Thomas Hardy", "Senior S/w Engg", "12"));
            radialTreeDetails.Add(new RadialTreeDetails("21", "Martín Kloss", "Senior S/w Engg", "5"));
            radialTreeDetails.Add(new RadialTreeDetails("23", "Diego Roel", "Senior S/w Engg", "7"));
            radialTreeDetails.Add(new RadialTreeDetails("24", "José Pedro", "Senior S/w Engg", "8"));
            radialTreeDetails.Add(new RadialTreeDetails("25", "Manu Pereira", "Senior S/w Engg", "8"));
            radialTreeDetails.Add(new RadialTreeDetails("26", "Annette Roel", "Senior S/w Engg", "25"));
            radialTreeDetails.Add(new RadialTreeDetails("27", "Catherine Kaff", "Senior S/w Engg", "8"));
            radialTreeDetails.Add(new RadialTreeDetails("28", "Lúcia Carvalho", "Senior S/w Engg", "12"));
            radialTreeDetails.Add(new RadialTreeDetails("29", "Alej Camino", "Senior S/w Engg", "13"));
            radialTreeDetails.Add(new RadialTreeDetails("30", "Liu Wong", "Senior S/w Engg", "14"));
            radialTreeDetails.Add(new RadialTreeDetails("31", "Karin Josephs", "Senior S/w Engg", "14"));
            radialTreeDetails.Add(new RadialTreeDetails("33", "Pirkko King", "Senior S/w Engg", "17"));
            radialTreeDetails.Add(new RadialTreeDetails("34", "Karl Jablonski", "Senior S/w Engg", "18"));
            radialTreeDetails.Add(new RadialTreeDetails("35", "Zbyszek Yang", "Senior S/w Engg", "19"));
            radialTreeDetails.Add(new RadialTreeDetails("36", "Nancy", "Senior S/w Engg", "5"));
            radialTreeDetails.Add(new RadialTreeDetails("37", "Anne", "Senior S/w Engg", "6"));

            radialTreeDetails.Add(new RadialTreeDetails("38", "Isabel Castro", "Senior S/w Engg", "7"));
            radialTreeDetails.Add(new RadialTreeDetails("39", "Nardo Batista", "Senior S/w Engg", "9"));
            radialTreeDetails.Add(new RadialTreeDetails("40", "Rene Phillips", "Senior S/w Engg", "16"));
            radialTreeDetails.Add(new RadialTreeDetails("41", "Rita Pfalzheim", "Senior S/w Engg", "9"));
            radialTreeDetails.Add(new RadialTreeDetails("42", "Janete Limeira", "Senior S/w Engg", "11"));

            radialTreeDetails.Add(new RadialTreeDetails("43", "Christina kaff", "S/w Engg", "20"));
            radialTreeDetails.Add(new RadialTreeDetails("44", "Peter Franken", "S/w Engg", "21"));
            radialTreeDetails.Add(new RadialTreeDetails("45", "Carlos Schmitt", "S/w Engg", "23"));
            radialTreeDetails.Add(new RadialTreeDetails("46", "Yoshi Wilson", "S/w Engg", "23"));
            radialTreeDetails.Add(new RadialTreeDetails("47", "Jean Fresnière", "S/w Engg", "24"));
            radialTreeDetails.Add(new RadialTreeDetails("48", "Simon Roel", "S/w Engg", "25"));
            radialTreeDetails.Add(new RadialTreeDetails("52", "Palle Ibsen", "S/w Engg", "29"));
            radialTreeDetails.Add(new RadialTreeDetails("53", "Lúcia Carvalho", "S/w Engg", "30"));


            radialTreeDetails.Add(new RadialTreeDetails("54", "Hanna Moos", "Project Trainee", "30"));
            radialTreeDetails.Add(new RadialTreeDetails("55", "Peter Citeaux", "Project Trainee", "33"));
            radialTreeDetails.Add(new RadialTreeDetails("56", "Elizabeth Mary", "Project Trainee", "33"));
            radialTreeDetails.Add(new RadialTreeDetails("57", "Victoria Ash", "Project Trainee", "34"));
            radialTreeDetails.Add(new RadialTreeDetails("58", "Janine Labrune", "Project Trainee", "35"));
            radialTreeDetails.Add(new RadialTreeDetails("60", "Carine Schmitt", "Project Trainee", "11"));
            radialTreeDetails.Add(new RadialTreeDetails("61", "Paolo Accorti", "Project Trainee", "38"));
            radialTreeDetails.Add(new RadialTreeDetails("62", "André Fonseca", "Project Trainee", "41"));
            radialTreeDetails.Add(new RadialTreeDetails("63", "Mario Pontes", "Project Trainee", "6"));
            radialTreeDetails.Add(new RadialTreeDetails("64", "John Steel", "Project Trainee", "7"));
            radialTreeDetails.Add(new RadialTreeDetails("65", "Renate Jose", "Project Trainee", "42"));
            radialTreeDetails.Add(new RadialTreeDetails("66", "Jaime Yorres", "Project Trainee", "20"));
            radialTreeDetails.Add(new RadialTreeDetails("67", "Alex Feuer", "Project Trainee", "21"));
            radialTreeDetails.Add(new RadialTreeDetails("70", "Helen Marie", "Project Trainee", "24"));
            radialTreeDetails.Add(new RadialTreeDetails("73", "Sergio roel", "Project Trainee", "37"));
            radialTreeDetails.Add(new RadialTreeDetails("75", "Janete Limeira", "Project Trainee", "29"));
            radialTreeDetails.Add(new RadialTreeDetails("76", "Jonas Bergsen", "Project Trainee", "18"));
            radialTreeDetails.Add(new RadialTreeDetails("77", "Miguel Angel", "Project Trainee", "18"));
            radialTreeDetails.Add(new RadialTreeDetails("80", "Helvetis Nagy", "Project Trainee", "34"));
            radialTreeDetails.Add(new RadialTreeDetails("81", "Rita Müller", "Project Trainee", "35"));
            radialTreeDetails.Add(new RadialTreeDetails("82", "Georg Pipps", "Project Trainee", "36"));
            radialTreeDetails.Add(new RadialTreeDetails("83", "Horst Kloss", "Project Trainee", "37"));
            radialTreeDetails.Add(new RadialTreeDetails("84", "Paula Wilson", "Project Trainee", "38"));
            radialTreeDetails.Add(new RadialTreeDetails("85", "Jose Michael", "Project Trainee", "37"));
            radialTreeDetails.Add(new RadialTreeDetails("86", "Mauri Moroni", "Project Trainee", "40"));
            radialTreeDetails.Add(new RadialTreeDetails("87", "Michael Holz", "Project Trainee", "41"));
            radialTreeDetails.Add(new RadialTreeDetails("88", "Alej Camino", "Project Trainee", "42"));

            radialTreeDetails.Add(new RadialTreeDetails("89", "Jytte Petersen", "Project Manager", "parent"));
            radialTreeDetails.Add(new RadialTreeDetails("90", "Mary Saveley", "Project Manager", "parent"));
            radialTreeDetails.Add(new RadialTreeDetails("91", "Robert King", "Project Manager", "parent"));

            radialTreeDetails.Add(new RadialTreeDetails("95", "Roland Mendel", "CSR", "19"));
            radialTreeDetails.Add(new RadialTreeDetails("98", "Helen Bennett", "SR", "42"));
            radialTreeDetails.Add(new RadialTreeDetails("99", "Carlos Nagy", "SR", "42"));
            radialTreeDetails.Add(new RadialTreeDetails("100", "Felipe Kloss", "SR", "77"));




            return radialTreeDetails;
        }
    }

    public class SymmetricalDetails
    {
        public string Id { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string ReportingPerson { get; set; }

        public SymmetricalDetails(string id, string source, string type)
        {
            this.Id = id;
            this.Source = source;
            this.Type = type;
        }

        public static List<SymmetricalDetails> GetAllRecords()
        {
            List<SymmetricalDetails> symmetricalDetails = new List<SymmetricalDetails>();

            symmetricalDetails.Add(new Models.SymmetricalDetails("parent", "", "Server"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("1", "parent", "Server"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("2", "parent", "Server"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("3", "parent", "Server"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("4", "parent", "Server"));

            symmetricalDetails.Add(new Models.SymmetricalDetails("5", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("6", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("7", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("8", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("9", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("10", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("11", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("12", "1", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("13", "1", "Hub"));

            symmetricalDetails.Add(new Models.SymmetricalDetails("14", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("15", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("16", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("18", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("19", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("20", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("21", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("22", "2", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("23", "2", "Hub"));

            symmetricalDetails.Add(new Models.SymmetricalDetails("24", "3", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("25", "3", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("26", "3", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("27", "3", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("28", "3", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("29", "3", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("30", "3", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("31", "3", "Hub"));

            symmetricalDetails.Add(new Models.SymmetricalDetails("32", "4", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("33", "4", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("34", "4", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("35", "4", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("36", "4", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("37", "4", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("38", "4", "Hub"));
            symmetricalDetails.Add(new Models.SymmetricalDetails("39", "4", "Hub"));

            return symmetricalDetails;
        }
    }

    public class MindMapDetails
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string ParentId { get; set; }
        public string Branch { get; set; }
        public string Fill { get; set; }

        public MindMapDetails(string id, string label, string parent, string branch, string fill)
        {
            this.Id = id;
            this.Label = label;
            this.ParentId = parent;
            this.Branch = branch;
            this.Fill = fill;
        }

        public static List<MindMapDetails> GetAllRecords()
        {
            List<MindMapDetails> mindmapDetails = new List<Models.MindMapDetails>();

            mindmapDetails.Add(new Models.MindMapDetails("1", "Creativity", "", "Root", "red"));
            mindmapDetails.Add(new Models.MindMapDetails("3", "Brainstorming", "1", "Right", "red"));
            mindmapDetails.Add(new Models.MindMapDetails("4", "Complementing", "1", "Left", "red"));

            mindmapDetails.Add(new Models.MindMapDetails("22", "Sessions", "3", "subRight", "red"));
            mindmapDetails.Add(new Models.MindMapDetails("23", "Complementing", "3", "subRight", "red"));

            mindmapDetails.Add(new Models.MindMapDetails("25", "Local", "22", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("26", "Remote", "22", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("27", "Individual", "22", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("28", "Teams", "22", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("29", "Ideas", "23", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("30", "Engagement", "23", "subRight", ""));

            mindmapDetails.Add(new Models.MindMapDetails("31", "Product", "29", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("32", "Service", "29", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("33", "Business Direction", "29", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("34", "Empowering", "30", "subRight", ""));
            mindmapDetails.Add(new Models.MindMapDetails("35", "Ownership", "30", "subRight", ""));

            mindmapDetails.Add(new Models.MindMapDetails("50", "Information", "4", "subLeft", ""));
            mindmapDetails.Add(new Models.MindMapDetails("51", "Expectations", "4", "subLeft", ""));


            mindmapDetails.Add(new Models.MindMapDetails("53", "Competetors", "50", "subLeft", ""));
            mindmapDetails.Add(new Models.MindMapDetails("54", "Products", "50", "subLeft", ""));
            mindmapDetails.Add(new Models.MindMapDetails("55", "Features", "50", "subLeft", ""));
            mindmapDetails.Add(new Models.MindMapDetails("56", "Other Data", "50", "subLeft", ""));

            mindmapDetails.Add(new Models.MindMapDetails("59", "Organization", "51", "subLeft", ""));
            mindmapDetails.Add(new Models.MindMapDetails("60", "Customer", "51", "subLeft", ""));
            mindmapDetails.Add(new Models.MindMapDetails("61", "Staff", "51", "subLeft", ""));
            mindmapDetails.Add(new Models.MindMapDetails("62", "Stakeholders", "51", "subLeft", ""));

            return mindmapDetails;
        }
    }

    public class ComplexHierarchicalDataDetails
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string[] ReportingPersons { get; set; }
        public string Border { get; set; }

        public ComplexHierarchicalDataDetails(string name, string color, string[] reportingPersons, string border)
        {
            this.Name = name;
            this.Color = color;
            this.ReportingPersons = reportingPersons;
            this.Border = border;
        }

        public static List<ComplexHierarchicalDataDetails> GetAllRecords()
        {
            List<ComplexHierarchicalDataDetails> multiParents = new List<ComplexHierarchicalDataDetails>();

            multiParents.Add(new ComplexHierarchicalDataDetails("node11", "#e7704c", null, "#c15433"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node12", "#efd46e", new string[] { "node114" }, "#d6b123"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node13", "#58b087", new string[] { "node12" }, "#16955e"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node14", "#58b087", new string[] { "node12" }, "#16955e"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node15", "#58b087", new string[] { "node12" }, "#16955e"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node16", "#14ad85", new string[] { }, ""));

            multiParents.Add(new ComplexHierarchicalDataDetails("node17", "#659be5", new string[] { "node13", "node14", "node15" }, "#3a6eb5"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node18", "#14ad85", new string[] { }, ""));
            multiParents.Add(new ComplexHierarchicalDataDetails("node19", "#8dbe6c", new string[] { "node16", "node17", "node18" }, "#489911"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node110", "#8dbe6c", new string[] { "node16", "node17", "node18" }, "#489911"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node111", "#8dbe6c", new string[] { "node16", "node17", "node18", "node116" }, "#489911"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node21", "#e7704c", null, "#c15433"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node22", "#efd46e", new string[] { "node114" }, "#d6b123"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node23", "#58b087", new string[] { "node22" }, "#16955e"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node24", "#58b087", new string[] { "node22" }, "#16955e"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node25", "#58b087", new string[] { "node22" }, "#16955e"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node26", "#14ad85", new string[] { }, "#14ad85"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node27", "#659be5", new string[] { "node23", "node24", "node25" }, "#3a6eb5"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node28", "#14ad85", new string[] { }, ""));

            multiParents.Add(new ComplexHierarchicalDataDetails("node29", "#8dbe6c", new string[] { "node26", "node27", "node28", "node116" }, "#489911"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node210", "#8dbe6c", new string[] { "node26", "node27", "node28" }, "#489911"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node211", "#8dbe6c", new string[] { "node26", "node27", "node28" }, "#489911"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node31", "#e7704c", null, "#c15433"));

            multiParents.Add(new ComplexHierarchicalDataDetails("node114", "#f3904a", new string[] { "node11", "node21", "node31" }, "#d3722e"));
            multiParents.Add(new ComplexHierarchicalDataDetails("node116", "#58b087", new string[] { "node12", "node22" }, "#d3722e"));

            return multiParents;
        }
    }
    public class LocalDataDetails
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string Manager { get; set; }
        public string ChartType { get; set; }
        public string Color { get; set; }

        public LocalDataDetails(string id, string role, string manager, string charttype, string color)
        {
            this.Id = id;
            this.Role = role;
            this.Manager = manager;
            this.ChartType = charttype;
            this.Color = color;
        }

        public static List<LocalDataDetails> GetAllRecords()
        {
            List<LocalDataDetails> localData = new List<LocalDataDetails>();

            localData.Add(new Models.LocalDataDetails("parent", "Board", "", "", "#71AF17"));
            localData.Add(new Models.LocalDataDetails("1", "General Manager", "parent", "right", "#71AF17"));
            localData.Add(new Models.LocalDataDetails("11", "Assistant Manager", "1", "", "#71AF17"));
            localData.Add(new Models.LocalDataDetails("2", "Human Resource Manager", "1", "right", "#1859B7"));
            localData.Add(new Models.LocalDataDetails("3", "Trainers", "2", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("4", "Recruiting Team", "2", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("5", "Finance Asst. Manager", "2", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("6", "Design Manager", "1", "right", "#1859B7"));
            localData.Add(new Models.LocalDataDetails("7", "Design Supervisor", "6", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("8", "Development Supervisor", "6", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("9", "Drafting Supervisor", "6", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("10", "Operation Manager", "1", "right", "#1859B7"));
            localData.Add(new Models.LocalDataDetails("11", "Statistic Department", "10", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("12", "Logistic Department", "10", "", "#2E95D8"));
            localData.Add(new Models.LocalDataDetails("16", "Marketing Manager", "1", "right", "#1859B7"));
            localData.Add(new Models.LocalDataDetails("17", "Overseas sales Manager", "16", "", "#1859B7"));
            localData.Add(new Models.LocalDataDetails("18", "Petroleum Manager", "16", "", "#1859B7"));
            localData.Add(new Models.LocalDataDetails("20", "Service Department Manager", "16", "", "#1859B7"));
            localData.Add(new Models.LocalDataDetails("21", "Quality Control Department", "16", "", "#1859B7"));

            return localData;
        }
    }

    public class OverviewData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ReportingPerson { get; set; }
        public string Image { get; set; }

        public OverviewData(string id, string name, string designation, string reportingperson, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            this.ReportingPerson = reportingperson;
            this.Image = image;
        }

        public static List<OverviewData> GetAllRecords(UrlHelper url)
        {

            List<OverviewData> data = new List<OverviewData>();
            data.Add(new OverviewData("parent", "Maria Anders", "Managing Director", "", url.Content("/Content/images/diagram/employees/Image1.png")));
            data.Add(new OverviewData("1", "Ana Trujillo", "Project Manager", "parent", url.Content("/Content/images/diagram/employees/Image2.png")));
            data.Add(new OverviewData("2", "Anto Moreno", "Project Lead", "1", url.Content("/Content/images/diagram/employees/Image3.png")));
            data.Add(new OverviewData("3", "Thomas Hardy", "Senior S/w Engg", "2", url.Content("/Content/images/diagram/employees/Image4.png")));
            data.Add(new OverviewData("4", "Christina kaff", "S/w Engg", "3", url.Content("/Content/images/diagram/employees/Image5.png")));
            data.Add(new OverviewData("5", "Hanna Moos", "Project Trainee", "4", url.Content("/Content/images/diagram/employees/Image6.png")));
            data.Add(new OverviewData("6", "Peter Citeaux", "S/w Engg", "5", url.Content("/Content/images/diagram/employees/Image7.png")));
            data.Add(new OverviewData("7", "Martín Kloss", "Project Trainee", "6", url.Content("/Content/images/diagram/employees/Image8.png")));
            data.Add(new OverviewData("8", "Elizabeth Mary", "Project Trainee", "6", url.Content("/Content/images/diagram/employees/Image9.png")));
            data.Add(new OverviewData("9", "Victoria Ash", "Senior S/w Engg", "5", url.Content("/Content/images/diagram/employees/Image10.png")));
            data.Add(new OverviewData("10", "Francisco Yang", "Senior S/w Engg", "3", url.Content("/Content/images/diagram/employees/Image11.png")));
            data.Add(new OverviewData("11", "Yang Wang", "Project Manager", "parent", url.Content("/Content/images/diagram/employees/Image12.png")));
            data.Add(new OverviewData("12", "Lino Rodri", "Project Manager", "11", url.Content("/Content/images/diagram/employees/Image13.png")));
            data.Add(new OverviewData("13", "Philip Cramer", "Senior S/w Engg", "24", url.Content("/Content/images/diagram/employees/Image14.png")));
            data.Add(new OverviewData("14", "Pedro Afonso", "Project Trainee", "15", url.Content("/Content/images/diagram/employees/Image15.png")));
            data.Add(new OverviewData("15", "Elizabeth Roel", "S/w Engg", "13", url.Content("/Content/images/diagram/employees/Image16.png")));
            data.Add(new OverviewData("16", "Janine Labrune", "Project Lead", "12", url.Content("/Content/images/diagram/employees/Image17.png")));
            data.Add(new OverviewData("17", "Ann Devon", "Project Manager", "25", url.Content("/Content/images/diagram/employees/Image18.png")));
            data.Add(new OverviewData("18", "Roland Mendel", "Project Lead", "17", url.Content("/Content/images/diagram/employees/Image19.png")));
            data.Add(new OverviewData("19", "Aria Cruz", "Senior S/w Engg", "18", url.Content("/Content/images/diagram/employees/Image20.png")));
            data.Add(new OverviewData("20", "Martine Rancé", "S/w Engg", "18", url.Content("/Content/images/diagram/employees/Image21.png")));
            data.Add(new OverviewData("21", "Maria Larsson", "Project Trainee", "19", url.Content("/Content/images/diagram/employees/Image1.png")));
            data.Add(new OverviewData("22", "Diego Roel", "Project Trainee", "21", url.Content("/Content/images/diagram/employees/Image2.png")));
            data.Add(new OverviewData("23", "Peter Franken", "Project Trainee", "21", url.Content("/Content/images/diagram/employees/Image3.png")));
            data.Add(new OverviewData("24", "Howard Snyder", "Project Lead", "16", url.Content("/Content/images/diagram/employees/Image4.png")));
            data.Add(new OverviewData("25", "Howard Snyder", "Project Manager", "parent", url.Content("/Content/images/diagram/employees/Image5.png")));
            data.Add(new OverviewData("26", "Paolo Accorti", "Project Lead", "36", url.Content("/Content/images/diagram/employees/Image20.png")));
            data.Add(new OverviewData("27", "Eduardo Roel", "Senior S/w Engg", "26", url.Content("/Content/images/diagram/employees/Image7.png")));
            data.Add(new OverviewData("28", "José Pedro", "Senior S/w Engg", "27", url.Content("/Content/images/diagram/employees/Image8.png")));
            data.Add(new OverviewData("29", "André Fonseca", "Senior S/w Engg", "28", url.Content("/Content/images/diagram/employees/Image9.png")));
            data.Add(new OverviewData("30", "Howard Snyd", "S/w Engg", "29", url.Content("/Content/images/diagram/employees/Image10.png")));
            data.Add(new OverviewData("31", "Manu Pereira", "Project Trainee", "29", url.Content("/Content/images/diagram/employees/Image11.png")));
            data.Add(new OverviewData("32", "Mario Pontes", "S/w Engg", "29", url.Content("/Content/images/diagram/employees/Image12.png")));
            data.Add(new OverviewData("33", "Carlos Schmitt", "Project Trainee", "29", url.Content("/Content/images/diagram/employees/Image13.png")));
            data.Add(new OverviewData("34", "Yoshi Latimer", "Project Trainee", "29", url.Content("/Content/images/diagram/employees/Image14.png")));
            data.Add(new OverviewData("35", "Patricia Kenna", "Project Trainee", "29", url.Content("/Content/images/diagram/employees/Image15.png")));
            data.Add(new OverviewData("36", "Helen Bennett", "Project Lead", "25", url.Content("/Content/images/diagram/employees/Image16.png")));
            data.Add(new OverviewData("37", "Daniel Tonini", "Project Manager", "parent", url.Content("/Content/images/diagram/employees/Image17.png")));
            data.Add(new OverviewData("38", "Annette Roel", "Project Lead", "37", url.Content("/Content/images/diagram/employees/Image18.png")));
            data.Add(new OverviewData("39", "Yoshi Wilson", "Senior S/w Engg", "38", url.Content("/Content/images/diagram/employees/Image19.png")));
            data.Add(new OverviewData("40", "John Steel", "Project Lead", "38", url.Content("/Content/images/diagram/employees/Image20.png")));
            data.Add(new OverviewData("41", "Renate Jose", "Senior S/w Engg", "40", url.Content("/Content/images/diagram/employees/Image21.png")));
            data.Add(new OverviewData("42", "Renate Jose", "SR", "41", url.Content("/Content/images/diagram/employees/Image1.png")));
            data.Add(new OverviewData("43", "Carlos Nagy", "SR", "42", url.Content("/Content/images/diagram/employees/Image2.png")));
            data.Add(new OverviewData("44", "Felipe Kloss", "S/w Engg", "43", url.Content("/Content/images/diagram/employees/Image3.png")));
            data.Add(new OverviewData("45", "Fran Wilson", "SR", "43", url.Content("/Content/images/diagram/employees/Image4.png")));
            data.Add(new OverviewData("46", "John Rovelli", "S/w Engg", "43", url.Content("/Content/images/diagram/employees/Image5.png")));
            data.Add(new OverviewData("47", "Catherine Kaff", "SR", "43", url.Content("/Content/images/diagram/employees/Image6.png")));
            data.Add(new OverviewData("48", "Jean Fresnière", "Project Trainee", "43", url.Content("/Content/images/diagram/employees/Image7.png")));
            data.Add(new OverviewData("49", "Alex Feuer", "Project Trainee", "43", url.Content("/Content/images/diagram/employees/Image8.png")));
            data.Add(new OverviewData("50", "Simon Roel", "Project Trainee", "41", url.Content("/Content/images/diagram/employees/Image9.png")));
            data.Add(new OverviewData("51", "Yvonne Wong", "Project Trainee", "52", url.Content("/Content/images/diagram/employees/Image10.png")));
            data.Add(new OverviewData("52", "Rene Phillips", "S/w Engg", "39", url.Content("/Content/images/diagram/employees/Image11.png")));
            data.Add(new OverviewData("53", "Yoshi Kenna", "Project Trainee", "52", url.Content("/Content/images/diagram/employees/Image12.png")));
            data.Add(new OverviewData("54", "Helen Marie", "Project Trainee", "52", url.Content("/Content/images/diagram/employees/Image13.png")));
            data.Add(new OverviewData("55", "Joseph Kaff", "Project Trainee", "52", url.Content("/Content/images/diagram/employees/Image14.png")));
            data.Add(new OverviewData("56", "Georg Pipps", "Senior S/w Engg", "57", url.Content("/Content/images/diagram/employees/Image15.png")));
            data.Add(new OverviewData("57", "Nardo Batista", "Project Lead", "12", url.Content("/Content/images/diagram/employees/Image16.png")));
            data.Add(new OverviewData("58", "Lúcia Carvalho", "Senior S/w Engg", "57", url.Content("/Content/images/diagram/employees/Image17.png")));
            data.Add(new OverviewData("59", "Horst Kloss", "Project Trainee", "57", url.Content("/Content/images/diagram/employees/Image18.png")));
            data.Add(new OverviewData("60", "Sergio roel", "CSR", "57", url.Content("/Content/images/diagram/employees/Image19.png")));
            data.Add(new OverviewData("61", "Paula Wilson", "CSR", "57", url.Content("/Content/images/diagram/employees/Image20.png")));
            data.Add(new OverviewData("62", "Mauri Moroni", "Senior S/w Engg", "57", url.Content("/Content/images/diagram/employees/Image21.png")));
            data.Add(new OverviewData("63", "Janete Limeira", "Project Trainee", "57", url.Content("/Content/images/diagram/employees/Image1.png")));
            data.Add(new OverviewData("64", "Michael Holz", "S/w Engg", "57", url.Content("/Content/images/diagram/employees/Image2.png")));
            data.Add(new OverviewData("65", "Alej Camino", "Project Manager", "parent", url.Content("/Content/images/diagram/employees/Image3.png")));
            data.Add(new OverviewData("66", "Jonas Bergsen", "Project Lead", "65", url.Content("/Content/images/diagram/employees/Image4.png")));
            data.Add(new OverviewData("67", "Jose Pavarotti", "Project Trainee", "68", url.Content("/Content/images/diagram/employees/Image5.png")));
            data.Add(new OverviewData("68", "Miguel Angel", "Senior S/w Engg", "66", url.Content("/Content/images/diagram/employees/Image6.png")));
            data.Add(new OverviewData("69", "Jytte Petersen", "Senior S/w Engg", "68", url.Content("/Content/images/diagram/employees/Image7.png")));
            data.Add(new OverviewData("70", "Kloss Perrier", "Project Lead", "72", url.Content("/Content/images/diagram/employees/Image8.png")));
            data.Add(new OverviewData("71", "Art Nancy", "Senior S/w Engg", "27", url.Content("/Content/images/diagram/employees/Image9.png")));
            data.Add(new OverviewData("72", "Pascal Cartrain", "Project Lead", "65", url.Content("/Content/images/diagram/employees/Image10.png")));
            data.Add(new OverviewData("73", "Liz Nixon", "Senior S/w Engg", "68", url.Content("/Content/images/diagram/employees/Image11.png")));
            data.Add(new OverviewData("74", "Liu Wong", "Project Manager", "parent", url.Content("/Content/images/diagram/employees/Image12.png")));
            data.Add(new OverviewData("75", "Karin Josephs", "Project Lead", "74", url.Content("/Content/images/diagram/employees/Image13.png")));
            data.Add(new OverviewData("76", "Ruby Anabela", "Senior S/w Engg", "75", url.Content("/Content/images/diagram/employees/Image14.png")));
            data.Add(new OverviewData("77", "Helvetis Nagy", "Project Trainee", "82", url.Content("/Content/images/diagram/employees/Image15.png")));
            data.Add(new OverviewData("78", "Palle Ibsen", "Senior S/w Engg", "76", url.Content("/Content/images/diagram/employees/Image16.png")));
            data.Add(new OverviewData("79", "Mary Saveley", "SR", "82", url.Content("/Content/images/diagram/employees/Image17.png")));
            data.Add(new OverviewData("80", "Paul Henriot", "SR", "79", url.Content("/Content/images/diagram/employees/Image18.png")));
            data.Add(new OverviewData("81", "Rita Müller", "SR", "79", url.Content("/Content/images/diagram/employees/Image19.png")));
            data.Add(new OverviewData("82", "Pirkko King", "Senior S/w Engg", "78", url.Content("/Content/images/diagram/employees/Image20.png")));
            data.Add(new OverviewData("83", "Paula Parente", "Senior S/w Engg", "75", url.Content("/Content/images/diagram/employees/Image21.png")));
            data.Add(new OverviewData("84", "Karl Jablonski", "S/w Engg", "83", url.Content("/Content/images/diagram/employees/Image1.png")));
            data.Add(new OverviewData("34", "Matti Kenna", "Project Trainee", "84", url.Content("/Content/images/diagram/employees/Image2.png")));
            data.Add(new OverviewData("35", "Zbyszek Yang", "Project Trainee", "84", url.Content("/Content/images/diagram/employees/Image3.png")));
            data.Add(new OverviewData("85", "Karl Jablonski", "Project Lead", "74", url.Content("/Content/images/diagram/employees/Image4.png")));
            data.Add(new OverviewData("86", "Matti Kenna", "Senior S/w Engg", "85", url.Content("/Content/images/diagram/employees/Image5.png")));
            data.Add(new OverviewData("87", "Zbyszek Yang", "CSR", "88", url.Content("/Content/images/diagram/employees/Image6.png")));
            data.Add(new OverviewData("88", "Anne", "CSR", "86", url.Content("/Content/images/diagram/employees/Image7.png")));
            data.Add(new OverviewData("89", "Georg Pipps", "Senior S/w Engg", "parent", url.Content("/Content/images/diagram/employees/Image8.png")));
            data.Add(new OverviewData("90", "Rene Phillips", "Project Trainee", "89", url.Content("/Content/images/diagram/employees/Image9.png")));
            data.Add(new OverviewData("91", "Lúcia Carvalho", "Project Trainee", "89", url.Content("/Content/images/diagram/employees/Image10.png")));
            data.Add(new OverviewData("92", "Horst Kloss", "Project Trainee", "89", url.Content("/Content/images/diagram/employees/Image11.png")));
            data.Add(new OverviewData("93", "Simon Roel", "Project Lead", "98", url.Content("/Content/images/diagram/employees/Image12.png")));

            return data;

        }
    }

    public class pertChartDataDetails
    {
        public string Id { get; set; }
        public string Branch { get; set; }
        public string Duration { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string[] Category { get; set; }

        public pertChartDataDetails(string Id, string Branch, string[] Category, string Duration, string StartDate, string EndDate)
        {
            this.Id = Id;
            this.Branch = Branch;
            this.Category = Category;
            this.Duration = Duration;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        public static List<pertChartDataDetails> GetAllRecords()
        {
            List<pertChartDataDetails> data = new List<pertChartDataDetails>();
            data.Add(new pertChartDataDetails("Start Project", "root", null, "4", "04/19/2018", "08/19/2018"));
            data.Add(new pertChartDataDetails("Design", "", new string[] { "Start Project" },
         "2", "08/20/2018", "10/20/2018"));
            data.Add(new pertChartDataDetails("Formalize Specification", "", new string[] { "Start Project" },
         "2", "10/21/2018", "12/22/2018"));
            data.Add(new pertChartDataDetails("Write Documentation", "", new string[] { "Start Project" },
         "1", "12/23/2018", "01/22/2019"));
            data.Add(new pertChartDataDetails("Release Prototype", "", new string[] { "Design" },
         "1", "01/23/2019", " 02/23/2019"));
            data.Add(new pertChartDataDetails("Testing", "", new string[] { "Formalize Specification", "Release Prototype" },
         "2", "02/24/2019", "04/22/2019"));
            data.Add(new pertChartDataDetails("Release Project", "", new string[] { "Release Prototype" },
         "1", "04/23/2019", "05/24/2019"));
            data.Add(new pertChartDataDetails("Review Changes", "", new string[] { "Write Documentation" },
         "1", "05/25/2019", " 06/26/2019"));
            data.Add(new pertChartDataDetails("Publish Documentation", "", new string[] { "Review Changes" },
         "1", "06/21/2019", " 07/22/2019"));
            data.Add(new pertChartDataDetails("Finish", "", new string[] { "Publish Documentation", "Release Project" },
         "1", "07/23/2019", "08/24/2019"));

            return data;
        }
    }

    public class RTLData
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Category { get; set; }

        public RTLData(string Name, string Branch, string Category)
        {
            this.Name = Name;
            this.Branch = Branch;
            this.Category = Category;
        }
        public static List<RTLData> GetAllRecords()
        {
            List<RTLData> data = new List<RTLData>();
            data.Add(new RTLData("Artificial Intelligence", "root", ""));
            data.Add(new RTLData("Machine Learning", "", "Artificial Intelligence"));
            data.Add(new RTLData("Natural Language Processing (NLP)", "", "Artificial Intelligence"));
            data.Add(new RTLData("Speech", "", "Artificial Intelligence"));
            data.Add(new RTLData("Planning, Scheduling and Optimization", "", "Artificial Intelligence"));
            data.Add(new RTLData("Robotics", "", "Artificial Intelligence"));
            data.Add(new RTLData("Vision", "", "Artificial Intelligence"));
            data.Add(new RTLData(" Deep Learning ", "", "Machine Learning"));
            data.Add(new RTLData("Predictive Analytics ", "", "Machine Learning"));
            data.Add(new RTLData("Translation ", "", "Natural Language Processing (NLP)"));
            data.Add(new RTLData("Classification", "", "Natural Language Processing (NLP)"));
            data.Add(new RTLData("Information Extraction", "", "Natural Language Processing (NLP)"));
            data.Add(new RTLData("Speech to Text", "", "Speech"));
            data.Add(new RTLData("Text to Speech", "", "Speech"));
            data.Add(new RTLData("Image Recognition ", "", "Vision"));
            data.Add(new RTLData("Machine Vision", "", "Vision"));

            return data;
        }
    }

}