#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> DialogItems = new List<ToolbarItemModel>();
        public ActionResult Dialog()
        {
            DialogItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-close" });
            ViewData["ToolbarItems"] = DialogItems;
            ViewData["PromptResponseData"] = new PromptResponseData().GetAllPromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetAllSuggestionData();
            return View();
        }

        public class ToolbarItemModel
        {
            public string type { get; set; }
            public string align { get; set; }
            public string iconCss { get; set; }
        }
    }
}