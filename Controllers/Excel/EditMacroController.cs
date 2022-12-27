#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.XlsIO;
using System.Web.Mvc;
using Syncfusion.Office;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        #region EditMacro
        public ActionResult EditMacro(string SaveOption)
        {
            if (SaveOption == null)
                return View();

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Accessing workbook
            IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"EditMacroTemplate.xltm"));

            #region VbaProject
            IVbaProject vbaProject = workbook.VbaProject;
            IVbaModule vbaModule = vbaProject.Modules["Module1"];
            vbaModule.Code = vbaModule.Code.Replace("xlAreaStacked", "xlLine");
            #endregion


            if (SaveOption == "xls")
            {
                workbook.SaveAs("EditMacro.xls", ExcelSaveType.SaveAsXLS, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog);
            }
            else if (SaveOption == "xltm")
            {
                workbook.SaveAs("EditMacro.xltm", ExcelSaveType.SaveAsMacroTemplate, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog);
            }
            else
            {
                workbook.SaveAs("EditMacro.xlsm", ExcelSaveType.SaveAsMacro, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog);
            }

            excelEngine.Dispose();
            return View();
        }
#endregion
    }
}