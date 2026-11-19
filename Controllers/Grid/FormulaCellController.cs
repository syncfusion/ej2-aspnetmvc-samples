using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: FormulaCell
        public ActionResult FormulaCell()
        {

            var data = FormulaData.GetData();
            ViewData["dataSource"] = data;
            return View();
        }
    }
}