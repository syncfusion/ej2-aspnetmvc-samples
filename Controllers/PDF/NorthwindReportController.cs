#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.Data.SqlServerCe;

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using System.Data;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        # region Private Members
        private const string DEF_DB_COMMAND2 = "SELECT CustomerID,CompanyName,ContactName,Address,City,PostalCode,Country,Phone,Fax FROM Customers";
        # endregion
        //
        // GET: /NorthwindReport/

        public ActionResult NorthwindReport()
        {
            List<string> styleList = new List<string>();

            foreach (var style in Enum.GetValues(typeof(PdfLightTableBuiltinStyle)))
            {
                styleList.Add(style.ToString());
            }
            ViewData.Add("styleName", new SelectList(styleList));
            return View();          
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult NorthwindReport(string styleName, string Header, string Bandedrow, string Bandedcolumn, string Firstcolumn, string Lastcolumn, string Lastrow, string InsideBrowser)
        {
		if (styleName == "")
                styleName = "GridTable4";

            //Create PDF document
            PdfDocument doc = new PdfDocument();

            //Set font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

            //Create Pdf ben for drawing broder
            PdfPen borderPen = new PdfPen(PdfBrushes.DarkBlue);
            borderPen.Width = 0;

            //Create brush
            PdfColor color = new PdfColor(192, 201, 219);
            PdfSolidBrush brush = new PdfSolidBrush(color);

            //Create cell styles
            PdfCellStyle altStyle = new PdfCellStyle();
            altStyle.Font = font;
            altStyle.BackgroundBrush = brush;
            altStyle.BorderPen = borderPen;

            PdfCellStyle defStyle = new PdfCellStyle();
            defStyle.Font = font;
            defStyle.BackgroundBrush = PdfBrushes.White;
            defStyle.BorderPen = borderPen;

            PdfCellStyle headerStyle = new PdfCellStyle(font, PdfBrushes.White, PdfPens.DarkBlue);
            brush = new PdfSolidBrush(Color.FromArgb(33, 67, 126));
            headerStyle.BackgroundBrush = brush;

            //Create DataTable for source
            PdfPage page = doc.Pages.Add();

            //Adding Header
            this.AddHeader(doc, "Northwind Customers", "");

            //Use DataTable as source
            PdfLightTable table = new PdfLightTable();

            //Create dataset with the "Customers" table from Norwind database
            DataSet dataSet = GetNorthwindDataSet(DEF_DB_COMMAND2);

            //Create datatable
            DataTable dataTable = dataSet.Tables[0];

            //Set Data source
            table.DataSource = dataTable;

            //Set table alternate row style
            table.Style.AlternateStyle = altStyle;

            //Set default style
            table.Style.DefaultStyle = defStyle;

            //Set header row style         
            table.Style.HeaderStyle = headerStyle;

            //Show the header row
            table.Style.ShowHeader = true;

            //Repeate header in all the pages
            table.Style.RepeatHeader = true;

            //Set header data from column caption
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;

            table.Style.BorderPen = borderPen;
            table.Style.BorderPen = borderPen;
            table.Style.CellPadding = 2;
            table.Columns[1].Width = 65;
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            table.Style.DefaultStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);

            #region PdfLightTableBuiltinStyleSettings
            table.Style.BorderPen = new PdfPen(Color.Empty);
            PdfLightTableBuiltinStyleSettings setting = new PdfLightTableBuiltinStyleSettings();
            setting.ApplyStyleForHeaderRow = Header != null ? true : false;
            setting.ApplyStyleForBandedRows = Bandedrow != null ? true : false;
            setting.ApplyStyleForBandedColumns = Bandedcolumn != null ? true : false;
            setting.ApplyStyleForFirstColumn = Firstcolumn != null ? true : false;
            setting.ApplyStyleForLastColumn = Lastcolumn != null ? true : false;
            setting.ApplyStyleForLastRow = Lastrow != null ? true : false;
            #endregion 

            PdfLightTableBuiltinStyle style = ConvertToPdfLightTableBuiltinStyle(styleName);

            table.ApplyBuiltinStyle(style, setting);


            //Set layout properties
            PdfLayoutFormat format = new PdfLayoutFormat();
            format.Break = PdfLayoutBreakType.FitElement;
            format.Layout = PdfLayoutType.Paginate;

            //Draw table
            table.Draw(page, PointF.Empty, format);

            //Save to disk
            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
        }
        # region Helpher Methods

        private PdfLightTableBuiltinStyle ConvertToPdfLightTableBuiltinStyle(string styleName)
        {
            PdfLightTableBuiltinStyle value = (PdfLightTableBuiltinStyle)Enum.Parse(typeof(PdfLightTableBuiltinStyle), styleName);
            return value;
        }
        /// <summary>
        /// Returns the data set from the data source
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="selectCommand"></param>
        /// <returns></returns>
        private DataSet GetNorthwindDataSet(string selectCommand)
        {
            DataSet dataSet = new DataSet();

            try
            {
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                SqlCeConnection conn = new SqlCeConnection();
                if (conn.ServerVersion.StartsWith("3.5"))
                    conn.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO_3.5.sdf");
                else
                    conn.ConnectionString = "Data Source = " + ResolveApplicationDataPath("NorthwindIO.sdf");
                conn.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, conn);
                adapter.Fill(dataSet);
                adapter.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

            return dataSet;
        }

        /// <summary>
        /// Adds header to the document
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        private void AddHeader(PdfDocument doc, string title, string description)
        {
            RectangleF rect = new RectangleF(0, 0, doc.Pages[0].GetClientSize().Width, 54);
            PdfPageTemplateElement header = new PdfPageTemplateElement(rect);
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 24);
            float doubleHeight = font.Height * 2;
            Color activeColor = Color.FromArgb(44, 71, 120);
            SizeF imageSize = new SizeF(110f, 35f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(doc.Pages[0].GetClientSize().Width - imageSize.Width - 20, 8);

            PdfImage img = new PdfBitmap(ResolveApplicationImagePath("logo.jpg"));

            //Draw the image in the Header.
            header.Graphics.DrawImage(img, imageLocation, imageSize);

            PdfSolidBrush brush = new PdfSolidBrush(activeColor);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            header.Graphics.DrawString(title, font, brush, new RectangleF(0, 0, header.Width, header.Height), format);
            brush = new PdfSolidBrush(Color.Gray);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            header.Graphics.DrawString(description, font, brush, new RectangleF(0, 0, header.Width, header.Height - 8), format);

            header.Graphics.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, header.Height - 4, header.Width, header.Height - 4);

            doc.Template.Top = header;
        }
        #endregion

    }
}
