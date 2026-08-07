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
                new { id = "openai", name = "GPT-4o-mini(Azure)" },
                new { id = "gemini", name = "Gemini 2.5 Flash" },
                new { id = "deepseek", name = "DeepSeek-R1" }
            };

            ViewData["Models"] = models;
            ViewData["SelectedModel"] = "openai";
            ViewData["Suggestions"] = new string[] {  "What are the best tools for organizing tasks?",
                "How can I maintain work-life balance?" };

            return View();
        }
    }
}