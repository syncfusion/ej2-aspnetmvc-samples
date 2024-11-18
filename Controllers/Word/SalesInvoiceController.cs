#region Copyright
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        public ActionResult SalesInvoice()
        {
            try
            {
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                DataSet dataset = new DataSet();
                //Access the database and get the NorthWind
                SqlCeConnection conn = new SqlCeConnection();
                if (conn.ServerVersion.StartsWith("3.5"))
                    conn.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO_3.5.sdf", "Data");
                else
                    conn.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO.sdf", "Data");
                conn.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter("select OrderID  from SyncOrders Order By OrderID", conn);
                adapter.Fill(dataset);
                adapter.Dispose();
                conn.Close();

                DataTable dt = dataset.Tables[0];

                ArrayList list = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row[0].ToString());
                }
                ViewData.Add("id", new SelectList(list));
            }
            catch (Exception Ex)
            {
                // Shows the Message box with Exception message, if an exception is thrown.
                this.Response.Write(Ex.Message);
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SalesInvoice(int id, string SaveOption, string Button)
        {
            if (Button == "View Template")
                return new TemplateResult("SalesInvoiceDemo.doc", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            string dataPath1 = ResolveApplicationDataPath("", "Data\\Word");
            // Create a new document
            WordDocument doc = new WordDocument();
            // Load the template.
            doc.Open((System.IO.Path.Combine(dataPath1, @"SalesInvoiceDemo.doc")), FormatType.Automatic);
            // Execute Mail Merge with groups.
            doc.MailMerge.ExecuteGroup(GetTestOrder(id));
            doc.MailMerge.ExecuteGroup(GetTestOrderTotals(id));

            // Using Merge events to do conditional formatting during runtime.
            doc.MailMerge.MergeField += new MergeFieldEventHandler(MailMerge_MergeField);

            DataView orderDetails = new DataView(GetTestOrderDetails(id));
            orderDetails.Sort = "ExtendedPrice DESC";
            doc.MailMerge.ExecuteGroup(orderDetails);
            //Save as .doc format
            if (SaveOption == "WordDoc")
            {
                return doc.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (SaveOption == "WordDocx")
            {
                return doc.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (SaveOption == "WordML")
            {
                return doc.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (SaveOption == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(doc);

                return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            return View();
        }
        private void MailMerge_MergeField(object sender, MergeFieldEventArgs args)
        {
            // Conditionally format data during Merge.
            if (args.RowIndex % 2 == 0)
            {
                args.CharacterFormat.TextColor = System.Drawing.Color.DarkBlue;
            }

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

        private DataTable GetTestOrder(int TestOrderId)
        {
            DataTable table = new DataTable();
            table = ExecuteDataTable(string.Format("SELECT * FROM SyncOrders WHERE OrderId = {0}", TestOrderId));
            table.TableName = "Orders";
            return table;
        }

        private DataTable GetTestOrderDetails(int TestOrderId)
        {
            DataTable table = new DataTable();
            table = ExecuteDataTable(string.Format("SELECT * FROM SyncOrderDetails WHERE OrderId = {0} ORDER BY ProductID", TestOrderId)); table.TableName = "Order";
            return table;
        }

        private DataTable GetTestOrderTotals(int TestOrderId)
        {
            DataTable table = ExecuteDataTable(string.Format("SELECT * FROM SyncOrderTotals WHERE OrderId = {0}", TestOrderId));
            table.TableName = "OrderTotals";
            return table;
        }
        // Return DataTable
        private DataTable ExecuteDataTable(string commandText)
        {
            try
            {
                //Access the database and get the NorthWind
                SqlCeConnection conn = new SqlCeConnection();
                if (conn.ServerVersion.StartsWith("3.5"))
                    conn.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO_3.5.sdf", "Data");
                else
                    conn.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO.sdf", "Data");
                conn.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(commandText, conn);
                DataSet set = new DataSet();
                adapter.Fill(set);
                adapter.Dispose();
                conn.Close();
                DataTable table = new DataTable();
                table = set.Tables[0];

                return table;
            }
            finally
            {
            }
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