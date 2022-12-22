#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
        public ActionResult FindAndReplace()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult FindAndReplace(string button, string matchCase, string matchWholeWord,
            string findText, string replaceText, string replaceFirst)
        {
            if (button == null)
                return View();

            if (button == "View Input Template")
            {
                string filename = "Input Template.pptx";

                //New Instance of PowerPoint is created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));

                return new PresentationResult(presentation, "Input Template.pptx", HttpContext.ApplicationInstance.Response);
            }
            else
            {
                string filename = "Input Template.pptx";

                //New Instance of PowerPoint is created.[Equivalent to launching MS PowerPoint with no slides].
                IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));
                //Replaces only the first occurrence of the text
                if (replaceFirst == "ReplaceFirst")
                {
                    //Finds the first occurrence of a particular text
                    ITextSelection textSelection = presentation.Find(findText, matchCase == "MatchCase", matchWholeWord == "MatchWholeWord");
                    if (textSelection != null)
                    {
                        //Gets the found text as single text part
                        ITextPart textPart = textSelection.GetAsOneTextPart();
                        //Replace the text
                        textPart.Text = replaceText;
                    }
                }
                else
                {
                    //Finds all the occurrences of a particular text
                    ITextSelection[] textSelections = presentation.FindAll(findText, matchCase == "MatchCase", matchWholeWord == "MatchWholeWord");
                    if (textSelections != null)
                    {
                        foreach (ITextSelection textSelection in textSelections)
                        {
                            //Gets the found text as single text part
                            ITextPart textPart = textSelection.GetAsOneTextPart();
                            //Replace the text
                            textPart.Text = replaceText;
                        }
                    }
                }

                //Save the presentation
                return new PresentationResult(presentation, "FindandReplace.pptx", HttpContext.ApplicationInstance.Response);
            }
        }
    }
}