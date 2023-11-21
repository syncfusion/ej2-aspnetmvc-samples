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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        public ActionResult AdvancedReplace(string Group1, string Button)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("MasterTemplate.doc", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);
            try
            {
                // Creating new documents.
                WordDocument docSource1 = new WordDocument();
                WordDocument docSource2 = new WordDocument();
                WordDocument docMaster = new WordDocument();

                // Load Templates.
                docSource1.Open(ResolveApplicationDataPath("SourceTemplate1.doc", "Data\\Word"), FormatType.Doc);
                docSource2.Open(ResolveApplicationDataPath("SourceTemplate2.doc", "Data\\Word"), FormatType.Doc);
                docMaster.Open(ResolveApplicationDataPath("MasterTemplate.doc", "Data\\Word"), FormatType.Doc);

                // Search for a string and store in TextSelection
                //The TextSelection copies a text segment with formatting.
                TextSelection selection1 = docSource1.Find("PlaceHolder text is replaced with this formatted animated text", false, false);

                //Get the text segment to replace the text across multiple paragraphs
                TextBodyPart replacePart = new TextBodyPart(docSource2);
                foreach (TextBodyItem bodyItem in docSource2.LastSection.Body.ChildEntities)
                    replacePart.BodyItems.Add(bodyItem.Clone());
                // Replacing the placeholder inside Master Template with matches found while
                //search the two template documents. 
                docMaster.Replace("PlaceHolder1", selection1, true, true, true);
                docMaster.ReplaceSingleLine((new System.Text.RegularExpressions.Regex("PlaceHolder2Start:Suppliers/Vendors of Northwind." +
                "Customers of Northwind.Employee details of Northwind traders.The product information.The inventory details.The shippers." +
                "PO transactions i.e Purchase Order transactions.Sales Order transaction.Inventory transactions.Invoices.PlaceHolder2End")), replacePart);

                #region document save option

                //Save as .doc format
                if (Group1 == "WordDoc")
                {
                    return docMaster.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .docx format
                else if (Group1 == "WordDocx")
                {
                    return docMaster.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                // Save as WordML(.xml) format
                else if (Group1 == "WordML")
                {
                    return docMaster.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
                }
                //Save as .pdf format
                else if (Group1 == "Pdf")
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    PdfDocument pdfDoc = converter.ConvertToPDF(docMaster);
                    return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }

                #endregion document save option
            }
            catch (Exception)
            {
            }

            return View();
        }
		protected string ResolveApplicationDataPath(string folderName)
        {
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\App_Data")).FullName;
            if (folderName != string.Empty)
                dataPath += "\\" + folderName;
            return dataPath;
        }
        protected string ResolveApplicationDataPath(string fileName, string folderName)
        {
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\App_Data")).FullName;
            if (folderName != string.Empty)
                dataPath += "\\" + folderName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }
	}
	public class TemplateResult : ActionResult
    {
        #region Fields
        private string m_filename;
        private string m_physicalPath;
        private HttpResponse m_response;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName
        {
            get
            {
                return m_filename;
            }
            set
            {
                m_filename = value;
            }
        }
        /// <summary>
        /// Gets or sets the physical path.
        /// </summary>
        /// <value>
        /// The physical path.
        /// </value>
        public string PhysicalPath
        {
            get
            {
                return m_physicalPath;
            }
            set
            {
                m_physicalPath = value;
            }
        }
        /// <summary>
        /// Gets the response.
        /// </summary>
        /// <value>
        /// The response.
        /// </value>
        public HttpResponse Response
        {
            get
            {
                return m_response;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResult"/> class.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="physicalPath">The physical path.</param>
        /// <param name="response">The response.</param>
        public TemplateResult(string filename, string physicalPath, HttpResponse response)
        {
            FileName = filename;
            m_response = response;
            m_physicalPath = physicalPath;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Enables processing of the result of an action method by a custom type that inherits from the <see cref="T:System.Web.Mvc.ActionResult" /> class.
        /// </summary>
        /// <param name="context">The context in which the result is executed. The context information includes the controller, HTTP content, request context, and route data.</param>
        /// <exception cref="System.ArgumentNullException">Context</exception>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context");
            LoadTemplate(FileName);
        }
        /// <summary>
        /// Loads the template.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        private void LoadTemplate(string fileName)
        {
            string dataPath = string.Format("{0}\\{1}", PhysicalPath, fileName);
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            fileStream.Position = 0L;
            Response.Clear();
            Response.AddHeader("Content-Type", fileName.EndsWith("doc") ? "application/msword" : "application/vnd.ms-word.document.12");
            Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName + ";");
            fileStream.CopyTo(Response.OutputStream);
            fileStream.Close();
            Response.End();
        }
        #endregion
    }
}
