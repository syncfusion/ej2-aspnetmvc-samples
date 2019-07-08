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

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region  LetterFormat
        public ActionResult LetterFormat(string Group1, string Button, string MapDataField)
        {
            if (Group1 == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("Letter Formatting.doc", ResolveApplicationDataPath("Data\\DocIO"), HttpContext.ApplicationInstance.Response);
            try
            {
                DataSet dataset = new DataSet();
                //Access the database and get the NorthWind
                string connectionstring = "Data Source = " + ResolveApplicationDataPath("Northwind.mdb", "Data");
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;" + connectionstring;
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select CompanyName, ContactName, Address, City, Region, Country, Phone, Fax from Customers", conn);
                adapter.Fill(dataset);
                adapter.Dispose();
                conn.Close();
                DataTable table = dataset.Tables[0];
                string dataPath = ResolveApplicationDataPath("Letter Formatting.doc", "Data\\DocIO");
                //Creating a new document.
                WordDocument document = new WordDocument();
                //Load template
                document.Open(dataPath, FormatType.Doc);
                //Checks if data field mapping should be enabled
                if (MapDataField == "MapDataField")
                {
                    //Removes paragraph that contains only empty fields.
                    document.MailMerge.RemoveEmptyParagraphs = true;
                    //To clear the fields with empty value
                    document.MailMerge.ClearFields = true;
                    //Clear the map fields
                    document.MailMerge.MappedFields.Clear();
                    //Update the mapping fields
                    document.MailMerge.MappedFields.Add("Contact Name", "ContactName");
                    document.MailMerge.MappedFields.Add("Company Name", "CompanyName");
                    document.MailMerge.MappedFields.Add("CompanyAddress", "Address");
                    document.MailMerge.MappedFields.Add("Residing City", "City");
                    document.MailMerge.MappedFields.Add("Current Region", "Region");
                    document.MailMerge.MappedFields.Add("Home Country", "Country");
                }
                //Mailmerge can be performed with the input as either DataRow, DataField, DataView, IDataReader 
                //or a set of merge field names and values. Here, one particular row is extraced from the table and used.
                DataRow dr = table.Rows[0];
                //Executes mail merge for the selected record or row
                document.MailMerge.Execute(dr);
                //Add Text Watermark
                document.Watermark = new TextWatermark();
                (document.Watermark as TextWatermark).Text = "Demo";
                (document.Watermark as TextWatermark).Size = 144;
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
                //Save as WordML(.xml) format
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
        #endregion  LetterFormat
    }
}