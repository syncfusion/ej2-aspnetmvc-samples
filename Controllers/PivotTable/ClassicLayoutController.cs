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

        public ActionResult ClassicLayout()
        {
            ViewData["data"] = new PivotTableData().GetPivot_Data();
            ViewData["drilledMembers"] = new string[] { "Accessories", "Bikes" };
            ViewData["drilledMembersProducts"] = new string[] { "Accessories##Helmets" };
            ViewData["filtersettings"] = new string[] { "Cleaners", "Fenders" };
            return View();
        }
    }
}
