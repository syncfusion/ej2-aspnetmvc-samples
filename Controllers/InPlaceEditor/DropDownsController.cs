using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.InPlaceEditor
{
    
    public partial class InPlaceEditorController : Controller
    {
        public ActionResult DropDowns()
        {
            ViewBag.ModeData = new string[] { "Inline", "Popup" };
            string[] data = new string[] { "Australia", "Bermuda", "Canada", "Cameroon", "Denmark", "Finland", "Greenland", "Poland" };
            ViewBag.MultiSelectData = new { placeholder = "Choose the countries", dataSource = data, mode="Box" };
            ViewBag.DropDownData = new { placeholder = "Find a country", dataSource = data };
            ViewBag.AutoCompleteData = new { placeholder = "Type to search country", dataSource = data };
            ViewBag.ComboData = new { placeholder = "Find a country", dataSource = data };
            return View();
        }
    }
}
