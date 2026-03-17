#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
using Syncfusion.EJ2.Grids;
using Syncfusion.EJ2.GridExport;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: ServerSideExporting
        public ActionResult ServerSideExporting()
        {
            var order = OrdersDetails.GetRecords();
            ViewData["datasource"] = order;
            return View();
        }

        public ActionResult ExcelExport(string gridModel)
        {
            GridExcelExport exp = new GridExcelExport();
            Syncfusion.EJ2.Grids.Grid gridProperty = ConvertGridObject(gridModel);
            return exp.ExcelExport<OrdersDetails>(gridProperty, OrdersDetails.GetRecords());
        }

        public ActionResult CsvExport(string gridModel)
        {
            GridExcelExport exp = new GridExcelExport();
            Syncfusion.EJ2.Grids.Grid gridProperty = ConvertGridObject(gridModel);
            return exp.CsvExport<OrdersDetails>(gridProperty, OrdersDetails.GetRecords());
        }

        public ActionResult PdfExport(string gridModel)
        {
            GridPdfExport exp = new GridPdfExport();
            Syncfusion.EJ2.Grids.Grid gridProperty = ConvertGridObject(gridModel);
            return exp.PdfExport<OrdersDetails>(gridProperty, OrdersDetails.GetRecords());
        }

        private Syncfusion.EJ2.Grids.Grid ConvertGridObject(string gridProperty)
        {
            Syncfusion.EJ2.Grids.Grid GridModel = (Syncfusion.EJ2.Grids.Grid)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(Syncfusion.EJ2.Grids.Grid));
            GridColumnModel cols = (GridColumnModel)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(GridColumnModel));
            GridModel.Columns = cols.columns;
            return GridModel;
        }
    }
}