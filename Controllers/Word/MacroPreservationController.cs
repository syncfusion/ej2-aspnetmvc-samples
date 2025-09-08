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
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        #region MacroPreservation
        // Create a DataSet.
        DataSet ds1 = new DataSet();
        public ActionResult MacroPreservation(string Button)
        {
            if (Button == null)
                return View();
            if (Button == "View Template")
                return new TemplateResult("MacroTemplate.dotm", ResolveApplicationDataPath("Data\\Word"), HttpContext.ApplicationInstance.Response);

            try
            {
                // Load the template.
                WordDocument document = new WordDocument(ResolveApplicationDataPath("MacroTemplate.dotm", "Data\\Word"));

                // Get the tables from Data Set.
                GetDataTable1();

                // Execute Mail Merge with groups.
                document.MailMerge.ExecuteGroup(ds1.Tables["Products"]);

                ds1 = null;
                ds1 = new DataSet();

                //Save as .docm format
                return document.ExportAsActionResult("Sample.docm", FormatType.Word2013Docm, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Trace.WriteLine(Ex.Message + "\n\n\n" + Ex.StackTrace);
            }
            return View();
        }
        private void GetDataTable1()
        {
            // List of syncfusion products name.
            string[] products = { "DocIO", "PDF", "XlsIO" };

            // Add new Tables to the data set.
            DataRow row;
            ds1.Tables.Add();

            // Add fields to the Products table.
            ds1.Tables[0].TableName = "Products";
            ds1.Tables[0].Columns.Add("ProductName");
            ds1.Tables[0].Columns.Add("Binary");
            ds1.Tables[0].Columns.Add("Source");

            // Inserting values to the tables.
            foreach (string product in products)
            {
                row = ds1.Tables["Products"].NewRow();
                row["ProductName"] = string.Concat("Essential ", product);
                row["Binary"] = "$895.00";
                row["Source"] = "$1,295.00";
                ds1.Tables["Products"].Rows.Add(row);
            }
        }
        #endregion MacroPreservation
    }
}