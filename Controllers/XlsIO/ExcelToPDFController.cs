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
using Syncfusion.XlsIO;
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.ExcelChartToImageConverter;
namespace EJ2MVCSampleBrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /ExcelToPDF/

        public ActionResult ExcelToPDF(string button, string Group1)
        {
            if (button == null)
                return View();
            ExcelToPdfConverter converter = new ExcelToPdfConverter(ResolveApplicationDataPath("ExcelTopdfwithChart.xlsx"));
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
             // return new Syncfusion.Mvc.Pdf.PdfResult(pdfDoc, "ExcelToPDF.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            catch (Exception)
            { }
            finally
            {

            }
            return View();
        }

    }
}
