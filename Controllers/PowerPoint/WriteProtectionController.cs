#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
using Syncfusion.Presentation;
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        public ActionResult WriteProtection()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult WriteProtection(string button, string Password1)
        {
            if (button == null)
                return View();
            string file = ResolveApplicationDataPath("Syncfusion Presentation.pptx");
            //Open a existing PowerPoint presentation
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(file);
            if (Password1 == null)
                Password1 = string.Empty;
            //Set the write protection for presentation instance
            presentation.SetWriteProtection(Password1);
            return new PresentationResult(presentation, "WriteProtection.pptx", HttpContext.ApplicationInstance.Response);
        }
    }
}