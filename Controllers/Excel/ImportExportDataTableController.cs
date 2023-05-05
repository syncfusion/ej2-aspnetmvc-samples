#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        public static DataTable dataTable = null;
        public ActionResult ImportExportDataTable(string saveOption, string button, string importOption)
        {
            string fileName = "NorthwindDataTemplate.xls";

            ViewBag.exportButtonState = "disabled=\"disabled\"";

            ///SaveOption Null
            if (saveOption == null || button == null)
            {
                ViewBag.DataSource = null;
                return View();
            }

            //Start Business Object Functions
            if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(fileName));
                return excelEngine.SaveAsActionResult(workbook, fileName, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
            }
            else if (button == "Import From Excel")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(fileName));

                IWorksheet sheet = workbook.Worksheets[0];

                if (importOption == "Skip")
                {
                    sheet.ExportDataTableEvent += Sheet_ExportDataTableEventSkip;
                    ViewBag.importOptionSkip = "value=" + importOption + " checked = \"checked\"";
                }
                else if (importOption == "Replace")
                {
                    sheet.ExportDataTableEvent += Sheet_ExportDataTableEventReplace;
                    ViewBag.importOptionReplace = "value=" + importOption + " checked = \"checked\"";
                }
                else
                {
                    sheet.ExportDataTableEvent += Sheet_ExportDataTableEventStop;
                    ViewBag.importOptionStop = "value=" + importOption + " checked = \"checked\"";
                }

                dataTable = sheet.ExportDataTable(sheet.UsedRange, ExcelExportDataTableOptions.ColumnNames); 

                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
                
                ViewBag.DataSource = dataTable;
                ViewBag.exportButtonState = "";

                return View();
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;

                if (saveOption == "Xls")
                    application.DefaultVersion = ExcelVersion.Excel97to2003;
                else
                    application.DefaultVersion = ExcelVersion.Excel2016;

                //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
                //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
                IWorkbook workbook;
                workbook = excelEngine.Excel.Workbooks.Create(1);
                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                //Import data table to worksheet
                sheet.ImportDataTable(dataTable, true ,1, 1, true);

                sheet.UsedRange.AutofitColumns();

                try
                {
                    //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
                    //an existing spreadsheet and then saving the result to a new workbook.

                    if (saveOption == "Xlsx")
                        return excelEngine.SaveAsActionResult(workbook, "ExportDataTable.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                    else
                        return excelEngine.SaveAsActionResult(workbook, "ExportDataTable.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
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
        /// <summary>
        /// Skip Row 
        /// </summary>
        /// <param name="exportDataTableArgs">ExportDataTableEventArgs</param>
        private void Sheet_ExportDataTableEventSkip(ExportDataTableEventArgs exportDataTableArgs)
        {
            if (exportDataTableArgs.ExcelColumnIndex == 4 && exportDataTableArgs.ExcelValue.ToString() == "Owner")
                exportDataTableArgs.ExportDataTableAction = ExportDataTableActions.SkipRow;
        }
        /// <summary>
        /// Replace value 
        /// </summary>
        /// <param name="exportDataTableArgs">ExportDataTableEventArgs</param>
        private void Sheet_ExportDataTableEventReplace(ExportDataTableEventArgs exportDataTableArgs)
        {
            if (exportDataTableArgs.ExcelValue != null && exportDataTableArgs.ExcelValue.ToString() == "México D.F.")
                exportDataTableArgs.DataTableValue = "Mexico";
        }
        /// <summary>
        /// Stop Exporting  
        /// </summary>
        /// <param name="exportDataTableArgs">ExportDataTableEventArgs</param>
        private void Sheet_ExportDataTableEventStop(ExportDataTableEventArgs exportDataTableArgs)
        {
            if (exportDataTableArgs.ExcelValue != null && exportDataTableArgs.ExcelValue.ToString() == "BLONP")
                exportDataTableArgs.ExportDataTableAction = ExportDataTableActions.StopExporting;
        }
    }
}