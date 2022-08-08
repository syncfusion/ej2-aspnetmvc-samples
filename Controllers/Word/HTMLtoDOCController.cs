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
        #region Private Members
        string errorMessage = "";
        #endregion
        #region HTMLtoDOC
        public ActionResult HTMLtoDOC(string Group1, HttpPostedFileBase file)
        {
            if (Group1 == null)
                return View();
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".html" || extension == ".htm")
                {
                    WordDocument document = new WordDocument();
                    IWSection section = document.AddSection();
                    IWParagraph para = section.AddParagraph();

                    string text;
                    StreamReader read = new StreamReader(file.InputStream);
                    text = read.ReadToEnd();
                    bool valid = section.Body.IsValidXHTML(text, XHTMLValidationType.Transitional, out errorMessage);
                    if (!valid)
                    {
                        ViewBag.Message = string.Format("Content is not a well formatted XHTML content \nError message:\n" + errorMessage);

                    }
                    else
                    {
                        // By default, the input html will be validated for XHTML format. This will provide you understandable error messages, if the format is invalid.
                        // However, if you are sure that the input html is valid, then you can skip the validation step to improve performance. However, any error messages 
                        // you might get here will not be very useful as to where exactly in your html, the issue is.

                        document.XHTMLValidateOption = XHTMLValidationType.Transitional;
                        section.Body.InsertXHTML(text);

                        #region Document save option
                        //Save as .doc format
                        if (Group1 == "WordDoc")
                        {
                            return document.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                        }
                        //Save as .docx format
                        else if (Group1 == "WordDocx")
                        {
                            return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                        }
                        // Save as WordML(.xml) format
                        else if (Group1 == "WordML")
                        {
                            return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                        }
                    }
                    #endregion Document save option
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose HTML document");
                }
            }
            else
            {
                ViewBag.Message = string.Format("Browse a HTML document and then click the button to convert as a Word document");
            }

            return View();
        }
        #endregion HTMLtoDOC
    }
}