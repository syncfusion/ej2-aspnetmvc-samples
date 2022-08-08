using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: SelectionAPI
        public ActionResult SelectionAPI()
        {
            var inventor = InventorDetails.GetAllRecords();
            ViewBag.datasource = inventor;
            return View();
        }
    }
}