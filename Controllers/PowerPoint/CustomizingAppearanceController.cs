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
using System.IO;
using System.Web.Mvc;
using Syncfusion.Presentation;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        public ActionResult CustomizingAppearance()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CustomizingAppearance(string Browser, FormCollection form)
        {
            Stream readFile = new FileStream(ResolveApplicationDataPath(@"SmartArts.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(readFile);
            
            //Method call to edit slides
            SmartArt5(presentation);
            SmartArt6(presentation); 
	        SmartArt7(presentation);

        string choice = form["File Type"];
        if (choice == "PPTX")
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
        private void SmartArt5(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            ISmartArt smartArt = slide1.Shapes[0] as ISmartArt;
            smartArt.Background.FillType = FillType.Solid;
            smartArt.Background.SolidFill.Color = ColorObject.Wheat;
            smartArt.Background.SolidFill.Transparency = 100;
            smartArt.Nodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[2].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[2].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;

        }
        #endregion

        # region Slide2
        private void SmartArt6(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[1];
            ISmartArt smartArt = slide2.Shapes[0] as ISmartArt;
            smartArt.Background.FillType = FillType.Solid;
            smartArt.Background.SolidFill.Color = ColorObject.Wheat;
            smartArt.Background.SolidFill.Transparency = 100;
            smartArt.Nodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[0].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[2].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[2].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[2].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[3].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[3].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[3].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[4].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[4].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[4].Shapes[0].LineFormat.Weight = 5;
        }
        #endregion

	# region Slide3
        private void SmartArt7(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[2];
            ISmartArt smartArt = slide2.Shapes[1] as ISmartArt;
            smartArt.Background.FillType = FillType.Solid;
            smartArt.Background.SolidFill.Color = ColorObject.Wheat;
            smartArt.Background.SolidFill.Transparency = 100;
            smartArt.Nodes[0].ChildNodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].ChildNodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[0].ChildNodes[0].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[0].ChildNodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].ChildNodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[0].ChildNodes[1].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].ChildNodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].ChildNodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].ChildNodes[0].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].ChildNodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].ChildNodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].ChildNodes[1].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].ChildNodes[2].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].ChildNodes[2].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].ChildNodes[2].Shapes[0].LineFormat.Weight = 5;


        }

        #endregion
    }
}