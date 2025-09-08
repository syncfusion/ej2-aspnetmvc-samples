#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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

using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf.Interactive;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /Portfolio/

        public ActionResult Portfolio()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Portfolio(string InsideBrowser)
        {
            //Stream readFile = new FileStream(ResolveApplicationDataPath(@"..\DocIO\DocToPDF.doc"), FileMode.Open, FileAccess.Read, FileShare.Read);
            // Create a new instance of PdfDocument class.
            PdfDocument document = new PdfDocument();

            //Creating new portfolio
            document.PortfolioInformation = new PdfPortfolioInformation();

            //setting the view mode of the portfolio
            document.PortfolioInformation.ViewMode = PdfPortfolioViewMode.Tile;

            //Creating the attachment
            PdfAttachment pdfFile = new PdfAttachment(ResolveApplicationDataPath("CorporateBrochure.pdf"));
            pdfFile.FileName = "CorporateBrochure.pdf";

            //Creating the attachement
            PdfAttachment wordfile = new PdfAttachment(ResolveApplicationDataPath("Stock.docx"));
            wordfile.FileName = "Stock.docx";

            //Creating the attachement
            PdfAttachment excelfile = new PdfAttachment(ResolveApplicationDataPath("Chart.xlsx"));
            excelfile.FileName = "Chart.xlsx";

            //Setting the startup document to view
            document.PortfolioInformation.StartupDocument = pdfFile;

            //Adding the attachment into document
            document.Attachments.Add(pdfFile);
            document.Attachments.Add(wordfile);
            document.Attachments.Add(excelfile);

            //Adding new page into the document
            document.Pages.Add();

            //Save the pdf file            
            if (InsideBrowser == "Browser")
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }

    }
}
