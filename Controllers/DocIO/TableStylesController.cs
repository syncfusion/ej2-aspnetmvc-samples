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
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Data;
using System.Data.OleDb;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region Table Styles
        public ActionResult TableStyles(string Group1)
        {
            if (Group1 == null)
                return View();
            string dataPath = ResolveApplicationDataPath("TemplateTableStyle.doc", "Data\\DocIO");
            WordDocument document = new WordDocument(dataPath);

            string dataBase = ResolveApplicationDataPath("Northwind.mdb", "Data");
            // Get Data from the Database.
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            string connectionstring = "Data Source = " + ResolveApplicationDataPath("Northwind.mdb", "Data");
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;" + connectionstring;
            conn.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Suppliers", conn);
            adapter.Fill(ds);
            ds.Tables[0].TableName = "Suppliers";
            adapter.Dispose();
            conn.Close();

            // Execute Mail Merge with groups.
            document.MailMerge.ExecuteGroup(ds.Tables[0]);

            #region Built-in table styles
            //Get table to apply style.
            WTable table = (WTable)document.LastSection.Tables[0];

            //Apply built-in table style to the table.
            table.ApplyStyle(BuiltinTableStyle.MediumShading1Accent5);
            #endregion

            #region Document save option
            //Save as .docx format
            if (Group1 == "WordDocx")
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
            #endregion Document save option

            return View();
        }
        #endregion Table Styles
    }
}