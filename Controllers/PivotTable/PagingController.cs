using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.PivotView;
using EJ2MVCSampleBrowser.Models;


namespace EJ2MVCSampleBrowser.Controllers.PivotView
{
    public partial class PivotTableController : Controller
    {

        public ActionResult Paging()
        {
            ViewData["pagerPositions"] = new string[] { "Top", "Bottom" };
            ViewData["pageSizes"] = new string[] { "Row", "Column", "Both", "None" };
            ViewData["pagerViewData"] = new string[] { "Row", "Column", "Both" };
            return View();
        }
    }
}
