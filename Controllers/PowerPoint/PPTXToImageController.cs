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
using System.IO;
using System.Web;
using System.Web.Mvc;

//using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Presentation;
using System.Drawing;
using System.Drawing.Imaging;
using Syncfusion.OfficeChartToImageConverter;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
        //
        // GET: /PPTXToImage/

        public ActionResult PPTXToImage()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PPTXToImage(string button)
        {
            if (button == null)
                return View();
            Stream readFile = new FileStream(ResolveApplicationDataPath(@"Syncfusion Presentation.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);
            IPresentation presentation = Presentation.Open(readFile);
            
            presentation.ChartToImageConverter = new ChartToImageConverter();
            presentation.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;
            ISlide slide = presentation.Slides[0];
            //Converts slide to image
            using (Image image = Image.FromStream(slide.ConvertToImage(Syncfusion.Drawing.ImageFormat.Png)))
            {
                ExportAsImage(image, "PPTXToImage_1.png", ImageFormat.Png, HttpContext.ApplicationInstance.Response);

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
