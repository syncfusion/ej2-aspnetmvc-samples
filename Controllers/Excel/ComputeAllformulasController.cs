#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
        // GET: /ComputeAllformulas/

        public ActionResult ComputeAllformulas(string Saveoption)
        {
            if (Saveoption == null)
                return View();

            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Get the path of the input file.
            IWorkbook myWorkbook = excelEngine.Excel.Workbooks.Open(ResolveApplicationDataPath("TimelogTemplate.xls"));
            IWorksheet worksheet = myWorkbook.Worksheets[0];
            string FileName = "";

            // set the workbook version
            if (Saveoption == "Xls")
            {
                myWorkbook.Version = ExcelVersion.Excel97to2003;
                FileName = "ComputeFormulas.xls";
            }           
            else
            {
                myWorkbook.Version = ExcelVersion.Excel2016;
                FileName = "ComputeFormulas.xlsx";
            }

            //Enable to calculate the formulas in the sheet.s
            worksheet.EnableSheetCalculations();

            //hourly rate
            worksheet["G7"].Number = 11;

            //overtime rate.
            worksheet["J7"].Formula = "=SUM(G7*1.5)";

            //Regular hours
            worksheet["F10"].Formula = "=IF((((C10-B10)+(E10-D10))*24)>8,8,((C10-B10)+(E10-D10))*24)";
            worksheet["F11"].Formula = "=IF((((C11-B11)+(E11-D11))*24)>8,8,((C11-B11)+(E11-D11))*24)";
            worksheet["F12"].Formula = "=IF((((C12-B12)+(E12-D12))*24)>8,8,((C12-B12)+(E12-D12))*24)";
            worksheet["F13"].Formula = "=IF((((C13-B13)+(E13-D13))*24)>8,8,((C13-B13)+(E13-D13))*24)";
            worksheet["F14"].Formula = "=IF((((C14-B14)+(E14-D14))*24)>8,8,((C14-B14)+(E14-D14))*24)";
            worksheet["F15"].Formula = "=IF((((C15-B15)+(E15-D15))*24)>8,8,((C15-B15)+(E15-D15))*24)";

            //overtime hours
            worksheet["G10"].Formula = "=IF(((C10-B10)+(E10-D10))*24>8, ((C10-B10)+(E10-D10))*24-8,0)";
            worksheet["G11"].Formula = "=IF(((C11-B11)+(E11-D11))*24>8, ((C11-B11)+(E11-D11))*24-8,0)";
            worksheet["G12"].Formula = "=IF(((C12-B12)+(E12-D12))*24>8, ((C12-B12)+(E12-D12))*24-8,0)";
            worksheet["G13"].Formula = "=IF(((C13-B13)+(E13-D13))*24>8, ((C13-B13)+(E13-D13))*24-8,0)";
            worksheet["G14"].Formula = "=IF(((C14-B14)+(E14-D14))*24>8, ((C14-B14)+(E14-D14))*24-8,0)";
            worksheet["G15"].Formula = "=IF(((C15-B15)+(E15-D15))*24>8, ((C15-B15)+(E15-D15))*24-8,0)";

            //regular pay
            worksheet["H10"].Formula = "=SUM(F10*G7)";
            worksheet["H11"].Formula = "=SUM(F11*G7)";
            worksheet["H12"].Formula = "=SUM(F12*G7)";
            worksheet["H13"].Formula = "=SUM(F13*G7)";
            worksheet["H14"].Formula = "=SUM(F14*G7)";
            worksheet["H15"].Formula = "=SUM(F15*G7)";

            //overtime pay
            worksheet["I10"].Formula = "=SUM(G10*J7)";
            worksheet["I11"].Formula = "=SUM(G11*J7)";
            worksheet["I12"].Formula = "=SUM(G12*J7)";
            worksheet["I13"].Formula = "=SUM(G13*J7)";
            worksheet["I14"].Formula = "=SUM(G14*J7)";
            worksheet["I15"].Formula = "=SUM(G15*J7)";

            //total pay
            worksheet["J10"].Formula = "=SUM(H10+I10)";
            worksheet["J11"].Formula = "=SUM(H11+I11)";
            worksheet["J12"].Formula = "=SUM(H12+I12)";
            worksheet["J13"].Formula = "=SUM(H13+I13)";
            worksheet["J14"].Formula = "=SUM(H14+I14)";
            worksheet["J15"].Formula = "=SUM(H15+I15)";

            //total regular hours
            worksheet["F17"].Formula = "=SUM(F10:F15)";

            //total overtime hours
            worksheet["G17"].Formula = "=SUM(G10:G15)";

            //total regular pay
            worksheet["H17"].Formula = "=SUM(H10:H15)";

            //total overtime pay
            worksheet["I17"].Formula = "=SUM(I10:I15)";

            //total pay
            worksheet["J17"].Formula = "=SUM(J10:J15)";

            //consolidated pay
            worksheet["C20"].Formula = "=J17";
            //allowance
            worksheet["C21"].Number = 20;
            //PF
            worksheet["C22"].Number = 38;

            //Net pay
            worksheet["C24"].Formula = "=SUM(C20:C21)-C22";

            try
            {
                //Saving the workbook to disk.

                if (Saveoption == "Xls")
                    return excelEngine.SaveAsActionResult(myWorkbook, FileName, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                else
                    return excelEngine.SaveAsActionResult(myWorkbook, FileName, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

            }
            catch (Exception)
            {
            }

            myWorkbook.Close();
            excelEngine.Dispose();
            return View();
        }

    }
}
