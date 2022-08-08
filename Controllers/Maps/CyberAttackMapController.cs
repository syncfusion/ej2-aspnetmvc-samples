using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Default
        public ActionResult CyberAttackMap()
        {
            ViewBag.shapeData = this.GetWorldMap();
            return View();
        }
    }

  
}