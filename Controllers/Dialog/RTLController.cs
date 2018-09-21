using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.Dialog
{
    public partial class DialogController : Controller
    {
        // GET: RTL
        public ActionResult RTL()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new RTLButtonModel() { content = "YES", isPrimary = true } });
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new RTLButtonModel() { content = "NO" } });
            ViewBag.DialogButtons = buttons;
            return View();
        }
    }

    public class RTLButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}