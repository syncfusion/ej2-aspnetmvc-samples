#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Web;
using System.Web.Mvc;
using Syncfusion.XlsIO;
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using System.IO;
using Syncfusion.ExcelChartToImageConverter;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        // GET: ExcelToPDFUA
        public ActionResult ExcelToPDFUA(string button, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            IWorkbook workbook = GetInputExcelocument(file);
            if (workbook != null)
            {
                
                //Intialize the ExcelToPdfConverterSettings class
                ExcelToPdfConverter converter = new ExcelToPdfConverter(workbook);
                //Intialize the PdfDocument Class
                PdfDocument pdfDoc = new PdfDocument();

                //Intialize the ExcelToPdfConverterSettings class
                ExcelToPdfConverterSettings settings = new ExcelToPdfConverterSettings();
                settings.AutoTag = true;
                //Convert the Excel document to PDf
                pdfDoc = converter.Convert(settings);
                try
                {

                    pdfDoc.Save("ExcelToPDF.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
                catch (Exception)
                { }
                finally
                {

                }
            }
            return View();
        }
        /// <summary>
        /// Gets the Excel document from default template document or uploaded document.
        /// </summary>
        /// <param name="file">HttpPostedFileBase contains the uploaded file data.</param>
        /// <returns>Returns the Excel document instance.</returns>
        private IWorkbook GetInputExcelocument(HttpPostedFileBase file)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            application.EnablePartialTrustCode = true;
            application.ChartToImageConverter = new ChartToImageConverter();
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();

                if (extension == ".xls" || extension == ".xlsx" || extension == ".xlsm" || extension == ".xltm" || extension == ".xltx" || extension == ".csv"
                   || extension == ".xml" || extension == ".tsv" || extension == ".xlsb")
                    return application.Workbooks.Open(file.InputStream, ExcelOpenType.Automatic);
                else
                    ViewBag.Message = string.Format("Please choose Excel format document to convert to PDF");
            }
            else
            {
                string filePath = ResolveApplicationDataPath(@"ExcelToPDFUA.xlsx");
                return application.Workbooks.Open(filePath, ExcelOpenType.Automatic);
            }
            return null;
        }

    }
}