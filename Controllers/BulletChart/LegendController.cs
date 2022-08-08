using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.BulletChart
{
    public partial class BulletChartController : Controller
    {
        // GET: Legend
        public ActionResult Legend()
        {
            List<LegendBulletData> bulletData1 = new List<LegendBulletData>
            {
                new LegendBulletData { value = 25, target = new double[]{ 20, 26, 28 } }
            };

            ViewBag.dataSource = bulletData1;
            return View();
        }
        public class LegendBulletData
        {
            public double value;
            public double[] target;
        }
    }
}