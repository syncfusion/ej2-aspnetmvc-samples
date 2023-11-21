#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /ComplexScript/

        public ActionResult ComplexScript()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult ComplexScript(string InsideBrowser)
        {
            string inputText = @"เอกสาร PDF มีการใช้อย่างแพร่หลายเป็นเวลาหลายปีและนับสิบ ๆ แถมฟรี ผู้อ่าน 
PDF เชิงพาณิชย์บรรณาธิการและห้องสมุดพร้อมใช้งาน อย่างไรก็ตามแม้จะมี
ความนิยมนี้ก็ยังคงยากที่จะหาคำแนะนำกระชับรูปแบบ PDF พื้นเมือง
การทำความเข้าใจการทำงานภายในของ PDF ทำให้สามารถสร้างได้แบบไดนามิก
เอกสาร PDF ตัวอย่างเช่นเว็บเซิร์ฟเวอร์สามารถดึงข้อมูลจากฐานข้อมูล
ใช้เพื่อกำหนดใบกำกับสินค้าและให้บริการกับลูกค้าได้ทันที";

            //Create a new PdfDocument.
            PdfDocument document = new PdfDocument();

            //Add a new page to the document.
            PdfPage page = document.Pages.Add();

            //Create font.
            PdfFont font = new PdfTrueTypeFont(new Font("Tahoma", 14), true);

            //Create brush.
            PdfBrush brush = new PdfSolidBrush(Color.Black);

            //Get page client size.          
            SizeF clipBounds = page.Graphics.ClientSize;

            RectangleF rect = new RectangleF(0, 0, clipBounds.Width, clipBounds.Height);

            //Create a new instance of the PdfStringFormat.
            PdfStringFormat format = new PdfStringFormat();

            //Set the property for complex text layout.
            format.ComplexScript = true;

            //Draw the text.
            page.Graphics.DrawString(inputText, font, brush, rect, format);

            //Stream the output to the browser.    
            if (InsideBrowser == "Browser")
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            }
            else
            {
                return document.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
        }

    }
}
