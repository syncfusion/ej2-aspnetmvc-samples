using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Lists;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /BulletsandLists/

        public ActionResult BulletsandLists()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult BulletsLists(string InsideBrowser)
        {
            //Create a new PDf document
            PdfDocument document = new PdfDocument();

            //Add a page
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;

            //Create a unordered list
            PdfUnorderedList list = new PdfUnorderedList();

            //Set the marker style
            list.Marker.Style = PdfUnorderedMarkerStyle.Disk;

            //Create a font and write title
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold);
            graphics.DrawString("List Features", font, PdfBrushes.DarkBlue, new PointF(225, 10));

            string[] products = { "Tools", "Grid", "Chart", "Edit", "Diagram", "XlsIO", "Grouping", "Calculate", "PDF", "HTMLUI", "DocIO" };
            string[] IO = { "XlsIO", "PDF", "DocIO" };

            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);
            graphics.DrawString("This sample demonstrates various features of bullets and lists. A list can be ordered and Unordered. Essential PDF provides support for creating and formatting ordered and unordered lists.", font, PdfBrushes.Black, new RectangleF(0, 50, page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height));

            //Create string format
            PdfStringFormat format = new PdfStringFormat();
            format.LineSpacing = 10f;

            font = new PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Bold);

            //Apply formattings to list
            list.Font = font;
            list.StringFormat = format;

            //Set list indent
            list.Indent = 10;

            //Add items to the list
            list.Items.Add("List of Essential Studio products");
            list.Items.Add("IO products");

            //Set text indent
            list.TextIndent = 10;

            //Create Ordered list as sublist of parent list
            PdfOrderedList subList = new PdfOrderedList();
            subList.Marker.Brush = PdfBrushes.Black;
            subList.Indent = 20;
            list.Items[0].SubList = subList;

            //Set format for sub list
            font = new PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Italic);
            subList.Font = font;
            subList.StringFormat = format;
            foreach (string s in products)
            {
                //Add items
                subList.Items.Add(string.Concat("Essential ", s));
            }

            //Create unorderd sublist for the second item of parent list
            PdfUnorderedList SubsubList = new PdfUnorderedList();
            SubsubList.Marker.Brush = PdfBrushes.Black;
            SubsubList.Indent = 20;
            list.Items[1].SubList = SubsubList;

            PdfImage image = PdfImage.FromFile(ResolveApplicationImagePath("syncfusion_logo.gif"));
            font = new PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Regular);
            SubsubList.Font = font;
            SubsubList.StringFormat = format;

            //Add subitems
            SubsubList.Items.Add("Essential PDF: It is a .NET library with the capability to produce Adobe PDF files. It features a full-fledged object model for the easy creation of PDF files from any .NET language. It does not use any external libraries and is built from scratch in C#. It can be used on the server side (ASP.NET or any other environment) or with Windows Forms applications. Essential PDF supports many features for creating a PDF document. Drawing Text, Images, Shapes, etc can be drawn easily in the PDF document.");
            SubsubList.Items.Add("Essential DocIO: It is a .NET library that can read and write Microsoft Word files. It features a full-fledged object model similar to the Microsoft Office COM libraries. It does not use COM interop and is built from scratch in C#. It can be used on systems that do not have Microsoft Word installed. Here are some of the most common questions that arise regarding the usage and functionality of Essential DocIO.");
            SubsubList.Items.Add("Essential XlsIO: It is a .NET library that can read and write Microsoft Excel files (BIFF 8 format). It features a full-fledged object model similar to the Microsoft Office COM libraries. It does not use COM interop and is built from scratch in C#. It can be used on systems that do not have Microsoft Excel installed, making it an excellent reporting engine for tabular data. ");

            //Set image as marker
            SubsubList.Marker.Image = image;

            //Draw list
            list.Draw(page, new RectangleF(0, 130, page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height));

            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
        }

    }
}
