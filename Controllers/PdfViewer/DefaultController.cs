#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
using Syncfusion.EJ2.PdfViewer;
using System.Web.Http;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Net;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Redaction;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf;
using System.Drawing;
using System.Web.Caching;
using Image = System.Drawing.Image;

namespace EJ2MVCSampleBrowser.Controllers.PdfViewer
{
    public partial class PdfViewerController : Controller
    {

        public PdfViewerController()
        {

        }

        public ActionResult Default()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Load(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            MemoryStream stream = new MemoryStream();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = new object();
            if (jsonObject != null && jsonData.ContainsKey("document"))
            {
                if (bool.Parse(jsonData["isFileName"]))
                {
                    string documentPath = GetDocumentPath(jsonData["document"]);
                    if (!string.IsNullOrEmpty(documentPath))
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        stream = new MemoryStream(bytes);
                    }
                    else
                    {
                        string fileName = jsonData["document"].Split(new string[] { "://" }, StringSplitOptions.None)[0];
                        if (fileName == "http" || fileName == "https")
                        {
                            WebClient WebClient = new WebClient();
                            byte[] pdfDoc = WebClient.DownloadData(jsonData["document"]);
                            stream = new MemoryStream(pdfDoc);
                        }
                        else
                            return this.Content(jsonData["document"] + " is not found");
                    }
                }
                else
                {
                    byte[] bytes = Convert.FromBase64String(jsonData["document"]);
                    stream = new MemoryStream(bytes);
                }
            }
            jsonResult = pdfviewer.Load(stream, jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }
        
        [System.Web.Mvc.HttpPost]
        public ActionResult ValidatePassword(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            MemoryStream stream = new MemoryStream();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = new object();
            if (jsonObject != null && jsonData.ContainsKey("document"))
            {
                if (bool.Parse(jsonData["isFileName"]))
                {
                    string documentPath = GetDocumentPath(jsonData["document"]);
                    if (!string.IsNullOrEmpty(documentPath))
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        stream = new MemoryStream(bytes);
                    }
                    else
                    {
                        string fileName = jsonData["document"].Split(new string[] { "://" }, StringSplitOptions.None)[0];
                        if (fileName == "http" || fileName == "https")
                        {
                            WebClient WebClient = new WebClient();
                            byte[] pdfDoc = WebClient.DownloadData(jsonData["document"]);
                            stream = new MemoryStream(pdfDoc);
                        }
                        else
                            return this.Content(jsonData["document"] + " is not found");
                    }
                }
                else
                {
                    byte[] bytes = Convert.FromBase64String(jsonData["document"]);
                    stream = new MemoryStream(bytes);
                }
            }
            string password = null;
            if (jsonObject != null && jsonData.ContainsKey("password"))
            {
                password = jsonData["password"];
            }
            var result = pdfviewer.Load(stream, password);

