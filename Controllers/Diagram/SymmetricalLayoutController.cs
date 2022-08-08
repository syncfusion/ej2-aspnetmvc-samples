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
        // GET: SymmetricalLayout
        public ActionResult SymmetricalLayout()
        {
            ViewBag.Nodes = SymmetricalDetails.GetAllRecords();
            return View();
        }
    }
}