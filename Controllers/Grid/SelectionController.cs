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
        // GET: Selection
        public ActionResult Selection()
        {
            var DataSource = EmployeeView.GetAllRecords();
            ViewBag.dataSource = DataSource;
            ViewBag.type = new string[] { "Single", "Multiple" };
            ViewBag.mode = new string[] { "Row", "Cell", "Both" };
            return View();
        }
    }
}