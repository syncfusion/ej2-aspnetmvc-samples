using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public ActionResult Thinking()
        {
            string[] promptSuggestions = new string[]
            {
                "Suggest ways to improve decision making",
                "Explain how climate change affects everyday life"
            };
            ViewData["PromptSuggestionData"] = promptSuggestions;
            return View();
        }
    }
}
