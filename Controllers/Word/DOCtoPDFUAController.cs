#region Copyright
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;
using Syncfusion.OfficeChartToImageConverter;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region doc to PDF
        public ActionResult DOCtoPDFUA(string button, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            //Get input Word document.
            WordDocument document = GetInputWordocument(file);
            if (document != null)
            {
                string output = file == null ? "DoctoPDF_Pdf_UA" : Path.GetFileNameWithoutExtension(file.FileName);
                //Initialize chart to image converter for converting charts in Word to PDF conversion
                document.ChartToImageConverter = new ChartToImageConverter();
                document.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Normal;

                DocToPDFConverter converter = new DocToPDFConverter();
                //Sets true to preserve document structured tags in the converted PDF document.
                converter.Settings.AutoTag = true;
                //Convert word document into PDF/UA document.
                PdfDocument pdfDoc = converter.ConvertToPDF(document);
                try
                {
                    return pdfDoc.ExportAsActionResult(output + ".pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
                catch (Exception)
                { }
                finally
                {

                }
            }

            return View();
        }
        #endregion doc to PDF
    }
}