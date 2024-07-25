#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
using Syncfusion.OfficeChart;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.Pdf;
using System.Drawing;
using System.IO;


namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        public ActionResult Notes()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Notes(string button, FormCollection form)
        {
            if (button == null)
                return View();
            Stream sourceFile = new FileStream(ResolveApplicationDataPath(@"..\PowerPoint\Images.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);

            //Opens a PowerPoint presentation
            IPresentation presentation = Presentation.Open(sourceFile);

            //  Method call to create slides
            SlideWithNotes1(presentation);
            SlideWithNotes2(presentation);
            string choice = form["File Type"];
            if (choice == "PPTX")

                //  Saves the presentation
                return new PresentationResult(presentation, "Sample.pptx", HttpContext.ApplicationInstance.Response);

            else
            {
                presentation.ChartToImageConverter = new ChartToImageConverter();
                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                //Select the notes pages option to convert the notes content to pdf.
                settings.PublishOptions = PublishOptions.NotesPages;
                PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation, settings);

                //Saves the pdf document
                //return new Syncfusion.Mvc.Pdf.PdfResult(pdfDocument, "PPTXToPDF.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                MemoryStream stream = new MemoryStream();
                pdfDocument.Save(stream);
                stream.Position = 0;
                return File(stream, "application/pdf", "PPTXToPDF.pdf");
            }

        }

        #region Slide1
        private void SlideWithNotes1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            IShape shape1 = (IShape)slide1.Shapes[0];
            shape1.Left = 1.27 * 72;
            shape1.Top = 0.56 * 72;
            shape1.Width = 9.55 * 72;
            shape1.Height = 5.4 * 72;

            ITextBody textFrame = shape1.TextBody;
            IParagraphs paragraphs = textFrame.Paragraphs;
            paragraphs.Add();
            IParagraph paragraph = paragraphs[0];
            paragraph.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts = paragraph.TextParts;
            textParts.Add();
            ITextPart textPart = textParts[0];
            textPart.Text = "Essential Presentation ";
            textPart.Font.CapsType = TextCapsType.All;
            textPart.Font.FontName = "Calibri Light (Headings)";
            textPart.Font.FontSize = 80;
            textPart.Font.Color = ColorObject.Black;

            //Adding Notes
            INotesSlide notesSlide = slide1.AddNotesSlide();
            ITextPart notesTextPart = notesSlide.NotesTextBody.Paragraphs[0].TextParts.Add();
            notesTextPart.Text = "The slide represents the title content of the presentation";

            IPresentationChart chart = notesSlide.Shapes.AddChart(1.24 * 72, 5.71 * 72, 5 * 72, 3.33 * 72);


            //Specifies the chart title

            chart.ChartTitle = "Sales Analysis";

            //Sets chart data - Row1

            chart.ChartData.SetValue(1, 2, "Jan");

            chart.ChartData.SetValue(1, 3, "Feb");

            chart.ChartData.SetValue(1, 4, "March");

            //Sets chart data - Row2

            chart.ChartData.SetValue(2, 1, 2010);

            chart.ChartData.SetValue(2, 2, 60);

            chart.ChartData.SetValue(2, 3, 70);

            chart.ChartData.SetValue(2, 4, 80);

            //Sets chart data - Row3

            chart.ChartData.SetValue(3, 1, 2011);

            chart.ChartData.SetValue(3, 2, 80);

            chart.ChartData.SetValue(3, 3, 70);

            chart.ChartData.SetValue(3, 4, 60);

            //Sets chart data - Row4

            chart.ChartData.SetValue(4, 1, 2012);

            chart.ChartData.SetValue(4, 2, 60);

            chart.ChartData.SetValue(4, 3, 70);

            chart.ChartData.SetValue(4, 4, 80);

            //Creates a new chart series with the name

            IOfficeChartSerie serieJan = chart.Series.Add("Jan");

            //Sets the data range of chart serie – start row, start column, end row, end column

            serieJan.Values = chart.ChartData[2, 2, 4, 2];

            //Creates a new chart series with the name

            IOfficeChartSerie serieFeb = chart.Series.Add("Feb");

            //Sets the data range of chart serie – start row, start column, end row, end column

            serieFeb.Values = chart.ChartData[2, 3, 4, 3];

            //Creates a new chart series with the name

            IOfficeChartSerie serieMarch = chart.Series.Add("March");

            //Sets the data range of chart series – start row, start column, end row, end column

            serieMarch.Values = chart.ChartData[2, 4, 4, 4];

            //Sets the data range of the category axis

            chart.PrimaryCategoryAxis.CategoryLabels = chart.ChartData[2, 1, 4, 1];

            //Specifies the chart type

            chart.ChartType = OfficeChartType.Column_Clustered;

            chart.ChartTitle = "Chart inside Notes section";
        }
        #endregion

        # region Slide2
        private void SlideWithNotes2(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides.Add(SlideLayoutType.ContentWithCaption);
            slide2.Background.Fill.FillType = FillType.Solid;
            slide2.Background.Fill.SolidFill.Color = ColorObject.White;


            slide2.Shapes.RemoveAt(1);
            slide2.Shapes.RemoveAt(1);

            //Adds picture in the shape
            string dataPath = ResolveApplicationImagePath("tablet.jpg");
            Stream imageStream = System.IO.File.Open(dataPath, FileMode.Open);
            IPicture picture1 = slide2.Shapes.AddPicture(imageStream, 5.18 * 72, 1.15 * 72, 7.3 * 72, 5.31 * 72);
            imageStream.Close();

            //Adding Notes
            INotesSlide notesSlide = slide2.AddNotesSlide();
            ITextPart notesTextPart = notesSlide.NotesTextBody.Paragraphs[0].TextParts.Add();
            notesTextPart.Text = "The slide represents the picture content for the presentation";

            IShape shape = notesSlide.Shapes.AddShape(AutoShapeType.RoundedRectangle, 1.66 * 72, 6.32 * 72, 4.32 * 72, 2.66 * 72) as IShape;
            shape.LineFormat.Fill.SolidFill.Color = ColorObject.Black;

            shape.Fill.SolidFill.Color = ColorObject.White;
            // Adds a new paragraph with the text in the left hand side textbox.

            IParagraph paragraph = shape.TextBody.AddParagraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            //Sets the list type as Numbered

            paragraph.ListFormat.Type = ListType.Bulleted;

            //Sets the numbered style (list numbering) as Arabic number following by period.

            paragraph.ListFormat.NumberStyle = NumberedListStyle.ArabicPeriod;

            //Sets the starting value as 1

            paragraph.ListFormat.StartValue = 1;

            //Sets the list level as 1

            paragraph.IndentLevelNumber = 1;

            // Sets the hanging value

            paragraph.FirstLineIndent = -20;

            // Sets the bullet character size. Here, 100 means 100% of its text. Possible values can range from 25 to 400.

            paragraph.ListFormat.Size = 100;

            // Adds another paragraph with the text in the left hand side textbox.

            paragraph = shape.TextBody.AddParagraph("Ut enim ad ");

            //Sets the list type as bulleted

            paragraph.ListFormat.Type = ListType.Bulleted;

            //Sets the numbered style (list numbering) as Arabic number following by period.

            paragraph.ListFormat.NumberStyle = NumberedListStyle.ArabicPeriod;

            //Sets the list level as 1

            paragraph.IndentLevelNumber = 1;

            // Sets the hanging value

            paragraph.FirstLineIndent = -20;

            // Sets the bullet character size. Here, 100 means 100% of its text. Possible values can range from 25 to 400.

            paragraph.ListFormat.Size = 100;

            // Adds another paragraph with the text in the left hand side textbox.

            paragraph = shape.TextBody.AddParagraph("Duis aute irure dolor.");

            //Sets the list type as bulleted

            paragraph.ListFormat.Type = ListType.Bulleted;

            //Sets the list level as 1

            paragraph.IndentLevelNumber = 1;

            // Sets the hanging value

            paragraph.FirstLineIndent = -20;

            // Sets the bullet character size. Here, 100 means 100% of its text. Possible values can range from 25 to 400.

            paragraph.ListFormat.Size = 100;
        }
        #endregion

    }
}