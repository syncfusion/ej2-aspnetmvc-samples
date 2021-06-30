using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: Adaptive
        public ActionResult Adaptive()
        {
            var order = OrdersDetails.GetRecords();
            ViewBag.datasource = order;
            return View();
        }
    }
}