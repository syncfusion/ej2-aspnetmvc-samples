#region Copyright
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
using System.Data;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region Pie Chart
        public ActionResult PieChart(string Group1)
        {
            if (Group1 == null)
                return View();

           //A new document is created.
            WordDocument document = new WordDocument(ResolveApplicationDataPath("PieChart.docx", "Data\\Word"));
			//Get chart data from xml file
            DataSet ds = new DataSet();
            ds.ReadXml(ResolveApplicationDataPath("Products.xml", "Data\\Word"));
            //Merge the product table in the Word document
            document.MailMerge.ExecuteGroup(ds.Tables["Product"]);
            //Find the Placeholder of Pie chart to insert
            TextSelection selection = document.Find("<Pie Chart>", false, false);
            WParagraph paragraph = selection.GetAsOneRange().OwnerParagraph;
            paragraph.ChildEntities.Clear();
            //Create and Append chart to the paragraph
            WChart pieChart = paragraph.AppendChart(446, 270);
            //Set chart data
            pieChart.ChartType = OfficeChartType.Pie;
            pieChart.ChartTitle = "Best Selling Products";
            pieChart.ChartTitleArea.FontName = "Calibri (Body)";
            pieChart.ChartTitleArea.Size = 14;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                pieChart.ChartData.SetValue(i + 2, 1, ds.Tables[0].Rows[i].ItemArray[1]);
                pieChart.ChartData.SetValue(i + 2, 2, ds.Tables[0].Rows[i].ItemArray[2]);
            }
            //Create a new chart series with the name “Sales”
            IOfficeChartSerie pieSeries = pieChart.Series.Add("Sales");
            pieSeries.Values = pieChart.ChartData[2, 2, 11, 2];
            //Setting data label
            pieSeries.DataPoints.DefaultDataPoint.DataLabels.IsPercentage = true;
            pieSeries.DataPoints.DefaultDataPoint.DataLabels.Position = OfficeDataLabelPosition.Outside;
            //Setting background color
            pieChart.ChartArea.Fill.ForeColor = System.Drawing.Color.FromArgb(242, 242, 242);
            pieChart.PlotArea.Fill.ForeColor = System.Drawing.Color.FromArgb(242, 242, 242);
            pieChart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;
            pieChart.PrimaryCategoryAxis.CategoryLabels = pieChart.ChartData[2, 1, 11, 1];

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
            return View();
            #endregion Document save option
        }
        #endregion 
    }
}
