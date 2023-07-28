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
using System.IO;
using System.Web.Mvc;
using Syncfusion.Presentation;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        public ActionResult ManipulatingSmartArt()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ManipulatingSmartArt(string button)
        {
            if (button == null)
                return View();
            Stream readFile = new FileStream(ResolveApplicationDataPath(@"SmartArtNode.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);
            IPresentation presentation = Presentation.Open(readFile);

            //Method call to edit slides
            AddNodeInMainNodes(presentation);
            AddNodeInChildNodes(presentation);

            //  Saves the presentation
            return new PresentationResult(presentation, "SmartArtNodeInsertion.pptx", HttpContext.ApplicationInstance.Response);

        }

        # region Slide1
        private void AddNodeInMainNodes(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            ISmartArt smartArt = slide1.Shapes[0] as ISmartArt;
            smartArt.Background.FillType = FillType.Solid;
            smartArt.Background.SolidFill.Color = ColorObject.Lavender;
            //New node adds to the node collection.
            ISmartArtNode newNode = smartArt.Nodes.Add();
            //Text content to the newly added node.
            newNode.TextBody.AddParagraph("Marketing");
        }
        #endregion

        # region Slide2
        private void AddNodeInChildNodes(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[2];
            ISmartArt smartArt = slide2.Shapes[1] as ISmartArt;
            // Gets first node from the node collection using index value.
            ISmartArtNode firstNode = smartArt.Nodes[0];
            //Adds new child node to the first node's child node collection.
            ISmartArtNode childNode = firstNode.ChildNodes.Add();
            //Gives the text content to the newly added child node.
            childNode.TextBody.AddParagraph("Make Simple");
        }
        #endregion
    }
}