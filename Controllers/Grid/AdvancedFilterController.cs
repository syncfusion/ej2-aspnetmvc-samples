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
        // GET: AdvancedFilter
        public ActionResult AdvancedFilter()
        {

            var tickets = Tickets.GetAllTickets();
            ViewData["dataSource"] = tickets;
            return View();
        }
    }
}