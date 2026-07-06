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
        // GET: Chart
        public ActionResult Chart()
        {
            var DataSource = SalesData.GetAllRecords();
            ViewData["dataSource"] = DataSource;
            return View();
        }
    }
}