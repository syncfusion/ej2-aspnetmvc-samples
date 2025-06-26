#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Web.Mvc;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Security;
using System.Drawing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /Encryption/
        public ActionResult Encryption()
        {
            ViewData["data"] = new string[] { "Encrypt all contents", "Encrypt all contents except metadata", "Encrypt only attachments [For AES and AES-GCM only]" };
            return View();
        }

        [HttpPost]
        public ActionResult Encryption(string InsideBrowser, string encryptionType, string encryptOptionType)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;

            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f, PdfFontStyle.Bold);
            PdfBrush brush = PdfBrushes.Black;
            PdfForm form = document.Form;

            //Document security
            PdfSecurity security = document.Security;

            //Specify key size and encryption algorithm
            if (encryptionType == "40_RC4")
            {
                //use 40 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key40Bit;
            }
            else if (encryptionType == "128_RC4")
            {
                //use 128 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit;
                security.Algorithm = PdfEncryptionAlgorithm.RC4;
            }
            else if (encryptionType == "128_AES")
            {
                //use 128 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
            else if (encryptionType == "256_AES")
            {
                //use 256 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key256Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
            else if (encryptionType == "256_AES_Revision_6")
            {
                security.KeySize = PdfEncryptionKeySize.Key256BitRevision6;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
            else if (encryptionType == "256_AES_GCM")
            {
                security.KeySize = PdfEncryptionKeySize.Key256Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AESGCM;
                document.FileStructure.Version = PdfVersion.Version2_0;
            }
            //set Encryption options
            if (encryptOptionType == "Encrypt only attachments [For AES and AES-GCM only]")
            {
                //Creates an attachment
                PdfAttachment attachment = new PdfAttachment(ResolveApplicationDataPath("Products.xml"));

                attachment.ModificationDate = DateTime.Now;

                attachment.Description = "About Syncfusion";

                attachment.MimeType = "application/txt";

                //Adds the attachment to the document
                document.Attachments.Add(attachment);

                security.EncryptionOptions = PdfEncryptionOptions.EncryptOnlyAttachments;
            }

            else if (encryptOptionType == "Encrypt all contents except metadata")
                security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContentsExceptMetadata;
            else
                security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContents;

            security.OwnerPassword = "syncfusion";
            security.Permissions = PdfPermissionsFlags.Print | PdfPermissionsFlags.FullQualityPrint;
            security.UserPassword = "password";

            string text = "Security options:\n\n" + String.Format("KeySize: {0}\n\nEncryption Algorithm: {4}\n\nOwner Password: {1}\n\nPermissions: {2}\n\n" +
                "User Password: {3}", security.KeySize, security.OwnerPassword, security.Permissions, security.UserPassword, security.Algorithm);
            if (encryptionType == "256_AES_Revision_6")
            {
                text += String.Format("\n\nRevision: {0}", "Revision 6");
            }
            else if (encryptionType == "256_AES")
            {
                text += String.Format("\n\nRevision: {0}", "Revision 5");
            }
            else if (encryptionType == "256_AES_GCM")
            {
                text += String.Format("\n\nRevision: {0}", "Revision 7");
            }
            graphics.DrawString("Document is Encrypted with following settings", font, brush, PointF.Empty);
            font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11f, PdfFontStyle.Bold);
            graphics.DrawString(text, font, brush, new PointF(0, 40));

            //Stream the output to the browser. 
            if (encryptionType == "256_AES_GCM")
            {
                MemoryStream stream = new MemoryStream();
                document.Save(stream);
                document.Close(true);
                Response.ClearContent();
                Response.Expires = 0;
                Response.Buffer = true;

                string disposition = "content-disposition";
                Response.AddHeader(disposition, "attachment; filename=sample.pdf");
                Response.AddHeader("Content-Type", "application/pdf");
                Response.Clear();
                stream.WriteTo(Response.OutputStream);
                Response.End();
                return View();
            }   
            else if (InsideBrowser == "Browser")
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);

        }

    }
}
