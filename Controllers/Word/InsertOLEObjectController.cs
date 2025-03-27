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
using System.Drawing;
using System.IO;
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
        #region InsertOLEObject
        public ActionResult InsertOLEObject(string Group1)
        {
            if (Group1 == null)
                return View();

            //Data folder path is resolved from requested page physical path.
            string dataPath = ResolveApplicationDataPath("", "Data\\Word");
            WordDocument oleSource;
            if (Group1 == ".doc")
                //Open an existing word document 
                oleSource = new WordDocument(Path.Combine(dataPath, "OleTemplate.doc"));
            else
                //Open an existing word document 
                oleSource = new WordDocument(Path.Combine(dataPath, "OleTemplate.docx"));

            WordDocument dest = new WordDocument();
            dest.EnsureMinimal();

            // Get OLE object from source document
            WOleObject oleObject = oleSource.LastParagraph.Items[0] as WOleObject;

            WPicture pic = oleObject.OlePicture.Clone() as WPicture;
            dest.LastParagraph.AppendText("OLE Object Demo");
            dest.LastParagraph.ApplyStyle(BuiltinStyle.Heading1);
            dest.LastParagraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            dest.Sections[0].AddParagraph();
            dest.LastParagraph.AppendText("Adobe PDF object Inserted");
            dest.LastParagraph.ApplyStyle(BuiltinStyle.Heading2);

            dest.Sections[0].AddParagraph();
            // AppendOLE object to the destination document
            dest.LastParagraph.AppendOleObject(oleObject.Container, pic, OleLinkType.Embed);

            //Save as .doc format
            if (Group1 == "WordDoc")
            {
                return dest.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (Group1 == "WordDocx")
            {
                return dest.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group1 == "WordML")
            {
                return dest.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            return View();
        }
        #endregion InsertOLEObject
    }
}