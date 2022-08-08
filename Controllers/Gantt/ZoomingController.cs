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
        // GET: Zooming
        public ActionResult Zooming()
        {
            ViewBag.DataSource = GanttData.ZoomingData();
            return View();
        }
    }
}