#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.IO;
using System.Reflection;

namespace EJ2MVCSampleBrowser.Controllers.PdfViewer
{
    public partial class PdfViewerController : Controller
    {

        public ActionResult CustomToolbar()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                iconCss = "e-icons e-stamp",
                items = new List<object>()
                {
                    new {
                        text= "Dynamic",
                        items = new List<object>()
                        {
                           new { text = "Revised", id = "Dynamic" },
                           new { text = "Reviewed", id = "Dynamic" },
                           new { text = "Received", id = "Dynamic" },
                           new { text = "Confidential", id = "Dynamic" },
                           new { text = "Approved", id = "Dynamic" },
                           new { text = "Not Approved", id = "Dynamic" },
                        }
                    },
                    new {
                        text= "Sign Here",
                        items = new List<object>()
                        {
                            new { text = "Witness" , id = "Sign Here" },
                            new { text = "Initial Here", id = "Sign Here" },
                            new { text = "Sign Here", id = "Sign Here" },
                            new { text = "Accepted", id = "Sign Here"},
                            new { text = "Rejected", id = "Sign Here" }                    }
                    },
                    new {
                        text= "Standard Business",
                        items = new List<object>()
                        {
                          new { text= "Approved" , id= "Standard Business" },
                          new { text= "Not Approved", id= "Standard Business" },
                          new { text= "Draft", id= "Standard Business" },
                          new { text= "Final", id= "Standard Business"},
                          new { text= "Completed", id= "Standard Business" },
                          new { text= "Confidential" , id= "Standard Business" },
                          new { text= "For Public Release", id= "Standard Business" },
                          new { text= "Not For Public Release", id= "Standard Business" },
                          new { text= "For Comment", id= "Standard Business"},
                          new { text= "Void", id= "Standard Business" },
                          new { text= "Preliminary Results" , id= "Standard Business" },
                          new { text= "Information Only", id= "Standard Business" }
                        }
                    },
                }
            });
            List<object> signItems = new List<object>();
            signItems.Add(new
            {
                iconCss = "e-icons e-signature",
                items = new List<object>()
                {
                    new { text = "Add Signature" },
                    new { text = "Add Initial" },

                }
            });
            ViewData["menuItem"] = menuItems;
            ViewData["signItem"] = signItems;

            return View();
        }
    }
}
