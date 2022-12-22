#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /Create/

        #region Getting Started
        public ActionResult ExcelToODS(string button)
        {
            if (button == null)
                return View();

            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Creating new workbook
            IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"ExcelToODS.xlsx"), ExcelOpenType.Automatic);
            IWorksheet sheet = workbook.Worksheets[0];
           
            
            return excelEngine.SaveAsActionResult(workbook, "ExcelToODS.ods", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.ODS);            
        }
        #endregion
    }
}
