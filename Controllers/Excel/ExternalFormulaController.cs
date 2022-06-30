#region Copyright Syncfusion Inc. 2001-2022.
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
using System.Drawing;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        #region Constants
        private const string DEFAULTPATH = @"..\\..\\..\\App_Data\\XlsIO\\";
        #endregion
        //
        // GET: /ExternalFormula/

        public ActionResult ExternalFormula(string button)
        {
            ViewData["computedValue"] = "";

            //Read Formula
            ViewData["formulaString"] = "";
            if (button == null)
                return View();
            else if (button == "Write Formula")
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //The new workbook will have 3 worksheets
                IWorkbook workbook = application.Workbooks.Create(1);

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];

                string fullPath = new System.IO.DirectoryInfo(Request.PhysicalPath + DEFAULTPATH).FullName;

                //External formula from another workboook
                worksheet.Range["A1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$1";
                worksheet.Range["A2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$2";
                worksheet.Range["A3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$3";
                worksheet.Range["A4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$4";
                worksheet.Range["A5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$5";
                worksheet.Range["A6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$6";
                worksheet.Range["A7"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$7";
                worksheet.Range["B1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$1";
                worksheet.Range["B2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$2";
                worksheet.Range["B3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$3";
                worksheet.Range["B4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$4";
                worksheet.Range["B5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$5";
                worksheet.Range["B6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$B$6";
                worksheet.Range["C1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$1";
                worksheet.Range["C2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$2";
                worksheet.Range["C3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$3";
                worksheet.Range["C4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$4";
                worksheet.Range["C5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$5";
                worksheet.Range["C6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$C$6";
                worksheet.Range["D1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$1";
                worksheet.Range["D2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$2";
                worksheet.Range["D3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$3";
                worksheet.Range["D4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$4";
                worksheet.Range["D5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$5";
                worksheet.Range["D6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$D$6";
                worksheet.Range["E1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$1";
                worksheet.Range["E2"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$2";
                worksheet.Range["E3"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$3";
                worksheet.Range["E4"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$4";
                worksheet.Range["E5"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$5";
                worksheet.Range["E6"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$E$6";
                worksheet.Range["F1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$F$1";
                worksheet.Range["B7"].Formula = "=SUM(B2:B6)";
                worksheet.Range["C7"].Formula = "=SUM(C2:C6)";
                worksheet.Range["D7"].Formula = "=SUM(D2:D6)";
                worksheet.Range["E7"].Formula = "=SUM(E2:E6)";
                worksheet.Range["F7"].Formula = "=SUM(F2:F6)";
                worksheet.Range["F2"].Formula = "=B2*C2+D2-E2";
                worksheet.Range["F3"].Formula = "=B3*C3+D3-E3";
                worksheet.Range["F4"].Formula = "=B4*C4+D4-E4";
                worksheet.Range["F5"].Formula = "=B5*C5+D5-E5";
                worksheet.Range["F6"].Formula = "=B6*C6+D6-E6";
                worksheet.Range["A1:F7"].CellStyle.Font.FontName = "Verdana";
                worksheet.Range["C2:F7"].NumberFormat = "_($* #,##0.00_)";
                worksheet.Range["A1:F1"].CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192);
                worksheet.Range["A7:F7"].CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192);
                worksheet.Range["A1:F1"].CellStyle.Font.Bold = true;
                worksheet.Range["A1:F1"].CellStyle.Font.Size = 11;
                worksheet.Columns[0].ColumnWidth = 17;
                worksheet.Columns[1].ColumnWidth = 13;
                worksheet.Columns[2].ColumnWidth = 11;
                worksheet.Columns[3].ColumnWidth = 11;
                worksheet.Columns[4].ColumnWidth = 13;
                worksheet.Columns[5].ColumnWidth = 13;

                worksheet.Calculate();

                string fileName = "ExternalFormula.xlsx";
                try
                {
                    //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
                    //an existing spreadsheet and then saving the result to a new workbook.
                    return excelEngine.SaveAsActionResult(workbook, fileName, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
                catch (Exception)
                {
                }

                workbook.Close();
                excelEngine.Dispose();
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                IWorkbook workbook = application.Workbooks.Create(1);

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];

                string fullPath = new System.IO.DirectoryInfo(Request.PhysicalPath + DEFAULTPATH).FullName;

                //External formula from another workboook
                worksheet.Range["A1"].Formula = @"='" + fullPath + "[External_Input.xlsx]Sheet1'!$A$1";

                worksheet.EnableSheetCalculations();

                //Read computed Formula Value. 
                ViewData["computedValue"] = worksheet.Range["A1"].CalculatedValue;

                //Read Formula
                ViewData["formulaString"] = worksheet.Range["A1"].Formula;

                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
            }
            return View();
        }

    }
}
