#region Copyright
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers
{
    public class ExcelResult : ActionResult
    {
        private IWorkbook m_source;
        private ExcelEngine m_engine;
        private string m_filename;
        private HttpResponse m_response;
        private ExcelDownloadType m_downloadType;
        private ExcelHttpContentType m_contentType;
        private string m_separator;

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
        public IWorkbook Source
        {
            get
            {
                return m_source as IWorkbook;
            }

        }
        public ExcelEngine Engine
        {
            get
            {
                return m_engine as ExcelEngine;
            }

        }
        public HttpResponse Response
        {
            get
            {
                return m_response;
            }
        }
        public ExcelDownloadType DownloadType
        {
            set
            {
                m_downloadType = value;
            }
            get
            {
                return m_downloadType;
            }
        }
        public ExcelHttpContentType ContentType
        {
            set
            {
                m_contentType = value;
            }
            get
            {
                return m_contentType;
            }
        }
        public string Separator
        {
            set
            {
                m_separator = value;
            }
            get
            {
                return m_separator;
            }
        }

        public ExcelResult(ExcelEngine engine, IWorkbook source, string fileName, HttpResponse response, ExcelDownloadType downloadType, ExcelHttpContentType contentType)
        {
            this.FileName = fileName;
            this.m_source = source;
            this.m_engine = engine;
            m_response = response;
            DownloadType = downloadType;
            ContentType = contentType;
        }

        public ExcelResult(ExcelEngine engine,IWorkbook source, string fileName, string separator, HttpResponse response, ExcelDownloadType downloadType, ExcelHttpContentType contentType)
        {
            this.FileName = fileName;
            this.m_source = source;
            this.m_engine = engine;
            m_response = response;
            DownloadType = downloadType;
            ContentType = contentType;
            Separator = separator;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("Context");
            if (m_contentType == ExcelHttpContentType.CSV)
            {
                this.m_source.SaveAs(FileName, Separator, Response, DownloadType, ContentType);
                this.m_source.Close();
                this.m_engine.Dispose();
            }
            else
            {
                this.m_source.SaveAs(FileName, Response, DownloadType, ContentType);
                this.m_source.Close();
                this.m_engine.Dispose();
            }
            
        }
    }
}
