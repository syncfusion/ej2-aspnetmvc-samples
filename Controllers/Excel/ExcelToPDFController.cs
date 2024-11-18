#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.ExcelChartToImageConverter;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /ExcelToPDF/
        string checkfontName = null;
        string checkfontStream = null;
        public ActionResult ExcelToPDF(string button, string checkboxStream, string checkboxName, string Group1)
        {
            if (button == null)
                return View();
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
			application.EnablePartialTrustCode = true;
            IWorkbook workbook;
            if (button == "Input Template")
            {
                if (checkboxStream != null || checkboxName != null)
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"invoiceTemplate.xlsx"), ExcelOpenType.Automatic);
                    return excelEngine.SaveAsActionResult(workbook, "invoiceTemplate.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
                else
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"ExcelTopdfwithChart.xlsx"), ExcelOpenType.Automatic);
                    return excelEngine.SaveAsActionResult(workbook, "ExcelTopdfwithChart.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
            }
            checkfontName = checkboxName;
            checkfontStream = checkboxStream;
            if (checkboxStream != null || checkboxName != null)
            {
                application.SubstituteFont += new Syncfusion.XlsIO.Implementation.SubstituteFontEventHandler(SubstituteFont);
                workbook = application.Workbooks.Open(ResolveApplicationDataPath("invoiceTemplate.xlsx"));
            }
            else
                workbook = application.Workbooks.Open(ResolveApplicationDataPath("ExcelTopdfwithChart.xlsx"));

            ExcelToPdfConverter converter = new ExcelToPdfConverter(workbook);
            converter.ChartToImageConverter = new ChartToImageConverter();
            //Set the image quality
            converter.ChartToImageConverter.ScalingMode = ScalingMode.Best;
            //Intialize the PdfDocument Class
            PdfDocument pdfDoc = new PdfDocument();

            //Intialize the ExcelToPdfConverterSettings class
            ExcelToPdfConverterSettings settings = new ExcelToPdfConverterSettings();

            //Set the Layout Options for the output Pdf page.
            if (Group1 == "NoScaling")
                settings.LayoutOptions = LayoutOptions.NoScaling;
            else if (Group1 == "FitAllRowsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
            else if (Group1 == "FitAllColumnsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
            else
                settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

            //Assign the output PdfDocument to the TemplateDocument property of ExcelToPdfConverterSettings 
            settings.TemplateDocument = pdfDoc;
            settings.DisplayGridLines = GridLinesDisplayStyle.Invisible;
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
            return View();
        }

        private void SubstituteFont(object sender, Syncfusion.XlsIO.Implementation.SubstituteFontEventArgs args)
        {
            if (checkfontName != null && (args.OriginalFontName == "Bahnschrift Pro SemiBold" || args.OriginalFontName == "Georgia Pro Semibold"))
            {
                args.AlternateFontName = "Calibri";
            }
            if (checkfontStream != null)
            {
                if (args.OriginalFontName == "Georgia Pro Semibold")
                {
                    FileStream fileStream = new FileStream(ResolveApplicationDataPath("georgiab.ttf"), FileMode.Open);
                    MemoryStream memoryStream = new MemoryStream();
                    fileStream.CopyTo(memoryStream);
                    fileStream.Close();
                    args.AlternateFontStream = memoryStream;
                }
                else if (args.OriginalFontName == "Bahnschrift Pro SemiBold")
                {
                    FileStream fileStream = new FileStream(ResolveApplicationDataPath("bahnschrift.ttf"), FileMode.Open);
                    MemoryStream memoryStream = new MemoryStream();
                    fileStream.CopyTo(memoryStream);
                    fileStream.Close();
                    args.AlternateFontStream = memoryStream;
                }
            }
        }

    }
}
