#region Copyright Syncfusion Inc. 2001-2022
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
using Syncfusion.Pdf.Security;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /Attachments/
        PdfDocument doc = null;
        PdfFont font = null;
        PdfBrush brush = new PdfSolidBrush(Color.Black);
        public ActionResult Attachments()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Attachments(string Browser, string encrypt, string password)
        {
             //Creates a new PDF document.
             doc = new PdfDocument();

             //Add a page
             PdfPage  page = doc.Pages.Add();

             //Set the font
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 18f, PdfFontStyle.Bold);

            System.Drawing.Color orangeColor = System.Drawing.Color.FromArgb(255, 255, 167, 73);

            //Draw the text
            page.Graphics.DrawString("Attachments", font, PdfBrushes.Black, new RectangleF(0, 0, page.GetClientSize().Width, page.GetClientSize().Height), new PdfStringFormat(PdfTextAlignment.Center));

            font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f, PdfFontStyle.Regular);

            page.Graphics.DrawString("This PDF document contains image and text file as attachment.", font, PdfBrushes.Black, new PointF(0, 30));

            font = new PdfStandardFont(PdfFontFamily.Helvetica, 8f, PdfFontStyle.Regular);

            page.Graphics.DrawString("Click to open the attachment:", font, PdfBrushes.Black, new PointF(0, 50));

            page.Graphics.DrawString("Click to open the attachment:", font, PdfBrushes.Black, new PointF(0, 70));

            //Creates an attachment
            PdfAttachment attachment = new PdfAttachment(ResolveApplicationDataPath("Text1.txt"));

            attachment.ModificationDate = DateTime.Now;

            attachment.Description = "About Syncfusion";

            attachment.MimeType = "application/txt";

            //Adds the attachment to the document
            doc.Attachments.Add(attachment);

            //Creates an attachment
            attachment = new PdfAttachment(ResolveApplicationImagePath("Autumn Leaves.jpg"));

            attachment.ModificationDate = DateTime.Now;

            attachment.Description = "Autumn Leaves Image";

            attachment.MimeType = "application/jpg";

            doc.Attachments.Add(attachment);

            //Creates an attachment
            attachment = new PdfAttachment(ResolveApplicationDataPath("Text2.txt"));

            attachment.ModificationDate = DateTime.Now;

            attachment.Description = "List of Syncfusion Control";

            attachment.MimeType = "application/txt";

            doc.Attachments.Add(attachment);

            //Set Encryption password
            if (!string.IsNullOrEmpty(encrypt) && !string.IsNullOrEmpty(password))
            {
                PdfSecurity security = doc.Security;
                security.UserPassword = password;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
                security.EncryptionOptions = PdfEncryptionOptions.EncryptOnlyAttachments;
            }

            //Set document viewerpreference.
            doc.ViewerPreferences.HideWindowUI = false;
            doc.ViewerPreferences.HideMenubar = false;
            doc.ViewerPreferences.HideToolbar = false;
            doc.ViewerPreferences.FitWindow = false;
            doc.ViewerPreferences.DisplayTitle = false;
            doc.ViewerPreferences.PageMode = PdfPageMode.UseAttachments;
			
			//Disable the default appearance.
            doc.Form.SetDefaultAppearance(false);

            //Create pdfbuttonfield.
            PdfButtonField openSpecificationButton = new PdfButtonField(page, "openSpecification");
            openSpecificationButton.Bounds = new RectangleF(105, 50, 62, 10);
            openSpecificationButton.TextAlignment = PdfTextAlignment.Left;
            openSpecificationButton.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 7);
            openSpecificationButton.BorderStyle = PdfBorderStyle.Underline;
            openSpecificationButton.BorderColor = orangeColor;
            openSpecificationButton.BackColor = new PdfColor(255, 255, 255);
            openSpecificationButton.ForeColor = orangeColor;
            openSpecificationButton.Text = "Autumn Leaves.jpg";
            openSpecificationButton.Actions.MouseUp = new PdfJavaScriptAction("this.exportDataObject({ cName: 'Autumn Leaves.jpg', nLaunch: 2 });");
            doc.Form.Fields.Add(openSpecificationButton);

            openSpecificationButton = new PdfButtonField(page, "openSpecification");
            openSpecificationButton.Bounds = new RectangleF(105, 70, 30, 10);
            openSpecificationButton.TextAlignment = PdfTextAlignment.Left;
            openSpecificationButton.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 7);
            openSpecificationButton.BorderStyle = PdfBorderStyle.Underline;
            openSpecificationButton.BorderColor = orangeColor;
            openSpecificationButton.BackColor = new PdfColor(255, 255, 255);
            openSpecificationButton.ForeColor = orangeColor;
            openSpecificationButton.Text = "Text1.txt";
            openSpecificationButton.Actions.MouseUp = new PdfJavaScriptAction("this.exportDataObject({ cName: 'Text1.txt', nLaunch: 2 });");
            doc.Form.Fields.Add(openSpecificationButton);           

            //Stream the output to the browser.    
            if (Browser == "Browser")
            {
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }

    }
}
