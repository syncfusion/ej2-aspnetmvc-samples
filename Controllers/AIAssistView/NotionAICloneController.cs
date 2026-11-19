using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> NotionToolbarItems = new List<ToolbarItemModel>();
        public ActionResult NotionAIClone()
        {
            NotionToolbarItems.Add(new ToolbarItemModel() {
                iconCss = "e-icons e-export",
                align = "Right",
                tooltip = "Share Chat",
            });
            NotionToolbarItems.Add(new ToolbarItemModel() {
                iconCss = "e-icons e-history",
                align = "Right",
                tooltip = "Chat History",
                cssClass = "history-icon",
            });
            NotionToolbarItems.Add(new ToolbarItemModel() {
                iconCss = "e-icons e-edit-notes",
                align = "Right",
                tooltip = "Start New chat",
            });
            NotionToolbarItems.Add(new ToolbarItemModel() {
                iconCss = "e-icons e-resize",
                align = "Right",
                tooltip = "Switch Chat Mode",
                cssClass = "screen-resizer",
            });
            NotionToolbarItems.Add(new ToolbarItemModel() {
                iconCss = "e-icons e-horizontal-line",
                align = "Right",
                tooltip = "Hide Chat",
            });
            var footerToolbarItems = new List<ToolbarItemModel>()
            {
                new ToolbarItemModel { iconCss = "e-icons e-assist-attachment-icon", align = "Left", tooltip = "Attach File" },
                new ToolbarItemModel { iconCss = "e-icons e-settings", align = "Left", tooltip = "Settings", cssClass = "settings-icon" },
                new ToolbarItemModel { iconCss = "e-icons e-edit", align = "Left", tooltip = "Edit access", visible = false },
                new ToolbarItemModel { iconCss = "e-icons e-time-zone", align = "Left", tooltip = "Web access", visible = false },
                new ToolbarItemModel { align = "Right", text = "Auto", template = "<button id='custombtn'>Auto</button>" },
                new ToolbarItemModel { iconCss = "e-icons e-assist-speech-to-text", align = "Right" },
                new ToolbarItemModel { iconCss = "e-icons e-assist-send", align = "Right" }
            };

            var responseToolbarItems = new List<ResponseToolbarItemModel>()
            {
                new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-copy", tooltip = "Copy" },
                new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-like", tooltip = "Like" },
                new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-dislike", tooltip = "Need Improvement" },
                new ResponseToolbarItemModel { type = "Button", iconCss = "e-icons e-assist-audio", tooltip = "Read Aloud" }
            };

            var iconMap = new PromptResponseData().GetIconMapByIndex().ToDictionary(k => k.Key.ToString(), v => v.Value);

            ViewData["FooterToolbarItems"] = footerToolbarItems;
            ViewData["ResponseToolbarItems"] = responseToolbarItems;
            ViewData["ToolbarItems"] = NotionToolbarItems;
            ViewData["PromptSuggestionData"] = PromptResponseData.GetNotionSuggestions();
            ViewData["PromptResponseData"] = new PromptResponseData().GetAllPromptResponseData();
            ViewData["ModelIcons"] = new PromptResponseData().GetModelIcons();
            ViewData["IconMapByIndex"] = iconMap;
            return View();
        }
    }
}
