using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;


namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        
        public ActionResult Constraints()
        {
            ViewData["DataSource"] = GanttData.ConstraintData();
            return View();
        }
    }
}