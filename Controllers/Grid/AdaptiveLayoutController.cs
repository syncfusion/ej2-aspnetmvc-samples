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
        // GET: Adaptive Layout
        public ActionResult AdaptiveLayout()
        {
            var order = OrdersDetails.GetRecords();
            ViewData["datasource"] = order;
            return View();
        }
    }
}