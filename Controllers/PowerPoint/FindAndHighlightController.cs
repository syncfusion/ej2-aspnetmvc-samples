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
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.Presentation;
using System.Drawing;
using System.IO;


namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        public ActionResult FindAndHighlight()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult FindAndHighlight(string button, string Group, string Group1, string matchCase, string matchWholeWord, string highlightFirst)
        {
            if (button == null)
                return View();

            if (button == "View Input Template")
            {
                string filename = "FindAndHighlightInput.pptx";

                //New Instance of PowerPoint is created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));

                return new PresentationResult(presentation, "FindAndHighlightInput.pptx", HttpContext.ApplicationInstance.Response);
            }
            else
            {
                string filename = "FindAndHighlightInput.pptx";

                //New Instance of PowerPoint is created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));
                //Highlight only the first occurrence of the text
                if (highlightFirst == "HighlightFirst")
                {
                    //Finds the first occurrence of a particular text
                    ITextSelection textSelection = presentation.Find(Group, matchCase == "MatchCase", matchWholeWord == "MatchWholeWord");
                    if (textSelection != null)
                    {
                        //Gets the found text containing text parts
                        foreach (ITextPart textPart in textSelection.GetTextParts())
                        {
                            //Sets highlight color
                            textPart.Font.HighlightColor = ColorObject.Yellow;
                        }
                    }
                }
                else
                {
                    //Finds all the occurrences of a particular text
                    ITextSelection[] textSelections = presentation.FindAll(Group, matchCase == "MatchCase", matchWholeWord == "MatchWholeWord");
                    if (textSelections != null)
                    {
                        foreach (ITextSelection textSelection in textSelections)
                        {
                            //Gets the found text containing text parts
                            foreach (ITextPart textPart in textSelection.GetTextParts())
                            {
                                //Sets highlight color
                                textPart.Font.HighlightColor = ColorObject.Yellow;
                            }
                        }
                    }
                }
                if (Group1 == "PPTX")
                    //Save the presentation
                    return new PresentationResult(presentation, "FindandHighlight.pptx", HttpContext.ApplicationInstance.Response);
                else
                {
                    PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                    //Instance to create pdf document from presentation                
                    PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation, settings);
                    //Saves the pdf document
                    MemoryStream stream = new MemoryStream();
                    pdfDocument.Save(stream);
                    stream.Position = 0;
                    pdfDocument.Close(true);
                    return File(stream, "application/pdf", "FindandHighlight.pdf");
                }
            }
        }
    }
}