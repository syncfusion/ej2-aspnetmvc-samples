using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: AdvancedExporting
        public ActionResult AdvancedExporting()
        {
            var product = Product.GetAllRecords().ToList();
            ViewBag.datasource = product;
            return View();
        }
    }
}