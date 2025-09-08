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
using Syncfusion.XlsIO;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /Bar/

        public ActionResult BoxAndWhisker(string button, string Saveoption)
        {
            if (button == null)
                return View();
            if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"BoxAndWhiskerTemplate.xlsx"));
                return excelEngine.SaveAsActionResult(workbook, "InputTemplate.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            else
            {
                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;
                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //Open workbook with Data
                IWorkbook workbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("BoxAndWhiskerTemplate.xlsx"));                
                IWorksheet sheet = workbook.Worksheets[0];
                IChart chart = null;

                if (Saveoption == "sheet")
                    chart = workbook.Charts.Add();
                else
                    chart = workbook.Worksheets[0].Charts.Add();

                #region Box and Whisker Chart Settings
                chart.ChartType = ExcelChartType.BoxAndWhisker;
                chart.DataRange = sheet["B1:C181"];
                IChartSerie series = chart.Series[0];
                series.SerieFormat.ShowInnerPoints = false;
                series.SerieFormat.ShowOutlierPoints = true;
                series.SerieFormat.ShowMeanMarkers = true;
                series.SerieFormat.ShowMeanLine = false;
                series.SerieFormat.QuartileCalculationType = ExcelQuartileCalculation.ExclusiveMedian;
                series.SerieFormat.Fill.ForeColorIndex = ExcelKnownColors.Grey_25_percent;
                chart.ChartTitle = "Box & Whisker Plot for Price Distribution of Books by Genre";
                #endregion
               
                chart.Legend.Position = ExcelLegendPosition.Right;                

                if (Saveoption=="sheet")
                {
                    chart.Activate();                  
                }
                else
                {
                    workbook.Worksheets[0].Activate();
                    IChartShape chartShape = chart as IChartShape;
                    chartShape.TopRow = 1;
                    chartShape.BottomRow = 20;
                    chartShape.LeftColumn = 6;
                    chartShape.RightColumn = 13;
                }            
                try
                {
                  return excelEngine.SaveAsActionResult(workbook, "BoxAndWhisker_Chart.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
                catch (Exception)
                {
                }

                workbook.Close();
                excelEngine.Dispose();
            }
            return View();
        }

    }
}
