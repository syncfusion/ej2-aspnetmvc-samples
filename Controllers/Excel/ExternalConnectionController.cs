#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        string connectionstring;
        OleDbDataAdapter adapter;
        OleDbConnection connection;
        //
        // GET: /ExternalConnection/
        public void InitializeExternalConnection()
        {
            try
            {
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                connectionstring = "Data Source = " + ResolveApplicationDataPath("Northwind.mdb");
                connection = new OleDbConnection();
                connection.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;" + connectionstring;
                connection.Open();
                OleDbCommand query = new OleDbCommand("select distinct country from customers", connection);
                adapter = new OleDbDataAdapter(query);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                ArrayList list = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row[0].ToString());
                }
                ViewData.Add("country", list);
                adapter.Dispose();
                connection.Close();
            }
            catch (Exception Ex)
            {
                // Shows the Message box with Exception message, if an exception is thrown.
                this.Response.Write(Ex.Message);
            }
            
        }
        public ActionResult ExternalConnection(string country, string button, string refresh)
        {
            if (button == null)
            {
                InitializeExternalConnection();
                return View();
            }

            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            #region Initialize Workbook
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            //Create the workbook with default sheet
            IWorkbook workbook = application.Workbooks.Create();
            workbook.Version = ExcelVersion.Excel2016;
            //Get the 1st sheet from the workbook
            IWorksheet sheet = workbook.Worksheets[0];
            connectionstring = "Data Source = " + ResolveApplicationDataPath("Northwind.mdb");
            //connection string for DataSource
            string Connectionstring = "OLEDB;Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;" + connectionstring;

            //query for the datasource
            string query;
            if (country != null)
                query = "select * from Customers where country='" + country + "'";
            else
                query = "select * from Customers";

            //Add the connection to workbook
            IConnection Connection = workbook.Connections.Add("Connection1", "Sample connection with MsAccess", Connectionstring, query, ExcelCommandType.Sql);
            //Add the QueryTable to sheet object
            sheet.ListObjects.AddEx(ExcelListObjectSourceType.SrcQuery, Connection, sheet.Range["C3"]);
            #endregion

            #region Refresh the Connection
            //Refresh the Connection for include the data            
            if (refresh != null)
            {
                try
                {
                    sheet.ListObjects[0].Refresh();
                    sheet.UsedRange.AutofitColumns();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
            #endregion

            try
            {
               return excelEngine.SaveAsActionResult(workbook, "ExternalConnection.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            catch (Exception)
            {
            }

            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            adapter.Dispose();
            connection.Close();
            return View();
        }

    }
}
