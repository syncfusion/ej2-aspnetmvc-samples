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
        // GET: Dialog
        public ActionResult CustomDialogs()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "alertBtnClick", ButtonModel = new customButtonModel() { content = "DISMISS", isPrimary = true } });
            ViewBag.alertbutton = buttons;
            List<DialogDialogButton> button = new List<DialogDialogButton>() { };
            button.Add(new DialogDialogButton() { Click = "confirmBtnClick", ButtonModel = new confirmButtonModel() { content = "YES", isPrimary = true } });
            button.Add(new DialogDialogButton() { Click = "confirmBtnClick", ButtonModel = new confirmButtonModel() { content = "NO"} });
            ViewBag.confirmbutton = button;
            List<DialogDialogButton> btn = new List<DialogDialogButton>() { };
            btn.Add(new DialogDialogButton() { Click = "promptBtnClick", ButtonModel = new promptButtonModel() { content = "CONNECT", isPrimary = true } });
            btn.Add(new DialogDialogButton() { Click = "promptBtnClick", ButtonModel = new promptButtonModel() { content = "CANCEL" } });
            ViewBag.promptbutton = btn;
            return View();
            
        }
    }
    public class customButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
    public class confirmButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
    public class promptButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}