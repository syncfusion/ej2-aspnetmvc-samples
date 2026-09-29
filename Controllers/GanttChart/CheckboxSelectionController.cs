using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Gantt
{
    public partial class GanttChartController : Controller
    {
        // GET: Gantt
        public ActionResult CheckboxSelection()
        {
            ViewData["dataSource"] = GanttData.HierarchyCheckboxData();
            ViewData["data1"] = DropDownListData.SelectionModeList();
            return View();
        }
        public class DropDownListData
        {
            public string id { get; set; }
            public string type { get; set; }

            public static List<DropDownListData1> SelectionModeList()
            {
                List<DropDownListData1> Data = new List<DropDownListData1>();
                Data.Add(new DropDownListData1 { id = "self", type = "self" });
                Data.Add(new DropDownListData1 { id = "hierarchy", type = "hierarchy" });
                Data.Add(new DropDownListData1 { id = "filteredHierarchy", type = "filteredHierarchy" });
                return Data;
            }
        }

    }
}