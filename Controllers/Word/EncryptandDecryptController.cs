#region Copyright
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region EncryptandDecrypt
        public ActionResult EncryptandDecrypt(string Group1, string Group2)
        {
            if (Group1 == null)
                return View();
            WordDocument document = null;
            if (Group1 == "CreateEncryptDoc")
            {
                document = new WordDocument();

                document.EnsureMinimal();

                // Getting last section of the document.
                IWSection section = document.LastSection;

                // Adding a paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();

                // Writing text
                IWTextRange text = paragraph.AppendText("This document was encrypted with password");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";

                // Encrypt the document by giving password
                document.EncryptDocument("syncfusion");
            }
            else
            {
                document = new WordDocument();
                // Open an existing template document.
                document.Open(ResolveApplicationDataPath("Security Settings.docx", "Data\\Word"), FormatType.Doc, "syncfusion");

                // Getting last section of the document.
                IWSection section = document.LastSection;

                // Adding a paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();

                // Writing text
                IWTextRange text = paragraph.AppendText("\nDemo For Document Decryption with Essential DocIO");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";

                text = paragraph.AppendText("\nThis document is Decrypted");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";
            }
            try
            {
                //Save as .doc format
                if (Group2 == "WordDoc")
                {
                    return document.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .docx format
                else if (Group2 == "WordDocx")
                {
                    return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
            }
            catch (Exception)
            { }
            finally
            {

            }
            return View();
        }
        #endregion EncryptandDecrypt
    }
}