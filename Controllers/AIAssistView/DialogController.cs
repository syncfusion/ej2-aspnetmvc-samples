#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<AIAssistModel> DialogItems = new List<AIAssistModel>();
        public ActionResult Dialog()
        {
            DialogItems.Add(new AIAssistModel { align = "Right", iconCss = "e-icons e-close" });
            ViewBag.ToolbarItems = DialogItems;
            return View();
        }

        public class AIAssistModel
        {
            public string type { get; set; }
            public string align { get; set; }
            public string iconCss { get; set; }
        }
    }
}