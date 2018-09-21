#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        // GET: /DocIO Default Code 
        public ActionResult Default()
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
        public ActionResult Default(int id, string SaveOption, string Button)
        {
            if (Button == "View Template")
                return new TemplateResult("SalesInvoiceDemo.doc", ResolveApplicationDataPath("Data\\DocIO"), HttpContext.ApplicationInstance.Response);

            string dataPath1 = ResolveApplicationDataPath("", "Data\\DocIO");
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
    }
}