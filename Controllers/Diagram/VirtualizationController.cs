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
        // GET: Virtualization
        public ActionResult Virtualization()
        {
            ViewBag.Data = GetAllRecords();
            return View();
        }
        public List<VirtualizationDetails> GetAllRecords()
        {
            List<VirtualizationDetails> data = new List<VirtualizationDetails>();

            int i = 0;
            string name;
            string parentName;
            string[] virtualData = VirtualizationData.GetNames();
            data.Add(new VirtualizationDetails() { Id = virtualData[0], ParentId = "" });
            i++;
            parentName = virtualData[0];
            for (var j = 1; j < 100; j++)
            {
                name = virtualData[i];
                data.Add(new VirtualizationDetails() { Id = name, ParentId = parentName });
                i++;
                for (var k = 0; k < 2; k++)
                {
                    data.Add(new VirtualizationDetails() { Id = virtualData[i], ParentId = name });
                    i++;
                }
            }
            return data;
        }
    }
    public partial class VirtualizationDetails
    {
        public string Id { get; set; }
        public string ParentId { get; set; }

    }
}
