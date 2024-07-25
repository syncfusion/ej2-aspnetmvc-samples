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

        public ActionResult PPTXToPdf()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PPTXToPdf(string button, HttpPostedFileBase file)
        {
            if (button == null)
                return View();
            IPresentation presentation = GetInputDocument(file);
            if(presentation != null)
            {
                string output = file == null ? "Input_Template" : Path.GetFileNameWithoutExtension(file.FileName);
                presentation.ChartToImageConverter = new ChartToImageConverter();
                presentation.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;

                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                settings.ShowHiddenSlides = true;
                settings.EnablePortableRendering = true;
                
				// Add a custom fallback font collection for Presentation.
                AddFallbackFonts(presentation);

                //Convert presentation document into PDF document
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
        /// <summary>
        /// Gets the presentation document from default template document or uploaded document.
        /// </summary>
        /// <param name="file">HttpPostedFileBase contains the uploaded file data.</param>
        /// <returns>Returns the IPresentation document instance.</returns>
        private IPresentation GetInputDocument(HttpPostedFileBase file)
        {
            IPresentation presentation;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".pptx")
                {
                    presentation = Presentation.Open(file.InputStream);
                    return presentation;
                }
                else
                    ViewBag.Message = string.Format("Please choose PowerPoint Presentation document(PPTX) to convert as PDF");
            }
            else
            {
                string filePath = ResolveApplicationDataPath("Input_Template.pptx");
                presentation = Presentation.Open(filePath);
                return presentation;
            }
            return null;
        }
    }
}
           

