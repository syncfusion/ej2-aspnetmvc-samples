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

        List<FilterValue> filterValue = new List<FilterValue>();
        public ActionResult Filtering()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["typeData"] = new string[] { "Include", "Exclude" }; ;
            ViewData["fieldsData"] = new string[] { "Country", "Products", "Year" };
            ViewData["filterValue"] = filterValue;
            return View();
        }
        public class FilterValue
        {
            public string Member { get; set; }
        }
    }
}
