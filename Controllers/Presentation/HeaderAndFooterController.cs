#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
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
    public partial class PresentationController : Controller
    {
        //
        // GET: /Images/

        public ActionResult HeaderAndFooter()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult HeaderAndFooter(string Browser)
        {
            //Opens an existing PowerPoint presentation.
            string filename = "HeaderFooter.pptx";
            IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));

            //Add footers into all the PowerPoint slides.
            foreach (ISlide slide in presentation.Slides)
            {
                //Enable a date and time footer in slide.
                slide.HeadersFooters.DateAndTime.Visible = true;
                //Enable a footer in slide.
                slide.HeadersFooters.Footer.Visible = true;
                //Sets the footer text.
                slide.HeadersFooters.Footer.Text = "Footer";
                //Enable a slide number footer in slide.
                slide.HeadersFooters.SlideNumber.Visible = true;
            }

            //Add header into first slide notes page.
            //Add a notes slide to the slide.
            INotesSlide notesSlide = presentation.Slides[0].AddNotesSlide();
            //Enable a header in notes slide.
            notesSlide.HeadersFooters.Header.Visible = true;
            //Sets the header text.
            notesSlide.HeadersFooters.Header.Text = "Header";

            //Saves the presentation
            return new PresentationResult(presentation, "HeaderAndFooter.pptx", HttpContext.ApplicationInstance.Response);
        }        
    }
}
