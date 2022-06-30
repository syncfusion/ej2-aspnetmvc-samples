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
using System.Drawing;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /StylesAndFormatting/

        public ActionResult StylesAndFormatting(string button1, string button)
        {
            if (button == null && button1 == null )
                return View();
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"CalendarTemplate.xlsx"));
                return excelEngine.SaveAsActionResult(workbook, "Template.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
            
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                application.DefaultVersion = ExcelVersion.Excel2016;

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //The new workbook will have 12 worksheets
                IWorkbook workbook = application.Workbooks.Create(12);
                IWorkbook tempWorkbook = application.Workbooks.Open(ResolveApplicationDataPath("CalendarTemplate.xlsx"));
                workbook.Worksheets.AddCopyAfter(tempWorkbook.Worksheets[0], workbook.Worksheets[11]);

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet;

                # region Calendar

                # region Draw Calendar
                String[] monthArray = new String[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                String[] dateArray = new String[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                Color[] colorArray = new Color[] { Color.FromArgb(149, 55, 53), Color.FromArgb(146, 208, 80), Color.FromArgb(0, 32, 96), Color.FromArgb(0, 176, 80), Color.FromArgb(255, 255, 0), Color.FromArgb(128, 128, 128), Color.FromArgb(255, 0, 0), Color.FromArgb(96, 73, 123), Color.FromArgb(169, 161, 117), Color.FromArgb(0, 176, 240), Color.FromArgb(192, 0, 0), Color.FromArgb(63, 49, 81), Color.FromArgb(192, 0, 0) };

                int cMonth = DateTime.Today.Month - 1;

                for (int monIndex = 1; monIndex < 13; monIndex++)
                {
                    sheet = workbook.Worksheets[monIndex - 1];
                    sheet.Name = monthArray[monIndex - 1];

                    sheet.Range["B3:H3"].Merge();
                    sheet.Range["B4:H4"].Merge();
                    sheet.IsGridLinesVisible = false;

                    //Write the month as the heading
                    sheet.Range["B3"].Text = monthArray[monIndex - 1];

                    //Apply styles for the month title
                    sheet.Range["B3:H3"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    sheet.Range["B3:H3"].VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet.Range["B3:H3"].BorderAround(ExcelLineStyle.Thin, Color.Brown);
                    sheet.Range["B3:H3"].RowHeight = 30;

                    IStyle style = sheet.Range["B3"].CellStyle;
                    style.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    style.Interior.FillPattern = ExcelPattern.Gradient;
                    style.Interior.Gradient.TwoColorGradient(ExcelGradientStyle.Diagonl_Up, ExcelGradientVariants.ShadingVariants_3);
                    style.Interior.Gradient.ForeColorIndex = ExcelKnownColors.White;
                    style.Interior.Gradient.BackColor = colorArray[monIndex - 1];
                    IFont font = style.Font;
                    font.FontName = "Segoe UI";
                    font.Size = 22;
                    font.Italic = true;

                    //Write the weekdays
                    for (int i = 2, j = 0; i < 9; i++, j++)
                    {
                        sheet.SetValue(5, i, dateArray[j]);
                        sheet.Range[5, i].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    }

                    //Get the number of days in the month
                    int days = DateTime.DaysInMonth(DateTime.Today.Year, monIndex);

                    //Write the calendar
                    DateTime firstDay = new DateTime(DateTime.Today.Year, monIndex, 1);
                    IRange range = sheet.FindFirst(firstDay.Date.DayOfWeek.ToString(), ExcelFindType.Text);

                    int row = range.End.Row + 1;
                    int column = range.End.Column;
                    int date = 1;

                    while (date < days + 1)
                    {
                        for (; column < 9; column++)
                        {
                            sheet.Range[row, column].Number = date;
                            date++;
                            if (date == days + 1)
                                break;
                        }
                        column = 2;
                        row++;
                    }

                    //Format Sunday
                    sheet.Range["B5:B11"].BuiltInStyle = BuiltInStyles.WarningText;
                    sheet.Range["B5"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;

                    //Format day title
                    sheet.Range["B5:H5"].BuiltInStyle = BuiltInStyles.Heading4;
                    sheet.Range["B5:H5"].CellStyle.Font.Size = 10;

                    //Border around the entire calendar
                    sheet.UsedRange.BorderAround(ExcelLineStyle.Double, Color.Black);
                    sheet.UsedRange.BorderInside(ExcelLineStyle.Hair, Color.Black);

                    sheet.Range["B3"].RowHeight = 35;
                    sheet.Range["B5:H11"].RowHeight = 60;
                    sheet.UsedRange.ColumnWidth = 15;

                    //Set Legend
                    sheet["K7"].BuiltInStyle = BuiltInStyles.Accent2_20;
                    sheet["K8"].BuiltInStyle = BuiltInStyles.Accent4_20;

                    sheet.Range["L7"].Text = "Holidays";
                    sheet.Range["L8"].Text = "Today";
                    sheet.Range["L7:L8"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                }
                # endregion

                # region Styles for today
                foreach (IWorksheet cSheet in workbook.Worksheets)
                {
                    if (cSheet.Name == monthArray[cMonth])
                    {
                        //Apply styles for today
                        IRange tRange = cSheet.FindFirst(DateTime.Today.Day, ExcelFindType.Number);
                        tRange.BuiltInStyle = BuiltInStyles.Accent4_20;
                        tRange.CellStyle.Font.RGBColor = Color.Purple;

                        tRange.AddComment().Text = "Today";
                        tRange.Comment.Width = 100;
                        tRange.Comment.Height = 40;
                        cSheet.Activate();
                    }
                    else if (cSheet.Name == "Holidays")
                    {
                        cSheet.Range["B3"].BuiltInStyle = BuiltInStyles.Accent2_20;
                        cSheet.Range["B3"].CellStyle.Font.FontName = "Calibri";
                        cSheet.Range["B3"].CellStyle.Font.Size = 11;
                        cSheet.Range["B3"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    }
                }

                # endregion

                # region Update Holidays
                workbook.Worksheets[12].EnableSheetCalculations();
                //Highlight holidays
                for (int i = 8; i <= 18; i++)
                {
                    IRange range = workbook.Worksheets[12].Range["D" + i.ToString()];
                    range.Value = range.CalculatedValue;
                    int sheetIndex = range.DateTime.Month;
                    IRange holiday = workbook.Worksheets[sheetIndex - 1].FindFirst(range.DateTime.Day, ExcelFindType.Number);
                    holiday.AddComment().Text = workbook.Worksheets[12].Range["B" + i.ToString()].Text;
                    holiday.Comment.Width = 100;
                    holiday.Comment.Height = 40;
                    holiday.BuiltInStyle = BuiltInStyles.Accent2_20;
                    holiday.CellStyle.Font.RGBColor = Color.Red;
                }

                # endregion

                # endregion

                try
                {
                    return excelEngine.SaveAsActionResult(workbook, "StylesAndFormatting.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }

                catch (Exception)
                {
                }
                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
               
            }
            return View();
        }
     }

  }

