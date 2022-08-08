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
        // GET: MapWithSlider
        public ActionResult MapWithSlider()
        {
            ViewBag.MapShapeData = this.getNorthAmericaMap();
            ViewBag.DataSource = GetPopulationGrowthData();
            return View();
        }

        public object GetPopulationGrowthData()
        {
            string usmap = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/PopulationGrowth.json"));
            return JsonConvert.DeserializeObject(usmap);
        }
    }
}