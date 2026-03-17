#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ2.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Uploader
{
    public partial class UploaderController : Controller
    {
        // GET: PreloadFiles
        List<UploaderUploadedFiles> list = new List<UploaderUploadedFiles>();
        public ActionResult PreloadFiles()
        {
            list.Add(new UploaderUploadedFiles { Name = "Nature", Size = 500000, Type = ".png" });
            list.Add(new UploaderUploadedFiles { Name = "TypeScript Succinctly", Size = 12000, Type = ".pdf" });
            list.Add(new UploaderUploadedFiles { Name = "ASP.NET Webhooks", Size = 500000, Type = ".docx" });

            ViewData["datasource"] = list;
            return View();
        }
    }
}