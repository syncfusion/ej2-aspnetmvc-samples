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

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PresentationController : Controller
    {
        //
        // GET: /PPTXToPdf/

        public ActionResult PPTXToPdf()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PPTXToPdf(string Browser)
        {
            string file = ResolveApplicationDataPath("Syncfusion Presentation.pptx");
            //Opens the specified presentation
            IPresentation presentation = Presentation.Open(file);
            presentation.ChartToImageConverter = new ChartToImageConverter();
            presentation.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;
            
            PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
            settings.ShowHiddenSlides = true;
            settings.EnablePortableRendering = true;

            // Add a custom fallback font collection for Presentation.
            AddFallbackFonts(presentation);

            //Instance to create pdf document from presentation                
            PdfDocument doc = PresentationToPdfConverter.Convert(presentation, settings);
            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            stream.Position = 0;
            //return new Syncfusion.Mvc.Pdf.PdfResult(doc, "PPTXToPDF.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            return File(stream, "application/pdf", "PPTXToPDF.pdf");
        }

        /// <summary>
        /// Add a custom fallback font collection for IPresentation.
        /// </summary>
        /// <param name="presentation">Represent a presentation to add.</param>
        private void AddFallbackFonts(IPresentation presentation)
        {
            //Add customized fallback font names.

            // Arabic
            presentation.FontSettings.FallbackFonts.Add(new FallbackFont(0x0600, 0x06ff, "Arial"));
            // Hebrew
            presentation.FontSettings.FallbackFonts.Add(new FallbackFont(0x0590, 0x05ff, "Arial, David"));
            // Hindi
            presentation.FontSettings.FallbackFonts.Add(new FallbackFont(0x0900, 0x097F, "Mangal"));
            // Chinese
            presentation.FontSettings.FallbackFonts.Add(new FallbackFont(0x4E00, 0x9FFF, "DengXian"));
            // Japanese
            presentation.FontSettings.FallbackFonts.Add(new FallbackFont(0x3040, 0x309F, "MS Mincho"));
            // Korean
            presentation.FontSettings.FallbackFonts.Add(new FallbackFont(0xAC00, 0xD7A3, "Malgun Gothic"));
        }
    }
}
           

