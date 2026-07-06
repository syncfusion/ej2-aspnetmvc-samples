using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public ActionResult GeminiClone()
        {
            var footerToolbarItems = new List<ToolbarItemModel>()
            {
                new ToolbarItemModel { iconCss = "e-icons e-assist-attachment-icon", align = "Left" },
                new ToolbarItemModel { align = "Right", template = "<button id='custombtn'>Fast</button>" },
                new ToolbarItemModel { iconCss = "e-icons e-assist-speech-to-text", align = "Right" }
            };

            ViewData["FooterToolbarItems"] = footerToolbarItems;
            ViewData["PromptResponseData"] = new PromptResponseData().GetAllPromptResponseData();
            return View();
        }
    }
}
