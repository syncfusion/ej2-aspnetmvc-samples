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
        // GET: Events
        public ActionResult Events()
        {
            var product = Categories.GetAllRecords();
            ViewBag.datasource = product;
            return View();
        }
    }
}