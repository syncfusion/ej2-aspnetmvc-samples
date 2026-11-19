using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public ActionResult Overview()
        {
            var toolbarItems = new List<ToolbarItemModel>();
            var footerToolbarItems = new List<ToolbarItemModel>();
            var responseToolbarItems = new List<ResponseToolbarItemModel>();

            var promptResponseData = new PromptResponseData().GetOverviewPromptResponseData();
            var promptSuggestionData = new string[] { "How do I plan my day for maximum focus?", "Generate content ideas for my website" };

            toolbarItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh", tooltip = "Start new chat" });

            footerToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-assist-send", align = "Right" });
            footerToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-assist-attachment-icon", align = "Left", tooltip = "Attach File" });
            footerToolbarItems.Add(new ToolbarItemModel { iconCss = "e-icons e-assist-speech-to-text", align = "Left" });

            responseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-copy", tooltip = "Copy" });
            responseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-like", tooltip = "Like" });
            responseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-dislike", tooltip = "Need Improvement" });
            responseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-audio", tooltip = "Read Aloud" });
            responseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-regenerate", tooltip = "Regenerate" });

            ViewData["ToolbarItems"] = toolbarItems;
            ViewData["FooterToolbarItems"] = footerToolbarItems;
            ViewData["ResponseToolbarItems"] = responseToolbarItems;
            ViewData["PromptResponseData"] = promptResponseData;
            ViewData["PromptSuggestionData"] = promptSuggestionData;

            return View();
        }
    }
}