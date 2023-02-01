#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
        // GET: AxesCrossing
        public ActionResult AxesCrossing()
        {
            List<AxesCrossingData1> chartData1 = new List<AxesCrossingData1>
            {
                new AxesCrossingData1 { x = -6,     y = 2      },
                new AxesCrossingData1 { x = -5,     y = 0.1      },
                new AxesCrossingData1 { x = -4.511, y = -0.977 },
                new AxesCrossingData1 { x = -3,     y = -4     },
                new AxesCrossingData1 { x = -1.348, y = -1.247 },
                new AxesCrossingData1 { x = -0.6,   y = 0.1      },
                new AxesCrossingData1 { x = 0.1,      y = 1      },
                new AxesCrossingData1 { x = 1.5,    y = 3.5    },
                new AxesCrossingData1 { x = 6,      y = 4.5    }
             };
            List<AxesCrossingData2> chartData2 = new List<AxesCrossingData2>
            {
                new AxesCrossingData2 { x = -6,    y = 2      },
                new AxesCrossingData2 { x = -5.291,y = 0.1      },
                new AxesCrossingData2 { x = -5,    y = -0.774 },
                new AxesCrossingData2 { x = -3,    y = -4     },
                new AxesCrossingData2 { x = -0.6,  y = -0.965 },
                new AxesCrossingData2 { x = -0.175,y = 0.1      },
                new AxesCrossingData2 { x = 0.1,     y = 0.404  },
                new AxesCrossingData2 { x = 1.5,   y = 3.5    },
                new AxesCrossingData2 { x = 3.863, y = 5.163  },
                new AxesCrossingData2 { x = 6,     y = 4.5    }
             };
            List<AxesCrossingData3> chartData3 = new List<AxesCrossingData3>
            {
                new AxesCrossingData3 { x = -6,  y = 2   },
                new AxesCrossingData3 { x = -3,  y = -4  },
                new AxesCrossingData3 { x = 1.5, y = 3.5 },
                new AxesCrossingData3 { x = 6,   y = 4.5 }               
             };
            ViewBag.dataSource1 = chartData1;
            ViewBag.dataSource2 = chartData2;
            ViewBag.dataSource3 = chartData3;
            ViewBag.data = new string[] { "X", "Y" };
            return View();
        }
        public class AxesCrossingData1
        {
            public double x;
            public double y;
        }
        public class AxesCrossingData2
        {
            public double x;
            public double y;
        }
        public class AxesCrossingData3
        {
            public double x;
            public double y;
        }
    }
}