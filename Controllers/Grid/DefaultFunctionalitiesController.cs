using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DefaultFunctionalities()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            return View();
        }
    }
}