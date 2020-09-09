#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region Track Changes
        public ActionResult TrackChanges(string Group1,string Button,string AuthorName)
        {
            if (Group1 == null)
                return View();
            if (Button == null)
                return View();
            
            if (Button == "View Template")
                return new TemplateResult("TrackChangesTemplate.docx", ResolveApplicationDataPath("Data\\DocIO"), HttpContext.ApplicationInstance.Response);

            // Opens a source document.
            WordDocument document = new WordDocument(ResolveApplicationDataPath("TrackChangesTemplate.docx", "Data\\DocIO"));

            string author = GetAuthorName(AuthorName);

            //Accepts the all changes made by the author
            if (Group1 == "acceptRadio")
                AcceptRevisionsOfAuthor(document, author);
            //Rejects the all the changes made by the author
            else if (Group1 == "rejectRadio")
                RejectRevisionsOfAuthor(document, author);
            //Rejects all the tracked changes revisions in the Word document
            else if (Group1 == "rejectAllRadio")
                document.Revisions.RejectAll();
            //Accepts all the tracked changes revisions in the Word document
            else
                document.Revisions.AcceptAll();

            FormatType type = FormatType.Docx;
            string filename = "TrackChanges.docx";
            string contenttype = "application/vnd.ms-word.document.12";
            
            #region Document SaveOption
            MemoryStream ms = new MemoryStream();
            document.Save(ms, type);
            document.Close();
            ms.Position = 0;
            return File(ms, contenttype, filename);


            #endregion Document SaveOption


        }
        #region Helper Methods
        /// <summary>
        ///  Rejects the all changes made by the author
        /// </summary>
        private void RejectRevisionsOfAuthor(WordDocument document, string author)
        {
            //Iterate into all the revisions in Word document
            for (int i = document.Revisions.Count - 1; i >= 0; i--)
            {
                //Checks the author of current revision and rejects it.
                if (document.Revisions[i].Author == author)
                    document.Revisions[i].Reject();

                //Reset to last item when reject the moving related revisions.
                if (i > document.Revisions.Count - 1)
                    i = document.Revisions.Count;

            }
        }
        /// <summary>
        ///  Accepts the all changes made by the author
        /// </summary>
        private void AcceptRevisionsOfAuthor(WordDocument document, string author)
        {
            //Iterate into all the revisions in Word document
            for (int i = document.Revisions.Count - 1; i >= 0; i--)
            {
                //Checks the author of current revision and rejects it.
                if (document.Revisions[i].Author == author)
                    document.Revisions[i].Accept();

                //Reset to last item when accept the moving related revisions.
                if (i > document.Revisions.Count - 1)
                    i = document.Revisions.Count;
            }
        }
        /// <summary>
        /// Gets the author name
        /// </summary>
        private string GetAuthorName(string selectedIndex)
        {
            switch (selectedIndex)
            {
                case "1":
                    return "Nancy Davolio";
                case "2":
                    return "Steven Buchanan";
                case "3":
                    return "Stanley Hudson";
                case "4":
                    return "Andrew Fuller";
            }
            return string.Empty;
        }
        #endregion
        #endregion Track Changes
    }
}