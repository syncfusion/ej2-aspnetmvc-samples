#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System.IO;
using System.Drawing;
namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /Booklet/

        public ActionResult Booklet()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Booklet(string PageHeight, string PageWidth, string CheckBoxDoubleSide, string InsideBrowser)
        {
            try
            {
                if (PageWidth == String.Empty || PageHeight == String.Empty)
                {

                    ViewData["Error"] = "Please ensure the width and height for the page to be updated.";
                }
                else
                {

                    //Read the file as stream
                    Stream file = new FileStream(ResolveApplicationDataPath("Essential_Pdf.pdf"), FileMode.Open, FileAccess.Read);

                    //Load a PDF document
                    PdfLoadedDocument ldoc = new PdfLoadedDocument(file);

                    //Create booklet with two sides               
                    PdfDocument pdf = PdfBookletCreator.CreateBooklet(ldoc, new SizeF(float.Parse(PageWidth), float.Parse(PageHeight)), (CheckBoxDoubleSide == "DoubleSide") ? true : false);

                    //Save the document
                    if (InsideBrowser == "Browser")
                    {
                        return pdf.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                    }
                    else
                    {
                        return pdf.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                    }

                }
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.ToString();
            }
            return View();
        }
    }
}
