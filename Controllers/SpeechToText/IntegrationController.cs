using Syncfusion.EJ2.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.SpeechToText
{
    public partial class SpeechToTextController : Controller
    {
        public List<ToolbarItemModel> Items = new List<ToolbarItemModel>();
        public ActionResult Integration()
        {
            Items.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewBag.ToolbarItems = Items;
            return View();
        }
        public class ToolbarItemModel
        {
            public string type { get; set; }
            public string align { get; set; }
            public string iconCss { get; set; }
        }
    }
}