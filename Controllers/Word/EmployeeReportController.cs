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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;
using System.Data.OleDb;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region  EmployeeReport
        public ActionResult EmployeeReport(string Group1, string Button)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("EmployeesReportDemo.doc", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            DataSet dataset = new DataSet();
            //Access the database and get the NorthWind.
            string connectionstring = "Data Source = " + ResolveApplicationDataPath("Northwind.mdb", "Data");
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;" + connectionstring;
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select TOP 5 * from EmployeesReport", conn);
            adapter.Fill(dataset);
            adapter.Dispose();
            conn.Close();
            System.Data.DataTable table = dataset.Tables[0];
            string dataPath = ResolveApplicationDataPath("EmployeesReportDemo.doc", "Data\\Word");
            // Creating a new document.
            WordDocument document = new WordDocument();
            // Load template
            document.Open(dataPath, FormatType.Doc);

            // Set table name as Employess for template mergefield reference.
            table.TableName = "Employees";
            // Execute Mail Merge with groups. 
            document.MailMerge.ExecuteGroup(table);
            try
            {
                #region Document SaveOption
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
                //Save as .pdf format
                else if (Group1 == "Pdf")
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);

                    return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
                #endregion Document SaveOption
            }
            catch (Exception)
            { }
            return View();
        }
        #endregion  EmployeeReport
    }
}