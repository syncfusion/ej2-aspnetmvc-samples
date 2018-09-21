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

namespace EJ2MVCSampleBrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /WorksheetManipulation/

        public ActionResult WorksheetManipulation(string button, string SaveOption)
        {
            if (button == null)
                return View();
            else if (button == "Input Template")
            {
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"SourceWorkbookTemplate.xls"));
                return excelEngine.SaveAsActionResult(workbook, "Template.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
              
            }
            else
            {
            //New instance of Excel is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel object.
            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2016;
            //Open the Source WorkBook    
            IWorkbook sourceWorkbook;

            //Open the Destination WorkBook    
            IWorkbook destinationWorkbook;
            if (SaveOption == "Xls")
            {
                sourceWorkbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("SourceWorkbookTemplate.xls"));
                destinationWorkbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("DestinationWorkbookTemplate.xls"));
            }
            else
            {
                sourceWorkbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("SourceWorkbookTemplate.xlsx"));
                destinationWorkbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("DestinationWorkbookTemplate.xlsx"));
            }
            //Copy the first worksheet from Source workbook to destination workbook.
            destinationWorkbook.Worksheets.AddCopy(sourceWorkbook.Worksheets[0]);

            //Activate the newly added worksheet in the destination workbook.
            destinationWorkbook.ActiveSheetIndex = 1;
            if (SaveOption == "Xls")
                destinationWorkbook.Version = ExcelVersion.Excel97to2003;
            else
                destinationWorkbook.Version = ExcelVersion.Excel2016;
            try
            {
                //Saving the workbook to disk.
                if (SaveOption == "Xlsx")
                    return excelEngine.SaveAsActionResult(destinationWorkbook, "WorksheeetManipulation.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                else
                    return excelEngine.SaveAsActionResult(destinationWorkbook, "WorksheeetManipulation.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
            }
            catch (Exception)
            {
            }

            destinationWorkbook.Close();
            sourceWorkbook.Close();
            excelEngine.Dispose();
           
        }
         return View();
    }

    }
}
