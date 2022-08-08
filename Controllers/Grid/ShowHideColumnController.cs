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
        // GET: ShowHideColumn
        public ActionResult ShowHideColumn()
        {
            var product = Categories.GetAllRecords().ToList();
            ViewBag.datasource = product;
            List<object> dd = new List<object>();
            dd.Add(new { text = "Category Name", value = "CategoryName" });
            dd.Add(new { text = "Product Name", value = "ProductName" });
            dd.Add(new { text = "Units In Stock", value = "UnitsInStock" });
            dd.Add(new { text = "Discontinued", value = "Discontinued" });
            ViewBag.columns = dd;
            return View();
        }
    }
}