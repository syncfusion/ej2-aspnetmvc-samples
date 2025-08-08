#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using System.Collections;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {

        public ActionResult AutoFilter(string id, string FilterType, string button, string colorsList, string rdb1, string rdb3, string iconText, string iconSetTypeList, string field,string checkbox )
        {
            if (FilterType == null)
            {
                ViewData["datasource"] = AutoFilterIconList.GetSymbols();
                ViewData["datasource2"] = AutoFilterIconList.GetRating();
                ViewData["datasource3"] = AutoFilterIconList.GetArrows();
                return View();
            }
            else if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook;
                if (FilterType == "Advanced Filter")
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"AdvancedFilterData.xlsx"), ExcelOpenType.Automatic);
                }
                else if (FilterType == "Icon Filter")
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"IconFilterData.xlsx"), ExcelOpenType.Automatic);
                }
                else if (FilterType == "Color Filter")
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"FilterData_Color.xlsx"), ExcelOpenType.Automatic);
                }
                else
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"FilterData.xlsx"), ExcelOpenType.Automatic);
                }
                return excelEngine.SaveAsActionResult(workbook, "InputTempalte.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel97);
               
            }
            else
            {

                string fileName = null ;

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                IWorkbook workbook;
                if (FilterType == "Advanced Filter")
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"AdvancedFilterData.xlsx"), ExcelOpenType.Automatic);
                }
                else if (FilterType == "Icon Filter")
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"IconFilterData.xlsx"), ExcelOpenType.Automatic);
                }
                else if (FilterType == "Color Filter")
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"FilterData_Color.xlsx"), ExcelOpenType.Automatic);
                }
                else
                {
                    workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"FilterData.xlsx"), ExcelOpenType.Automatic);
                }
                IWorksheet sheet = workbook.Worksheets[0];
                if (FilterType != "Advanced Filter")
                    sheet.AutoFilters.FilterRange = sheet.Range[1, 1, 49, 3];
                
                switch(FilterType)
                {
                    case "Custom Filter":
                        fileName = "CustomFilter.xlsx";
                        IAutoFilter filter1 = sheet.AutoFilters[0];
                        filter1.IsAnd = false;
                        filter1.FirstCondition.ConditionOperator = ExcelFilterCondition.Equal;
                        filter1.FirstCondition.DataType = ExcelFilterDataType.String;
                        filter1.FirstCondition.String = "Owner";

                        filter1.SecondCondition.ConditionOperator = ExcelFilterCondition.Equal;
                        filter1.SecondCondition.DataType = ExcelFilterDataType.String;
                        filter1.SecondCondition.String = "Sales Representative";            
                        break;
                         
                    case "Text Filter":
                        fileName = "TextFilter.xlsx";
                        IAutoFilter filter2 = sheet.AutoFilters[0];
                        filter2.AddTextFilter(new string[] { "Owner", "Sales Representative", "Sales Associate" });
                        break;

                    case "DateTime Filter":
                        fileName = "DateTimeFilter.xlsx";
                         IAutoFilter filter3 = sheet.AutoFilters[1];
                         filter3.AddDateFilter(new DateTime(2004, 9, 1, 1, 0, 0, 0), DateTimeGroupingType.month);
                         filter3.AddDateFilter(new DateTime(2011, 1, 1, 1, 0, 0, 0), DateTimeGroupingType.year);
                        break;

                    case "Dynamic Filter":
                        fileName = "DynamicFilter.xlsx";
                         IAutoFilter filter4 = sheet.AutoFilters[1];
                         filter4.AddDynamicFilter(DynamicFilterType.Quarter1);
                        break;

                    case "Color Filter":
                        fileName = "ColorFilter.xlsx";
                        #region ColorFilter

                        System.Drawing.Color color = System.Drawing.Color.Empty;
                        switch (colorsList.ToLower())
                        {
                            case "red":
                                color = System.Drawing.Color.Red;
                                break;
                            case "blue":
                                color = System.Drawing.Color.Blue;
                                break;
                            case "green":
                                color = System.Drawing.Color.Green;
                                break;
                            case "yellow":
                                color = System.Drawing.Color.Yellow;
                                break;
                            case "empty":
                                color = System.Drawing.Color.Empty;
                                break;
                        }
                        if (rdb3 == "FontColor")
                        {
                            IAutoFilter filter = sheet.AutoFilters[2];
                            filter.AddColorFilter(color, ExcelColorFilterType.FontColor);
                        }
                        else
                        {
                            IAutoFilter filter = sheet.AutoFilters[0];
                            filter.AddColorFilter(color, ExcelColorFilterType.CellColor);
                        }
                        #endregion
                        break;

                    case "Icon Filter":
                        fileName = "IconFilter.xlsx";
                        #region IconFilter
                        sheet.AutoFilters.FilterRange = sheet["A4:D44"];
                        int filterIndex = 0;
                        ExcelIconSetType iconset = ExcelIconSetType.FiveArrows;
                        int iconId = 0;
                        switch(iconSetTypeList)
                        {
                            case "ThreeSymbols":
                                iconset = ExcelIconSetType.ThreeSymbols;
                                filterIndex = 3;
                                break;
                            case "FourRating":
                                iconset = ExcelIconSetType.FourRating;
                                filterIndex = 1;
                                break;
                            case "FiveArrows":
                                iconset = ExcelIconSetType.FiveArrows;
                                filterIndex = 2;
                                break;
                        }
                        switch (iconText)
                        {
                            case "0":
                                //Do nothing
                                break;
                            case "1":
                                iconId = 1;
                                break;
                            case "2":
                                iconId = 2;
                                break;
                            case "3":
                                if (iconSetTypeList.Equals("ThreeSymbols"))
                                    iconset = (ExcelIconSetType)(-1);
                                else
                                    iconId = 3;
                                break;
                            case "4":
                                if (iconSetTypeList.Equals("FourRating"))
                                    iconset = (ExcelIconSetType)(-1);
                                else
                                    iconId = 4;
                                break;
                            case "5":
                                iconset = (ExcelIconSetType)(-1);
                                break;
                        }
                        IAutoFilter filter5 = sheet.AutoFilters[filterIndex];
                        filter5.AddIconFilter(iconset, iconId);
                        #endregion
                        break;

                    case "Advanced Filter":
                        fileName = "AdvancedFilter.xlsx";
                        #region AdvancedFilter

                        IRange filterRange = sheet.Range["A8:G51"];
                        IRange criteriaRange = sheet.Range["A2:B5"];
                        if (rdb1 == "FilterIN")
                        {
                            sheet.AdvancedFilter(ExcelFilterAction.FilterInPlace, filterRange, criteriaRange, null, checkbox == "Unique");
                        }
                        else if (rdb1 == "FilterCopy")
                        {
                            IRange range = sheet.Range["I7:O7"];
                            range.Merge();
                            range.Text = "FilterCopy";
                            range.CellStyle.Font.RGBColor = System.Drawing.Color.FromArgb(0, 112, 192);
                            range.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                            range.CellStyle.Font.Bold = true;
                            IRange copyRange = sheet.Range["I8"];
                            sheet.AdvancedFilter(ExcelFilterAction.FilterCopy, filterRange, criteriaRange, copyRange, checkbox == "Unique");
                        }
                        break;
                        #endregion
                }
              
                workbook.Version = ExcelVersion.Excel2016;
                try
                {
                    return excelEngine.SaveAsActionResult(workbook, fileName, HttpContext.ApplicationInstance.Response, ExcelDownloadType.PromptDialog, ExcelHttpContentType.Excel2016);
                }
                catch(Exception)
                {

                }
            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            //adapter.Dispose();
            //connection.Close();
            return View();
			}
        }
    }
    public class AutoFilterIconList
    {
        public string iconId { get; set; }
        public string image { get; set; }

        public static List<AutoFilterIconList> GetSymbols()
        {
            List<AutoFilterIconList> iconList = new List<AutoFilterIconList>();
            iconList.Add(new AutoFilterIconList { iconId = "1", image = "CF_IS_RedCrossSymbol" });
            iconList.Add(new AutoFilterIconList { iconId = "2", image = "CF_IS_YellowExclamationSymbol" });
            iconList.Add(new AutoFilterIconList { iconId = "3", image = "CF_IS_GreenCheckSymbol" });
            iconList.Add(new AutoFilterIconList { iconId = "NoIcon", image = "NoIcon" });
            return iconList;
        }
        public static List<AutoFilterIconList> GetRating()
        {
            List<AutoFilterIconList> iconList = new List<AutoFilterIconList>();
            iconList.Add(new AutoFilterIconList { iconId = "1", image = "CF_IS_SignalWithOneFillBar" });
            iconList.Add(new AutoFilterIconList { iconId = "2", image = "CF_IS_SignalWithTwoFillBars" });
            iconList.Add(new AutoFilterIconList { iconId = "3", image = "CF_IS_SignalWithThreeFillBars" });
            iconList.Add(new AutoFilterIconList { iconId = "4", image = "CF_IS_SignalWithFourFillBars" });
            iconList.Add(new AutoFilterIconList { iconId = "NoIcon", image = "NoIcon" });
            return iconList;
        }
        public static List<AutoFilterIconList> GetArrows()
        {
            List<AutoFilterIconList> iconList = new List<AutoFilterIconList>();
            iconList.Add(new AutoFilterIconList { iconId = "1", image = "CF_IS_RedDownArrow" });
            iconList.Add(new AutoFilterIconList { iconId = "2", image = "CF_IS_YellowDownInclineArrow" });
            iconList.Add(new AutoFilterIconList { iconId = "3", image = "CF_IS_YellowSideArrow" });
            iconList.Add(new AutoFilterIconList { iconId = "4", image = "CF_IS_YellowUpInclineArrow" });
            iconList.Add(new AutoFilterIconList { iconId = "5", image = "CF_IS_GreenUpArrow" });
            iconList.Add(new AutoFilterIconList { iconId = "NoIcon", image = "NoIcon" });
            return iconList;
        }
    }
}
