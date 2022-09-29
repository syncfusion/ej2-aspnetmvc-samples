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

using Syncfusion.HtmlConverter;
using Syncfusion.Pdf.HtmlToPdf;
using System.Drawing;
using System.Drawing.Imaging;
using Syncfusion.Pdf;
using System.Threading;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf.Graphics;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        // GET: /HtmltoPDF/
        PdfDocument Pdfdoc = new PdfDocument();
        string sourceUrl = string.Empty;

        string chkEnableJavaScript = string.Empty;
        string chkEnableHyperlink = string.Empty;
        string chkEnableForm = string.Empty;
        string chkEnableToc = string.Empty;
        string chkEnableBookmark = string.Empty;

        string ViewportWidth = string.Empty;
        string ViewportHeight = string.Empty;

        string pagemargin = string.Empty;
        string rotate = string.Empty;
        string convertType = string.Empty;
        string rdbtnOrientation = string.Empty;

        string activatePageBreak = string.Empty;
        string showHeader = string.Empty;
        string showFooter = string.Empty;
        string jsAdditionalDelay = string.Empty;


        public ActionResult HtmltoPDF()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult HtmltoPDF(string TextBox1, string RadioButtonListEngine, string chkJavaScript, string chkHyperlink, string chkForm, string chkToc, string chkBookMark, string chktextBreak, string chkImageBreak, string txtViewportWidth, string txtViewportHeight, string DropDownList1, string DropDownList2, string RadioButtonList2, string CheckBox2, string CheckBox3, string txtAdditionalDelay)
        {
            sourceUrl = TextBox1;
            pagemargin = DropDownList1;
            rotate = DropDownList2;
            rdbtnOrientation = RadioButtonList2;
            chkEnableJavaScript = chkJavaScript;
            chkEnableHyperlink = chkHyperlink;
            showHeader = CheckBox2;
            showFooter = CheckBox3;
            sourceUrl = TextBox1;

            chkEnableJavaScript = chkJavaScript;
            chkEnableHyperlink = chkHyperlink;
            chkEnableForm = chkForm;
            chkEnableToc = chkToc;
            chkEnableBookmark = chkBookMark;

            ViewportWidth = txtViewportWidth;
            ViewportHeight = txtViewportHeight;

            pagemargin = DropDownList1;
            rotate = DropDownList2;
            rdbtnOrientation = RadioButtonList2;
            showHeader = CheckBox2;
            showFooter = CheckBox3;

            jsAdditionalDelay = txtAdditionalDelay;

            if (RadioButtonListEngine == "WebKit")
            {
                Pdfdoc = ConvertWithWebKitRendering();
            }
            else
            {
                Pdfdoc = ConvertWithBlinkRendering();
            }

            return Pdfdoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);

        }
        private PdfDocument ConvertWithWebKitRendering()
        {
            //Initialize HTML to PDF converter with WebKit settings
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            WebKitConverterSettings converterSettings = new WebKitConverterSettings();

            //Set page margins
            converterSettings.Margin = new PdfMargins() { All = float.Parse(pagemargin) };

            //Set page orientation
            if (rdbtnOrientation == "Portrait")
                converterSettings.Orientation = PdfPageOrientation.Portrait;
            else
                converterSettings.Orientation = PdfPageOrientation.Landscape;

            //Set rotation
            converterSettings.PageRotateAngle = (PdfPageRotateAngle)Enum.Parse(typeof(PdfPageRotateAngle), rotate);

            //Enable Javascript
            converterSettings.EnableJavaScript = chkEnableJavaScript == "on" ? true : false;
            //Enable Hyperlink
            converterSettings.EnableHyperLink = chkEnableHyperlink == "on" ? true : false;
            //Enable Form
            converterSettings.EnableForm = chkEnableForm == "on" ? true : false;
            //Enabel Toc
            converterSettings.EnableToc = chkEnableToc == "on" ? true : false;
            //Enable Bookmark
            converterSettings.EnableBookmarks = chkEnableBookmark == "on" ? true : false;

            //Set WebKit viewport size
            int viewportWidth = 1024;
            if (int.TryParse(ViewportWidth, out viewportWidth)) { }

            int viewportHeight = 0;
            if (int.TryParse(ViewportHeight, out viewportHeight)) { }

            converterSettings.WebKitViewPort = new Size(viewportWidth, viewportHeight);

            //Set WebKitPath
            string WebKitBinaryPath = ResolveApplicationImagePath("QtBinaries");

            converterSettings.WebKitPath = WebKitBinaryPath;

            //Set additional delay
            if (int.TryParse(jsAdditionalDelay, out int additionalDelay))
                converterSettings.AdditionalDelay = additionalDelay * 1000;

            //Adding Header
            if (showHeader == "on")
                converterSettings.PdfHeader = this.AddHeader(converterSettings.PdfPageSize.Width, "Syncfusion Essential PDF", " ");

            //Adding Footer
            if (showFooter == "on")
                converterSettings.PdfFooter = this.AddFooter(converterSettings.PdfPageSize.Height, "@Copyright 2016");

            //Assign WebKit settings to HTML converter
            htmlConverter.ConverterSettings = converterSettings;

            //Convert url to pdf
            Pdfdoc = htmlConverter.Convert(sourceUrl);

            return Pdfdoc;
        }

        private PdfDocument ConvertWithBlinkRendering()
        {
            //Initialize HTML to PDF converter with Blink settings
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);
            BlinkConverterSettings converterSettings = new BlinkConverterSettings();

            //Set page margins
            converterSettings.Margin = new PdfMargins() { All = float.Parse(pagemargin) };

            //Set page orientation
            if (rdbtnOrientation == "Portrait")
                converterSettings.Orientation = PdfPageOrientation.Portrait;
            else
                converterSettings.Orientation = PdfPageOrientation.Landscape;

            //Set rotation
            converterSettings.PageRotateAngle = (PdfPageRotateAngle)Enum.Parse(typeof(PdfPageRotateAngle), rotate);

            //Enable Javascript
            converterSettings.EnableJavaScript = chkEnableJavaScript == "on" ? true : false;
            //Enable Hyperlink
            converterSettings.EnableHyperLink = chkEnableHyperlink == "on" ? true : false;
            //Enable Form
            converterSettings.EnableForm = chkEnableForm == "on" ? true : false;
            //Enabel Toc
            converterSettings.EnableToc = chkEnableToc == "on" ? true : false;
            //Enable Bookmark
            converterSettings.EnableBookmarks = chkEnableBookmark == "on" ? true : false;

            //Set Blink viewport size
            int viewportWidth = 1024;
            if (int.TryParse(ViewportWidth, out viewportWidth)) { }

            int viewportHeight = 0;
            if (int.TryParse(ViewportHeight, out viewportHeight)) { }

            converterSettings.ViewPortSize = new Size(viewportWidth, viewportHeight);

            //Set BlinkPath
            string BlinkBinaryPath = ResolveApplicationImagePath("BlinkBinaries");
          
            converterSettings.BlinkPath = BlinkBinaryPath;

            //Set additional delay
            if (int.TryParse(jsAdditionalDelay, out int additionalDelay))
                converterSettings.AdditionalDelay = additionalDelay * 1000;

            //Adding Header
            if (showHeader == "on")
                converterSettings.PdfHeader = this.AddHeader(converterSettings.PdfPageSize.Width, "Syncfusion Essential PDF", " ");

            //Adding Footer
            if (showFooter == "on")
                converterSettings.PdfFooter = this.AddFooter(converterSettings.PdfPageSize.Height, "@Copyright 2016");

            //Assign Blink settings to HTML converter
            htmlConverter.ConverterSettings = converterSettings;

            //Convert url to pdf
            Pdfdoc = htmlConverter.Convert(sourceUrl);

            return Pdfdoc;
        }

        #region Helpher Methods
        /// <summary>
        /// Adds header to the document
        /// </summary>
        /// <param name="width"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        private PdfPageTemplateElement AddHeader(float width, string title, string description)
        {
            RectangleF rect = new RectangleF(0, 0, width, 50);
            //Create a new instance of PdfPageTemplateElement class.     
            PdfPageTemplateElement header = new PdfPageTemplateElement(rect);
            PdfGraphics g = header.Graphics;

            //Draw title.
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);
            PdfSolidBrush brush = new PdfSolidBrush(Color.FromArgb(44, 71, 120));
            float x = (width / 2) - (font.MeasureString(title).Width) / 2;
            g.DrawString(title, font, brush, new RectangleF(x, (rect.Height / 4) + 3, font.MeasureString(title).Width, font.Height));

            //Draw description
            brush = new PdfSolidBrush(Color.Gray);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Bottom);
            g.DrawString(description, font, brush, new RectangleF(0, 0, header.Width, header.Height - 8), format);

            //Draw some lines in the header
            PdfPen pen = new PdfPen(Color.DarkBlue, 0.7f);
            g.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            g.DrawLine(pen, 0, 03, header.Width + 3, 03);
            pen = new PdfPen(Color.DarkBlue, 2f);
            g.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3);
            g.DrawLine(pen, 0, header.Height, header.Width, header.Height);

            return header;
        }

        /// <summary>
        /// Adds footer to the document
        /// </summary>
        /// <param name="width"></param>
        /// <param name="footerText"></param>
        private PdfPageTemplateElement AddFooter(float width, string footerText)
        {
            RectangleF rect = new RectangleF(0, 0, width, 50);
            //Create a new instance of PdfPageTemplateElement class.
            PdfPageTemplateElement footer = new PdfPageTemplateElement(rect);
            PdfGraphics g = footer.Graphics;

            // Draw footer text.
            PdfSolidBrush brush = new PdfSolidBrush(Color.Gray);
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);
            float x = (width / 2) - (font.MeasureString(footerText).Width) / 2;
            g.DrawString(footerText, font, brush, new RectangleF(x, g.ClientSize.Height - 10, font.MeasureString(footerText).Width, font.Height));

            //Create page number field
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, brush);

            //Create page count field
            PdfPageCountField count = new PdfPageCountField(font, brush);

            PdfCompositeField compositeField = new PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count);
            compositeField.Bounds = footer.Bounds;
            compositeField.Draw(g, new PointF(470, 40));

            return footer;

        }

        # endregion
    }
}
