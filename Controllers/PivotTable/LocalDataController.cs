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

        public ActionResult LocalData()
        {
            ViewData["data"] = new PivotTableData().GetrenewableEnergy();
            ViewData["drilledMembers"] = new string[] { "Biomass", "Free Energy" };
            ViewData["contentTypeDropDown"] = new string[] { "JSON", "CSV" };
            return View();
        }
    }
}
