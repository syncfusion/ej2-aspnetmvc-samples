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
using System.IO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;


namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        //
        // GET: /DOCToEPub/

        public ActionResult DOCToEPub()
        {
            return View();
        }

        #region Doc to EPub
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DOCtoEPub(string OpenType, HttpPostedFileBase file)
        {
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".doc" || extension == ".docx" || extension == ".dot" || extension == ".dotx" || extension == ".dotm" || extension == ".docm"
                    || extension == ".xml" || extension == ".rtf")
                {
                    WordDocument document = new WordDocument(file.InputStream);

                    if (OpenType == "Font")
                        document.SaveOptions.EPubExportFont = true;
                    else
                        document.SaveOptions.EPubExportFont = false;

                    try
                    {
                        return document.ExportAsActionResult("Sample.epub", FormatType.EPub, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                    }
                    catch (Exception)
                    { }
                    finally
                    {
                    }
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose Word format document to convert to EPub");
                }
            }
            else
            {
                ViewBag.Message = string.Format("Browse a Word document and then click the button to convert as a EPub document");
            }

            return View();
        }
        #endregion Doc to EPub
    }
}