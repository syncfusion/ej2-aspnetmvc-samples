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
            public string tooltip { get; set; }
            public string cssClass { get; set; }
            public string text { get; set; }
            public string template { get; set; }
            public bool visible { get; set; }
        }
    }
}