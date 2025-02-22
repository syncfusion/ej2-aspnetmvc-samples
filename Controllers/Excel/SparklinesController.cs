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
using System.Drawing;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /Sparklines/

        public ActionResult Sparklines(string button)
        {

            if (button == null)
                return View();

            //Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2016;
            //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
            //Open workbook with Data
            IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("Sparkline.xlsx"));

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            #region WholeSale Report

            //A new Sparkline group is added to the sheet sparklinegroups
            ISparklineGroup sparklineGroup = sheet.SparklineGroups.Add();

            //Set the Sparkline group type as line
            sparklineGroup.SparklineType = SparklineType.Line;

            //Set to display the empty cell as line
            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Line;

            //Sparkline group style properties
            sparklineGroup.ShowFirstPoint = true;
            sparklineGroup.FirstPointColor = Color.Green;
            sparklineGroup.ShowLastPoint = true;
            sparklineGroup.LastPointColor = Color.DarkOrange;
            sparklineGroup.ShowHighPoint = true;
            sparklineGroup.HighPointColor = Color.DarkBlue;
            sparklineGroup.ShowLowPoint = true;
            sparklineGroup.LowPointColor = Color.DarkViolet;
            sparklineGroup.ShowMarkers = true;
            sparklineGroup.MarkersColor = Color.Black;
            sparklineGroup.ShowNegativePoint = true;
            sparklineGroup.NegativePointColor = Color.Red;

            //set the line weight
            sparklineGroup.LineWeight = 0.3;

            //The sparklines are added to the sparklinegroup.
            ISparklines sparklines = sparklineGroup.Add();

            //Set the Sparkline Datarange .
            IRange dataRange = sheet.Range["D6:G17"];
            //Set the Sparkline Reference range.
            IRange referenceRange = sheet.Range["H6:H17"];

            //Create a sparkline with the datarange and reference range.
            sparklines.Add(dataRange, referenceRange);
            #endregion

            #region Retail Trade

            //A new Sparkline group is added to the sheet sparklinegroups
            sparklineGroup = sheet.SparklineGroups.Add();

            //Set the Sparkline group type as column
            sparklineGroup.SparklineType = SparklineType.Column;

            //Set to display the empty cell as zero
            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero;

            //Sparkline group style properties
            sparklineGroup.ShowHighPoint = true;
            sparklineGroup.HighPointColor = Color.Green;
            sparklineGroup.ShowLowPoint = true;
            sparklineGroup.LowPointColor = Color.Red;
            sparklineGroup.ShowNegativePoint = true;
            sparklineGroup.NegativePointColor = Color.Black;

            //The sparklines are added to the sparklinegroup.
            sparklines = sparklineGroup.Add();

            //Set the Sparkline Datarange .
            dataRange = sheet.Range["D21:G32"];
            //Set the Sparkline Reference range.
            referenceRange = sheet.Range["H21:H32"];

            //Create a sparkline with the datarange and reference range.
            sparklines.Add(dataRange, referenceRange);

            #endregion

            #region Manufacturing Trade

            //A new Sparkline group is added to the sheet sparklinegroups
            sparklineGroup = sheet.SparklineGroups.Add();

            //Set the Sparkline group type as win/loss
            sparklineGroup.SparklineType = SparklineType.ColumnStacked100;

            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero;

            sparklineGroup.DisplayAxis = true;
            sparklineGroup.AxisColor = Color.Black;
            sparklineGroup.ShowFirstPoint = true;
            sparklineGroup.FirstPointColor = Color.Green;
            sparklineGroup.ShowLastPoint = true;
            sparklineGroup.LastPointColor = Color.Orange;
            sparklineGroup.ShowNegativePoint = true;
            sparklineGroup.NegativePointColor = Color.Red;

            sparklines = sparklineGroup.Add();

            dataRange = sheet.Range["D36:G46"];
            referenceRange = sheet.Range["H36:H46"];

            sparklines.Add(dataRange, referenceRange);

            #endregion

            try
            {
                //Saving the workbook to disk.
                return excelEngine.SaveAsActionResult(workbook, "Sparklines.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            catch (Exception)
            {
            }

            workbook.Close();
            excelEngine.Dispose();
            return View();
        }

    }
}
