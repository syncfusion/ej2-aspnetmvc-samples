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

namespace EJ2MVCSampleBrowser.Controllers
{
    
    public partial class DashboardLayoutController : Controller
    {
        public class spacingModel
        {
            public double[] cellSpacing { get; set; }

        }
        public class SplineAreaChartData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
            public double yValue2;
        }
        public class PieData
        {
            public string x;
            public double y;
            public string text;
        }

        public class LineData
        {
            public string x;
            public double y;
        }

        public class SplineData
        {
            public DateTime x;
            public double y;
        }
        public ActionResult EditableLayout()
        {
            List<PieData> pieChartData = new List<PieData>
            {
                new PieData {
                    x = "Jan",
                    y = 12.5,
                    text = "January"
                },
                new PieData {
                    x = "Feb",
                    y = 25,
                    text = "February"
                },
                new PieData {
                    x = "Mar",
                    y = 50,
                    text = "March"
                }
            };
            ViewData["pieSource"] = pieChartData;
            List<LineData> LineChartData = new List<LineData>
            {
                new LineData {
                    x = "Jan",
                    y = 37,
                },
                new LineData {
                    x = "Feb",
                    y = 23,
                },
                new LineData {
                    x = "Mar",
                    y = 18,
                }
            };
            ViewData["lineSource"] = LineChartData;
            List<LineData> LineChartData1 = new List<LineData>
            {
                new LineData {
                    x = "Jan",
                    y = 46,
                },
                new LineData {
                    x = "Feb",
                    y = 27,
                },
                new LineData {
                    x = "Mar",
                    y = 26,
                }
            };
            ViewData["lineSource1"] = LineChartData1;
            List<LineData> LineChartData2 = new List<LineData>
            {
                new LineData {
                    x = "Jan",
                    y = 38,
                },
                new LineData {
                    x = "Feb",
                    y = 17,
                },
                new LineData {
                    x = "Mar",
                    y = 26,
                }
            };
            ViewData["lineSource2"] = LineChartData2;
            ViewData["pallets"] = new string[] { "#00bdae", "#357cd2", "#e56691" };
            List<SplineData> SplineChartData1 = new List<SplineData>
            {
                new SplineData { x =  new DateTime(2002, 1, 1), y =  2.2 }, new SplineData { x =  new DateTime(2003, 1, 1), y =  3.4 },
                new SplineData { x =  new DateTime(2004, 1, 1), y =  2.8 }, new SplineData { x =  new DateTime(2005, 1, 1), y =  1.6 },
                new SplineData { x =  new DateTime(2006, 1, 1), y =  2.3 }, new SplineData { x =  new DateTime(2007, 1, 1), y =  2.5 },
                new SplineData { x =  new DateTime(2008, 1, 1), y =  2.9 }, new SplineData { x =  new DateTime(2009, 1, 1), y =  3.8 },
                new SplineData { x =  new DateTime(2010, 1, 1), y =  1.4 }, new SplineData { x = new DateTime(2011, 1, 1), y =  3.1 }
            };
            ViewData["splineSource1"] = SplineChartData1;
            List<SplineData> SplineChartData2 = new List<SplineData>
            {
                new SplineData { x =  new DateTime(2002, 1, 1), y =  2 }, new SplineData { x =  new DateTime(2003, 1, 1), y =  1.7 },
                new SplineData { x =  new DateTime(2004, 1, 1), y =  1.8 }, new SplineData { x =  new DateTime(2005, 1, 1), y =  2.1 },
                new SplineData { x =  new DateTime(2006, 1, 1), y =  2.3 }, new SplineData { x =  new DateTime(2007, 1, 1), y =  1.7 },
                new SplineData { x =  new DateTime(2008, 1, 1), y =  1.5 }, new SplineData { x =  new DateTime(2009, 1, 1), y =  2.8 },
                new SplineData { x =  new DateTime(2010, 1, 1), y =  1.5 }, new SplineData { x = new DateTime(2011, 1, 1), y =  2.3 }
            };
            ViewData["splineSource2"] = SplineChartData2;
            List<SplineAreaChartData> chartData = new List<SplineAreaChartData>
            {
                new SplineAreaChartData { xValue = new DateTime(2002, 01, 01), yValue = 2.2, yValue1 = 2, yValue2 = 0.8  },
                new SplineAreaChartData { xValue = new DateTime(2003, 01, 01), yValue = 3.4, yValue1 = 1.7, yValue2 = 1.3 },
                new SplineAreaChartData { xValue = new DateTime(2004, 01, 01), yValue = 2.8, yValue1 = 1.8, yValue2 = 1.1 },
                new SplineAreaChartData { xValue = new DateTime(2005, 01, 01), yValue = 1.6, yValue1 = 2.1, yValue2 = 1.6 },
                new SplineAreaChartData { xValue = new DateTime(2006, 01, 01), yValue = 2.3, yValue1 = 2.3, yValue2 = 2 },
                new SplineAreaChartData { xValue = new DateTime(2007, 01, 01), yValue = 2.5, yValue1 = 1.7, yValue2 = 1.7 },
                new SplineAreaChartData { xValue = new DateTime(2008, 01, 01), yValue = 2.9, yValue1 = 1.5, yValue2 = 2.3 },
                new SplineAreaChartData { xValue = new DateTime(2009, 01, 01), yValue = 3.8, yValue1 = 2.8, yValue2 = 2.7 },
                new SplineAreaChartData { xValue = new DateTime(2010, 01, 01), yValue = 1.4, yValue1 = 1.5, yValue2 = 1.1 },
                new SplineAreaChartData { xValue = new DateTime(2011, 01, 01), yValue = 3.1, yValue1 = 2.3, yValue2 = 2.3 },
            };
            ViewData["dataSource"] = chartData;
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            return View(modelValue);
        }
    }
}