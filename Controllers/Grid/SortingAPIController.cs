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
        // GET: SortingAPI
        public ActionResult SortingAPI()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            List<object> dd = new List<object>();
            dd.Add(new { text = "Order ID", value = "OrderID" });
            dd.Add(new { text = "Customer Name", value = "CustomerID" });
            dd.Add(new { text = "Order Date", value = "OrderDate" });
            dd.Add(new { text = "Freight", value = "Freight" });

            ViewBag.columns = dd;
            List<object> direction = new List<object>();
            direction.Add(new { text = "Ascending", value = "Ascending" });
            direction.Add(new { text = "Descending", value = "Descending" });

            ViewBag.Direction = direction;
            return View();
        }
    }
}