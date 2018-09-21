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
        // GET: /PivotChart/

        public ActionResult PivotChart(string button)
        {
            if (button == null)
                return View();

            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            
            IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("PivotCodeDate.xlsx"));
            workbook.Version = ExcelVersion.Excel2016;
            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            //Access the sheet to draw pivot table.
            IWorksheet pivotSheet = workbook.Worksheets[1];

            //Select the data to add in cache
            IPivotCache cache = workbook.PivotCaches.Add(sheet["A1:H50"]);

            //Insert the pivot table. 
            IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A1"], cache);
            pivotTable.Fields[2].Axis = PivotAxisTypes.Row;
            pivotTable.Fields[4].Axis = PivotAxisTypes.Row;
            pivotTable.Fields[3].Axis = PivotAxisTypes.Column;

            IPivotField field = pivotSheet.PivotTables[0].Fields[5];
            pivotTable.DataFields.Add(field, "Sum of Units", PivotSubtotalTypes.Sum);

            //Show expand/collapse button.
            pivotTable.ShowDrillIndicators = true;

            //Shows row grand.
            pivotTable.RowGrand = true;

            //Shows filter and field caption.
            pivotTable.DisplayFieldCaptions = true;

            //Apply built in style.
            pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium2;

            //Add the Pivot chart sheet to the workbook.
            IChart pivotChartSheet = workbook.Charts.Add();
            pivotChartSheet.Name = "PivotChart";

            //Set the Pivot source for the Pivot Chart.
            pivotChartSheet.PivotSource = pivotTable;

            //Set the Pivot Chart Type.
            pivotChartSheet.PivotChartType = ExcelChartType.Column_Clustered;

            pivotSheet.Range[1, 1, 1, 14].ColumnWidth = 11;
            pivotSheet.SetColumnWidth(1, 15.29);
            pivotSheet.SetColumnWidth(2, 15.29);
            //Activate the pivot sheet.
            pivotChartSheet.Activate();

            try
            {
                return excelEngine.SaveAsActionResult(workbook, "PivotChart.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
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
