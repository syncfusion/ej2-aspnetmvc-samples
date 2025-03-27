#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using System.Web.Mvc;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Xfa;

namespace Syncfusion.Mvc.Pdf
{
    public class PdfResult : ActionResult
    {
        private string m_filename;
        private PdfDocument m_pdfDocument;
        private PdfLoadedDocument m_pdfLoadedDocument;
        private HttpResponse m_response;
        private HttpReadType m_readType;
        private PdfXfaDocument m_xfaDocument;
        private PdfLoadedXfaDocument m_loadedXfaDocument;
        private PdfXfaType m_xfaType;
        public string FileName
        {
            get
            {
                return m_filename;
            }
            set
            {
                m_filename = value;
            }
        }
        public PdfDocument PdfDoc
        {
            get
            {
                if (m_pdfDocument != null)
                    return m_pdfDocument;
                return null;
            }
        }
        public PdfLoadedDocument pdfLoadedDoc
        {
            get
            {
                if (m_pdfLoadedDocument != null)
                    return m_pdfLoadedDocument;
                return null;
            }
        }
        public PdfXfaDocument PdfXfaDoc
        {
            get
            {
                if (m_xfaDocument != null)
                    return m_xfaDocument;
                return null;
            }
        }
        public PdfLoadedXfaDocument pdfLoadedXfaDoc
        {
            get
            {
                if (m_loadedXfaDocument != null)
                    return m_loadedXfaDocument;
                return null;
            }
        }
        public HttpResponse Response
        {
            get
            {
                return m_response;
            }
        }
        public HttpReadType ReadType
        {
            get
            {
                return m_readType;
            }
            set
            {
                m_readType = value;
            }
        }
        public PdfXfaType XfaType
        {
            get
            {
                return m_xfaType;
            }
            set
            {
                m_xfaType = value;
            }
        }
        public PdfResult(PdfDocument pdfDocument, string filename, HttpResponse respone, HttpReadType type)
        {
            this.m_pdfDocument = pdfDocument;
            this.m_pdfLoadedDocument = null;
            this.FileName = filename;
            this.m_response = respone;
            this.ReadType = type;
        }

        public PdfResult(PdfLoadedDocument pdfLoadedDocument, string filename, HttpResponse respone, HttpReadType type)
        {
            this.m_pdfDocument = null;
            this.m_pdfLoadedDocument = pdfLoadedDocument;
            this.FileName = filename;
            this.m_response = respone;
            this.ReadType = type;
        }

        public PdfResult(PdfXfaDocument pdfDocument, string filename,PdfXfaType xfaType, HttpResponse respone, HttpReadType type)
        {
            this.m_xfaDocument = pdfDocument;
            this.m_pdfDocument = null;
            this.m_pdfLoadedDocument = null;
            this.m_loadedXfaDocument = null;
            this.FileName = filename;
            this.m_response = respone;
            this.ReadType = type;
            this.m_xfaType = xfaType;
        }

        public PdfResult(PdfLoadedXfaDocument pdfLoadedDocument, string filename, HttpResponse respone, HttpReadType type,bool isxfa)
        {
            this.m_pdfDocument = null;
            this.m_loadedXfaDocument = pdfLoadedDocument;
            this.m_xfaDocument = null;
            this.m_pdfDocument = null;
            this.m_pdfLoadedDocument = null;
            this.FileName = filename;
            this.m_response = respone;
            this.ReadType = type;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                return;
            if (pdfLoadedDoc != null)
            {
                this.pdfLoadedDoc.Save(FileName, Response, ReadType);
                this.pdfLoadedDoc.Close(true);
            }
            if (PdfDoc != null)
            {
                this.PdfDoc.Save(FileName, Response, ReadType);
                this.PdfDoc.Close(true);
            }
            if(PdfXfaDoc != null)
            {
                this.PdfXfaDoc.Save(FileName, XfaType, Response, ReadType);
                this.PdfXfaDoc.Close();
            }  
            if(pdfLoadedXfaDoc != null)
            {
                this.pdfLoadedXfaDoc.Save(FileName, Response, ReadType);
            }         
        }


    }
}
