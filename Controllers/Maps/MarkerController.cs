using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Marker
        public ActionResult Marker()
        {
            ViewBag.shapeData = this.GetWorldMap();
            string population = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Population.js"));
            object datasrc = JsonConvert.DeserializeObject(population, typeof(object));
            MapsMarker marker = new MapsMarker();
            marker.Visible = true;
            marker.DataSource = JsonConvert.DeserializeObject(population, typeof(object));
            marker.AnimationDuration = 0;
            marker.Shape = MarkerType.Circle;
            marker.Fill = "#FFFFFF";
            marker.Width = 12;
            marker.Border = new MapsBorder { Width = 2, Color = "#285255" };
            marker.TooltipSettings = new MapsTooltipSettings{ Visible = true, ValuePath = "population", Template = "#template" };
            List<MapsMarker> markerSettings = new List<MapsMarker>();
            markerSettings.Add(marker);
            ViewBag.markerSettings = markerSettings;
            return View();
        }
    }
}