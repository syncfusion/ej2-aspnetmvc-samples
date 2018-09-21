using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Buttons;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: HierarchicalLayout
        public ActionResult HierarchicalLayout()
        {

            ViewBag.Nodes = HierarchicalDetails.GetAllRecords();            
            return View();
        }
    }
}