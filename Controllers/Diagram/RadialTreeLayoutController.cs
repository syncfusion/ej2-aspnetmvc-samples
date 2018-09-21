using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: RadialTreeLayout
        public ActionResult RadialTreeLayout()
        {
            ViewBag.Nodes = RadialTreeDetails.GetAllRecords();
            return View();
        }
    }
}