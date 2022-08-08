using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.BulletChart
{
    public partial class BulletChartController : Controller
    {
        // GET: Tooltip
        public ActionResult Tooltip()
        {
            List<TooltipData> bulletData1 = new List<TooltipData>
            {
                new TooltipData { value = 70, target = 50}
            };

            ViewBag.dataSource = bulletData1;
            return View();
        }
        public class TooltipData
        {
            public double value;
            public double target;
        }
    }
}