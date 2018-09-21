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

            //Instance to create pdf document from presentation                
            PdfDocument doc = PresentationToPdfConverter.Convert(presentation, settings);
            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            stream.Position = 0;
            //return new Syncfusion.Mvc.Pdf.PdfResult(doc, "PPTXToPDF.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            return File(stream, "application/pdf", "PPTXToPDF.pdf");
        }
    }
}
           

