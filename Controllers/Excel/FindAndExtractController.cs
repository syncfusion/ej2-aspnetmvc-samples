#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
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
using System.Globalization;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /FindAndExtract/
        protected void FillData()
        {
            List<string> list = new List<string>();
            list.Add("Number with format 0.00");
            list.Add("Number with format $#,##0.00");
            list.Add("-----------------------------------");
            list.Add("DateTime with format m/d/yy h:mm");
            list.Add("Time with format h:mm:ss AM/PM");
            list.Add("Date with format d-mmm-yy");
            list.Add("Date with format Saturday, December 01, 2007");
            list.Add("-----------------------------------");
            list.Add("Text");
            list.Add("Text With Styles and Patterns");
            list.Add("Number with Text Format");
            ViewData.Add("selectoption", list);
        }

        public ActionResult FindAndExtract(string selectoption)
        {
            if (selectoption == null)
            {
                FillData();
                return View();
            }
            ViewData["selectoptionValue"] = selectoption;
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
            //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath("FindAndExtract.xls"));

            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet sheet = workbook.Worksheets[0];

            IRange result;

            try
            {

                switch (selectoption)
                {
                    #region Find and Extract Numbers
                    case "Number with format 0.00":
                        {
                            result = sheet.FindFirst(1000000.00075, ExcelFindType.Number);

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }

                    case "Number with format $#,##0.00":
                        {
                            result = sheet.FindFirst(3.2, ExcelFindType.Number);

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }

                    #endregion

                    #region Find and Extract DateTime
                    case "DateTime with format m/d/yy h:mm":
                        {
                            result = sheet.FindFirst(DateTime.Parse("12/1/2007  1:23:00 AM", CultureInfo.InvariantCulture));

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }

                    case "Time with format h:mm:ss AM/PM":
                        {
                            result = sheet.FindFirst(DateTime.Parse("1/1/2007  2:23:00 AM", CultureInfo.InvariantCulture));

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.DateTime.ToString());
                            break;
                        }
                    case "Date with format d-mmm-yy":
                        {
                            result = sheet.FindFirst(DateTime.Parse("12/4/2007  1:23:00 AM", CultureInfo.InvariantCulture));

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }
                    case "Date with format Saturday, December 01, 2007":
                        {
                            result = sheet.FindFirst(DateTime.Parse("8/1/2007  3:23:00 AM", CultureInfo.InvariantCulture));

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }
                    #endregion

                    #region Find and Extract Text

                    case "Text":
                        {
                            result = sheet.FindFirst("Simple text", ExcelFindType.Text);

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }
                    case "Text With Styles and Patterns":
                        {
                            result = sheet.FindFirst("Text with Styles and patterns", ExcelFindType.Text);

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }
                    case "Number with Text Format":
                        {
                            result = sheet.FindFirst("$8.200", ExcelFindType.Text);

                            //Gets the cell display text
                            ViewData.Add("displayText", result.DisplayText.ToString());

                            //Gets the cell value
                            ViewData.Add("valueText", result.Value2.ToString());
                            break;
                        }
                    #endregion
                    default:
                        break;
                }

                workbook.Close();
                excelEngine.Dispose();
            }
            catch (Exception)
            {
            }

            FillData();
            return View();
        }
        }

    }

