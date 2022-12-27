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
using System.Drawing;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /RangeManipulation/

        public ActionResult RangeManipulation(string Saveoption)
        {
            if (Saveoption == null)
                return View();

            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            IWorkbook workbook;

            //Opening the Existing worksheet from a Workbook
            if (Saveoption == "Xls")
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                workbook = application.Workbooks.Open(ResolveApplicationDataPath("RangeManipulation.xls"));
            }
            else
            {
                application.DefaultVersion = ExcelVersion.Excel2016;
                workbook = application.Workbooks.Open(ResolveApplicationDataPath("RangeManipulation.xlsx"));
            }         
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            # region AutoFilter

            //Creating an AutoFilter in the first worksheet. Specifying the Autofilter range. 
            sheet.AutoFilters.FilterRange = sheet.Range["B14:E91"];

            //Counting the auto filtered value.
            sheet.Range["D9"].Formula = "=SUBTOTAL(2,B14:B91)";

            # endregion

            # region Range copy

            // Copying a Range
            IRange source = sheet.Range["D8:D9"];
            IRange des = sheet.Range["E93"];
            source.CopyTo(des, ExcelCopyRangeOptions.CopyValueAndSourceFormatting);

            #endregion

            # region Clear Range
            source.Clear(true);
            # endregion

            # region Named Range

            //Defining the Range 
            IName lname1 = sheet.Names.Add("One");

            //Another way to refer range of cells.
            lname1.RefersToRange = sheet.Range[98, 4, 98, 5];

            #endregion

            # region Merge Cells

            sheet.Range["One"].Merge();
            sheet.Range["One"].Text = "Thank you for choosing the product";
            sheet.Range["One"].CellStyle.Font.Bold = true;

            #endregion

            # region MigrantRange

            //Optimal method for writting strings in the given range.
            IMigrantRange migrantRange = sheet.MigrantRange;
            migrantRange.ResetRowColumn(6, 4);
            migrantRange.Value = "INVENTORY REPORT";
            migrantRange.CellStyle.Font.Bold = true;
            migrantRange.CellStyle.Font.Size = 16;

            #endregion

            try
            {
                // Save the file
                if (Saveoption == "Xls")
                    return excelEngine.SaveAsActionResult(workbook, "RangeManipulation.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                else
                    return excelEngine.SaveAsActionResult(workbook, "RangeManipulation.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

            }
            catch (Exception)
            {
            }

            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            return View();
        }
    }
}
