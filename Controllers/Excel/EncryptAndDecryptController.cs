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
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /EncryptAndDecrypt/

        public ActionResult EncryptAndDecrypt(string button, string SaveOption)
        {
            if (button == null)
                return View();
            else if (button == "Encrypt Document")
            {

                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;              
                application.DefaultVersion = ExcelVersion.Excel2016;

                // Opening the Existing Worksheet from a Workbook.
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("Encrypt.xlsx"));
                
                //Encrypt the workbook with password.
                workbook.PasswordToOpen = "syncfusion";

                try
                {
                    if (SaveOption == "Xls")
                    {
                        workbook.Version = ExcelVersion.Excel97to2003;
                        return excelEngine.SaveAsActionResult(workbook, "EncryptedWorkbook.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog);
                    }
                    else
                    {
                        //Saving the workbook to disk.
                        return excelEngine.SaveAsActionResult(workbook, "EncryptedWorkbook.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog);
                    }
                }
                catch (Exception)
                {
                }

                // Close the workbook
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
                application.DefaultVersion = ExcelVersion.Excel2016;


                // Opening the encrypted Workbook.
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("EncryptedSpreadsheet.xlsx"), ExcelParseOptions.Default, true, "syncfusion");

                //Modify the decrypted document.
                workbook.Worksheets[0].Range["B2"].Text = "Demo for workbook decryption with Essential XlsIO";
                workbook.Worksheets[0].Range["B5"].Text = "This document is decrypted using password 'syncfusion'.";

                workbook.PasswordToOpen = "";

                try
                {
                    if (SaveOption == "Xls")
                    {
                        workbook.Version = ExcelVersion.Excel97to2003;
                        return excelEngine.SaveAsActionResult(workbook, "EncryptAndDecrypt.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog);
                    }
                    else
                    {
                        //Saving the workbook to disk.
                        return excelEngine.SaveAsActionResult(workbook, "EncryptAndDecrypt.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog);
                    }
                }
                catch (Exception)
                {
                }

                // Close the workbook
                workbook.Close();
                excelEngine.Dispose();
            }
            return View();
        }

    }
}
