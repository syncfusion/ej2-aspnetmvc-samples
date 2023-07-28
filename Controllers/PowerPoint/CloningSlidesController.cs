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
        public ActionResult CloningSlides(string button, string Group1, string Group2)
        {
            if (button == null)
                return View();
            if (Group1 == null)
                return View();
            Stream readFile = new FileStream(ResolveApplicationDataPath(@"..\PowerPoint\Template.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);

            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(readFile);

            ISlide slide = presentation.Slides[0].Clone();

            Stream destinationFile = new FileStream(ResolveApplicationDataPath(@"..\PowerPoint\MergeContent.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);

            IPresentation destinationPresentation = Syncfusion.Presentation.Presentation.Open(destinationFile);
            if(Group1 == "DestinationTheme")
            {
                //Adding the cloned slide to the destination presentation by using Destination option.
                destinationPresentation.Slides.Add(slide, PasteOptions.UseDestinationTheme, presentation);

                return new PresentationResult(destinationPresentation, "ClonedUsingDestination.pptx", HttpContext.ApplicationInstance.Response);
            }
            else
            {
                //Adding the cloned slide to the destination presentation by using Destination option.
                destinationPresentation.Slides.Add(slide, PasteOptions.SourceFormatting, presentation);

                return new PresentationResult(destinationPresentation, "ClonedUsingSource.pptx", HttpContext.ApplicationInstance.Response);

            }           
        }
    }
}