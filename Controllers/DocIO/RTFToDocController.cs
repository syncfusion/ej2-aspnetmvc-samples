#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
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
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

using System.ComponentModel;

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region RTF to Doc
        public ActionResult RTFToDoc(string Group1, HttpPostedFileBase file)
        {
            if (Group1 == null)
                return View();
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".rtf")
                {
                    WordDocument document = new WordDocument(file.InputStream, FormatType.Rtf);
                    string outputFileName = Path.GetFileNameWithoutExtension(file.FileName);

                    #region Document save option
                    //Save as .doc format
                    if (Group1 == "WordDoc")
                    {
                        return document.ExportAsActionResult(outputFileName + ".doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    //Save as .docx format
                    else if (Group1 == "WordDocx")
                    {
                        return document.ExportAsActionResult(outputFileName + ".docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    // Save as WordML(.xml) format
                    else if (Group1 == "WordML")
                    {
                        return document.ExportAsActionResult(outputFileName + ".xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    #endregion Document save option
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose RTF document to convert to Word document");
                }
            }
            else
            {
                ViewBag.Message = string.Format("Browse a RTF document and then click the button to convert as a Word document");
            }

            return View();
        }
        #endregion RTF to Doc
    }
}
