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

        public ActionResult ConditionalFormatting()
        {
            ViewBag.data = new PivotTableData().GetPivot_Data();
            ViewBag.drilledMembers = new string[] { "France", "Germany" };
            return View();
        }
    }
}
