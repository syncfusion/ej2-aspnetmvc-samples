using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Buttons;
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SpeedDialController : Controller
    {
        public ActionResult Radial()
        {           
            List<SpeedDialItem> items = new List<SpeedDialItem>();
            items.Add(new SpeedDialItem
                {
                Title = "Cut",
                IconCss = "speeddial-icons speeddial-icon-cut"
            });
            items.Add(new SpeedDialItem
                {
                Title = "Copy",
                IconCss = "speeddial-icons speeddial-icon-copy"
            });
            items.Add(new SpeedDialItem
                {
                Title = "Paste",
                IconCss = "speeddial-icons speeddial-icon-paste"
            });
            items.Add(new SpeedDialItem
                {
                Title = "Delete",
                IconCss = "speeddial-icons speeddial-icon-delete"
            });
            ViewData["datasource"] = items;
            return View();
        }
    }

}
