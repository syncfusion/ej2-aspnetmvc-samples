using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        public ActionResult FIFAStatistics()
        {
            return View(FIFAStatisticsData.GetAllRecords());
        }
    }
}
