#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
            ViewData["ModeData"] = new string[] { "Inline", "Popup" };
            string[] data = new string[] { "Australia", "Bermuda", "Canada", "Cameroon", "Denmark", "Finland", "Greenland", "Poland" };
            ViewData["MultiSelectData"] = new { placeholder = "Choose the countries", dataSource = data, mode="Box" };
            ViewData["DropDownData"] = new { placeholder = "Find a country", dataSource = data };
            ViewData["AutoCompleteData"] = new { placeholder = "Type to search country", dataSource = data };
            ViewData["ComboData"] = new { placeholder = "Find a country", dataSource = data };
            return View();
        }
    }
}
