#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.DocumentEditor
{
    public partial class DocumentEditorController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DocumentList()
        {
            var documentDetails = DocumentDataDetails.GetAllRecords();
            ViewData["dataSource"] = documentDetails;
            return View();
        }
    }
    public class DocumentDataDetails
    {
        public static List<DocumentDataDetails> order;
        public DocumentDataDetails()
        {

        }
        public DocumentDataDetails(string FileName, string FilePath, string Author)
        {
            this.FileName = FileName;
            this.FilePath = FilePath;
            this.Author = Author;
        }
        public static List<DocumentDataDetails> GetAllRecords()
        {
            order = new List<DocumentDataDetails>();
            order.Add(new DocumentDataDetails("Getting Started.docx", "~/Scripts/documenteditor/data-default.json", "Ryan Hodson"));
            order.Add(new DocumentDataDetails("Character Formatting.docx", "~/Scripts/documenteditor/data-character-formatting.json", "Elton Stoneman"));
            order.Add(new DocumentDataDetails("Paragraph Format.docx", "~/Scripts/documenteditor/data-paragraph-formatting.json", "Peter Shaw"));
            order.Add(new DocumentDataDetails("Style.docx", "~/Scripts/documenteditor/data-styles.json", "Cody Lindley"));
            order.Add(new DocumentDataDetails("Web Layout.docx", "~/Scripts/documenteditor/data-WebLayout.json", "Scott Allen"));
            return order;
        }
        public string FileName { get; set; }
        public object FilePath { get; set; }
        public string Author { get; set; }
    }
}