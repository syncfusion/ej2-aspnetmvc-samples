#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        // GET: StackedLine
        public ActionResult StackedLine()
        {
            List<StackedChartData> ChartPoints = new List<StackedChartData>
            {
                new StackedChartData { ExpensesCategory= "Jan", JohnExpenses= 90, PeterExpenses= 40, SteveExpenses= 70,  CharleExpenses= 120 },
                new StackedChartData { ExpensesCategory= "Feb", JohnExpenses= 80, PeterExpenses= 90, SteveExpenses= 110, CharleExpenses= 70  },
                new StackedChartData { ExpensesCategory= "Mar", JohnExpenses= 50, PeterExpenses= 80, SteveExpenses= 120, CharleExpenses= 50  },
                new StackedChartData { ExpensesCategory= "Apr", JohnExpenses= 70, PeterExpenses= 30, SteveExpenses= 60,  CharleExpenses= 180 },
                new StackedChartData { ExpensesCategory= "May", JohnExpenses= 30, PeterExpenses= 80, SteveExpenses= 80,  CharleExpenses= 30  },
                new StackedChartData { ExpensesCategory= "Jun", JohnExpenses= 10, PeterExpenses= 40, SteveExpenses= 30,  CharleExpenses= 270 },
                new StackedChartData { ExpensesCategory= "Jul", JohnExpenses= 100,PeterExpenses= 30, SteveExpenses= 70,  CharleExpenses= 40  },
                new StackedChartData { ExpensesCategory= "Aug", JohnExpenses= 55, PeterExpenses= 95, SteveExpenses= 55,  CharleExpenses= 75  },
                new StackedChartData { ExpensesCategory= "Sep", JohnExpenses= 20, PeterExpenses= 50, SteveExpenses= 40,  CharleExpenses= 65  },
                new StackedChartData { ExpensesCategory= "Oct", JohnExpenses= 40, PeterExpenses= 20, SteveExpenses= 80,  CharleExpenses= 95  },
                new StackedChartData { ExpensesCategory= "Nov", JohnExpenses= 45, PeterExpenses= 15, SteveExpenses= 45,  CharleExpenses= 195 },
                new StackedChartData { ExpensesCategory= "Dec", JohnExpenses= 75, PeterExpenses= 45, SteveExpenses= 65,  CharleExpenses= 115 }
            };
            ViewBag.ChartPoints = ChartPoints;
            return View();
        }
        public class StackedChartData
        {
            public string ExpensesCategory;
            public double JohnExpenses;
            public double PeterExpenses;
            public double SteveExpenses;
            public double CharleExpenses;
        }
    }
}