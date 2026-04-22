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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        // GET: Inversed
        public ActionResult Largedata()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "inherit"
            };
            ViewData["labelTextStyle"] = new
            {
                fontFamily = "inherit"
            };
            string[] yLabels = new string[24] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8::00", "9:00", "10:00", "11:00",
                "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00",
                "22:00", "23:00", "24:00" };
            ViewData["yLabels"] = yLabels;
            List<largeDataPalette> palette = new List<largeDataPalette>
            {
                new largeDataPalette { value = 150, color = "#A6DC7E" },
                new largeDataPalette { value = 250, color = "#DCD57E" },
                new largeDataPalette { value = 300, color = "#DC8D7E" }

             };
            ViewData["palette"] = palette;
            ViewData["border"] = new { width = "0" };
            ViewData["dataSource"] = new HeatMapData().GetLargeData();
            return View();
        }
        public class largeDataPalette
        {
            public double value;
            public string color;
        }

    }

    internal class Date
    {
        private int v1;
        private int v2;
        private int v3;

        public Date(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}