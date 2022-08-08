using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult InsertEmoticons()
         {
             List<TabTabItem> tabItems = new List<TabTabItem>();
            tabItems.Add(new TabTabItem { Header = new TabHeader { Text = "&#128578;" }, Content = "#rteEmoticons-smiley" });
            tabItems.Add(new TabTabItem { Header = new TabHeader { Text = "&#128053;" }, Content = "#rteEmoticons-animal" });
            ViewBag.TabItems = tabItems;
            var tools = new
            {
                tooltipText = "Insert Emoticons",
                template = "<button class='e-tbar-btn e-btn' tabindex='-1' id='emot_tbar'  style='width:100%'><div class='e-tbar-btn-text rtecustomtool' style='font-weight: 500;'> &#128578;</div></button>"
            };
            ViewBag.Items = new object[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "OrderedList",
                "UnorderedList", "|", "CreateLink", "Image", "|", "SourceCode", tools
                , "|", "Undo", "Redo"
            };
            ViewBag.InsertBtn = new
            {
                content = "Insert",
                isPrimary = true
            };
            ViewBag.CancelBtn = new
            {
                content = "Cancel"
            };

            return View();
        } 
    }
}
