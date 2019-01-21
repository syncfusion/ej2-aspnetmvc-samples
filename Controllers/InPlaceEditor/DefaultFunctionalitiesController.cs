using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.InPlaceEditor
{
    public partial class InPlaceEditorController : Controller
    {
      
        List<clickTypes> type = new List<clickTypes>(); 
        public ActionResult DefaultFunctionalities()
        {
            ViewBag.modeData = new string[] { "Inline", "Popup" };
            type.Add(new clickTypes { Id = "Click", ClickType = "Click" });
            type.Add(new clickTypes { Id = "DblClick", ClickType = "Double Click" });
            type.Add(new clickTypes { Id = "EditIconClick", ClickType = "Edit Icon Click" });
            ViewBag.modalData = new { placeholder = "Enter employee name" };
            ViewBag.maskData = new { mask = "000-000-0000" };
            ViewBag.numericData = new { placeholder = "Currency format", value = 100, format = "c2" };
            ViewBag.clickData = type;
            return View();
        }
    }
    public class clickTypes
    {
        public string Id { get; set; }
        public string ClickType { get; set; }

    }
}
