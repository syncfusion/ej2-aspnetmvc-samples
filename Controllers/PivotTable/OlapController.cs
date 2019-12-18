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

        public ActionResult Olap()
        {
            ViewBag.filterMembers = new string[] { "[Date].[Fiscal].[Fiscal Quarter].&[2002]&[4]", "[Date].[Fiscal].[Fiscal Year].&[2005]" };
            return View();
        }
    }
}
