using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.InPlaceEditor
{
    public partial class InPlaceEditorController : Controller
    {
        public ActionResult EditPost()
        {
            ViewBag.modeData = new string[] { "Inline", "Popup" };
            string[] data = new string[] { "Android", "JavaScript", "jQuery", "TypeScript", "Angular", "React", "Vue", "Ionic" };
            ViewBag.tagData = new { mode="Box", dataSource=data, placeholder= "Enter your tags" };
            string[] validation1 = new string[] { "true", "Enter valid tags" };
            ViewBag.tagValidation = new { Tag = new { required = validation1 } };
            string[] validation2 = new string[] { "true", "Enter valid title" };
            ViewBag.titleValidation = new { Title = new { required = validation2 } };
            ViewBag.titleData = new { placeHolder = "Enter your question title" };
            string[] rteItems = new string[] { "Bold", "Italic", "Underline", "FontColor", "BackgroundColor", "LowerCase", "UpperCase", "|", "OrderedList", "UnorderedList" };
            ViewBag.commentData = new { toolbarSettings= new {enableFloating=false, items= rteItems } };
            string[] validation3 = new string[] { "true", "Enter valid comments" };
            ViewBag.commentValidation = new { rte = new { required = validation3 } };
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dialogBtnClick", ButtonModel = new DefaultButtonModel() { content = "ok", isPrimary = true } });
            ViewBag.DefaultButtons = buttons;
            return View();
        }
    }
    public class DefaultButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}
