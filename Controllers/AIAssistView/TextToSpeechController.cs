#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
        public List<ToolbarItemModel> TextToSpeechItems = new List<ToolbarItemModel>();
        public List<ResponseToolbarItemModel> ResponseToolbarItems = new List<ResponseToolbarItemModel>();

        public ActionResult TextToSpeech()
        {
            TextToSpeechItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });

            // Response toolbar items
            ResponseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-copy", tooltip = "Copy" });
            ResponseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-audio", tooltip = "Read Aloud" });
            ResponseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-like", tooltip = "Like" });
            ResponseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-dislike", tooltip = "Need Improvement" });

            ViewData["ToolbarItems"] = TextToSpeechItems;
            ViewData["ResponseToolbarItems"] = ResponseToolbarItems;
            ViewData["PromptsData"] = new List<object>
            {
                new { prompt = "What is AI?", response = "<div>AI stands for Artificial Intelligence, enabling machines to mimic human intelligence for tasks such as learning, problem-solving, and decision-making.</div>", suggestionData = new List<string> { } }
            };

            return View();
        }
    }

    public class ToolbarItemModel
    {
        public string align { get; set; }
        public string iconCss { get; set; }
    }

    public class ResponseToolbarItemModel
    {
        public string type { get; set; }
        public string iconCss { get; set; }
        public string tooltip { get; set; }
    }
}