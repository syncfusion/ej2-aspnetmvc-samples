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

namespace EJ2MVCSampleBrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /Bar/

        public ActionResult FunnelChart(string button, string Saveoption)
        {
            if (button == null)
                return View();
            if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"FunnelChartTemplate.xlsx"));
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
                IWorkbook workbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("FunnelChartTemplate.xlsx"));                
                IWorksheet sheet = workbook.Worksheets[0];
                IChart chart = null;

                if (Saveoption == "sheet")
                    chart = workbook.Charts.Add();
                else
                    chart = workbook.Worksheets[0].Charts.Add();

                #region Funnel Chart Settings
                chart.ChartType = ExcelChartType.Funnel;
                chart.DataRange = sheet["A2:B8"];
                chart.ChartTitle = "Sales Pipeline";
                chart.Series[0].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
                chart.Series[0].DataPoints.DefaultDataPoint.DataLabels.Size = 8.5;
				chart.Series[0].SerieFormat.CommonSerieOptions.GapWidth = 100;
                #endregion
            
                chart.Legend.Position = ExcelLegendPosition.Right;

                if (Saveoption == "sheet")
                {
                    chart.Activate();
                }
                else
                {
                    workbook.Worksheets[0].Activate();
                    IChartShape chartShape = chart as IChartShape;
                    chartShape.TopRow = 2;
                    chartShape.BottomRow = 19;
                    chartShape.LeftColumn = 4;
                    chartShape.RightColumn = 11;
                }            
                try
                {
                    return excelEngine.SaveAsActionResult(workbook, "Funnel_Chart.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
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
