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
      
        List<clickTypes> type = new List<clickTypes>(); 
        public ActionResult DefaultFunctionalities()
        {
            ViewData["ModeData"] = new string[] { "Inline", "Popup" };
            type.Add(new clickTypes { Id = "Click", ClickType = "Click" });
            type.Add(new clickTypes { Id = "DblClick", ClickType = "Double Click" });
            type.Add(new clickTypes { Id = "EditIconClick", ClickType = "Edit Icon Click" });
            ViewData["ModalData"] = new { placeholder = "Enter employee name" };
            ViewData["MaskData"] = new { mask = "000-000-0000" };
            ViewData["NumericData"] = new { placeholder = "Currency format", value = 100, format = "c2" };
            ViewData["ClickData"] = type;
            return View();
        }
    }
    public class clickTypes
    {
        public string Id { get; set; }
        public string ClickType { get; set; }

    }
}
