#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public ActionResult AIModels()
        {
            var models = new[]
            {
                new { id = "gemini", name = "Gemini 2.5 Flash" },
                new { id = "deepseek", name = "DeepSeek-R1" },
                new { id = "openai", name = "GPT-4o-mini(Azure)" }
            };

            ViewData["Models"] = models;
            ViewData["SelectedModel"] = "openai";
            ViewData["Suggestions"] = new string[] {  "What are the best tools for organizing tasks?",
                "How can I maintain work-life balance?" };

            return View();
        }
    }
}