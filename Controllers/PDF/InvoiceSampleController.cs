#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Syncfusion.Pdf.Grid;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        # region Private Members
        DataSet dataSet = new DataSet();
        string y, shipName, address, shipCity, shipCountry, shippedDate;
        Double x, total = 0,  freight;
        int k = 0;
        SqlCeConnection connection;
        SqlCeDataAdapter adapter;
        # endregion
        //
        // GET: /InvoiceSample/

        public ActionResult InvoiceSample()
        {
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            connection = new SqlCeConnection();
            if (connection.ServerVersion.StartsWith("3.5"))
                connection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO_3.5.sdf");
            else
                connection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO.sdf");
            connection.Open();
            adapter = new SqlCeDataAdapter("select OrderID from SyncOrders Order By OrderID", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ArrayList list = new ArrayList();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            ViewData.Add("id", new SelectList(list));
            adapter.Dispose();
            connection.Close();
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult InvoiceSample(int id, string Browser)
        {
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            connection = new SqlCeConnection();
            if (connection.ServerVersion.StartsWith("3.5"))
                connection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO_3.5.sdf");
            else
                connection.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO.sdf");
            connection.Open();
          
            PdfDocument document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;
            document.PageSettings.Margins.All = 50;
            PdfPage page = document.Pages.Add();
            PdfGraphics g = page.Graphics;
            PdfTextElement element = new PdfTextElement("Northwind Traders\n67, rue des Cinquante Otages,\nElgin,\nUnites States.");
            element.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);
            element.Brush = new PdfSolidBrush(new PdfColor(89, 89, 93));
            PdfLayoutResult result = element.Draw(page, new RectangleF(0, 0, page.Graphics.ClientSize.Width / 2, 200));

            PdfImage img = PdfImage.FromFile(ResolveApplicationImagePath("logo.jpg"));
            page.Graphics.DrawImage(img, new RectangleF(g.ClientSize.Width - 200, result.Bounds.Y, 190, 45));
            PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);
            g.DrawRectangle(new PdfSolidBrush(new PdfColor(126, 151, 173)), new RectangleF(0, result.Bounds.Bottom + 40, g.ClientSize.Width, 30));
            element = new PdfTextElement("INVOICE " + id.ToString(), subHeadingFont);
            element.Brush = PdfBrushes.White;
            result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 48));
            string currentDate = "DATE " + DateTime.Now.ToString("MM/dd/yyyy");
            SizeF textSize = subHeadingFont.MeasureString(currentDate);
            g.DrawString(currentDate, subHeadingFont, element.Brush, new PointF(g.ClientSize.Width - textSize.Width - 10, result.Bounds.Y));

            element = new PdfTextElement("BILL TO ", new PdfStandardFont(PdfFontFamily.TimesRoman, 10));
            element.Brush = new PdfSolidBrush(new PdfColor(126, 155, 203));
            result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));

            g.DrawLine(new PdfPen(new PdfColor(126, 151, 173), 0.70f), new PointF(0, result.Bounds.Bottom + 3), new PointF(g.ClientSize.Width, result.Bounds.Bottom + 3));

            //Get the product table details
            DataTable shipTable = GetShipDetails(id);
            //Get the order details
            GetProductTable(id);

            element = new PdfTextElement(shipName, new PdfStandardFont(PdfFontFamily.TimesRoman, 10));
            element.Brush = new PdfSolidBrush(new PdfColor(89, 89, 93));
            result = element.Draw(page, new RectangleF(10, result.Bounds.Bottom + 5, g.ClientSize.Width / 2, 100));

            element = new PdfTextElement(string.Format("{0}, {1}, {2}", address, shipCity, shipCountry), new PdfStandardFont(PdfFontFamily.TimesRoman, 10));
            element.Brush = new PdfSolidBrush(new PdfColor(89, 89, 93));
            result = element.Draw(page, new RectangleF(10, result.Bounds.Bottom + 3, g.ClientSize.Width / 2, 100));

            PdfGrid grid = new PdfGrid();
            grid.DataSource = GetProductDetails(id);
            PdfGridCellStyle cellStyle = new PdfGridCellStyle();
            cellStyle.Borders.All = PdfPens.White;
            PdfGridRow header = grid.Headers[0];

            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = new PdfPen(new PdfColor(126, 151, 173));
            headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
            headerStyle.TextBrush = PdfBrushes.White;
            headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f, PdfFontStyle.Regular);

            for (int i = 0; i < header.Cells.Count; i++)
            {
                if (i == 0 || i==1)
                    header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                else
                    header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);
            }

            header.ApplyStyle(headerStyle);
            cellStyle.Borders.Bottom = new PdfPen(new PdfColor(217, 217, 217), 0.70f);
            cellStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12f);
            cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(131, 130, 136));
            foreach (PdfGridRow row in grid.Rows)
            {
                row.ApplyStyle(cellStyle);
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    PdfGridCell cell = row.Cells[i];
                    if (i == 1)
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                    else if (i == 0)
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                    else
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);

                    if (i > 2)
                    {
                        float val = float.MinValue;
                        float.TryParse(cell.Value.ToString(), out val);
                        cell.Value = val.ToString("C");
                    }
                }
            }

            grid.Columns[0].Width = 100;
            grid.Columns[1].Width = 200;
            
            PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();
            layoutFormat.Layout = PdfLayoutType.Paginate;

            PdfGridLayoutResult gridResult = grid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(g.ClientSize.Width, g.ClientSize.Height - 100)), layoutFormat);
            float pos = 0.0f;
            for (int i = 0; i < grid.Columns.Count - 1; i++)
                pos += grid.Columns[i].Width;

            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f);

            gridResult.Page.Graphics.DrawString("Total Due", font, new PdfSolidBrush(new PdfColor(126, 151, 173)), new RectangleF(new PointF(pos, gridResult.Bounds.Bottom + 20), new SizeF(grid.Columns[3].Width - pos, 20)), new PdfStringFormat(PdfTextAlignment.Right));
            gridResult.Page.Graphics.DrawString("Thank you for your business!", new PdfStandardFont(PdfFontFamily.TimesRoman, 12), new PdfSolidBrush(new PdfColor(89, 89, 93)), new PointF(pos - 55, gridResult.Bounds.Bottom + 60));
            pos += grid.Columns[4].Width;
            gridResult.Page.Graphics.DrawString(total.ToString("C"), font, new PdfSolidBrush(new PdfColor(131, 130, 136)), new RectangleF(new PointF(pos, gridResult.Bounds.Bottom + 20), new SizeF(grid.Columns[4].Width - pos, 20)), new PdfStringFormat(PdfTextAlignment.Right));

            adapter.Dispose();
            connection.Close();
            //Save to disk
            //Stream the output to the browser.    
            if (Browser == "Browser")
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);

        }

        private void GetProductTable(int id)
        {
            DataTable dataTable = new DataTable();
            adapter = new SqlCeDataAdapter("Select ShipName,ShipAddress,Freight,ShippedDate,ShipCity,ShipCountry from Orders where OrderID=" + id, connection);
            adapter.Fill(dataTable);
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

        //Main table
        private DataSet GetTestOrder(int id)
        {
            string DEF_DB_COMMAND2 = "SELECT Salesperson,ShipName,ShipCountry,CustomerID,OrderDate,RequiredDate FROM SyncOrders WHERE OrderId =" + id;
            adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, connection);
            adapter.Fill(dataSet);
            return dataSet;
        }

        //Sub table
        private DataTable GetProductDetails(int id)
        {
            adapter = new SqlCeDataAdapter("select ProductID,ProductName,Quantity,UnitPrice,Discount from SyncOrderDetails where OrderID=" + id, connection);
            DataTable prodDT = new DataTable();
            adapter.Fill(prodDT);

            //Add new column
            prodDT.Columns.Add(new DataColumn("Price", typeof(String)));

            DataTable dt = new DataTable();
            adapter = new SqlCeDataAdapter("select Quantity,UnitPrice from SyncOrderDetails where OrderID=" + id, connection);
            adapter.Fill(dt);
            DataRow dr;
            int rows = dt.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                dr = dt.Rows[i];
                x = System.Convert.ToDouble(dr["Quantity"].ToString()) * System.Convert.ToDouble(dr["UnitPrice"].ToString());
                dr = prodDT.Rows[k];
                y = x.ToString();
                dr["Price"] = y.ToString();
                k++;

                total = total + x;
            }
            return prodDT;
        }

        private DataTable GetShipDetails(int TestOrderId)
        {
            DataTable dt = new DataTable();
            adapter = new SqlCeDataAdapter(String.Format("SELECT ShipName,ShipAddress,Freight,ShipCity,ShipCountry,ShippedDate from Orders where OrderID={0}", TestOrderId), connection);
            adapter.Fill(dt);
            return dt;
        }
     }
}
