#region Copyright Syncfusion Inc. 2001-2022
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;
using System.Reflection;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        public ActionResult SmartArtCreation()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SmartArtCreation(FormCollection form)
        {
            IPresentation presentation = Presentation.Create();
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

            //Method call to edit slides
            SmartArt1(presentation);
            SmartArt2(presentation);
            SmartArt3(presentation);
            SmartArt4(presentation);
            string choice = form["File Type"];
            if (choice=="PPTX")
            {
                //  Saves the presentation
                return new PresentationResult(presentation, "SmartArtSample.pptx", HttpContext.ApplicationInstance.Response);
            }
            else
            {
                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                settings.ShowHiddenSlides = true;

                //Instance to create pdf document from presentation                
                PdfDocument doc = PresentationToPdfConverter.Convert(presentation, settings);

                //Saves the pdf document
                //return new Syncfusion.Mvc.Pdf.PdfResult(doc, "PPTXToPDF.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                MemoryStream stream = new MemoryStream();
                doc.Save(stream);
                stream.Position = 0;
                return File(stream, "application/pdf", "PPTXToPDF.pdf");
            }

        }
        # region Slide1
        public void SmartArt1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide1.Shapes.AddSmartArt(SmartArtType.BasicBlockList, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("One");
            ISmartArtNode node2 = smartArt.Nodes[1];
            node2.TextBody.AddParagraph("Two");
            ISmartArtNode node3 = smartArt.Nodes[2];
            node3.TextBody.AddParagraph("Three");
            ISmartArtNode node4 = smartArt.Nodes[3];
            node4.TextBody.AddParagraph("Four");
            ISmartArtNode node5 = smartArt.Nodes[4];
            node5.TextBody.AddParagraph("Five");
        }
        #endregion

        # region Slide2
        public void SmartArt2(IPresentation presentation)
        {
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide.Shapes.AddSmartArt(SmartArtType.StepUpProcess, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("First");
            ISmartArtNode node2 = smartArt.Nodes[1];
            node2.TextBody.AddParagraph("Second");
            ISmartArtNode node3 = smartArt.Nodes[2];
            node3.TextBody.AddParagraph("Three");
        }

        #endregion

        # region Slide3
        public void SmartArt3(IPresentation presentation)
        {
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide.Shapes.AddSmartArt(SmartArtType.BasicCycle, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("Requirement");
            ISmartArtNode node2 = smartArt.Nodes[1];
            node2.TextBody.AddParagraph("Analyzing");
            ISmartArtNode node3 = smartArt.Nodes[2];
            node3.TextBody.AddParagraph("Estimation");
            ISmartArtNode node4 = smartArt.Nodes[3];
            node4.TextBody.AddParagraph("Implementing");
            ISmartArtNode node5 = smartArt.Nodes[4];
            node5.TextBody.AddParagraph("Testing");
        }
        #endregion

        # region Slide4
        public void SmartArt4(IPresentation presentation)
        {
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide.Shapes.AddSmartArt(SmartArtType.Hierarchy, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("Grand Father");
            ISmartArtNode childNode1 = node1.ChildNodes[0];
            childNode1.TextBody.AddParagraph("Son1");
            ISmartArtNode childNode2 = node1.ChildNodes[1];
            childNode2.TextBody.AddParagraph("Son2");
            ISmartArtNode childnode1 = childNode1.ChildNodes[0];
            childnode1.TextBody.AddParagraph("Son1");
            ISmartArtNode childnode2 = childNode1.ChildNodes[1];
            childnode2.TextBody.AddParagraph("Son2");
            ISmartArtNode childnode2s1 = childNode2.ChildNodes[0];
            childnode2s1.TextBody.AddParagraph("Son1");
        }

        #endregion
    }
}