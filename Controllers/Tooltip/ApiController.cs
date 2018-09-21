using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Tooltip
{
    public partial class TooltipController : Controller
    {
        public ActionResult Api()
        {
            string[] ddlData = new String[] { "Hover", "Click", "Auto" };
            ViewBag.ddlData = ddlData;
            return View();
        }
    }

}