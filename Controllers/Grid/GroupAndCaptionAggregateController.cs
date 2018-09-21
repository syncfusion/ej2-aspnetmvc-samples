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
        // GET: GroupAndCaptionAggregate
        public ActionResult GroupAndCaptionAggregate()
        {
            var DataSource = Product.GetAllRecords();
            ViewBag.dataSource = DataSource;
            return View();
        }
    }
}