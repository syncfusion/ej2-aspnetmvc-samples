#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
        // GET: /WorksheetProtection/

        public ActionResult WorksheetProtection(string button, string SaveOption)
        {
            if (button == null)
                return View();
            else if (button == "Lock Worksheet")
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                if (SaveOption == "Xls")
                    application.DefaultVersion = ExcelVersion.Excel97to2003;
                else
                    application.DefaultVersion = ExcelVersion.Excel2016;              

                // Opening the Existing Worksheet from a Workbook
                IWorkbook workbook = application.Workbooks.Create(1);
                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                sheet.Range["C5"].Text = "Worksheet protected with password 'syncfusion'";
                sheet.Range["C6"].Text = "You can't edit any cells other than A1 and A2";
                sheet.Range["C5"].CellStyle.Font.Bold = true;
                sheet.Range["C5"].CellStyle.Font.Size = 12;

                sheet.Range["C6"].CellStyle.Font.Bold = true;
                sheet.Range["C6"].CellStyle.Font.Size = 12;

                sheet.Range["C8"].Text = "For Excel 2003: Click 'Tools->Protection' to view the Protection settings.";
                sheet.Range["C8"].CellStyle.Font.Bold = true;
                sheet.Range["C8"].CellStyle.Font.Size = 12;

                sheet.Range["C10"].Text = "For Excel 2007 and above: Click 'Review Tab->Unprotect Sheet' to view the Protection settings.";
                sheet.Range["C10"].CellStyle.Font.Bold = true;
                sheet.Range["C10"].CellStyle.Font.Size = 12;

                sheet.Range["A1:A2"].Text = "You can edit this cell";
                sheet.Range["A1:A2"].CellStyle.Font.Bold = true;

                //Protecting Worksheet using Password
                sheet.Protect("syncfusion");

                //Unlocking the cells which are needed to be edited
                sheet.Range["A1"].CellStyle.Locked = false;
                sheet.Range["A2"].CellStyle.Locked = false;

                try
                {
                    //Saving the workbook to disk.
                    if (SaveOption == "Xlsx")
                        return excelEngine.SaveAsActionResult(workbook, "WorksheetProtectionTemplate.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                    else
                        return excelEngine.SaveAsActionResult(workbook, "WorksheetProtectionTemplate.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
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

                // Opening a Existing(Protected) Worksheet from a Workbook
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("WorksheetProtectionTemplate.xls"));
                //The first worksheet object in the worksheets collection is accessed.
                if (SaveOption == "Xls")
                    workbook.Version = ExcelVersion.Excel97to2003;               
                else
                    workbook.Version = ExcelVersion.Excel2016;

                IWorksheet sheet = workbook.Worksheets[0];

                //Unprotecting( unlocking) Worksheet using the Password
                sheet.Unprotect("syncfusion");

                sheet.Range["C5"].Text = "Worksheet is Unprotected with password 'syncfusion' and changes are done";
                sheet.Range["C6"].Text = "You can edit any cell";
                sheet.Range["A1:A2"].Text = " ";

                sheet.Range["C5"].CellStyle.Font.Bold = true;
                sheet.Range["C5"].CellStyle.Font.Size = 12;

                sheet.Range["C8"].Text = "Click 'Tools->Protection' to view the Protection settings.";
                sheet.Range["C8"].CellStyle.Font.Bold = true;
                sheet.Range["C8"].CellStyle.Font.Size = 12;

                try
                {
                    //Saving the workbook to disk.
                    if (SaveOption == "Xls")
                        return excelEngine.SaveAsActionResult(workbook, Server.MapPath("WorksheetProtection.xls"), HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                    else
                        return excelEngine.SaveAsActionResult(workbook, Server.MapPath("WorksheetProtection.xlsx"), HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
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
