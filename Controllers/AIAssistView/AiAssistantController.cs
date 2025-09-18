#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Xml;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItem> AssistantTemplateItems = new List<ToolbarItem>();
        public ActionResult AiAssistant()
        {
            var listTemplate = "<div class='chat-item'>"
                       + "<div class='chat-title'>${text}</div>"
                       + "</div>";
            AssistantTemplateItems.Add(new ToolbarItem { Type = ItemType.Input, Align = ItemAlign.Right, Template = "<button id=\"ddMenu\"></button>" });
            ViewData["ToolbarItems"] = AssistantTemplateItems;
            ViewData["PromptResponseData"] = new PromptResponseData().GetAssistantPromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetAssistantSuggestionData();
            ViewData["ListTemplate"] = listTemplate;
            return View();
        }
    }
}