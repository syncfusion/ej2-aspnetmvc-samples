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
        // GET: CheckboxSelection
        public ActionResult CheckboxSelection()
        {
            
            var inventor = InventorDetails.GetAllRecords();
            ViewBag.datasource = inventor;
            return View();
        }
    }
}