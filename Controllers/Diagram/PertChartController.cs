using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public  partial class DiagramController : Controller
    {
        // GET: PertChart
        public ActionResult PertChart()
        {
            ViewBag.Nodes = pertChartDataDetails.GetAllRecords();
            return View();
        }
    }
}