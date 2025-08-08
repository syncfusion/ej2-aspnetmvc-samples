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
using System.Text.RegularExpressions;

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
            string findText, string findTextUsingRegex, string findUsing, string replaceText, string replaceFirst)
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
                //Replaces only the first occurrence of the text or text pattern
                if (replaceFirst == "ReplaceFirst")
                {
                    ITextSelection textSelection = null;
                    if (findUsing == "0")
                    {
                        //Finds the first occurrence of a particular text
                        textSelection = presentation.Find(findText, matchCase == "MatchCase", matchWholeWord == "MatchWholeWord");
                    }
                    else
                    {
                        Regex regex = new Regex(findTextUsingRegex);
                        //Finds the first occurrence of a text pattern
                        textSelection = presentation.Find(regex);
                    }
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
                    ITextSelection[] textSelections = null;
                    if (findUsing == "0")
                    {
                        //Finds all the occurrence of a particular text
                        textSelections = presentation.FindAll(findText, matchCase == "MatchCase", matchWholeWord == "MatchWholeWord");
                    }
                    else
                    {
                        Regex regex = new Regex(findTextUsingRegex);
                        //Finds all the occurrence of a text pattern
                        textSelections = presentation.FindAll(regex);
                    }
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