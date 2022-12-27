#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        public ActionResult MergingPresentation(string button, string Group1, string Group2)
        {
            if (button == null)
                return View();
            if (Group1 == null)
                return View();
            Stream sourceFile = new FileStream(ResolveApplicationDataPath(@"..\PowerPoint\MergeContent.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);

            IPresentation sourcePresentation = Presentation.Open(sourceFile);

            Stream destinationFile = new FileStream(ResolveApplicationDataPath(@"..\PowerPoint\Essential Presentation.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);

            IPresentation destinationPresentation = Presentation.Open(destinationFile);

            ISlides slides = sourcePresentation.Slides;

            if (Group1 == "DestinationTheme")
            {
                //Adding the cloned slide to the destination presentation by using Destination option.
                foreach (ISlide slide in slides)
                {
                     destinationPresentation.Slides.Add(slide, PasteOptions.UseDestinationTheme, sourcePresentation);
                }

                return new PresentationResult(destinationPresentation, "MergedUsingDestination.pptx", HttpContext.ApplicationInstance.Response);
            }
            else
            {
                foreach (ISlide slide in slides)
                {
                    //Adding the cloned slide to the destination presentation by using Destination option.
                     destinationPresentation.Slides.Add(slide, PasteOptions.SourceFormatting, sourcePresentation);
                }

                return new PresentationResult(destinationPresentation, "MergedUsingSource.pptx", HttpContext.ApplicationInstance.Response);

            }         
        }
    }
}