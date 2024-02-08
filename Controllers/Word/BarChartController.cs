#region Copyright
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.OfficeChart;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region Bar Chart
        public ActionResult BarChart(string Group1)
        {
            if (Group1 == null)
                return View();

            //A new document is created.
            WordDocument document = new WordDocument();
            //Add new section to the Word document
            IWSection section = document.AddSection();
            //Set page margins of the section
            section.PageSetup.Margins.All = 72;
            //Add new paragraph to the section
            IWParagraph paragraph = section.AddParagraph();
            //Apply heading style to the title paragraph
            paragraph.ApplyStyle(BuiltinStyle.Heading1);
            //Apply center alignment to the paragraph
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Append text to the paragraph
            paragraph.AppendText("Northwind Management Report").CharacterFormat.TextColor = System.Drawing.Color.FromArgb(46, 116, 181);
            //Add new paragraph
            paragraph = section.AddParagraph();
            //Set before spacing to the paragraph
            paragraph.ParagraphFormat.BeforeSpacing = 20;
             //Load the excel template as stream
            Stream excelStream = new FileStream(ResolveApplicationDataPath("Excel_Template.xlsx", "Data\\Word"), FileMode.Open, FileAccess.Read);
            //Create and Append chart to the paragraph with excel stream as parameter
            WChart BarChart = paragraph.AppendChart(excelStream, 1, "B2:C6", 470, 300);
            //Set chart data
            BarChart.ChartType = OfficeChartType.Bar_Clustered;
            BarChart.ChartTitle = "Purchase Details";
            BarChart.ChartTitleArea.FontName = "Calibri (Body)";
            BarChart.ChartTitleArea.Size = 14;
            //Set name to chart series            
            BarChart.Series[0].Name = "Sum of Purchases";
            BarChart.Series[1].Name = "Sum of Future Expenses";
            //Set Chart Data table
            BarChart.HasDataTable = true;
            BarChart.DataTable.HasBorders = true;
            BarChart.DataTable.HasHorzBorder = true;
            BarChart.DataTable.HasVertBorder = true;
            BarChart.DataTable.ShowSeriesKeys = true;
            BarChart.HasLegend = false;
            //Setting background color
            BarChart.ChartArea.Fill.ForeColor = System.Drawing.Color.FromArgb(208, 206, 206);
            BarChart.PlotArea.Fill.ForeColor = System.Drawing.Color.FromArgb(208, 206, 206);
            //Setting line pattern to the chart area
            BarChart.PrimaryCategoryAxis.Border.LinePattern = OfficeChartLinePattern.None;
            BarChart.PrimaryValueAxis.Border.LinePattern = OfficeChartLinePattern.None;
            BarChart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;
            BarChart.PrimaryValueAxis.MajorGridLines.Border.LineColor = System.Drawing.Color.FromArgb(175, 171, 171);
            //Set label for primary catagory axis
            BarChart.PrimaryCategoryAxis.CategoryLabels = BarChart.ChartData[2, 1, 6, 1];

            #region Document save option
            //Save as .docx format
            if (Group1 == "WordDocx")
            {
                return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group1 == "WordML")
            {
                return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            #endregion Document save option
            return View();
        }
        #endregion
    }
}
