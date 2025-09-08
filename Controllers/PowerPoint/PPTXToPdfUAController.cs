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
using System.IO;
using System.Drawing;
using System.Web.Mvc;

using Syncfusion.Presentation;
using Syncfusion.Pdf;
using Syncfusion.Presentation.Drawing;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Office;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        //
        // GET: /PPTXToPdf/

        public ActionResult PPTXToPdfUA()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PPTXToPdfUA(string button, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            IPresentation presentation = GetInputDocument(file);
            if(presentation != null)
            {
                string output = file == null ? "Input_Template_Pdf_UA" : Path.GetFileNameWithoutExtension(file.FileName);
                presentation.ChartToImageConverter = new ChartToImageConverter();
                presentation.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;

                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                //Sets true to preserve document structured tags in the converted PDF document.
                settings.AutoTag = true;
                
                // Add a custom fallback font collection for Presentation.
                AddFallbackFonts(presentation);

                //Convert presentation document into PDF/UA document
                PdfDocument pdfDoc = PresentationToPdfConverter.Convert(presentation,settings);
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
    }
}
           

