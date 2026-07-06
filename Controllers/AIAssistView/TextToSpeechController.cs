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
            ResponseToolbarItems.Add(new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-audio", tooltip = "Read Aloud" });
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

    public class ResponseToolbarItemModel
    {
        public string type { get; set; }
        public string iconCss { get; set; }
        public string tooltip { get; set; }
    }
}