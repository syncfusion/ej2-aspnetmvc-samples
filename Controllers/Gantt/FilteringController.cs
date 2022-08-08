using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttController : Controller
    {
        // GET: Filtering
        public ActionResult Filtering()
        {
            ViewBag.DataSource = GanttData.FilteredData();
            return View();
        }
    }
}