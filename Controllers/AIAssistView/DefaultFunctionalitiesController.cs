using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> Items = new List<ToolbarItemModel>();
        public ActionResult DefaultFunctionalities()
        {
            Items.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewData["ToolbarItems"] = Items;
            ViewData["PromptResponseData"] = new PromptResponseData().GetAllPromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetAllSuggestionData();
            return View();
        }
    }
}