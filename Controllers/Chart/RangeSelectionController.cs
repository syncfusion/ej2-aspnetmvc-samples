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
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: RangeSelection
        public ActionResult RangeSelection()
        {
            List<RangeSelectionChartData> chartData = new List<RangeSelectionChartData>
            {
                new RangeSelectionChartData { xValue = 1971, yValue = 50, yValue1 = 23 },
                new RangeSelectionChartData { xValue = 1972, yValue = 20, yValue1 = 67 },
                new RangeSelectionChartData { xValue = 1973, yValue = 63, yValue1 = 83 },
                new RangeSelectionChartData { xValue = 1974, yValue = 81, yValue1 = 43 },
                new RangeSelectionChartData { xValue = 1975, yValue = 64, yValue1 = 8  },
                new RangeSelectionChartData { xValue = 1976, yValue = 36, yValue1 = 41 },
                new RangeSelectionChartData { xValue = 1977, yValue = 22, yValue1 = 56 },
                new RangeSelectionChartData { xValue = 1978, yValue = 78, yValue1 = 31 },
                new RangeSelectionChartData { xValue = 1979, yValue = 60, yValue1 = 29 },
                new RangeSelectionChartData { xValue = 1980, yValue = 41, yValue1 = 87 },
                new RangeSelectionChartData { xValue = 1981, yValue = 62, yValue1 = 43 },
                new RangeSelectionChartData { xValue = 1982, yValue = 56, yValue1 = 12 },
                new RangeSelectionChartData { xValue = 1983, yValue = 96, yValue1 = 38 },
                new RangeSelectionChartData { xValue = 1984, yValue = 48, yValue1 = 67 },
                new RangeSelectionChartData { xValue = 1985, yValue = 23, yValue1 = 49 },
                new RangeSelectionChartData { xValue = 1986, yValue = 54, yValue1 = 67 },
                new RangeSelectionChartData { xValue = 1987, yValue = 73, yValue1 = 83 },
                new RangeSelectionChartData { xValue = 1988, yValue = 56, yValue1 = 16 },
                new RangeSelectionChartData { xValue = 1989, yValue = 67, yValue1 = 89 },
                new RangeSelectionChartData { xValue = 1990, yValue = 79, yValue1 = 18 },
                new RangeSelectionChartData { xValue = 1991, yValue = 18, yValue1 = 46 },
                new RangeSelectionChartData { xValue = 1992, yValue = 78, yValue1 = 39 },
                new RangeSelectionChartData { xValue = 1993, yValue = 92, yValue1 = 68 },
                new RangeSelectionChartData { xValue = 1994, yValue = 43, yValue1 = 87 },
                new RangeSelectionChartData { xValue = 1995, yValue = 29, yValue1 = 45 },
                new RangeSelectionChartData { xValue = 1996, yValue = 14, yValue1 = 42 },
                new RangeSelectionChartData { xValue = 1997, yValue = 85, yValue1 = 28 },
                new RangeSelectionChartData { xValue = 1998, yValue = 24, yValue1 = 82 },
                new RangeSelectionChartData { xValue = 1999, yValue = 61, yValue1 = 13 },
                new RangeSelectionChartData { xValue = 2000, yValue = 80, yValue1 = 83 },
                new RangeSelectionChartData { xValue = 2001, yValue = 14, yValue1 = 26 },
                new RangeSelectionChartData { xValue = 2002, yValue = 34, yValue1 = 57 },
                new RangeSelectionChartData { xValue = 2003, yValue = 81, yValue1 = 48 },
                new RangeSelectionChartData { xValue = 2004, yValue = 70, yValue1 = 84 },
                new RangeSelectionChartData { xValue = 2005, yValue = 21, yValue1 = 64 },
                new RangeSelectionChartData { xValue = 2006, yValue = 70, yValue1 = 24 },
                new RangeSelectionChartData { xValue = 2007, yValue = 32, yValue1 = 82 },
                new RangeSelectionChartData { xValue = 2008, yValue = 43, yValue1 = 37 },
                new RangeSelectionChartData { xValue = 2009, yValue = 21, yValue1 = 68 },
                new RangeSelectionChartData { xValue = 2010, yValue = 63, yValue1 = 37 },
                new RangeSelectionChartData { xValue = 2011, yValue = 9 , yValue1 = 35},
                new RangeSelectionChartData { xValue = 2012, yValue = 51, yValue1 = 81 },
                new RangeSelectionChartData { xValue = 2013, yValue = 25, yValue1 = 38 },
                new RangeSelectionChartData { xValue = 2014, yValue = 96, yValue1 = 51 },
                new RangeSelectionChartData { xValue = 2015, yValue = 32, yValue1 = 58 }
            };
            ViewBag.dataSource = chartData;
            ViewBag.data = new string[] { "DragXY", "DragX", "DragY", "Lasso"};
            return View();
        }
        public class RangeSelectionChartData
        {
            public double xValue;
            public double yValue;
            public double yValue1;
        }
    }
}