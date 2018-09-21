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
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers
{ 
    public partial class PresentationController : Controller
    {
        //
        // GET: /InsertOLEObject/

        public ActionResult InsertOLEObject()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult InsertOLEObject(string Browser)
        {
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].
            IPresentation presentation = Presentation.Create();

            ISlide slide = presentation.Slides.Add(SlideLayoutType.TitleOnly);

            IShape titleShape = slide.Shapes[0] as IShape;
            titleShape.Left = 0.92 * 72;
            titleShape.Top = 0.4 * 72;
            titleShape.Width = 11.5 * 72;
            titleShape.Height = 1.01 * 72;
            titleShape.TextBody.AddParagraph("Ole Object Demo");
            titleShape.TextBody.Paragraphs[0].Font.Bold = true;
            titleShape.TextBody.Paragraphs[0].HorizontalAlignment = HorizontalAlignmentType.Center;

            IShape heading = slide.Shapes.AddTextBox(100, 100, 100, 100);
            heading.Left = 3.2 * 72;
            heading.Top = 1.51 * 72;
            heading.Width = 1.86 * 72;
            heading.Height = 0.71 * 72;
            heading.TextBody.AddParagraph("MS Excel Object");
            heading.TextBody.Paragraphs[0].Font.Italic = true;
            heading.TextBody.Paragraphs[0].Font.Bold = true;
            heading.TextBody.Paragraphs[0].Font.FontSize = 18;

            string excelPath = "OleTemplate.xlsx";
            //Get the excel file as stream
            Stream excelStream = new FileStream(ResolveApplicationDataPath(excelPath), FileMode.Open);
            string imagePath = "OlePicture.png";
            //Image to be displayed, This can be any image
            Stream imageStream = new FileStream(ResolveApplicationImagePath(imagePath), FileMode.Open);

            IOleObject oleObject = slide.Shapes.AddOleObject(imageStream, "Excel.Sheet.12", excelStream);
			//Set size and position of the ole object
            oleObject.Left = 3.29 * 72;
            oleObject.Top = 2.01 * 72;
            oleObject.Width = 6.94 * 72;
            oleObject.Height = 5.13 * 72;
            return new PresentationResult(presentation, "InsertOLEObject.pptx", HttpContext.ApplicationInstance.Response);
           
        }
    }
}
