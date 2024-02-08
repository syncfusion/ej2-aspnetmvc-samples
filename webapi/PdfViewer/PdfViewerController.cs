#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Newtonsoft.Json;
using Syncfusion.EJ2.PdfViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using Syncfusion.Pdf.Parsing;
using System.Security.Cryptography.X509Certificates;
using Syncfusion.Pdf.Security;
using Syncfusion.Pdf;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class PdfViewerController : ApiController
    {
        [HttpPost]
        public object Load(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            MemoryStream stream = new MemoryStream();
            object jsonResult = new object();
            if (jsonObject != null && jsonObject.ContainsKey("document"))
            {
                if (bool.Parse(jsonObject["isFileName"]))
                {
                    string documentPath = GetDocumentPath(jsonObject["document"]);
                    if (!string.IsNullOrEmpty(documentPath))
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        stream = new MemoryStream(bytes);
                    }
                    else
                    {
						string fileName = jsonObject["document"].Split(new string[] { "://" }, StringSplitOptions.None)[0];
                        if (fileName == "http" || fileName == "https")
                        {
                            WebClient WebClient = new WebClient();
                            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                            byte[] pdfDoc = WebClient.DownloadData(jsonObject["document"]);
                            stream = new MemoryStream(pdfDoc);
                        }
                        else
                        return(jsonObject["document"] + " is not found");
                    }
                }
                else
                {
                    byte[] bytes = Convert.FromBase64String(jsonObject["document"]);
                    stream = new MemoryStream(bytes);
                }
            }
            jsonResult = pdfviewer.Load(stream, jsonObject);
            return (JsonConvert.SerializeObject(jsonResult));
        }
        [HttpPost]
        public object Bookmarks(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            var jsonResult = pdfviewer.GetBookmarks(jsonObject);
            return (jsonResult);
        }
        [HttpPost]
        public object RenderPdfPages(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            object jsonResult = pdfviewer.GetPage(jsonObject);
            return (JsonConvert.SerializeObject(jsonResult));
        }
        [HttpPost]
		
		public object AddSignature(Dictionary<string, string> jsonObject)
        {
			PdfRenderer pdfviewer = new PdfRenderer();
			string documentBase = pdfviewer.GetDocumentAsBase64(jsonObject);
			byte[] documentBytes = Convert.FromBase64String(documentBase.Split(',')[1]);
			PdfLoadedDocument loadedDocument = new PdfLoadedDocument(documentBytes);
			//Get the first page of the document.
			PdfPageBase loadedPage = loadedDocument.Pages[0];
			//Create new X509Certificate2 with the root certificate.
			X509Certificate2 certificate = new X509Certificate2(GetDocumentPath("localhost.pfx"), "Syncfusion@123");
			PdfCertificate pdfCertificate = new PdfCertificate(certificate);
			//Creates a digital signature.
			PdfSignature signature = new PdfSignature(loadedDocument, loadedPage, pdfCertificate, "Signature");
			signature.Certificated = true;
			MemoryStream str = new MemoryStream();
			//Saves the document.
			loadedDocument.Save(str);
			byte[] docBytes = str.ToArray();
			string docBase64 = "data:application/pdf;base64," + Convert.ToBase64String(docBytes);
            return (GetPlainText(docBase64));
        }
        [HttpPost]
		
		public object ValidateSignature(Dictionary<string, string> jsonObject)
		{
			var hasDigitalSignature = false;
			var errorVisible = false;
			var successVisible = false;
			var warningVisible = false;
			var downloadVisibility = true;
			var message = string.Empty;
			if (jsonObject.ContainsKey("documentData"))
			{
				byte[] documentBytes = Convert.FromBase64String(jsonObject["documentData"].Split(',')[1]);
				PdfLoadedDocument loadedDocument = new PdfLoadedDocument(documentBytes);

				PdfLoadedForm form = loadedDocument.Form;
				if (form != null)
				{
					foreach (PdfLoadedField field in form.Fields)
					{
						if (field is PdfLoadedSignatureField)
						{
							//Gets the first signature field of the PDF document.
							PdfLoadedSignatureField signatureField = field as PdfLoadedSignatureField;
							if (signatureField.IsSigned)
							{
								hasDigitalSignature = true;
								//X509Certificate2Collection to check the signers identity using root certificates.
								X509Certificate2Collection collection = new X509Certificate2Collection();
								//Create new X509Certificate2 with the root certificate.
								X509Certificate2 certificate = new X509Certificate2(GetDocumentPath("localhost.pfx"), "Syncfusion@123");
								//Add the certificate to the collection.
								collection.Add(certificate);
								//Validate all signatures in loaded PDF document and get the list of validation result.
								PdfSignatureValidationResult result = signatureField.ValidateSignature(collection);
								//Checks whether the document is modified or not.
								if (result.IsDocumentModified)
								{
									errorVisible = true;
									successVisible = false;
									warningVisible = false;
									downloadVisibility = false;
									message = "The document has been digitally signed, but it has been modified since it was signed and at least one signature is invalid .";
								}
								else
								{
									//Checks whether the signature is valid or not.
									if (result.IsSignatureValid)
									{
										if (result.SignatureStatus.ToString() == "Unknown")
										{
											errorVisible = false;
											successVisible = false;
											warningVisible = true;
											message = "The document has been digitally signed and at least one signature has problem";
										}
										else
										{
											errorVisible = false;
											successVisible = true;
											warningVisible = false;
											downloadVisibility = false;
											message = "The document has been digitally signed and all the signatures are valid.";
										}
									}
								}
							}
						}
					}
				}
			}
			return (JsonConvert.SerializeObject(new { hasDigitalSignature = hasDigitalSignature, errorVisible = errorVisible, successVisible = successVisible, warningVisible = warningVisible, downloadVisibility = downloadVisibility, message = message }));

		}
		[HttpPost]
        public object RenderPdfTexts(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            object jsonResult = pdfviewer.GetDocumentText(jsonObject);
            return (JsonConvert.SerializeObject(jsonResult));
        }
        [HttpPost]
        public object RenderAnnotationComments(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            object jsonResult = pdfviewer.GetAnnotationComments(jsonObject);
            return (JsonConvert.SerializeObject(jsonResult));
        }
        [HttpPost]
        public object RenderThumbnailImages(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            object result = pdfviewer.GetThumbnailImages(jsonObject);
            return (JsonConvert.SerializeObject(result));
        }
        [HttpPost]
        public object Unload(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            pdfviewer.ClearCache(jsonObject);
            return ("Document cache is cleared");
        }
        [HttpPost]
        public HttpResponseMessage Download(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            string documentBase = pdfviewer.GetDocumentAsBase64(jsonObject);
            return (GetPlainText(documentBase));
        }
        [HttpPost]
        public object PrintImages(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            object pageImage = pdfviewer.GetPrintImage(jsonObject);
            return (pageImage);
        }
        [HttpPost]
        public object ExportAnnotations([FromBody] Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            string jsonResult = pdfviewer.ExportAnnotation(jsonObject);
            return (GetPlainText(jsonResult));
        }
        [HttpPost]
        public object ImportAnnotations([FromBody] Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            string jsonResult = string.Empty;
            object JsonResult;
            if (jsonObject != null && jsonObject.ContainsKey("fileName"))
            {
                string documentPath = GetDocumentPath(jsonObject["fileName"]);
                if (!string.IsNullOrEmpty(documentPath))
                {
                    jsonResult = System.IO.File.ReadAllText(documentPath);
                    string[] searchStrings = { "textMarkupAnnotation", "measureShapeAnnotation", "freeTextAnnotation", "stampAnnotations", "signatureInkAnnotation", "stickyNotesAnnotation", "signatureAnnotation", "AnnotationType" };
                    bool isnewJsonFile = !searchStrings.Any(jsonResult.Contains);
                    if (isnewJsonFile)
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        jsonObject["importedData"] = Convert.ToBase64String(bytes);
                        JsonResult = pdfviewer.ImportAnnotation(jsonObject);
                        jsonResult = JsonConvert.SerializeObject(JsonResult);
                    }
                }
                else
                {
                    return GetPlainText(jsonObject["document"] + " is not found");
                }
            }
            else
            {
                string extension = Path.GetExtension(jsonObject["importedData"]);
                if (extension != ".xfdf")
                {
                    JsonResult = pdfviewer.ImportAnnotation(jsonObject);
                    return GetPlainText(JsonConvert.SerializeObject(JsonResult));
                }
                else
                {
                    string documentPath = GetDocumentPath(jsonObject["importedData"]);
                    if (!string.IsNullOrEmpty(documentPath))
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(documentPath);
                        jsonObject["importedData"] = Convert.ToBase64String(bytes);
                        JsonResult = pdfviewer.ImportAnnotation(jsonObject);
                        return GetPlainText(JsonConvert.SerializeObject(JsonResult));
                    }
                    else
                    {
                        return GetPlainText(jsonObject["document"] + " is not found");
                    }
                }
            }
            return (GetPlainText(jsonResult));
        }
        [HttpPost]
        public HttpResponseMessage ExportFormFields(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            string jsonResult = pdfviewer.ExportFormFields(jsonObject);
            return (GetPlainText(jsonResult));
        }
        [HttpPost]
        public object ImportFormFields(Dictionary<string, string> jsonObject)
        {
            PdfRenderer pdfviewer = new PdfRenderer();
            object jsonResult = pdfviewer.ImportFormFields(jsonObject);
            return (JsonConvert.SerializeObject(jsonResult));
        }
        private HttpResponseMessage GetPlainText(string pageImage)
        {
            var responseText = new HttpResponseMessage(HttpStatusCode.OK);
            responseText.Content = new StringContent(pageImage, System.Text.Encoding.UTF8, "text/plain");
            return responseText;
        }
        private string GetDocumentPath(string document)
        {
            string documentPath = string.Empty;
            if (!System.IO.File.Exists(document))
            {
                var path = HttpContext.Current.Request.PhysicalApplicationPath;
                if (System.IO.File.Exists(path + "App_Data\\Data\\" + document))
                    documentPath = path + "App_Data\\Data\\" + document;
            }
            else
            {
                documentPath = document;
            }
            return documentPath;
        }
    }
}