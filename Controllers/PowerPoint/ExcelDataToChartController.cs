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
using Syncfusion.OfficeChart;
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        public ActionResult ExcelDataToChart()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ExcelDataToChart(string Browser)
        {
            IPresentation presentation = Presentation.Create();
            // New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

            //  Method call to create slides
            CreateChart2(presentation);

            //  Saves the presentation
            return new PresentationResult(presentation, "Chart.pptx", HttpContext.ApplicationInstance.Response);
        }

        # region Slide1
        private void CreateChart2(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides.Add(SlideLayoutType.TitleOnly);
            IShape titleShape = slide1.Shapes[0] as IShape;
            titleShape.Height = 1.45 * 72;
            titleShape.Width = 11.5 * 72;
            titleShape.Left = 0.92 * 72;
            titleShape.Top = 0.4 * 72;

            IParagraph titleParagarph = titleShape.TextBody.AddParagraph();
            ITextPart titleTextPart = titleParagarph.TextParts.Add();
            titleTextPart.Text = "Northwind Management Report";
            titleTextPart.Font.FontSize = 44;
            titleTextPart.Font.FontName = "Calibri Light (Headings)";
            titleParagarph.HorizontalAlignment = HorizontalAlignmentType.Center;
            titleTextPart.Font.Color = ColorObject.FromArgb(0, 112, 48, 160);

            //Load the excel template as stream
            Stream excelStream = new FileStream(ResolveApplicationDataPath(@"..\PowerPoint\Excel_Template.xlsx"), FileMode.Open, FileAccess.Read, FileShare.Read);
            RectangleF chartSize = new RectangleF();
            chartSize.Width = (float)9.66 * 72;
            chartSize.Height = (float)5.57 * 72;

            IPresentationChart excelChart = slide1.Shapes.AddChart(excelStream, 1, "B2:C6", chartSize);
            //Set chart data
            excelChart.ChartType = OfficeChartType.Bar_Clustered;
            excelChart.ChartTitle = "Purchase Details";
            excelChart.ChartTitleArea.FontName = "Calibri (Body)";
            excelChart.ChartTitleArea.Size = 14;
            //Set name to chart series            
            excelChart.Series[0].Name = "Sum of Purchases";
            excelChart.Series[1].Name = "Sum of Future Expenses";
            //Set Chart Data table
            excelChart.HasDataTable = true;
            excelChart.DataTable.HasBorders = true;
            excelChart.DataTable.HasHorzBorder = true;
            excelChart.DataTable.HasVertBorder = true;
            excelChart.DataTable.ShowSeriesKeys = true;
            excelChart.HasLegend = false;
            //Setting background color
            excelChart.ChartArea.Fill.ForeColor = Color.FromArgb(208, 206, 206);
            excelChart.PlotArea.Fill.ForeColor = Color.FromArgb(208, 206, 206);
            //Setting line pattern to the chart area
            excelChart.PrimaryCategoryAxis.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.PrimaryValueAxis.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;
            excelChart.PrimaryValueAxis.MajorGridLines.Border.LineColor = Color.FromArgb(175, 171, 171);
            //Set label for primary catagory axis
            excelChart.PrimaryCategoryAxis.CategoryLabels = excelChart.ChartData[2, 1, 6, 1];
            excelChart.CategoryLabelLevel = OfficeCategoriesLabelLevel.CategoriesLabelLevelNone;
            //excelChart.XPos = (float)1.6 * 72;
            //excelChart.YPos = (float)1.8 * 72;
            slide1.Shapes[1].Left = (float)1.8 * 72;
            slide1.Shapes[1].Top = (float)1.6 * 72;
        }
        #endregion     
    }
}