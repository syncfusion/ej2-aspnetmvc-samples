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

namespace EJ2MVCSampleBrowser.Controllers.Sparkline
{
    public partial class SparklineController : Controller
    {
        // GET: Layout
        public ActionResult Layout()
        {
            ViewData["lineData"] = LineData.GetLineData();
            ViewData["areaData"] = LineData.GetArea();
            ViewData["winlossData"] = LineData.getWinloss();
            ViewData["pieData"] = LineData.getPieData();
            return View();
        }
        public class LineData
        {
            public int x;
            public int y;
            public string xval;
            public double yval, yval1;
            
            public static List<LineData> GetLineData()
            {
                List<LineData> linedata = new List<LineData>();
                linedata.Add(new LineData() { x = 1,  y = 5  });
                linedata.Add(new LineData() { x = 2,  y = 6  });
                linedata.Add(new LineData() { x = 3,  y = 5  });
                linedata.Add(new LineData() { x = 4,  y = 7  });
                linedata.Add(new LineData() { x = 5,  y = 4  });
                linedata.Add(new LineData() { x = 6,  y = 3  });
                linedata.Add(new LineData() { x = 7,  y = 9  });
                linedata.Add(new LineData() { x = 8,  y = 5  });
                linedata.Add(new LineData() { x = 9,  y = 6  });
                linedata.Add(new LineData() { x = 10, y = 5  });
                linedata.Add(new LineData() { x = 11, y = 7  });
                linedata.Add(new LineData() { x = 12, y = 8  });
                linedata.Add(new LineData() { x = 13, y = 4  });
                linedata.Add(new LineData() { x = 14, y = 5  });
                linedata.Add(new LineData() { x = 15, y = 3  });
                linedata.Add(new LineData() { x = 16, y = 4  });
                linedata.Add(new LineData() { x = 17, y = 11 });
                linedata.Add(new LineData() { x = 18, y = 10 });
                linedata.Add(new LineData() { x = 19, y = 2  });
                linedata.Add(new LineData() { x = 20, y = 12 });
                linedata.Add(new LineData() { x = 21, y = 4  });
                linedata.Add(new LineData() { x = 22, y = 7  });
                linedata.Add(new LineData() { x = 23, y = 6  });
                linedata.Add(new LineData() { x = 24, y = 8 });
                return linedata;
            }
            public static List<LineData> GetArea()
            {
                List<LineData> areadata = new List<LineData>();
                areadata.Add(new LineData() { xval = "Jan", yval = 34 , yval1 = 10 });
                areadata.Add(new LineData() { xval = "Feb", yval = 36  , yval1 = 6  });
                areadata.Add(new LineData() { xval = "Mar", yval = 32  , yval1 = 8  });
                areadata.Add(new LineData() { xval = "Apr", yval = 35, yval1 = -5 });
                areadata.Add(new LineData() { xval = "May", yval = 40  , yval1 = 11 });
                areadata.Add(new LineData() { xval = "Jun", yval = 38  , yval1 = 5  });
                areadata.Add(new LineData() { xval = "Jul", yval = 33  , yval1 = -2 });
                areadata.Add(new LineData() { xval = "Aug", yval = 37 , yval1 = 7  });
                areadata.Add(new LineData() { xval = "Sep", yval = 34 , yval1 = -3 });
                areadata.Add(new LineData() { xval = "Oct", yval = 31 , yval1 = 6  });
                areadata.Add(new LineData() { xval = "Nov", yval = 30  , yval1 = 8  });
                areadata.Add(new LineData() { xval = "Dec", yval = 29  , yval1 = 10 });
                return areadata;
            }

            public static List<LineData> getWinloss()
            {
                List<LineData> winloss = new List<LineData>();
                winloss.Add(new LineData() { x = 1, y = 12 });
                winloss.Add(new LineData() { x = 2, y = 15 });
                winloss.Add(new LineData() { x = 3, y = -10 });
                winloss.Add(new LineData() { x = 4, y = 13 });
                winloss.Add(new LineData() { x = 5, y = 15 });
                winloss.Add(new LineData() { x = 6, y = 6 });
                winloss.Add(new LineData() { x = 7, y = -12 });
                winloss.Add(new LineData() { x = 8, y = 17 });
                winloss.Add(new LineData() { x = 9, y = 13 });
                winloss.Add(new LineData() { x = 10, y = 0});
                winloss.Add(new LineData() { x = 11, y = 8});
                winloss.Add(new LineData() { x = 12, y = -10});
                return winloss;
            }

            public static List<LineData> getPieData()
            {
                List<LineData> piedata = new List<LineData>();
                piedata.Add(new LineData() { xval = "Gold"  , yval = 46, yval1 = 27, x = 26, y = 19 });
                piedata.Add(new LineData() { xval = "Silver", yval = 37, yval1 = 23, x = 18, y = 17 });
                piedata.Add(new LineData() { xval = "Bronze", yval = 38, yval1 = 17, x = 26, y = 19 });
                return piedata;
            }
        }
    }
}