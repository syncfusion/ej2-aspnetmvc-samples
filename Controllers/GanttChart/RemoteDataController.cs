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
        // GET: RemoteData
        public ActionResult RemoteData()
        {
            ViewData["DataSource"] = GanttData.RemoteData();
            return View();
        }
    }
}