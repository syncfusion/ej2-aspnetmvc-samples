#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.PdfViewer
{
    public partial class PdfViewerController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DocumentList()
        {
            var documentDetails = DocumentDetails.GetAllRecords();
            ViewData["dataSource"] = documentDetails;
            return View();
        }
    }
    public class DocumentDetails
    {
        public static List<DocumentDetails> order;
        public DocumentDetails()
        {

        }
        public DocumentDetails(string FileName, string Url, string Author)
        {
            this.FileName = FileName;
            this.Url = Url;
            this.Author = Author;
        }
        public static List<DocumentDetails> GetAllRecords()
        {
            order = new List<DocumentDetails>();
            order.Add(new DocumentDetails("PDF Succinctly.pdf", "https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf","Ryan Hodson"));
            order.Add(new DocumentDetails("Hive Succinctly.pdf", "https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf","Elton Stoneman"));
            order.Add(new DocumentDetails("GIS Succinctly.pdf", "https://cdn.syncfusion.com/content/pdf/gis-succinctly.pdf", "Peter Shaw"));
            order.Add(new DocumentDetails("JavaScript Succinctly.pdf", "https://cdn.syncfusion.com/content/pdf/Javascript-succinctly.pdf","Cody Lindley"));
            order.Add(new DocumentDetails("HTTP Succinctly.pdf", "https://cdn.syncfusion.com/content/pdf/http-succinctly.pdf","Scott Allen"));
            return order;
        }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string Author { get; set; }
    }
}