#region Copyright
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
        #region Document Protection
        public ActionResult DocumentProtection(string Protection_Type, string Password1, string Group2)
        {
            if (Group2 == null)
                return View();

            WordDocument document;
            ProtectionType protectionType;

            //Loads the template document.
            if (Protection_Type == "AllowOnlyFormFields")
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateFormFields.doc", "Data\\Word"));
                // Sets the protection type as allow only Form Fields.
                protectionType = ProtectionType.AllowOnlyFormFields;
            }
            else if (Protection_Type == "AllowOnlyComments")
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateComments.doc", "Data\\Word"));
                // Sets the protection type as allow only Comments.
                protectionType = ProtectionType.AllowOnlyComments;
            }
            else if (Protection_Type == "AllowOnlyRevisions")
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateRevisions.doc", "Data\\Word"));
                // Enables track changes in the document.
                document.TrackChanges = true;
                // Sets the protection type as allow only Revisions.
                protectionType = ProtectionType.AllowOnlyRevisions;
            }
            else
            {
                document = new WordDocument(ResolveApplicationDataPath("Essential DocIO.doc", "Data\\Word"));
                // Sets the protection type as allow only Reading.
                protectionType = ProtectionType.AllowOnlyReading;
            }
            // Enforces protection of the document.
            if (string.IsNullOrEmpty(Password1))
                document.Protect(protectionType);
            else
                document.Protect(protectionType, Password1);

            #region saveOption
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
            // Save as WordML(.xml) format
            else if (Group2 == "WordML")
            {
                return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            #endregion saveOption

            return View();
        }
        #endregion Document Protection
    }
}