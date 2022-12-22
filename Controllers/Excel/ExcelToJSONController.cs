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
using System.Web.Mvc;
using System.Drawing;
using System.IO;
using Syncfusion.XlsIO;


namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /ExcelToJSON/

        public ActionResult ExcelToJSON(string button, string checkBox, string ConvertOptions)
        {
            if (button == null)
                return View();
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"ExcelToJSON.xlsx"));
                return excelEngine.SaveAsActionResult(workbook, "InputTemplate.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            else if(button == "Convert to JSON")
            {
                //Initialize ExcelEngine
                ExcelEngine excelEngine = new ExcelEngine();

                //Initialize Application
                IApplication application = excelEngine.Excel;

                //Open the input template workbook
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"ExcelToJSON.xlsx"));

                //Accessing first worksheet in the workbook
                IWorksheet worksheet = workbook.Worksheets[0];

                IRange range = worksheet.Range["A2:B10"];

                bool isSchema = (checkBox == "Schema") ? true : false;

                //Save the Excel workbook as JSON file
                MemoryStream stream = new MemoryStream();
                if (ConvertOptions == "Workbook")
                    workbook.SaveAsJson(stream, isSchema);
                else if (ConvertOptions == "Worksheet")
                    workbook.SaveAsJson(stream, worksheet, isSchema);
                else if (ConvertOptions == "Range")
                    workbook.SaveAsJson(stream, range, isSchema);

                //If the position is not set to '0' then the file will be empty.
                stream.Position = 0;

                //Download the converted JSON file in the browser
                FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/json");
                fileStreamResult.FileDownloadName = "ExcelToJSON.json";

                workbook.Close();
                return fileStreamResult;
            }
            return View();
        }
    }
}