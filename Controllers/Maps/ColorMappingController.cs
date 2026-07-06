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
        // GET: ColorMapping
        public ActionResult ColorMapping()
        {
            ViewData["MapShapeData"] = this.getusMap();
            ViewData["DataSource"] = GetColorMappingData();
            return View();
        }

        public object GetColorMappingData()
        {
            string usmap = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/ColorMapping.json"));
            return JsonConvert.DeserializeObject(usmap);
        }
    }
}