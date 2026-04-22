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
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.TreeGrid;
using Syncfusion.EJ2.TreeGridExport;

namespace EJ2MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult ServerSideExporting()
        {
            var treeData = TreeGridItems.GetTreeData();
            ViewData["datasource"] = treeData;
            return View();
        }
        public ActionResult ExcelExport(string treeGridModel)
        {
            if (treeGridModel == null)
            {
                return View();
            }
            TreeGridExcelExport exp = new TreeGridExcelExport();
            Syncfusion.EJ2.TreeGrid.TreeGrid gridProperty = ConvertTreeGridObject(treeGridModel);
            return exp.ExportToExcel<TreeGridItems>(gridProperty, TreeGridItems.GetTreeData());
        }

        public ActionResult CsvExport(string treeGridModel)
        {
            if (treeGridModel == null)
            {
                return View();
            }
            TreeGridExcelExport exp = new TreeGridExcelExport();
            Syncfusion.EJ2.TreeGrid.TreeGrid gridProperty = ConvertTreeGridObject(treeGridModel);
            return exp.ExportToCsv<TreeGridItems>(gridProperty, TreeGridItems.GetTreeData());
        }
        public ActionResult PdfExport(string treeGridModel)
        {
            if (treeGridModel == null)
            {
                return View();
            }
            TreeGridPdfExport exp = new TreeGridPdfExport();
            Syncfusion.EJ2.TreeGrid.TreeGrid gridProperty = ConvertTreeGridObject(treeGridModel);
            PdfExportProperties pdfExportProperties = new PdfExportProperties();
            return exp.ExportToPdf<TreeGridItems>(gridProperty, TreeGridItems.GetTreeData());
        }

        private Syncfusion.EJ2.TreeGrid.TreeGrid ConvertTreeGridObject(string gridProperty)
        {
            Syncfusion.EJ2.TreeGrid.TreeGrid TreeGridModel = (Syncfusion.EJ2.TreeGrid.TreeGrid)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(Syncfusion.EJ2.TreeGrid.TreeGrid));
            TreeGridColumnModel cols = (TreeGridColumnModel)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(TreeGridColumnModel));
            TreeGridModel.Columns = cols.columns;
            return TreeGridModel;
        }

        public class TreeGridColumnModel
        {
            public List<TreeGridColumn> columns { get; set; }
        }
    }
}
