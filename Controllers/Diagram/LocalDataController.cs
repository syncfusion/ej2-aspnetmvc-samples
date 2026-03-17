#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        // GET: LocalData
        public ActionResult LocalData()
        {
            List<LocalDataDetails> localData = new List<LocalDataDetails>();
            localData.Add(new LocalDataDetails("Species", ""));
            localData.Add(new LocalDataDetails("Plants", "Species"));
            localData.Add(new LocalDataDetails("Fungi", "Species"));
            localData.Add(new LocalDataDetails("Lichens", "Species"));
            localData.Add(new LocalDataDetails("Animals", "Species"));
            localData.Add(new LocalDataDetails("Mosses", "Plants"));
            localData.Add(new LocalDataDetails("Ferns", "Plants"));
            localData.Add(new LocalDataDetails("Gymnosperms", "Plants"));
            localData.Add(new LocalDataDetails("Dicotyledens", "Plants"));
            localData.Add(new LocalDataDetails("Monocotyledens", "Plants"));
            localData.Add(new LocalDataDetails("Invertebrates", "Animals"));
            localData.Add(new LocalDataDetails("Vertebrates", "Animals"));
            localData.Add(new LocalDataDetails("Insects", "Invertebrates"));
            localData.Add(new LocalDataDetails("Molluscs", "Invertebrates"));
            localData.Add(new LocalDataDetails("Crustaceans", "Invertebrates"));
            localData.Add(new LocalDataDetails("Others", "Invertebrates"));
            localData.Add(new LocalDataDetails("Fish", "Vertebrates"));
            localData.Add(new LocalDataDetails("Amphibians", "Vertebrates"));
            localData.Add(new LocalDataDetails("Reptiles", "Vertebrates"));
            localData.Add(new LocalDataDetails("Birds", "Vertebrates"));
            localData.Add(new LocalDataDetails("Mammals", "Vertebrates"));

            ViewData["Nodes"] = localData;
            return View();
        }
    }

    public class LocalDataDetails
    {
        public string Name { get; set; }
        public string Category { get; set; }


        public LocalDataDetails(string id, string category)
        {
            this.Name = id;
            this.Category = category;
        }
    }
}