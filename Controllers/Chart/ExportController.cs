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
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Export
        public ActionResult Export()
        {
            List<ExportChartData> ChartPoints = new List<ExportChartData>
            {
                new ExportChartData {Country="India", GigaWatts = 35.5, DataLabelMappingName="35.5GW"},
                new ExportChartData {Country="China", GigaWatts = 18.3, DataLabelMappingName="18.3GW"},
                new ExportChartData {Country="Italy", GigaWatts = 17.6, DataLabelMappingName="17.6GW"},
                new ExportChartData {Country="Japan", GigaWatts = 13.6, DataLabelMappingName="13.6GW"},
                new ExportChartData {Country="United state", GigaWatts = 12, DataLabelMappingName="12GW"},
                new ExportChartData {Country="Spain", GigaWatts = 5.6, DataLabelMappingName="5.6GW"},
                new ExportChartData {Country="France", GigaWatts = 4.6, DataLabelMappingName="4.6GW"},
                new ExportChartData {Country="Australia", GigaWatts = 3.3, DataLabelMappingName="3.3GW"},
                new ExportChartData {Country="Belgium", GigaWatts = 3, DataLabelMappingName="3GW"},
                new ExportChartData {Country="United Kingdom", GigaWatts = 2.9, DataLabelMappingName="2.9GW"},
                
            };
            bool isMobile = Request.Browser.IsMobileDevice;
            if (isMobile)
            {
                ChartPoints[0].DataLabelMappingName = "35.5";
                ChartPoints[1].DataLabelMappingName = "18.3";
                ChartPoints[2].DataLabelMappingName = "17.6";
                ChartPoints[3].DataLabelMappingName = "13.6";
                ChartPoints[4].DataLabelMappingName = "12";
                ChartPoints[5].DataLabelMappingName = "5.6";
                ChartPoints[6].DataLabelMappingName = "4.6";
                ChartPoints[7].DataLabelMappingName = "3.3";
                ChartPoints[8].DataLabelMappingName = "3";
                ChartPoints[9].DataLabelMappingName = "2.9";
            };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["data"] = new string[] { "JPEG", "PNG", "SVG", "PDF", "XLSX", "CSV" };
            return View();
        }
        public class ExportChartData
        {
            public string Country;
            public double GigaWatts;
            public string DataLabelMappingName;
        }
    }
}