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
            List<InversedRangeColumnData> chartData = new List<InversedRangeColumnData>
            {
                new InversedRangeColumnData { x= "Jul", low= 28, high= 72 },
                new InversedRangeColumnData { x= "Aug", low= 18, high= 65 }, 
                new InversedRangeColumnData { x= "Sep", low= 56, high= 87 },
                new InversedRangeColumnData { x= "Oct", low= 40, high= 78 },
                new InversedRangeColumnData { x= "Nov", low= 43, high= 64 }, 
                new InversedRangeColumnData { x= "Dec", low= 28, high= 54 }
            };
            ViewBag.dataSource = chartData;
            List<InversedRangeColumnData> chartData1 = new List<InversedRangeColumnData>
            {
                    new InversedRangeColumnData { x= "Jul", low= 38, high= 78 },
                    new InversedRangeColumnData { x= "Aug", low= 27, high= 78 },
                    new InversedRangeColumnData { x= "Sep", low= 28, high= 79 },
                    new InversedRangeColumnData { x= "Oct", low= 37, high= 66 },
                    new InversedRangeColumnData { x= "Nov", low= 25, high= 52 },
                    new InversedRangeColumnData { x= "Dec", low= 20, high= 60 }
            };
            ViewBag.dataSource1 = chartData1;
            return View();
        }
        public class InversedRangeColumnData
        {
            public string x;
            public double low;
            public double high;
        }
    }
}