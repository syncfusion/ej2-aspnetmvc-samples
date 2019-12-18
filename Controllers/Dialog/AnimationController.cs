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
        // GET: AnimationDialog
        public ActionResult Animation()
        {
            List<DialogDialogButton> button = new List<DialogDialogButton>() { };
            button.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new defaultButton() { content = "Hide", isPrimary = true } });
            ViewBag.DefaultButton = button;
            return View();
        }
    }
    public class defaultButton
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}