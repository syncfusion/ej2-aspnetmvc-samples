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
        List<AccordionItem> accItems = new List<AccordionItem>();
        string template = "<div><div style='height: 35px;'><div class='msg'><span class='e-acrdn-icons e-content-icon people'></span>Message Thread</div></div><div style='height: 35px;'><div class='msg'><span class='e-acrdn-icons e-content-icon people'></span>Message Thread</div></div></div>";
        public ActionResult Accordion()
        {
            accItems.Add(new AccordionItem { Header = "Robert", Expanded = true, Content = template, IconCss = "e-people e-acrdn-icons" } );
            accItems.Add(new AccordionItem { Header = "Kevin", Content = template, IconCss = "e-people e-acrdn-icons" });
            accItems.Add(new AccordionItem { Header = "Eric", Content = template, IconCss = "e-people e-acrdn-icons" });
            accItems.Add(new AccordionItem { Header = "Peter", Content = template, IconCss = "e-people e-acrdn-icons" });
            ViewData["accordionItems"] = accItems;
            return View();
        }
    }

}