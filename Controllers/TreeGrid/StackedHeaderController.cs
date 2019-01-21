using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using static EJ2MVCSampleBrowser.Models.TreeGridItems;

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult StackedHeader()
        {
            var treeData = ShipmentData.GetShipmentData();
            ViewBag.datasource = treeData;
            return View();
        }
    }
}