using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Accordion
{
    public partial class AccordionController : Controller
    {
        List<AccordionItem> iconsItems = new List<AccordionItem>();
        public ActionResult Icons()
        {
            iconsItems.Add(new AccordionItem { Header = "Athletics", Expanded = true, Content = "#athletics", IconCss = "e-athletics e-acrdn-icons" });
            iconsItems.Add(new AccordionItem { Header = "Water Games", Content = "#water_games", IconCss = "e-water-game e-acrdn-icons" });
            iconsItems.Add(new AccordionItem { Header = "Racing", Content = "#racing_games", IconCss = "e-racing-games e-acrdn-icons" });
            iconsItems.Add(new AccordionItem { Header = "Indoor Games", Content = "#indoor_games", IconCss = "e-indoor-games e-acrdn-icons" });
            ViewData["iconsItems"] = iconsItems;
            return View();
        }
    }

}