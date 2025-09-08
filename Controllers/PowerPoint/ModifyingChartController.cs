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
using Syncfusion.OfficeChart;
using Syncfusion.Presentation;
using System.IO;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class PowerPointController : Controller
    {
       
        public ActionResult ModifyingChart()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ModifyingChart(string button)
        {
            if (button == null)
                return View();
            Stream readFile = new FileStream(ResolveApplicationDataPath(@"..\PowerPoint\ChartInput.pptx"), FileMode.Open, FileAccess.Read, FileShare.Read);
            IPresentation presentation = Presentation.Open(readFile);
            //New Instance of PowerPoint is Created.

            //Method call to create slides
            CreateChart31(presentation);
            CreateChart32(presentation);
            CreateChart33(presentation);
            CreateChart34(presentation);

            return new PresentationResult(presentation, "ModifiedChart.pptx", HttpContext.ApplicationInstance.Response);

        }

        # region Slide1
        private void CreateChart31(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            IPresentationChart chart = slide1.Charts[0] as IPresentationChart;
            chart.Legend.Position = OfficeLegendPosition.Top;
            chart.ChartArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.ChartArea.Fill.ForeColor = Color.FromArgb(251, 229, 214);
            chart.ChartArea.Border.AutoFormat = false;
            chart.ChartArea.Border.IsAutoLineColor = false;
            chart.ChartArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.ChartArea.Border.LineColor = Color.FromArgb(32, 56, 100);
            chart.ChartArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.Series[0].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            chart.Series[1].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            chart.Series[2].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
        }
        #endregion

        #region Slide2
        private void CreateChart32(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[1];
            IPresentationChart chart = slide2.Shapes[0] as IPresentationChart;
            chart.HasDataTable = true;
            chart.DataTable.HasBorders = true;
            chart.DataTable.HasHorzBorder = true;
            chart.DataTable.HasVertBorder = true;
            chart.DataTable.ShowSeriesKeys = true;
            chart.DataTable.TextArea.FrameFormat.Border.AutoFormat = false;
            chart.DataTable.TextArea.FrameFormat.Border.IsAutoLineColor = false;
            chart.DataTable.TextArea.FrameFormat.Border.LineColor = Color.FromArgb(143, 170, 220);
            chart.DataTable.TextArea.FrameFormat.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.DataTable.TextArea.FrameFormat.Border.LineWeight = OfficeChartLineWeight.Medium;


            chart.PlotArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.PlotArea.Fill.ForeColor = Color.FromArgb(112, 48, 160);
            chart.PlotArea.Fill.Transparency = 0.75;

            chart.PlotArea.Border.AutoFormat = false;
            chart.PlotArea.Border.IsAutoLineColor = false;
            chart.PlotArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.PlotArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.PlotArea.Border.LineColor = Color.FromArgb(132, 151, 176);
        }

        #endregion

        # region Slide3
        private void CreateChart33(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[2];
            IPresentationChart chart = slide2.Charts[0] as IPresentationChart;
            chart.PlotArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.PlotArea.Fill.ForeColor = Color.FromArgb(251, 229, 214);
            chart.Series[0].DataPoints[0].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[0].DataFormat.Fill.ForeColor = Color.FromArgb(244, 177, 131);
            chart.Series[0].DataPoints[1].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[1].DataFormat.Fill.ForeColor = Color.FromArgb(255, 230, 153);
            chart.Series[0].DataPoints[2].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[2].DataFormat.Fill.ForeColor = Color.FromArgb(132, 151, 176);
            chart.Series[0].DataPoints[3].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[3].DataFormat.Fill.ForeColor = Color.FromArgb(157, 195, 230);
        }
        #endregion

        #region Slide4
        private void CreateChart34(IPresentation presentation)
        {
            ISlide slide4 = presentation.Slides[3];
            IPresentationChart chart = slide4.Charts[0] as IPresentationChart;
            chart.Series[0].SerieFormat.CommonSerieOptions.GapWidth = 81;
            chart.PlotArea.Border.AutoFormat = false;
            chart.PlotArea.Border.IsAutoLineColor = false;
            chart.PlotArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.PlotArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.PlotArea.Border.LineColor = Color.FromArgb(143, 173, 220);
        }
        #endregion
    }
}