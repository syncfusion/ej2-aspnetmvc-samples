#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<AIAssistModel> Items = new List<AIAssistModel>();
        public ActionResult DefaultFunctionalities()
        {
            Items.Add(new AIAssistModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewBag.ToolbarItems = Items;
            return View();
        }
    }
}