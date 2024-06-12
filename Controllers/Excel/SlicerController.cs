#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //Table Slicer

        public ActionResult Slicer(string view, string Columns1, string Columns2)
        {

            if (Columns1 == null)
                return View();

            if (view == "Input Template")
            {
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"TableSlicer.xlsx"));
                workbook.Version = ExcelVersion.Excel2016;

                return excelEngine.SaveAsActionResult(workbook, "InputTemplate.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

                excelEngine.Dispose();
            }

            else
            {
                string fileName = "TableSlicer.xlsx";

                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(fileName));
                workbook.Version = ExcelVersion.Excel2016;
                IWorksheet sheet = workbook.Worksheets[0];

                IListObject table = sheet.ListObjects[0];

                //Get the column id from the given column name
                int colId1 = GetColumnId(Columns1, table);
                int colId2 = GetColumnId(Columns2, table);

                // Add slicer for the table
                sheet.Slicers.Add(table, colId1, 11, 2);
                sheet.Slicers.Add(table, colId2, 11, 4);

                return excelEngine.SaveAsActionResult(workbook, fileName, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

                excelEngine.Dispose();
            }
        }

        private int GetColumnId(String columnName, IListObject table)
        {
            int colId = 0;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].Name == columnName)
                {
                    colId = i + 1;
                    break;
                }
            }
            return colId;
        }

    }
}
