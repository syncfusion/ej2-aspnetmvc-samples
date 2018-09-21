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
        //
        // GET: /HtmltoPDF/
        PdfDocument Pdfdoc = new PdfDocument();
        string sourceUrl = string.Empty;
        string chkInsideBrowser = string.Empty;
        string chkPdfA = string.Empty;
        string pagemargin = string.Empty;
        string rotate = string.Empty;
        string convertType = string.Empty;
        string rdbtnOrientation = string.Empty;
        string chkEnableJavaScript = string.Empty;
        string chkSplitText = string.Empty;
        string chkEnableHyperlink = string.Empty;
        string splitImage = string.Empty;
        string activatePageBreak = string.Empty;
        string showHeader = string.Empty;
        string showFooter = string.Empty;

        public ActionResult HtmltoPDF()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult HtmlToPDF(string TextBox1, string InsideBrowser, string chkPDFA, string DropDownList1, string RadioButtonList2, string DropDownList2, string chkTag, string CheckBox2, string CheckBox3, string chkJavaScript, string chkPageBreak, string chkHyperlink, string RadioButtonList1, string chktextBreak, string chkImageBreak)
        {
            sourceUrl = TextBox1;
            chkInsideBrowser = InsideBrowser;
            chkPdfA = chkPDFA;
            pagemargin = DropDownList1;
            rotate = DropDownList2;
            convertType = RadioButtonList1;
            rdbtnOrientation = RadioButtonList2;
            chkEnableJavaScript = chkJavaScript;
            chkSplitText = chktextBreak;
            chkEnableHyperlink = chkHyperlink;
            splitImage = chkImageBreak;
            activatePageBreak = chkPageBreak;
            showHeader = CheckBox2;
            showFooter = CheckBox3;
            //Single threaded call.
            Thread t = new Thread(CreateDocument);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();


            if (InsideBrowser == "Browser")
            {
                return Pdfdoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return Pdfdoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }
        private void CreateDocument(object s)
        {
            if (chkPdfA == "on")
            {
                //Create a PDF document in PDF_A1B standard
                Pdfdoc = new PdfDocument(PdfConformanceLevel.Pdf_A1B);
            }
            else
            {
                //Create a PDF document
                Pdfdoc = new PdfDocument();
            }

            //Set page margins
            Pdfdoc.PageSettings.SetMargins(float.Parse(pagemargin));

            //Set page orientation
            if (rdbtnOrientation == "Portrait")
                Pdfdoc.PageSettings.Orientation = PdfPageOrientation.Portrait;
            else
                Pdfdoc.PageSettings.Orientation = PdfPageOrientation.Landscape;

            //Set rotation
            Pdfdoc.PageSettings.Rotate = (PdfPageRotateAngle)Enum.Parse(typeof(PdfPageRotateAngle), rotate);

            PdfPage page = null;
            SizeF pageSize = SizeF.Empty;
            PdfUnitConvertor convertor = new PdfUnitConvertor();
            float width = -1;
            float height = -1;


            page = Pdfdoc.Pages.Add();

            pageSize = page.GetClientSize();

            width = convertor.ConvertToPixels(page.GetClientSize().Width, PdfGraphicsUnit.Point);


            //Adding Header
            if (showHeader == "on")
                this.AddHtmlHeader(Pdfdoc, "Syncfusion Essential PDF", " ");

            //Adding Footer
            if (showFooter == "on")
                this.AddHtmlFooter(Pdfdoc, "@Copyright 2008");

             HtmlConverter html = new HtmlConverter();
            
                // setting Javascript
                html.EnableJavaScript = chkEnableJavaScript == "on" ? true : false;
                //// Setting Pagebreak
                html.AutoDetectPageBreak = activatePageBreak == "on" ? true : false;
                //// set hyperlink
                html.EnableHyperlinks = chkEnableHyperlink == "on" ? true : false;

                if (convertType == "Metafile")
                {
                    HtmlToPdfResult result = html.Convert(sourceUrl, Syncfusion.HtmlConverter.ImageType.Metafile, (int)width, (int)height, AspectRatio.KeepWidth);

                    if (result != null)
                    {
                        PdfMetafile mf = new PdfMetafile(result.RenderedImage as Metafile);
                        mf.Quality = 100;

                        PdfMetafileLayoutFormat format = new PdfMetafileLayoutFormat();
                        format.Break = PdfLayoutBreakType.FitPage;
                        format.Layout = PdfLayoutType.Paginate;
                        Pdfdoc.PageSettings.Height = result.RenderedImage.Size.Height;
                        format.SplitTextLines = chkSplitText == "on" ? true : false;
                        format.SplitImages = splitImage == "on" ? true : false;

                        result.Render(page, format);
                    }
                    else
                        Response.Write("Warning ! Please check the HTML link");
                }
                else if (convertType == "Bitmap")
                {
                    using (System.Drawing.Image img = html.ConvertToImage(sourceUrl, Syncfusion.HtmlConverter.ImageType.Bitmap, (int)width, -1, AspectRatio.KeepWidth))
                    {
                        if (img != null)
                        {
                            PdfImage image = new PdfBitmap(img);
                            PdfLayoutFormat format = new PdfLayoutFormat();
                            format.Break = PdfLayoutBreakType.FitPage;
                            format.Layout = PdfLayoutType.Paginate;
                            if (img.Size.Width > pageSize.Width)
                            {
                                //Bitmap
                                image.Draw(page, new RectangleF(0, 0, pageSize.Width, pageSize.Height), format);
                            }
                            else
                            {
                                //Bitmap
                                image.Draw(page, new RectangleF(0, 0, img.Width, img.Height), format);
                            }
                        }
                        else
                            Response.Write("Warning ! Please check the HTML link");
                    }
                }

        }
        # region Helpher Methods
        /// <summary>
        /// Adds header to the document
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        private void AddHtmlHeader(PdfDocument doc, string title, string description)
        {
            RectangleF rect = new RectangleF(0, 0, doc.Pages[0].GetClientSize().Width, 50);

            Font f = new Font("Helvetica", 24, FontStyle.Regular);

            //Create page template
            PdfPageTemplateElement header = new PdfPageTemplateElement(rect);
            PdfFont font = new PdfTrueTypeFont(f, true);
            float doubleHeight = font.Height * 2;
            Color activeColor = Color.FromArgb(44, 71, 120);
            SizeF imageSize = new SizeF(110f, 35f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(doc.Pages[0].GetClientSize().Width - imageSize.Width - 20, 5);

            PdfImage img = new PdfBitmap(ResolveApplicationImagePath("logo.png"));

            //Draw the image in the Header.
            header.Graphics.DrawImage(img, imageLocation, imageSize);

            PdfSolidBrush brush = new PdfSolidBrush(activeColor);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            f = new Font("Helvetica", 16, FontStyle.Bold);
            font = new PdfTrueTypeFont(f, true);
            //font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);

            //Set formattings for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;

            //Draw title
            header.Graphics.DrawString(title, font, brush, new RectangleF(0, 0, header.Width, header.Height), format);
            brush = new PdfSolidBrush(Color.Gray);
            f = new Font("Helvetica", 6, FontStyle.Bold);
            font = new PdfTrueTypeFont(f, true);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Draw description
            header.Graphics.DrawString(description, font, brush, new RectangleF(0, 0, header.Width, header.Height - 8), format);

            //Draw some lines in the header
            pen = new PdfPen(Color.DarkBlue, 0.7f);
            header.Graphics.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, 03, header.Width + 3, 03);
            pen = new PdfPen(Color.DarkBlue, 2f);
            header.Graphics.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3);
            header.Graphics.DrawLine(pen, 0, header.Height, header.Width, header.Height);

            //Add header template at the top.
            doc.Template.Top = header;
        }

        /// <summary>
        /// Adds footer to the document
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="footerText"></param>
        private void AddHtmlFooter(PdfDocument doc, string footerText)
        {
            RectangleF rect = new RectangleF(0, 0, doc.Pages[0].GetClientSize().Width, 50);

            //Create a page template
            PdfPageTemplateElement footer = new PdfPageTemplateElement(rect);

            Font f = new Font("Helvetica", 8, FontStyle.Regular);
            PdfFont font = new PdfTrueTypeFont(f, true);

            PdfSolidBrush brush = new PdfSolidBrush(Color.Gray);

            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            f = new Font("Helvetica", 6, FontStyle.Bold);
            font = new PdfTrueTypeFont(f, true);

            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            footer.Graphics.DrawString(footerText, font, brush, new RectangleF(0, 18, footer.Width, footer.Height), format);

            format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Right;
            format.LineAlignment = PdfVerticalAlignment.Bottom;

            //Create page number field
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, brush);

            //Create page count field
            PdfPageCountField count = new PdfPageCountField(font, brush);

            PdfCompositeField compositeField = new PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count);
            compositeField.Bounds = footer.Bounds;
            compositeField.Draw(footer.Graphics, new PointF(470, 40));

            //Add the footer template at the bottom
            doc.Template.Bottom = footer;
        }



        # endregion

    }
}
