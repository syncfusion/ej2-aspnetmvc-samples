#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class AutoFillOptionsModel
    {
        public ExcelSeries SeriesBy { get; set; }

        public string StepValue { get; set; }

        public string StopValue { get; set; }
        [Required(ErrorMessage = "Please select an Auto Fill option.")]
        public string SelectedAutoFillOption { get; set; }
        public bool Trend { get; set; }
    }

    public enum ExcelSeries
    {
        Rows = 0,
        Columns = 1
    }

    public enum ExcelAutoFill
    {
        FillDefault = 0,
        FillCopy = 1,
        FillSeries = 2,
        FillFormats = 3,
        FillValues = 4,
        FillDays = 5,
        FillWeekDays = 6,
        FillMonths = 7,
        FillYears = 8,
        LinearTrend = 9,
        GrowthTrend = 10
    }

    public enum ExcelFill
    {
        Linear = 0,
        Growth = 1,
        Days = 2,
        WeekDays = 3,
        Months = 4,
        Years = 5,
        AutoFill = 6
    }
}