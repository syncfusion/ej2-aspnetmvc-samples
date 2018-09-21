using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Badge
{
    public partial class BadgeController : Controller
    {
        List<AccordionAccordionItem> accItems = new List<AccordionAccordionItem>();
        string template = "<div style='display:none'><div style='height: 35px;'><div class='msg'><span class='e-acrdn-icons e-content-icon people'></span>Message Thread</div></div><div style='height: 35px;'><div class='msg'><span class='e-acrdn-icons e-content-icon people'></span>Message Thread</div></div></div>";
        public ActionResult Accordion()
        {
            accItems.Add(new AccordionAccordionItem { Header = "Robert", Expanded = true, Content = template, IconCss = "e-people e-acrdn-icons" } );
            accItems.Add(new AccordionAccordionItem { Header = "Kevin", Content = template, IconCss = "e-people e-acrdn-icons" });
            accItems.Add(new AccordionAccordionItem { Header = "Eric", Content = template, IconCss = "e-people e-acrdn-icons" });
            accItems.Add(new AccordionAccordionItem { Header = "Peter", Content = template, IconCss = "e-people e-acrdn-icons" });
            ViewBag.accordionItems = accItems;
            return View();
        }
    }

}