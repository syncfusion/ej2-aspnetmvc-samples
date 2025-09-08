#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
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
using System.Drawing;
using System.Data;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /DocumentationSettings/

        public ActionResult DocumentationSettings(string SaveOption)
        {
            if (SaveOption == null)
                return View();

            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
            //The new workbook will have 3 worksheets
            IWorkbook workbook = excelEngine.Excel.Workbooks.Create(3);
            // Default version is set as Excel 2007
            if (SaveOption == "Xls")
                workbook.Version = ExcelVersion.Excel97to2003;           
            else
                workbook.Version = ExcelVersion.Excel2016;

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            //Get order details 
            DataSet northwindData = new DataSet();
            northwindData.ReadXml(ResolveApplicationDataPath("Orders.xml"), XmlReadMode.Auto);
            sheet.ImportDataTable(northwindData.Tables["Orders"], true, 6, 1, -1, 9, false);

            # region Document Properties
            //Setting Builtin document Properties     
            workbook.Author = "Essential XlsIO";
            workbook.BuiltInDocumentProperties.ApplicationName = "Essential XlsIO";
            workbook.BuiltInDocumentProperties.Category = "Excel Generator";
            workbook.BuiltInDocumentProperties.Comments = "This document was generated using Essential XlsIO";
            workbook.BuiltInDocumentProperties.Company = "Syncfusion Inc.";
            workbook.BuiltInDocumentProperties.Subject = "Native Excel Generator";
            workbook.BuiltInDocumentProperties.Keywords = "Syncfusion";
            workbook.BuiltInDocumentProperties.Manager = "Sync Manager";
            workbook.BuiltInDocumentProperties.Title = "Essential XlsIO";

            //Setting Custom Properties.
            ICustomDocumentProperties customProperites = workbook.CustomDocumentProperties;
            customProperites["Author"].Text = "Test Author";
            customProperites["Comments"].Text = "XlsIO support Custom document properties";
            customProperites["Double"].Double = 120.2;
            customProperites["Choice"].Boolean = true;
            customProperites["Today"].DateTime = DateTime.Today;
            customProperites["Integer"].Int32 = 1234;
            # endregion

            # region Header and Footer

            // Setting the Page number in the Center Header
            sheet.PageSetup.CenterHeader = "&P";

            // Setting the Date in the Right Header
            sheet.PageSetup.LeftHeader = "&D";
            // Setting the file name in the Center Footer
            sheet.PageSetup.CenterFooter = "&F";
            // Setting the Sheet Name in the Left Footer
            sheet.PageSetup.LeftFooter = "&A";


            System.Drawing.Image img = System.Drawing.Image.FromFile(ResolveApplicationImagePath("logo.jpg"));
            // Right Header Image
            sheet.PageSetup.RightHeaderImage = img;
            sheet.PageSetup.RightHeader = "&G";

            sheet.PageSetup.AutoFirstPageNumber = false;
            sheet.PageSetup.FirstPageNumber = 2;

            #endregion

            # region Margin

            //Setting page Margins
            sheet.PageSetup.LeftMargin = 2;
            sheet.PageSetup.RightMargin = 2;
            sheet.PageSetup.TopMargin = 2;
            sheet.PageSetup.BottomMargin = 2;

            #endregion

            #region Page setup

            // Setting the Page Orientation as Portrait or Landscape    
            sheet.PageSetup.Orientation = ExcelPageOrientation.Landscape;

            // Setting the Paper Type
            sheet.PageSetup.PaperSize = ExcelPaperSize.PaperA4;

            #endregion

            # region Page break

            // Giving Horizontal pagebreaks 
            sheet.HPageBreaks.Add(sheet.Range["A105"]);
            sheet.HPageBreaks.Add(sheet.Range["A200"]);

            // Giving Vertical pagebreaks
            sheet.VPageBreaks.Add(sheet.Range["H100"]);

            #endregion

            #region Format Header rows
            sheet.Range["D2"].Text = "Order Details";
            sheet.Range["D2:E2"].Merge();
            sheet.Range["D2"].CellStyle.Font.Size = 10;
            sheet.Range["D2"].CellStyle.Font.Bold = true;
            sheet.Range["D2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;

            sheet.Rows[4].CellStyle.Color = Color.FromArgb(182, 189, 218);
            sheet.Rows[4].CellStyle.Font.Size = 10;
            sheet.Rows[4].CellStyle.Font.Bold = true;

            sheet.UsedRange.AutofitColumns();
            sheet.IsGridLinesVisible = false;

            sheet.Range["A4"].Text = "Note: Please check File->Properties for document properties and File->PageSetUp for page set up options";
            sheet.Range["A4"].CellStyle.Font.Bold = true;

            #endregion

            try
            {
                if (SaveOption == "Xls")
                    return excelEngine.SaveAsActionResult(workbook, "DocumentationSettings.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                else
                    return excelEngine.SaveAsActionResult(workbook, "DocumentationSettings.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            catch (Exception)
            {
            }

            workbook.Close();
            excelEngine.Dispose();
            return View();
        }
        protected string ResolveApplicationImagePath(string fileName)
        {
            string folderName = "XlsIO";
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\Content")).FullName;
            if (folderName != string.Empty)
                dataPath += "\\" + folderName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }
        private string ResolveApplicationDataPath(string fileName)
        {
            string folderName = "XlsIO";
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\App_Data")).FullName;
            if (folderName != string.Empty)
                dataPath += "\\" + folderName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }

    }
}
