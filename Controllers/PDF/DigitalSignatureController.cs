#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
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
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.Drawing;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /DigitalSignature/

        public ActionResult DigitalSignature()
        {
            return View();
        }

        PdfLoadedDocument ldoc;
        PdfSignature signature;
        PdfBitmap bmp;
        PdfGraphics graphics;
        PdfCertificate pdfCert;         

        [HttpPost]
        public ActionResult DigitalSignature(string Browser, string password, string Reason, string Contact, string Location, HttpPostedFileBase pdfdocument, HttpPostedFileBase certificate, string RadioButtonList2, string NewPDF, string submit)
        {
            if (submit == "Create Sign PDF")
            {
                if (password != string.Empty && Reason != String.Empty && Contact != String.Empty && Location != string.Empty)
                {
                    string pfxPath = string.Empty;
                    if (pdfdocument != null && pdfdocument.ContentLength > 0)
                    {
                        if (pdfdocument.FileName.Contains(".pdf"))
                        {
                            ldoc = new PdfLoadedDocument(pdfdocument.InputStream);
                        }
                    }
                    if (certificate != null && certificate.ContentLength > 0)
                    {
                        if (certificate.FileName.Contains(".pfx"))
                        {
                            pfxPath = Path.Combine(Server.MapPath("~/App_Data"), certificate.FileName);
                            certificate.SaveAs(pfxPath);
                        }
                    }

                    bmp = new PdfBitmap(ResolveApplicationImagePath("PDFDemo.jpg"));

                    PdfPageBase page = ldoc.Pages[0];
                    if (password != string.Empty)
                        pdfCert = new PdfCertificate(pfxPath, password);

                    signature = new PdfSignature(ldoc, page, pdfCert, "Signature");

                    signature.Bounds = new RectangleF(new PointF(5, 5), bmp.PhysicalDimension);
                    signature.ContactInfo = Contact;
                    signature.LocationInfo = Location;
                    signature.Reason = Reason;
                    string validto = "Valid To: " + signature.Certificate.ValidTo.ToString();
                    string validfrom = "Valid From: " + signature.Certificate.ValidFrom.ToString();

                    // Save the pdf document to the Stream.
                    MemoryStream stream = new MemoryStream();
                    ldoc.Save(stream);
                    Response.ClearContent();
                    Response.Expires = 0;
                    Response.Buffer = true;

                    string disposition = "content-disposition";
                    Response.AddHeader(disposition, "attachment; filename=Sample.pdf");
                    Response.AddHeader("Content-Type", "application/pdf");
                    Response.Clear();
                    stream.WriteTo(Response.OutputStream);
                    Response.End();

                    ldoc.Close();
                    return View();
                }
                else 
                {
                   ViewBag.lab = "NOTE: Fill all fields and then create PDF";
                   return View();
                }
            }
            else
            {
                PdfDocument doc = new PdfDocument();
                PdfPage page = doc.Pages.Add();
                PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
                PdfPen pen = new PdfPen(brush, 0.2f);
                PdfFont font = new PdfStandardFont(PdfFontFamily.Courier, 12, PdfFontStyle.Regular);
                try
                {
                    pdfCert = new PdfCertificate(ResolveApplicationDataPath("PDF.pfx"), "syncfusion");
                    signature = new PdfSignature(page, pdfCert, "Signature");
                    bmp = new PdfBitmap(ResolveApplicationImagePath("syncfusion_logo.gif"));

                    signature.Bounds = new RectangleF(new PointF(5, 5), page.Size);
                    signature.ContactInfo = "johndoe@owned.us";
                    signature.LocationInfo = "Honolulu, Hawaii";
                    signature.Reason = "I am author of this document.";

                    if (RadioButtonList2 == "Standard")
                        signature.Certificated = true;
                    else
                        signature.Certificated = false;
                    graphics = signature.Appearence.Normal.Graphics;
                }
                catch (Exception)
                {
                    graphics = signature.Appearence.Normal.Graphics;

                    Response.Write("Warning Certificate not found \"Cannot sign This Document\"");

                    //Draw the Text at specified location.
                    graphics.DrawString("Warning this document is not signed", font, brush, new PointF(0, 20));
                    graphics.DrawString("Create a self signed Digital ID to sign this document", font, brush, new PointF(20, 40));
                    graphics.DrawLine(pen, new PointF(0, 100), new PointF(page.GetClientSize().Width, 200));
                    graphics.DrawLine(pen, new PointF(0, 200), new PointF(page.GetClientSize().Width, 100));
                }

                string validto = "Valid To: " + signature.Certificate.ValidTo.ToString();
                string validfrom = "Valid From: " + signature.Certificate.ValidFrom.ToString();

                graphics.DrawImage(bmp, 0, 0);

                doc.Pages[0].Graphics.DrawString(validfrom, font, pen, brush, 0, 90);
                doc.Pages[0].Graphics.DrawString(validto, font, pen, brush, 0, 110);

                doc.Pages[0].Graphics.DrawString(" Protected Document. Digitally signed Document.", font, pen, brush, 0, 130);
                doc.Pages[0].Graphics.DrawString("* To validate Signature click on the signature on this page \n * To check Document Status \n click document status icon on the bottom left of the acrobat reader.", font, pen, brush, 0, 150);

                // Save the pdf document to the Stream.
                MemoryStream stream = new MemoryStream();
                doc.Save(stream);
                Response.ClearContent();
                Response.Expires = 0;
                Response.Buffer = true;

                string disposition = "content-disposition";
                Response.AddHeader(disposition, "attachment; filename=Sample.pdf");
                Response.AddHeader("Content-Type", "application/pdf");
                Response.Clear();
                stream.WriteTo(Response.OutputStream);
                Response.End();

                doc.Close();
                return View();
            }          
        }
    }
}
