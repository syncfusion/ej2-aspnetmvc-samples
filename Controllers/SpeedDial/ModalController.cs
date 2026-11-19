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
        public ActionResult Modal()
        {
            List<SpeedDialItem> items = new List<SpeedDialItem>();
            items.Add(new SpeedDialItem
            {
                Title ="Home",
                IconCss = "e-icons e-home"
            });
            items.Add(new SpeedDialItem
            {
                Title="People",
                IconCss = "e-icons e-people"
            });
            items.Add(new SpeedDialItem
            {
                Title="Search",
                IconCss = "e-icons e-search"
            });
            items.Add(new SpeedDialItem
            {
                Title="Message",
                IconCss = "e-icons e-comment-show"
            });
            ViewData["datasource"] = items;
            return View();
        }
    }

}