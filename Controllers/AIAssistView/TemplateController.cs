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
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItem> TemplateItems = new List<ToolbarItem>();
        public ActionResult Template()
        {
            TemplateItems.Add(new ToolbarItem { Type = ItemType.Input, Align = ItemAlign.Right, Template = "<button id=\"ddMenu\"></button>" });
            ViewData["ToolbarItems"] = TemplateItems;

            List<AIAssitCarouselDataBinding> datasrc = new List<AIAssitCarouselDataBinding>();            
            
            datasrc.Add(new AIAssitCarouselDataBinding
            {
                ImgPath = Url.Content("~/Content/carousel/images/moscow.jpg"),
                Suggestion = "How do I prioritize tasks effectively?"
            });
            datasrc.Add(new AIAssitCarouselDataBinding
            {
                ImgPath = Url.Content("~/Content/carousel/images/san-francisco.jpg"),
                Suggestion = "How do I set daily goals in my work day?"
            });
            datasrc.Add(new AIAssitCarouselDataBinding
            {
                ImgPath = Url.Content("~/Content/carousel/images/london.jpg"),
                Suggestion = "Steps to publish a e-book with marketing strategy"
            });
            datasrc.Add(new AIAssitCarouselDataBinding
            {
                ImgPath = Url.Content("~/Content/carousel/images/tokyo.jpg"),
                Suggestion = "What tools or apps can help me prioritize tasks?"
            });
            ViewData["CarouselDataSource"] = datasrc;
            ViewData["PromptResponseData"] = new PromptResponseData().GetTemplatePromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetAllSuggestionData();
            return View();
        }

        public class AIAssitCarouselDataBinding
        {
            public string Suggestion { get; set; }
            public string ImgPath { get; set; }
        }
    }
}