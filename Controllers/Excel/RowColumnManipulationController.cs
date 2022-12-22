#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /RowColumnManipulation/

        public ActionResult RowColumnManipulation(string Saveoption, string button)
        {

            if (Saveoption == null)
                return View();
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"monthly_sales.xlsx"));
                return excelEngine.SaveAsActionResult(workbook, "Template.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //The new workbook will have 3 worksheets
                IWorkbook workbook;

                if (Saveoption == "Xlsx")
                {
                    application.DefaultVersion = ExcelVersion.Excel2016;
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath("monthly_sales.xlsx"));
                }
                else
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath("monthly_sales.xls"));

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                #region Grouping and ungrouping

                // Grouping by Rows
                sheet.Range["C5:F7"].Group(ExcelGroupBy.ByRows);

                // Grouping by Columns
                sheet.Range["C10:F10"].Group(ExcelGroupBy.ByColumns);

                #endregion

                #region Hiding unhiding

                // Hiding fifth and sixth Column
                sheet.ShowColumn(5, false);
                sheet.ShowColumn(6, false);

                //Showing the 28th row
                sheet.ShowRow(28, true);

                #endregion

                #region Insert and delete

                //Deleting Row
                sheet.DeleteRow(25);

                //Inserting Column
                sheet.InsertColumn(7, 1, ExcelInsertOptions.FormatAsBefore);
                sheet.Range["G4"].Text = "Loss/Gain";

                //Deleting Column
                sheet.DeleteColumn(8);

                #endregion

                #region ColumnWidth and RowHeight

                // Changing the Column Width
                sheet.Range["D5"].ColumnWidth = 15;

                // Changing the Row Height
                sheet.Range["D29"].RowHeight = 25;

                #endregion

                try
                {
                    // Save the file
                    if (Saveoption == "Xls")
                        return excelEngine.SaveAsActionResult(workbook, "RowColumnManipulation.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                    else
                        return excelEngine.SaveAsActionResult(workbook, "RowColumnManipulation.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

                }
                catch (Exception)
                {
                }

                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
            }
            return View();
        }
    }
}
