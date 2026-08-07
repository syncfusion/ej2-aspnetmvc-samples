using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DropDownListController : Controller
    {
        public ActionResult DataBinding()
        {
            ViewData["localdata"] = new GameList().GameLists();
            ViewData["sort"] = "Ascending";
            ViewData["query"] = "new ej.data.Query().select(['FirstName', 'EmployeeID']).take(10).requiresCount()";
            return View();
        }
    }
}