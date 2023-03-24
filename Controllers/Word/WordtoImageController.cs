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
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Drawing;
using System.Drawing.Imaging;
namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        public ActionResult WordtoImage()
        {
            return View();
        }

        #region word to Image
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult WordtoImage(string Group1, string OpenType, HttpPostedFileBase file)
        {
            if (Group1 == null)
                return View();
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".doc" || extension == ".docx" || extension == ".dot" || extension == ".dotx" || extension == ".dotm" || extension == ".docm"
                    || extension == ".xml" || extension == ".rtf")
                {
                    WordDocument document = new WordDocument(file.InputStream);
                    try
                    {
                        // Convert Word Document into image
                        Image image = document.RenderAsImages(0, ImageType.Metafile);
                        //Save as Bitmap image
                        if (Group1 == "BMP")
                        {
                            ExportAsImage(image, "WordToImage_1.bmp", ImageFormat.Bmp, HttpContext.ApplicationInstance.Response);
                        }
                        //Save as PNG image
                        else if (Group1 == "PNG")
                        {
                            ExportAsImage(image, "WordToImage_1.png", ImageFormat.Png, HttpContext.ApplicationInstance.Response);
                        }
                        //Save as JPEG image
                        else if (Group1 == "JPEG")
                        {
                            ExportAsImage(image, "WordToImage_1.jpeg", ImageFormat.Jpeg, HttpContext.ApplicationInstance.Response);
                        }
                        //Save as EMF image
                        else if (Group1 == "EMF")
                        {
                            MemoryStream stream = (MemoryStream)document.RenderAsImages(0, ImageFormat.Emf);
                            stream.Position = 0;
                            stream.WriteTo(Response.OutputStream);
                            ExportAsImage(image, "WordToImage_1.emf", ImageFormat.Emf, HttpContext.ApplicationInstance.Response);
                        }
                    }
                    catch (Exception)
                    { }
                    finally
                    {

                    }
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose Word format document to convert to Image");
                }
            }
            else
            {
                ViewBag.Message = string.Format("Browse a Word document and then click the button to convert as a Image");
            }

            return View();
        }
        #endregion word to Image
        protected void ExportAsImage(Image image, string fileName, ImageFormat imageFormat, HttpResponse response)
        {
            if (ControllerContext == null)
                throw new ArgumentNullException("Context");
            string disposition = "content-disposition";
            response.AddHeader(disposition, "attachment; filename=" + fileName);
            if (imageFormat != ImageFormat.Emf)
                image.Save(Response.OutputStream, imageFormat);
            Response.End();
        }
    }
}