using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.ListBox
{
    public partial class ListBoxController : Controller
    {
        public ActionResult Api()
        {

            ViewBag.vegetableData = new Vegetables().VegetablesList();

            List<object> sortOrder = new List<object>();
            sortOrder.Add(new { Text = "None"});
            sortOrder.Add(new { Text = "Ascending"});
            sortOrder.Add(new { Text = "Descending" });
            ViewBag.sortOrder = sortOrder;

            List<object> selectionType = new List<object>();
            selectionType.Add(new { Text = "Single" });
            selectionType.Add(new { Text = "Multiple" });
            ViewBag.selectionType = selectionType;
            return View();
        }
    }

}