using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public ActionResult Views()
        {
            ViewData["PromptResponseData"] = new PromptResponseData().GetAllPromptResponseData();
            return View();
        }
    }
}