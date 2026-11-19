using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> GenerativeUIItems = new List<ToolbarItemModel>();

        public ActionResult GenerativeUI()
        {
            GenerativeUIItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh", tooltip = "Start new chat" });

            ViewData["ToolbarItems"] = GenerativeUIItems;
            ViewData["PromptSuggestionData"] = PromptResponseData.GenerativeSuggestions;
            ViewData["BlockData"] = new PromptResponseData().GetGenerativeUIBlockData();

            return View();
        }
    }
}
