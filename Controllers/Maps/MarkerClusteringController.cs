using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: MarkerClustering
        public ActionResult MarkerClustering()
        {
            ViewBag.shapeData = this.getWorldMap();
            ViewBag.ClusterData = this.ClusterData();
            return View();
        }
        public object ClusterData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/ClusterData.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}