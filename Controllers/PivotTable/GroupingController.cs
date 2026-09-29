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

        public ActionResult Grouping()
        {
            ViewData["selectedGroups"] = new string[] { "Years", "Months", "Days" };
            ViewData["groupData"] = new string[] { "Years", "Quarters", "Months", "Days" };
            return View();
        }
    }
}