            return Content(JsonConvert.SerializeObject(result));
        }
        public Dictionary<string, string> JsonConverter(jsonObjects results)
        {
            Dictionary<string, object> resultObjects = new Dictionary<string, object>();
            resultObjects = results.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToDictionary(prop => prop.Name, prop => prop.GetValue(results, null));
            var emptyObjects = (from kv in resultObjects
                                where kv.Value != null
                                select kv).ToDictionary(kv => kv.Key, kv => kv.Value);
            Dictionary<string, string> jsonResult = emptyObjects.ToDictionary(k => k.Key, k => k.Value.ToString());
            return jsonResult;
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult RenderPdfPages(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = pdfviewer.GetPage(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult RenderAnnotationComments(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = pdfviewer.GetAnnotationComments(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Unload(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            pdfviewer.ClearCache(jsonData);
            return this.Content("Document cache is cleared");
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult RenderThumbnailImages(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object result = pdfviewer.GetThumbnailImages(jsonData);
            return Content(JsonConvert.SerializeObject(result));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Bookmarks(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object jsonResult = pdfviewer.GetBookmarks(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Download(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            string documentBase = pdfviewer.GetDocumentAsBase64(jsonData);
            return Content(documentBase);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult PrintImages(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object pageImage = pdfviewer.GetPrintImage(jsonData);
            return Content(JsonConvert.SerializeObject(pageImage));
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult ExportAnnotations(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            string result = pdfviewer.ExportAnnotation(jsonData);
            return Content(result);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult ImportAnnotations(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            string jsonResult = string.Empty;
            object JsonResult;
            var jsonData = JsonConverter(jsonObject);
            if (jsonObject != null && jsonData.ContainsKey("fileName"))
            {
                string documentPath = GetDocumentPath(jsonData["fileName"]);
                if (!string.IsNullOrEmpty(documentPath))
                {
                    jsonResult = System.IO.File.ReadAllText(documentPath);
                    string[] searchStrings = { "textMarkupAnnotation", "measureShapeAnnotation", "freeTextAnnotation", "stampAnnotations", "signatureInkAnnotation", "stickyNotesAnnotation", "signatureAnnotation", "AnnotationType" };
                    bool isnewJsonFile = !searchStrings.Any(jsonResult.Contains);
                    if (isnewJsonFile)
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        jsonData["importedData"] = Convert.ToBase64String(bytes);
                        JsonResult = pdfviewer.ImportAnnotation(jsonData);
                        return Content(JsonConvert.SerializeObject(JsonResult));
                    }
                }
                else
                {
                    return Content(jsonData["document"] + " is not found");
                }
            }
            else
            {
                string extension = Path.GetExtension(jsonData["importedData"]);
                if (extension != ".xfdf")
                {
                    JsonResult = pdfviewer.ImportAnnotation(jsonData);
                    return Content(JsonConvert.SerializeObject(JsonResult));
                }
                else
                {
                    string documentPath = GetDocumentPath(jsonData["importedData"]);
                    if (!string.IsNullOrEmpty(documentPath))
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        jsonData["importedData"] = Convert.ToBase64String(bytes);
                        JsonResult = pdfviewer.ImportAnnotation(jsonData);
                        return Content(JsonConvert.SerializeObject(JsonResult));
                    }
                    else
                    {
                        return Content(jsonData["document"] + " is not found");
                    }
                }
            }
            return Content(jsonResult);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult RenderPdfTexts(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            object result = pdfviewer.GetDocumentText(jsonData);
            return Content(JsonConvert.SerializeObject(result));
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult ExportFormFields(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            string jsonResult = pdfviewer.ExportFormFields(jsonData);
            return Content(jsonResult);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult ImportFormFields(jsonObjects jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonData = JsonConverter(jsonObject);
            jsonData["data"] = GetDocumentPath(jsonData["data"]);
            object jsonResult = pdfviewer.ImportFormFields(jsonData);
            return Content(JsonConvert.SerializeObject(jsonResult));
        }
        private string GetDocumentPath(string document)
        {
            string documentPath = string.Empty;
            if (!System.IO.File.Exists(document))
            {
                var path = HttpContext.Request.PhysicalApplicationPath;
                if (System.IO.File.Exists(path + "App_Data\\Data\\" + document))
                    documentPath = path + "App_Data\\Data\\" + document;
            }
            else
            {
                documentPath = document;
            }
            return documentPath;
        }
        // GET api/values
        [System.Web.Http.HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult Redaction([FromBody] Dictionary<string, string> jsonObject)
        {
            string RedactionText = "Redacted";
            var finalbase64 = string.Empty;
            if (jsonObject != null && jsonObject.ContainsKey("base64String"))
            {
                string base64 = jsonObject["base64String"];
                string base64String = base64.Split(new string[] { "data:application/pdf;base64," }, StringSplitOptions.None)[1];
                if (base64String != null || base64String != string.Empty)
                {
                    byte[] byteArray = Convert.FromBase64String(base64String);
                    Console.WriteLine("redaction");
                    PdfLoadedDocument loadedDocument = new PdfLoadedDocument(byteArray);
                    foreach (PdfLoadedPage loadedPage in loadedDocument.Pages)
                    {
                        List<PdfLoadedAnnotation> removeItems = new List<PdfLoadedAnnotation>();
                        foreach (PdfLoadedAnnotation annotation in loadedPage.Annotations)
                        {
                            if (annotation is PdfLoadedRectangleAnnotation)
                            {
                                if (annotation.Author == "Redaction")
                                {
                                    // Add the annotation to the removeItems list
                                    removeItems.Add(annotation);
                                    // Create a new redaction with the annotation bounds and color
                                    PdfRedaction redaction = new PdfRedaction(annotation.Bounds, annotation.Color);
                                    // Add the redaction to the page
                                    loadedPage.AddRedaction(redaction);
                                    annotation.Flatten = true;
                                }
                                if (annotation.Author == "Text")
                                {
                                    // Add the annotation to the removeItems list
                                    removeItems.Add(annotation);
                                    // Create a new redaction with the annotation bounds and color
                                    PdfRedaction redaction = new PdfRedaction(annotation.Bounds);
                                    //Set the font family and font size
                                    PdfStandardFont font = new PdfStandardFont(PdfFontFamily.Courier, 8);
                                    //Create the appearance like repeated text in the redaction area 
                                    CreateRedactionAppearance(redaction.Appearance.Graphics, PdfTextAlignment.Left, true, new SizeF(annotation.Bounds.Width, annotation.Bounds.Height), RedactionText, font, PdfBrushes.Red);
                                    // Add the redaction to the page
                                    loadedPage.AddRedaction(redaction);
                                    annotation.Flatten = true;
                                }
                                //Apply the pattern for the Redaction
                                if (annotation.Author == "Pattern")
                                {
                                    // Add the annotation to the removeItems list
                                    removeItems.Add(annotation);
                                    // Create a new redaction with the annotation bounds and color
                                    PdfRedaction redaction = new PdfRedaction(annotation.Bounds);
                                    RectangleF rect = new RectangleF(0, 0, 8, 8);
                                    PdfTilingBrush tillingBrush = new PdfTilingBrush(rect);
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.Gray, new RectangleF(0, 0, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.White, new RectangleF(2, 0, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.LightGray, new RectangleF(4, 0, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.DarkGray, new RectangleF(6, 0, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.White, new RectangleF(0, 2, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.LightGray, new RectangleF(2, 2, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.Black, new RectangleF(4, 2, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.LightGray, new RectangleF(6, 2, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.LightGray, new RectangleF(0, 4, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.DarkGray, new RectangleF(2, 4, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.LightGray, new RectangleF(4, 4, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.White, new RectangleF(6, 4, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.Black, new RectangleF(0, 6, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.LightGray, new RectangleF(2, 6, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.Black, new RectangleF(4, 6, 2, 2));
                                    tillingBrush.Graphics.DrawRectangle(PdfBrushes.DarkGray, new RectangleF(6, 6, 2, 2));
                                    rect = new RectangleF(0, 0, 16, 14);
                                    PdfTilingBrush tillingBrushNew = new PdfTilingBrush(rect);
                                    tillingBrushNew.Graphics.DrawRectangle(tillingBrush, rect);
                                    //Set the pattern for the redaction area
                                    redaction.Appearance.Graphics.DrawRectangle(tillingBrushNew, new RectangleF(0, 0, annotation.Bounds.Width, annotation.Bounds.Height));
                                    // Add the redaction to the page
                                    loadedPage.AddRedaction(redaction);
                                    annotation.Flatten = true;
                                }
                            }
                            else if (annotation is PdfLoadedRubberStampAnnotation)
                            {
                                if (annotation.Author == "Image")
                                {
                                    //Get the existing rubber stamp annotation.
                                    PdfLoadedRubberStampAnnotation rubberStampAnnotation = annotation as PdfLoadedRubberStampAnnotation;
                                    //Get the custom images used for the rubber stamp annotation.
                                    Image[] images = rubberStampAnnotation.GetImages();
                                    // Create a new redaction with the annotation bounds and color
                                    PdfRedaction redaction = new PdfRedaction(annotation.Bounds);
                                    // images[0].Position = 0;
                                    PdfImage image = new PdfBitmap(images[0]);
                                    //Apply the image to redaction area
                                    redaction.Appearance.Graphics.DrawImage(image, new RectangleF(0, 0, annotation.Bounds.Width, annotation.Bounds.Height));
                                    // Add the redaction to the page
                                    loadedPage.AddRedaction(redaction);
                                    annotation.Flatten = true;
                                }
                            }
                        }
                        foreach (PdfLoadedAnnotation annotation1 in removeItems)
                        {
                            loadedPage.Annotations.Remove(annotation1);
                        }
                    }
                    loadedDocument.Redact();
                    MemoryStream stream = new MemoryStream();
                    loadedDocument.Save(stream);
                    stream.Position = 0;
                    loadedDocument.Close(true);
                    byteArray = stream.ToArray();
                    finalbase64 = "data:application/pdf;base64," + Convert.ToBase64String(byteArray);
                    stream.Dispose();
                    return Content(finalbase64);
                }
            }
            return Content("data:application/pdf;base64," + "");
        }

        //The Method used for apply the text in the full area of redaction rectangle
        private static void CreateRedactionAppearance(PdfGraphics graphics, PdfTextAlignment alignment, bool repeat, SizeF size, string overlayText, PdfFont font, PdfBrush textcolor)
        {
            float col = 0, row;
            if (font == null) font = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
            int textAlignment = Convert.ToInt32(alignment);
            float y = 0, x = 0, diff = 0;
            RectangleF rect;
            SizeF textsize = font.MeasureString(overlayText);

            if (repeat)
            {
                col = size.Width / textsize.Width;
                row = (float)Math.Floor(size.Height / font.Size);
                diff = Math.Abs(size.Width - (float)(Math.Floor(col) * textsize.Width));
                if (textAlignment == 1)
                    x = diff / 2;
                if (textAlignment == 2)
                    x = diff;
                for (int i = 1; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        rect = new RectangleF(x, y, 0, 0);
                        graphics.DrawString(overlayText, font, textcolor, rect);
                        y = y + font.Size;
                    }
                    x = x + textsize.Width;
                    y = 0;
                }
            }
            else
            {
                diff = Math.Abs(size.Width - textsize.Width);
                if (textAlignment == 1)
                {
                    x = diff / 2;
                }
                if (textAlignment == 2)
                {
                    x = diff;
                }
                rect = new RectangleF(x, 0, 0, 0);
                graphics.DrawString(overlayText, font, textcolor, rect);
            }
        }
    }
    public class jsonObjects
    {
        public string document { get; set; }
        public string password { get; set; }
        public string zoomFactor { get; set; }
        public string isFileName { get; set; }
        public string xCoordinate { get; set; }
        public string yCoordinate { get; set; }
        public string pageNumber { get; set; }
        public string documentId { get; set; }
        public string hashId { get; set; }
        public string sizeX { get; set; }
        public string sizeY { get; set; }
        public string startPage { get; set; }
        public string endPage { get; set; }
        public string stampAnnotations { get; set; }
        public string textMarkupAnnotations { get; set; }
        public string stickyNotesAnnotation { get; set; }
        public string shapeAnnotations { get; set; }
        public string measureShapeAnnotations { get; set; }
        public string action { get; set; }
        public string pageStartIndex { get; set; }
        public string pageEndIndex { get; set; }
        public string fileName { get; set; }
        public string elementId { get; set; }
        public string pdfAnnotation { get; set; }
        public string importPageList { get; set; }
        public string uniqueId { get; set; }
        public string data { get; set; }
        public string viwePortWidth { get; set; }
        public string viewportHeight { get; set; }
        public string tilecount { get; set; }
        public string isCompletePageSizeNotReceived { get; set; }
        public string freeTextAnnotation { get; set; }
        public string fieldsData { get; set; }
        public string signatureData { get; set; }
    }
}
