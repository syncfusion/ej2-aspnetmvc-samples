using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> toolbarItems = new List<ToolbarItemModel>();
        public ActionResult Streaming()
        {
            toolbarItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewData["ToolbarItems"] = toolbarItems;
            ViewData["PromptResponseData"] = new PromptResponseData().GetStreamingPromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetStreamingSuggestionData();
            return View();
        }
    }
}