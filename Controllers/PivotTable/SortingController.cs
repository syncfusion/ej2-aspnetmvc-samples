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

        public ActionResult Sorting()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["fieldsData"] = GetFieldsData();
            ViewData["orderData"] = new string[] { "Ascending", "Descending" }; ;
            return View();
        }
        public List<SortData> GetFieldsData()
        {
            List<SortData> fieldsData = new List<SortData>();
            fieldsData.Add(new SortData { Field = "Country", Order = "Country_asc" });
            fieldsData.Add(new SortData { Field = "Products", Order = "Products_asc" });
            fieldsData.Add(new SortData { Field = "Year", Order = "Year_asc" });
            fieldsData.Add(new SortData { Field = "Order Source", Order = "Order Source_asc" });
            return fieldsData;
        }
        public class SortData
        {
            public string Field { get; set; }
            public string Order { get; set; }
        }
    }
}
