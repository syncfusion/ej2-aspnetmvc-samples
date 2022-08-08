using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: OSMWithSubLayer
        public ActionResult OSMWithSubLayer()
        {
            ViewBag.shapeData = this.getAfricaShape();
            return View();
        }

        public object getAfricaShape()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/Africa.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}