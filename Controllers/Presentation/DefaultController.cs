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
        // GET: /Default/

        public ActionResult Default()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Default(string Browser)
        {
            string filename = "HelloWorld.pptx";
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(DefaultResolveApplicationDataPath(filename));
            // New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

            //  Method call to create slides
            CreateSlide(presentation);

            //  Saves the presentation
            return new PresentationResult(presentation, "Sample.pptx", HttpContext.ApplicationInstance.Response);

        }

        # region Slide
        private void CreateSlide(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            IShape titleShape = slide1.Shapes[0] as IShape;
            titleShape.Left = 0.33 * 72;
            titleShape.Top = 0.58 * 72;
            titleShape.Width = 12.5 * 72;
            titleShape.Height = 1.75 * 72;

            ITextBody textFrame1 = (slide1.Shapes[0] as IShape).TextBody;
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            IParagraph paragraph = paragraphs1.Add();
            paragraph.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart1 = paragraph.AddTextPart();
            textPart1.Text = "Essential Presentation";
            textPart1.Font.CapsType = TextCapsType.All;
            textPart1.Font.FontName = "Adobe Garamond Pro";
            textPart1.Font.Bold = true;
            textPart1.Font.FontSize = 40;

            IShape subtitle = slide1.Shapes[1] as IShape;
            subtitle.Left = 0.5 * 72;
            subtitle.Top = 3 * 72;
            subtitle.Width = 11.8 * 72;
            subtitle.Height = 1.7 * 72;

            ITextBody textFrame2 = (slide1.Shapes[1] as IShape).TextBody;
            textFrame2.VerticalAlignment = VerticalAlignmentType.Top;
            IParagraphs paragraphs2 = textFrame2.Paragraphs;
            IParagraph para = paragraphs2.Add();
            para.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextPart textPart2 = para.AddTextPart();
            textPart2.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus.Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet.";
            textPart2.Font.FontName = "Adobe Garamond Pro";
            textPart2.Font.FontSize = 21;

            para = paragraphs2.Add();
            para.HorizontalAlignment = HorizontalAlignmentType.Left;
            textPart2 = para.AddTextPart();
            textPart2.Text = "Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet. Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula.";
            textPart2.Font.FontName = "Adobe Garamond Pro";
            textPart2.Font.FontSize = 21;

        }
        #endregion

        private string DefaultResolveApplicationDataPath(string fileName)
        {
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\App_Data") + "\\Presentation").FullName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }

        protected string DefaultResolveApplicationImagePath(string fileName)
        {
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\Content") + "\\Presentation").FullName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }
        
    }
}
