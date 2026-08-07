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
        // GET: BaselineTemplate
        public ActionResult BaselineTemplate()
        {
            ViewData["DataSource"] = GanttData.BaselineTemplateData();
            return View();
        }
    }
}