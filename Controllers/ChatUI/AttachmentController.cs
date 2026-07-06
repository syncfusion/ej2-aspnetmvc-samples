using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.InteractiveChat;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.ChatUI
{
    public partial class ChatUIController : Controller
    {
        public List<AttachmentToolbarItemModel> AttachmentHeaderToolbar { get; set; } = new List<AttachmentToolbarItemModel>();
        public ActionResult Attachment()
        {
            AttachmentHeaderToolbar.Add(new AttachmentToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right", tooltipText = "Clear Chat" });
            ViewData["AttachmentHeaderToolbar"] = AttachmentHeaderToolbar;
            return View();
        }

        public class AttachmentToolbarItemModel
        {
            public string align { get; set; }
            public string tooltipText { get; set; }
            public string iconCss { get; set; }
        }

    }
}