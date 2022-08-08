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
        // GET: FilterMenu
        public ActionResult FilterMenu()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            ViewBag.filterType = new string[] { "Menu", "Excel", "CheckBox" };
            return View();
        }
    }
}