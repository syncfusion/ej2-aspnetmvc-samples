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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Syncfusion.XlsIO;


namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /WorksheetToImage/

        public ActionResult WorksheetToImage(string Group1, string OpenType,string button)
        {
            if (Group1 == null)
                return View();
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"WorkSheetToImage.xlsx"));
                return excelEngine.SaveAsActionResult(workbook, "Template.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            
            }
            else
            {
                // The instantiation process consists of two steps.
                // Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                // Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                // An existing workbook is opened.
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("WorkSheetToImage.xlsx"));

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets["Sheet1"];

                sheet.UsedRangeIncludesFormatting = false;
                int lastRow = sheet.UsedRange.LastRow + 1;
                int lastColumn = sheet.UsedRange.LastColumn + 1;


                try
                {
                    // Convert worksheet Document into image
                    Image image = sheet.ConvertToImage(1, 1, lastRow, lastColumn, ImageType.Bitmap, null);

                    //Save as Bitmap image
                    if (Group1 == "BMP")
                    {
                        ExportAsImage(image, "WorksheetToImage_1.bmp", ImageFormat.Bmp, HttpContext.ApplicationInstance.Response);
                    }
                    //Save as PNG image
                    else if (Group1 == "PNG")
                    {
                        ExportAsImage(image, "WorksheetToImage_1.png", ImageFormat.Png, HttpContext.ApplicationInstance.Response);
                    }
                    //Save as JPEG image
                    else if (Group1 == "JPEG")
                    {
                        ExportAsImage(image, "WorksheetToImage_1.jpeg", ImageFormat.Jpeg, HttpContext.ApplicationInstance.Response);
                    }                    

                    workbook.Close();
                    excelEngine.Dispose();
                }
                catch (Exception)
                { }
                finally
                {

                }
            }
            return View();
        }
        protected void ExportAsImage(Image image, string fileName, ImageFormat imageFormat, HttpResponse response)
        {
            if (ControllerContext == null)
                throw new ArgumentNullException("Context");
            string disposition = "content-disposition";
            response.AddHeader(disposition, "attachment; filename=" + fileName);
            if (imageFormat != ImageFormat.Emf)
                image.Save(Response.OutputStream, imageFormat);
            Response.End();
        }

    }
}
