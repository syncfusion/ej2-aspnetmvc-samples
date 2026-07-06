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

        public ActionResult LabelFiltering()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["filterFields"] = new string[] { "Country", "Products", "Year" };
            ViewData["filterOperators"] = new string[] { "Equals", "DoesNotEquals", "BeginWith", "DoesNotBeginWith", "EndsWith",
                "DoesNotEndsWith", "Contains", "DoesNotContains", "GreaterThan",
                "GreaterThanOrEqualTo", "LessThan", "LessThanOrEqualTo", "Between", "NotBetween" };
            return View();
        }
    }
}
