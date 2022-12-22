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
using System.Text;
using Syncfusion.Pdf;
using System.Web;
using System.Web.UI;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Xfa;

namespace Syncfusion.Mvc.Pdf
{
    public static class PdfExtension
    {
        public static PdfResult ExportAsActionResult(this PdfDocument PdfDoc, string filename, HttpResponse response, HttpReadType type)
        {
            return new PdfResult(PdfDoc, filename, response, type);
        }
        public static PdfResult ExportAsActionResult(this PdfXfaDocument PdfDoc,  string filename, PdfXfaType xfaType, HttpResponse response, HttpReadType type)
        {
            return new PdfResult(PdfDoc, filename,xfaType, response, type);
        }
        public static PdfResult ExportAsActionResult(this PdfLoadedDocument pdfdoc, string filename, HttpResponse response, HttpReadType type)
        {
            return new PdfResult(pdfdoc, filename, response, type);
        }
        public static PdfResult ExportAsActionResult(this PdfLoadedXfaDocument pdfdoc, string filename, HttpResponse response, HttpReadType type,bool isxfa)
        {
            return new PdfResult(pdfdoc, filename, response, type,isxfa);
        }
    }
}
