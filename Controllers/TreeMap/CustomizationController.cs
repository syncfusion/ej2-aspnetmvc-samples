using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Treemap
{
    public partial class TreemapController : Controller
    {
        // GET: Customization
        public ActionResult Customization()
        {
            ViewBag.imagedata = "<div><img src='../Content/Treemap/{{:GameImage}}')' style='height:{{:ItemHeight}};width:{{:ItemWidth}};'/></div>";
            return View();
        }
    }
}