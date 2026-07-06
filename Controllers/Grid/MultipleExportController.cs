using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller {
            // GET: MultipleExport
            public ActionResult MultipleExport()
            {
                ViewData["dataSource"] = OrdersDetails.GetAllRecords();
                ViewData["CustomerDataSource"] = Customer.GetAllRecords();
                return View();
            }
    }

}