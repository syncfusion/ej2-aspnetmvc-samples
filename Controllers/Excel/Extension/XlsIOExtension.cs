#region Copyright
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
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Syncfusion.XlsIO;

namespace EJ2MVCSampleBrowser.Controllers
{
    public static class XlsIOExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_workbook"></param>
        /// <param name="filename"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static ExcelResult SaveAsActionResult(this ExcelEngine _engine, IWorkbook _workbook, string filename, HttpResponse response)
        {
            ExcelHttpContentType contentType = ExcelHttpContentType.Excel2007;
            if (_workbook.Version == ExcelVersion.Excel2007)
                contentType = ExcelHttpContentType.Excel2007;
            else if (_workbook.Version == ExcelVersion.Excel97to2003)
                contentType = ExcelHttpContentType.Excel2000;

            return new ExcelResult(_engine, _workbook, filename, response, ExcelDownloadType.PromptDialog, contentType);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_workbook"></param>
        /// <param name="filename"></param>
        /// <param name="response"></param>
        /// <param name="DownloadType"></param>
        /// <returns></returns>
        public static ExcelResult SaveAsActionResult(this ExcelEngine _engine, IWorkbook _workbook, string filename, HttpResponse response, ExcelDownloadType DownloadType)
        {
            ExcelHttpContentType contentType = ExcelHttpContentType.Excel2007;
            if (_workbook.Version == ExcelVersion.Excel2007)
                contentType = ExcelHttpContentType.Excel2007;
            else if (_workbook.Version == ExcelVersion.Excel97to2003)
                contentType = ExcelHttpContentType.Excel2000;
            return new ExcelResult(_engine, _workbook, filename, response, DownloadType, contentType);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_workbook"></param>
        /// <param name="filename"></param>
        /// <param name="response"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static ExcelResult SaveAsActionResult(this ExcelEngine _engine, IWorkbook _workbook, string filename, HttpResponse response, ExcelHttpContentType contentType)
        {
            return new ExcelResult(_engine, _workbook, filename, response, ExcelDownloadType.PromptDialog, contentType);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_workbook"></param>
        /// <param name="filename"></param>
        /// <param name="response"></param>
        /// <param name="DownloadType"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static ExcelResult SaveAsActionResult(this ExcelEngine _engine, IWorkbook _workbook, string filename, HttpResponse response, ExcelDownloadType DownloadType, ExcelHttpContentType contentType)
        {
            return new ExcelResult(_engine, _workbook, filename, response, DownloadType, contentType);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_workbook"></param>
        /// <param name="filename"></param>
        /// <param name="saveType"></param>
        /// <param name="response"></param>
        /// <param name="DownloadType"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static ExcelResult SaveAsActionResult(this ExcelEngine _engine, IWorkbook _workbook, string filename, ExcelSaveType saveType, HttpResponse response, ExcelDownloadType DownloadType, ExcelHttpContentType contentType)
        {
            return new ExcelResult(_engine, _workbook, filename, response, DownloadType, contentType);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_workbook"></param>
        /// <param name="filename"></param>
        /// <param name="saveType"></param>
        /// <param name="response"></param>
        /// <param name="DownloadType"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static ExcelResult SaveAsActionResult(this ExcelEngine _engine, IWorkbook _workbook, string filename, string separator, HttpResponse response, ExcelDownloadType DownloadType, ExcelHttpContentType contentType)
        {
            return new ExcelResult(_engine, _workbook, filename, separator, response, DownloadType, contentType);
        }
    }
}
