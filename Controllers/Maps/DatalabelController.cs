using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Syncfusion.EJ2.Maps;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Datalabel
        public ActionResult Datalabel()
        {
            ViewBag.usmap = getusMap();
            return View();
        }
        public object getusMap()
        {
            string usmap = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/USA.js"));
            return JsonConvert.DeserializeObject(usmap);
        }
    }
}