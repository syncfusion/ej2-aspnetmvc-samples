#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Syncfusion.Drawing;
using System.IO;
using EJ2MVCSampleBrowser.Models;
using System.Drawing;
namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        [HttpGet]
        public ActionResult AutoFill()
        {
            var model = new AutoFillOptionsModel();
            ViewBag.AutoFillOptions = new List<SelectListItem>
            {
                new SelectListItem { Text = "Default", Value = "A0" },
                new SelectListItem { Text = "Copy", Value = "A1" },
                new SelectListItem { Text = "Series", Value = "A2" },
                new SelectListItem { Text = "Formats", Value = "A3" },
                new SelectListItem { Text = "Values", Value = "A4" },
                new SelectListItem { Text = "Days", Value = "A5" },
                new SelectListItem { Text = "Weekdays", Value = "A6" },
                new SelectListItem { Text = "Months", Value = "A7" },
                new SelectListItem { Text = "Years", Value = "A8" },
                new SelectListItem { Text = "Linear Trend", Value = "A9" },
                new SelectListItem { Text = "Growth Trend", Value = "A10" }
            };
            ViewBag.FillSeriesOptions = new List<SelectListItem>
            {
                new SelectListItem { Text = "Linear", Value = "F0" },
                new SelectListItem { Text = "Growth", Value = "F1" },
                new SelectListItem { Text = "Days", Value = "F2" },
                new SelectListItem { Text = "Weekdays", Value = "F3" },
                new SelectListItem { Text = "Months", Value = "F4" },
                new SelectListItem { Text = "Years", Value = "F5" },
                new SelectListItem { Text = "Auto Fill", Value = "F6" }
            };

            ViewBag.SeriesByList = new List<SelectListItem>
            {
                new SelectListItem { Text = "Rows", Value = "0" },
                new SelectListItem { Text = "Columns", Value = "1" }
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AutoFill(AutoFillOptionsModel model)
        {
            string selected = model.SelectedAutoFillOption;

            if (selected.StartsWith("A"))
            {
                int val = int.Parse(selected.Substring(1));
                ExcelAutoFill type = (ExcelAutoFill)val;
                ViewBag.SelectedType = $"AutoFillType selected: {type}";
            }
            else if (selected.StartsWith("F"))
            {
                int val = int.Parse(selected.Substring(1));
                ExcelFill series = (ExcelFill)val;
                ViewBag.SelectedType = $"FillSeries selected: {series}";
            }

            ExcelSeries seriesBy = model.SeriesBy;
            string stepValue = model.StepValue;
            string stopValue = model.StopValue;
            string autofillType = model.SelectedAutoFillOption;
            bool isTrend = model.Trend;

            if (selected.StartsWith("A"))
            {
                int enumVal = int.Parse(selected.Substring(1));
                ExcelAutoFill selectedAutoFill = (ExcelAutoFill)enumVal;
                ExcelAutoFillType autoFillType = (ExcelAutoFillType)enumVal;
                MemoryStream stream = AutoFill(autoFillType);

                if (stream != null)
                {
                    return File(stream,
                                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                "AutoFill.xlsx");
                }
            }
            else if (selected.StartsWith("F"))
            {
                int enumVal = int.Parse(selected.Substring(1));
                ExcelFill selectedSeries = (ExcelFill)enumVal;
                ExcelSeriesBy seriesBy1 = (ExcelSeriesBy)seriesBy;
                ExcelFillSeries fillSeries = (ExcelFillSeries)selectedSeries;
                MemoryStream stream = AutoFill(fillSeries, seriesBy1, stepValue, stopValue, isTrend);
                if (stream != null)
                {
                    return File(stream,
                                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                "FillSeries.xlsx");
                }
            }
            return View("Generated");
        }
        /// <summary>
        /// Table Slicer
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream AutoFill(ExcelFillSeries fillSeries, ExcelSeriesBy seriesBy, object stepValue, object stopValue, bool enableTrend)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet sheet = workbook.Worksheets[0];
                if (seriesBy == ExcelSeriesBy.Columns)
                {
                    sheet["A1"].Number = 2;
                    sheet["A2"].Number = 4;
                    sheet["A3"].Number = 6;
                }
                else
                {
                    sheet["A1"].Number = 2;
                    sheet["B1"].Number = 4;
                    sheet["C1"].Number = 6;
                }

                stepValue = stepValue != null ? ConvertObject(stepValue.ToString()) : stepValue;
                stopValue = stopValue != null ? ConvertObject(stopValue.ToString()) : stopValue;

                switch (fillSeries)
                {
                    case ExcelFillSeries.AutoFill:
                    case ExcelFillSeries.Linear:
                    case ExcelFillSeries.Growth:
                        break;
                    case ExcelFillSeries.Years:
                    case ExcelFillSeries.Days:
                    case ExcelFillSeries.Weekdays:
                    case ExcelFillSeries.Months:
                        {
                            if (seriesBy == ExcelSeriesBy.Columns)
                            {
                                DateTime dateTime = new DateTime(2025, 1, 1);
                                sheet["A1"].Value2 = dateTime;
                                sheet["A2"].Value2 = dateTime.AddDays(1);
                                sheet["A3"].Value2 = dateTime.AddDays(2);
                                sheet["A1:A3"].NumberFormat = "m/d/yyyy";
                            }
                            else
                            {
                                DateTime dateTime = new DateTime(2025, 1, 1);
                                sheet["A1"].Value2 = dateTime;
                                sheet["B1"].Value2 = dateTime.AddDays(1);
                                sheet["C1"].Value2 = dateTime.AddDays(2);
                                sheet["A1:C1"].NumberFormat = "m/d/yyyy";
                            }

                            break;
                        }

                }
                if (seriesBy == ExcelSeriesBy.Columns)
                {
                    if (enableTrend)
                        sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, enableTrend);
                    else if (stepValue == null && stopValue == null)
                    {
                        if (fillSeries == ExcelFillSeries.AutoFill)
                        {
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, enableTrend);
                        }
                    }
                    else if ((stepValue == null && stopValue != null) || (stepValue != null && stopValue == null))
                    {
                        bool isStepValue = stepValue != null;
                        if (isStepValue)
                        {
                            if (stepValue is DateTime)
                                sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, isStepValue);
                            else if (stepValue is double)
                                sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stepValue, isStepValue);
                        }
                        else
                        {
                            if (stopValue is DateTime)
                                sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stopValue, isStepValue);
                            else if (stopValue is double)
                                sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stopValue, isStepValue);
                        }
                    }
                    else
                    {
                        if (stepValue is DateTime && stopValue is DateTime)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (DateTime)stopValue);
                        else if (stepValue is DateTime && stopValue is double)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (double)stopValue);
                        else if (stepValue is double && stopValue is double)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stepValue, (double)stopValue);
                        else if (stepValue is double && stopValue is DateTime)
                            sheet[1, 1, 1000, 1].FillSeries(seriesBy, fillSeries, (double)stepValue, (DateTime)stopValue);
                    }

                }
                else
                {
                    if (enableTrend)
                        sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, enableTrend);
                    else if (stepValue == null && stopValue == null)
                    {
                        if (fillSeries == ExcelFillSeries.AutoFill)
                        {
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, enableTrend);
                        }
                    }
                    else if ((stepValue == null && stopValue != null) || (stepValue != null && stopValue == null))
                    {
                        bool isStepValue = stepValue != null;
                        if (isStepValue)
                        {
                            if (stepValue is DateTime)
                                sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, isStepValue);
                            else if (stepValue is double)
                                sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stepValue, isStepValue);
                        }
                        else
                        {
                            if (stopValue is DateTime)
                                sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stopValue, isStepValue);
                            else if (stopValue is double)
                                sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stopValue, isStepValue);
                        }
                    }
                    else
                    {
                        if (stepValue is DateTime && stopValue is DateTime)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (DateTime)stopValue);
                        else if (stepValue is DateTime && stopValue is double)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (DateTime)stepValue, (double)stopValue);
                        else if (stepValue is double && stopValue is double)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stepValue, (double)stopValue);
                        else if (stepValue is double && stopValue is DateTime)
                            sheet[1, 1, 1, 1000].FillSeries(seriesBy, fillSeries, (double)stepValue, (DateTime)stopValue);
                    }
                }

                sheet.UsedRange.ColumnWidth = 10;
                //Save the document as a stream and return the stream
                MemoryStream stream = new MemoryStream();
                //Save the created Excel document to MemoryStream
                workbook.SaveAs(stream);
                stream.Position = 0;
                return stream;
            }
        }
        #region HelperMethod
        public object ConvertObject(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            if (double.TryParse(value, out double d)) return d;
            if (DateTime.TryParse(value, out DateTime dt)) return dt;
            return value;
        }
        #endregion

        /// <summary>
        /// Table Slicer
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream AutoFill(ExcelAutoFillType autoFillOption)
        {

            //Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;
                IWorkbook workbook = application.Workbooks.Create(1);

                IWorksheet sheet = workbook.Worksheets[0];
                sheet["A1"].Number = 2;
                sheet["A2"].Number = 4;
                sheet["A3"].Number = 6;

                switch (autoFillOption)
                {
                    case ExcelAutoFillType.FillDefault:
                    case ExcelAutoFillType.FillCopy:
                    case ExcelAutoFillType.FillValues:
                    case ExcelAutoFillType.FillSeries:
                    case ExcelAutoFillType.GrowthTrend:
                    case ExcelAutoFillType.LinearTrend:
                        {
                            sheet["A1:A3"].AutoFill(sheet["A4:A1000"], autoFillOption);
                            break;
                        }
                    case ExcelAutoFillType.FillFormats:
                        {
                            sheet["A1"].CellStyle.Color = Color.Blue;
                            sheet["A2"].CellStyle.Color = Color.Red;
                            sheet["A3"].CellStyle.Color = Color.Chocolate;
                            sheet["A1:A3"].NumberFormat = "$0.00";
                            sheet["A1:A3"].AutoFill(sheet["A4:A1000"], autoFillOption);
                            break;
                        }
                    case ExcelAutoFillType.FillMonths:
                    case ExcelAutoFillType.FillDays:
                    case ExcelAutoFillType.FillWeekdays:
                    case ExcelAutoFillType.FillYears:
                        {
                            DateTime dateTime = new DateTime(2025, 1, 1);
                            sheet["A1"].Value2 = dateTime;
                            sheet["A2"].Value2 = dateTime.AddDays(1);
                            sheet["A3"].Value2 = dateTime.AddDays(2);
                            sheet["A1:A3"].NumberFormat = "m/d/yyyy";
                            sheet["A1:A3"].AutoFill(sheet["A4:A1000"], autoFillOption);
                            break;
                        }

                }

                sheet.UsedRange.ColumnWidth = 10;
                //Save the document as a stream and return the stream
                MemoryStream stream = new MemoryStream();
                //Save the created Excel document to MemoryStream
                workbook.SaveAs(stream);
                stream.Position = 0;
                return stream;
            }

        }
        public ActionResult Generated()
        {
            return View();
        }
    }
}