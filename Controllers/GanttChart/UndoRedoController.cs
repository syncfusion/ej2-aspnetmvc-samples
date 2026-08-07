using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: UndoRedo
        public ActionResult UndoRedo()
        {
            ViewData["DataSource"] = GanttData.EditingData();
            return View();
        }
    }
}