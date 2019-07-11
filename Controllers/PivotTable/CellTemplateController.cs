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

        public ActionResult CellTemplate()
        {
            ViewBag.data = new PivotTableData().GetrenewableEnergy();
            ViewBag.drilledMembers = new string[] { "FY 2015", "FY 2017", "FY 2018" };
            return View();
        }
    }
}
