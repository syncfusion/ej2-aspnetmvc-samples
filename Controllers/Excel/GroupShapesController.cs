#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
using Syncfusion.XlsIO;


namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        public ActionResult GroupShapes(string Group1, string button)
        {
            if (Group1 == null)
                return View();
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"GroupShapes.xlsx"));
                return excelEngine.SaveAsActionResult(workbook, "GroupShapes.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            }
            else
            {
                // The instantiation process consists of two steps.
                // Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                // Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                // An existing workbook is opened.
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("GroupShapes.xlsx"));

                IWorksheet worksheet;
                try
                {
                    if (Group1 == "Group")
                    {
                        // The first worksheet object in the worksheets collection is accessed.
                        worksheet = workbook.Worksheets[0];
                        IShapes shapes = worksheet.Shapes;

                        IShape[] groupItems;
                        for (int i = 0; i < shapes.Count; i++)
                        {
                            if (shapes[i].Name == "Development" || shapes[i].Name == "Production" || shapes[i].Name == "Sales")
                            {
                                groupItems = new IShape[] { shapes[i], shapes[i + 1], shapes[i + 2], shapes[i + 3], shapes[i + 4], shapes[i + 5] };
                                shapes.Group(groupItems);
                                i = -1;
                            }
                        }

                        groupItems = new IShape[] { shapes[0], shapes[1], shapes[2], shapes[3], shapes[4], shapes[5], shapes[6] };

                        // Group the selected shapes
                        shapes.Group(groupItems);

                        return excelEngine.SaveAsActionResult(workbook, "GroupShapes.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                    }
                    else if(Group1 == "UngroupAll")
                    {
                        // The second worksheet object in the worksheets collection is accessed.
                        worksheet = workbook.Worksheets[1];
                        IShapes shapes = worksheet.Shapes;

                        // Ungroup group shape and its all the inner shapes.
                        shapes.Ungroup(shapes[0] as IGroupShape, true);
                        worksheet.Activate();

                        return excelEngine.SaveAsActionResult(workbook, "UngroupShapes.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                    }
                    else if(Group1 == "Ungroup")
                    {
                        // The second worksheet object in the worksheets collection is accessed.
                        worksheet = workbook.Worksheets[1];
                        IShapes shapes = worksheet.Shapes;

                        // Ungroup group shape.
                        shapes.Ungroup(shapes[0] as IGroupShape);
                        worksheet.Activate();

                        return excelEngine.SaveAsActionResult(workbook, "UngroupShapes.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                    }
                }
                catch (Exception)
                {

                }
            }
            return View();
        }
    }
}
