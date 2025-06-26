#region Copyright
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
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
        public ActionResult DocumentProtection(string Protection_Type, string Password1, string EditableRangeOption)
        {
            if (Protection_Type == null)
                return View();

            WordDocument document;
            ProtectionType protectionType;

            //Loads the template document.
            if (Protection_Type == "AllowOnlyFormFields")
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateFormFields.docx", "Data\\Word"));
                // Sets the protection type as allow only Form Fields.
                protectionType = ProtectionType.AllowOnlyFormFields;
            }
            else if (Protection_Type == "AllowOnlyComments")
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateComments.docx", "Data\\Word"));
                // If the "Make part of the document editable for everyone" checkbox is checked,
                // add editable ranges to allow unrestricted editing in specific sections.

                if (EditableRangeOption == "EditableRange")
                    AddEditableRange(document);
                // Sets the protection type as allow only Comments.
                protectionType = ProtectionType.AllowOnlyComments;
            }
            else if (Protection_Type == "AllowOnlyRevisions")
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateRevisions.docx", "Data\\Word"));
                // Enables track changes in the document.
                document.TrackChanges = true;
                // Sets the protection type as allow only Revisions.
                protectionType = ProtectionType.AllowOnlyRevisions;
            }
            else if (Protection_Type == "AllowOnlyReading")
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateReading.docx", "Data\\Word"));
                // If the "Make part of the document editable for everyone" checkbox is checked,
                // add editable ranges to allow unrestricted editing in specific sections.
                if (EditableRangeOption == "EditableRange")
                    AddEditableRange(document);
                // Sets the protection type as allow only Reading.
                protectionType = ProtectionType.AllowOnlyReading;
            }
            else
            {
                document = new WordDocument(ResolveApplicationDataPath("TemplateFormFields.docx", "Data\\Word"));
                // Sets the protection type as allow only Form Fields.
                protectionType = ProtectionType.AllowOnlyFormFields;
            }
            // Enforces protection of the document.
            if (string.IsNullOrEmpty(Password1))
                document.Protect(protectionType);
            else
                document.Protect(protectionType, Password1);

            //Save as .docx format.
            return document.ExportAsActionResult(Protection_Type + ".docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);

        }
        private void AddEditableRange(WordDocument document)
        {
            // Access the paragraph
            WParagraph paragraph = document.Sections[0].Body.ChildEntities[5] as WParagraph;
            // Create a new editable range start
            EditableRangeStart editableRangeStart = new EditableRangeStart(document);
            // Insert the editable range start at the beginning of the selected paragraph
            paragraph.ChildEntities.Insert(0, editableRangeStart);
            // Set the editor group for the editable range to allow everyone to edit
            editableRangeStart.EditorGroup = EditorType.Everyone;
            // Append an editable range end to close the editable region
            paragraph.AppendEditableRangeEnd();

            // Access the first table in the first section of the document
            WTable table = document.Sections[0].Tables[0] as WTable;
            // Access the paragraph in the third row and third column of the table
            paragraph = table[2, 2].ChildEntities[0] as WParagraph;
            // Create a new editable range start for the table cell paragraph
            editableRangeStart = new EditableRangeStart(document);
            // Insert the editable range start at the beginning of the paragraph
            paragraph.ChildEntities.Insert(0, editableRangeStart);
            // Set the editor group for the editable range to allow everyone to edit
            editableRangeStart.EditorGroup = EditorType.Everyone;
            // Apply editable range to second column only
            editableRangeStart.FirstColumn = 1;
            editableRangeStart.LastColumn = 1;
            // Access the paragraph
            paragraph = table[5, 2].ChildEntities[0] as WParagraph;
            // Append an editable range end to close the editable region
            paragraph.AppendEditableRangeEnd();

        }
        #endregion Document Protection
    }
}