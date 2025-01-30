#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        # region Private Members
       
        # endregion
        //
        // GET: /AdventureCycle/

        public ActionResult AdventureCycle()
        {
            List<string> styleList = new List<string>();

            foreach (var style in Enum.GetValues(typeof(PdfGridBuiltinStyle)))
            {
                styleList.Add(style.ToString());
            }
            ViewData.Add("styleName", new SelectList(styleList));
           
            return View();          
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AdventureCycle(string styleName, string Header, string Bandedrow, string Bandedcolumn, string Firstcolumn, string Lastcolumn, string Lastrow, string InsideBrowser)
        {
            if (styleName == "")
                styleName = "GridTable4";
            //Create PDF document
            PdfDocument doc = new PdfDocument();

            //Set font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 7);

            //Create Pdf ben for drawing broder
            PdfPen borderPen = new PdfPen(PdfBrushes.DarkBlue);
            borderPen.Width = 0;
           
            //Create DataTable for source
            PdfPage page = doc.Pages.Add();
         

            //Use DataTable as source
            PdfGrid grid = new PdfGrid();

            //Create dataset with the "Customers" table from Norwind database
            DataSet dataSet = GetReportsDataSet1();

            DataTable dt = dataSet.Tables[0];
            string[] unwantedColumns = { "Freight", "EmployeeID", "OrderDate", "RequiredDate", "ShippedDate", "ShipVia", "ShipRegion" };
            foreach (string columnIndex in unwantedColumns)
            {
                dt.Columns.Remove(columnIndex);
            }

            grid.Style.AllowHorizontalOverflow = true;

            //Set Data source
            grid.DataSource = dt;          

            #region PdfGridBuiltinStyleSettings
            PdfGridBuiltinStyleSettings setting = new PdfGridBuiltinStyleSettings();
            setting.ApplyStyleForHeaderRow = Header!=null ? true : false;
            setting.ApplyStyleForBandedRows = Bandedrow != null ? true : false;
            setting.ApplyStyleForBandedColumns = Bandedcolumn != null ? true : false;
            setting.ApplyStyleForFirstColumn = Firstcolumn != null ? true : false;
            setting.ApplyStyleForLastColumn = Lastcolumn != null ? true : false;
            setting.ApplyStyleForLastRow = Lastrow != null ? true : false;
            #endregion 

            //Set layout properties
            PdfLayoutFormat format = new PdfLayoutFormat();
            format.Break = PdfLayoutBreakType.FitElement;
            format.Layout = PdfLayoutType.Paginate;

            PdfGridBuiltinStyle style = ConvertToPdfGridBuiltStyle(styleName);

            grid.ApplyBuiltinStyle(style, setting);
            grid.Style.Font = font;
            //Draw table
            grid.Draw(page, PointF.Empty, format);

            //Save to disk
            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
        }
        # region Helpher Methods


        private PdfGridBuiltinStyle ConvertToPdfGridBuiltStyle(string styleName)
        {
            PdfGridBuiltinStyle value = (PdfGridBuiltinStyle)Enum.Parse(typeof(PdfGridBuiltinStyle), styleName);
            return value;
        }

        private DataSet GetReportsDataSet1()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(ResolveApplicationDataPath("Orders.xml"));
            return dataSet;
        }
      
        #endregion

    }
}
