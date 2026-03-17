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
        // GET: AxesCrossing
        public ActionResult AxesCrossing()
        {
            List<AxesCrossingData> LinePoints = new List<AxesCrossingData>
            {
                new AxesCrossingData { XValue = -6,     YValue = 2      },
                new AxesCrossingData { XValue = -5,     YValue = 0      },
                new AxesCrossingData { XValue = -4.511, YValue = -0.977 },
                new AxesCrossingData { XValue = -3,     YValue = -4     },
                new AxesCrossingData { XValue = -1.348, YValue = -1.247 },
                new AxesCrossingData { XValue = -0.6,   YValue = 0      },
                new AxesCrossingData { XValue = 0,      YValue = 1      },
                new AxesCrossingData { XValue = 1.5,    YValue = 3.5    },
                new AxesCrossingData { XValue = 6,      YValue = 4.5    }
             };
            List<AxesCrossingData> SplinePoints = new List<AxesCrossingData>
            {
                new AxesCrossingData { XValue = -6,    YValue = 2      },
                new AxesCrossingData { XValue = -5.291,YValue = 0      },
                new AxesCrossingData { XValue = -5,    YValue = -0.774 },
                new AxesCrossingData { XValue = -3,    YValue = -4     },
                new AxesCrossingData { XValue = -0.6,  YValue = -0.965 },
                new AxesCrossingData { XValue = -0.175,YValue = 0.1    },
                new AxesCrossingData { XValue = 0,     YValue = 0.404  },
                new AxesCrossingData { XValue = 1.5,   YValue = 3.5    },
                new AxesCrossingData { XValue = 3.863, YValue = 5.163  },
                new AxesCrossingData { XValue = 6,     YValue = 4.5    }
             };
            List<AxesCrossingData> ScatterPoints = new List<AxesCrossingData>
            {
                new AxesCrossingData { XValue = -6,  YValue = 2   },
                new AxesCrossingData { XValue = -3,  YValue = -4  },
                new AxesCrossingData { XValue = 1.5, YValue = 3.5 },
                new AxesCrossingData { XValue = 6,   YValue = 4.5 }               
             };
            ViewData["LinePoints"] = LinePoints;
            ViewData["SplinePoints"] = SplinePoints;
            ViewData["ScatterPoints"] = ScatterPoints;
            ViewData["data"] = new string[] { "X", "Y" };
            return View();
        }
        public class AxesCrossingData
        {
            public double XValue;
            public double YValue;
        }
    }
}