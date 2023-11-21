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
        // GET: InversedRangeColumn
        public ActionResult InversedRangeColumn()
        {
            List<InversedRangeColumnData> ChartPoints = new List<InversedRangeColumnData>
            {
                new InversedRangeColumnData { Month = "Jan", CA_LowTemp = 28, CA_HighTemp = 72, Text = "January", CO_LowTemp = 38, CO_HighTemp = 78 },
                new InversedRangeColumnData { Month = "Feb", CA_LowTemp = 25, CA_HighTemp = 75, Text = "February", CO_LowTemp = 38, CO_HighTemp = 78 },
                new InversedRangeColumnData { Month = "Mar", CA_LowTemp = 18, CA_HighTemp = 65, Text = "March", CO_LowTemp = 27, CO_HighTemp = 78 },
                new InversedRangeColumnData { Month = "Apr", CA_LowTemp = 22, CA_HighTemp = 69, Text = "April", CO_LowTemp = 38, CO_HighTemp = 78 },
                new InversedRangeColumnData { Month = "May", CA_LowTemp = 56, CA_HighTemp = 87, Text = "May", CO_LowTemp = 28, CO_HighTemp = 79 },
                new InversedRangeColumnData { Month = "Jun", CA_LowTemp = 48, CA_HighTemp = 75, Text = "June", CO_LowTemp = 38, CO_HighTemp = 78 },
                new InversedRangeColumnData { Month = "Jul", CA_LowTemp = 40, CA_HighTemp = 78, Text = "July", CO_LowTemp = 37, CO_HighTemp = 66 },
                new InversedRangeColumnData { Month = "Aug", CA_LowTemp = 35, CA_HighTemp = 73, Text = "August", CO_LowTemp = 38, CO_HighTemp = 78 },
                new InversedRangeColumnData { Month = "Sep", CA_LowTemp = 43, CA_HighTemp = 64, Text = "September", CO_LowTemp = 25, CO_HighTemp = 52 },
                new InversedRangeColumnData { Month = "Oct", CA_LowTemp = 38, CA_HighTemp = 77, Text = "October", CO_LowTemp = 38, CO_HighTemp = 78 },
                new InversedRangeColumnData { Month = "Nov", CA_LowTemp = 28, CA_HighTemp = 54, Text = "November", CO_LowTemp = 20, CO_HighTemp = 60 },
                new InversedRangeColumnData { Month = "Dec", CA_LowTemp = 29, CA_HighTemp = 56, Text = "December", CO_LowTemp = 20, CO_HighTemp = 60 }
            };
            ViewBag.ChartPoints = ChartPoints;
            return View();
        }
        public class InversedRangeColumnData
        {
            public string Month;
            public double CA_LowTemp;
            public double CA_HighTemp;
            public string Text;
            public double CO_LowTemp;
            public double CO_HighTemp;
        }
    }
}