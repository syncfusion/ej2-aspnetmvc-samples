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
        List<AccordionAccordionItem> iconsItems = new List<AccordionAccordionItem>();
        public ActionResult Icons()
        {
            iconsItems.Add(new AccordionAccordionItem { Header = "Athletics", Expanded = true, Content = "#athletics", IconCss = "e-athletics e-acrdn-icons" });
            iconsItems.Add(new AccordionAccordionItem { Header = "Water Games", Content = "#water_games", IconCss = "e-water-game e-acrdn-icons" });
            iconsItems.Add(new AccordionAccordionItem { Header = "Racing", Content = "#racing_games", IconCss = "e-racing-games e-acrdn-icons" });
            iconsItems.Add(new AccordionAccordionItem { Header = "Indoor Games", Content = "#indoor_games", IconCss = "e-indoor-games e-acrdn-icons" });
            ViewBag.iconsItems = iconsItems;
            return View();
        }
    }

}