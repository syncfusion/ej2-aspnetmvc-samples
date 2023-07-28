#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
using System.Data;
using System.Data.SqlServerCe;
using System.Collections;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /Invoice/

        private string shipName, address, shipCity, shipCountry, shippedDate;
        private Double freight;
        SqlCeConnection sqlCeConnection;
        SqlCeDataAdapter sqlCeAdapter;

        private void InitializeData()
        {
            try
            {
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                sqlCeConnection = new SqlCeConnection();
                if (sqlCeConnection.ServerVersion.StartsWith("3.5"))
                    sqlCeConnection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO_3.5.sdf");
                else
                    sqlCeConnection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO.sdf");
                sqlCeAdapter = new SqlCeDataAdapter("select OrderID from SyncOrders Order By OrderID", sqlCeConnection);
                DataSet ds = new DataSet();
                sqlCeAdapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                ArrayList list = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row[0].ToString());
                }
                ViewData.Add("id", new SelectList(list));
                sqlCeAdapter.Dispose();
                sqlCeConnection.Close();
            }
            catch (Exception Ex)
            {
                // Shows the Message box with Exception message, if an exception is thrown.
                this.Response.Write(Ex.Message);
            }
            
        }
        public ActionResult Invoice(string id, string SaveOption)
        {
            if (SaveOption == null)
            {
                InitializeData();
                return View();
            }
            int invoiceId = Convert.ToInt32(id);
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            sqlCeConnection = new SqlCeConnection();
            if (sqlCeConnection.ServerVersion.StartsWith("3.5"))
                sqlCeConnection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO_3.5.sdf");
            else
                sqlCeConnection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO.sdf");
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            IWorkbook workbook;

            if (SaveOption == "Xlsx")
            {
                application.DefaultVersion = ExcelVersion.Excel2016;
                workbook = application.Workbooks.Open(ResolveApplicationDataPath("Invoice.xlsx"));
            }
            else
            {
                application.DefaultVersion = ExcelVersion.Excel97to2003;
                workbook = application.Workbooks.Open(ResolveApplicationDataPath("Invoice.xls"));
            }

            IWorksheet sheet = workbook.Worksheets[0];

            sheet.Range["A5"].Text = "One Portals Way";
            sheet.Range["A6"].Text = "Twin Points WA 98156";
            sheet.Range["A7"].Text = "Phone: 1-206-555-1417 ";
            sheet.Range["A8"].Text = "Fax: 1-206-555-5938";

            sheet.Range["D5"].Text = "INVOICE NO:";
            sheet.Range["D6"].Text = "DATE:";
            sheet.Range["D7"].Text = "CUSTOMER ID  :";
            sheet.Range["E6"].Formula = "TODAY()";

            sheet.Range["E5"].Number = invoiceId;

            //Set values for Ship To.
            GetShipDetails(invoiceId);
            sheet.Range["E7"].Text = shipName;
            sheet.Range["E10"].Text = shipName;
            sheet.Range["E11"].Text = address;
            sheet.Range["E12"].Text = shipCity;
            sheet.Range["E13"].Text = shipCountry;

            //Set values for Bill To.
            sheet.Range["B10"].Text = shipName;
            sheet.Range["B11"].Text = address;
            sheet.Range["B12"].Text = shipCity;
            sheet.Range["B13"].Text = shipCountry;

            //Calculates sub total
            sheet.Range["E27"].Formula = "SUM(E20:E26)";

            //Set the number format
            sheet.Range["E20:E29"].NumberFormat = "$#,##0.00";
            sheet.Range["E28"].Value = freight.ToString();

            //Calculates final total
            sheet.Range["E29"].Formula = "E27+E28";

            //Import the data tables.
            sheet.ImportDataTable(GetOrder(invoiceId), false, 17, 1);
            sheet.ImportDataTable(GetProductDetails(invoiceId), false, 20, 1);

            //Calculates price from discount and unit price.
            for (int i = 20; i <= 26; i++)
            {
                if (sheet.Range["A" + i.ToString()].Value == "")
                {
                    break;
                }
                else
                {
                    sheet.Range["E" + i.ToString()].Formula = "(B" + i.ToString() + "*C" + i.ToString() + ")- (D" + i.ToString() + "/100)";
                }
            }

            try
            {

                if (SaveOption == "Xls")
                    return excelEngine.SaveAsActionResult(workbook, "Invoice.xls", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
                else
                    return excelEngine.SaveAsActionResult(workbook, "Invoice.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);

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

        private DataTable GetProductDetails(int invoiceId)
        {
            SqlCeDataAdapter da = new SqlCeDataAdapter("Select ProductID,Quantity,UnitPrice,Discount from SyncOrderDetails where OrderID=" + invoiceId, sqlCeConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable prodDS = new DataTable();
            prodDS = ds.Tables[0];
            return prodDS;
        }

        private void GetShipDetails(int invoiceId)
        {
            SqlCeDataAdapter da = new SqlCeDataAdapter("Select ShipName,ShipAddress,Freight,ShippedDate,ShipCity,ShipCountry from Orders where OrderID=" + invoiceId, sqlCeConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dataTable = new DataTable();
            dataTable = ds.Tables[0];
            DataRow dr;
            int rows = dataTable.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                dr = dataTable.Rows[i];
                shipName = dr["ShipName"].ToString();
                freight = System.Convert.ToDouble(dr["Freight"].ToString());
                address = dr["ShipAddress"].ToString();
                shippedDate = dr["ShippedDate"].ToString();
                shipCity = dr["ShipCity"].ToString();
                shipCountry = dr["ShipCountry"].ToString();
            }
        }

        private DataTable GetOrder(int invoiceId)
        {
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter("Select Salesperson,ShipName,ShipCountry,CustomerID,OrderDate,RequiredDate from SyncOrders where OrderID=" + invoiceId, sqlCeConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];

            return dt;
        }

    }
}
