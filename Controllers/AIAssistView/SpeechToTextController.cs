using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> SpeechToTextItems = new List<ToolbarItemModel>();
        public ActionResult SpeechToText()
        {
            SpeechToTextItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            var footerToolbarItems = new List<ToolbarItemModel>()
            {
                new ToolbarItemModel { iconCss = "e-icons e-assist-send", align = "Right" },
                new ToolbarItemModel { iconCss = "e-icons e-assist-attachment-icon", align = "Left", tooltip = "Attach File" },
                new ToolbarItemModel { iconCss = "e-icons e-assist-speech-to-text", align = "Left" }
            };

            ViewData["FooterToolbarItems"] = footerToolbarItems;
            ViewData["ToolbarItems"] = SpeechToTextItems;
            return View();
        }
    }
}