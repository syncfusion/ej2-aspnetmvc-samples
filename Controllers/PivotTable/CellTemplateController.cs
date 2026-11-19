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
            ViewData["data"] = new PivotTableData().GetrenewableEnergy();
            ViewData["drilledMembers"] = new string[] { "FY 2022", "FY 2023", "FY 2024" };
            return View();
        }
    }
}
