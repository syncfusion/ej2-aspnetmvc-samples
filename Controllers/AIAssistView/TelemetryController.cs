using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public ActionResult Telemetry()
        {
            toolbarItems.Clear();
            toolbarItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewData["ToolbarItems"] = toolbarItems;
            ViewData["PromptResponseData"] = new PromptResponseData().GetTelemetryPromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetTelemetrySuggestionData();
            return View();
        }
    }
}
