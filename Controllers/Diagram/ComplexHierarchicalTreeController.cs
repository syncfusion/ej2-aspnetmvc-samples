using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: ComplexHierarchicalTree
        public ActionResult ComplexHierarchicalTree()
        {            
            ViewBag.Nodes = ComplexHierarchicalDataDetails.GetAllRecords();
            return View();
        }
    }
}