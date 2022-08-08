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
        // GET: Orientation
        public ActionResult Orientation()
        {
            List<OrientationBulletData> bulletData1 = new List<OrientationBulletData>
            {
                new OrientationBulletData { value = 270, target = 250}     
            };
            ViewBag.dataSource = bulletData1;
            return View();
        }
        public class OrientationBulletData
        {           
            public double value;
            public double target;
        }
    }
}