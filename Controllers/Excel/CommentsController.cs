#region Copyright Syncfusion Inc. 2001 - 2024
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
using System.Drawing;
using System.Web.Mvc;
using System.IO;
using Syncfusion.XlsIO;
using Syncfusion.Pdf;
using Syncfusion.ExcelToPdfConverter;


namespace EJ2MVCSampleBrowser.Controllers.Excel
{
    public partial class ExcelController : Controller
    {
        //
        // GET: /Comments/

        public ActionResult Comments(string button)
        {
            if (button == null)
                return View();
            else if (button == "Input Template")
            {
                Stream ms = new FileStream(ResolveApplicationDataPath(@"CommentsTemplate.xlsx"), FileMode.Open, FileAccess.Read);
                return File(ms, "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "CommentsTemplate.xlsx");
            }
            else if (button == "Create Document")
            {
                //Initialize ExcelEngine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Initialize IApplication and set the default application version
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                    IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"CommentsTemplate.xlsx"));
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Add Comments
                    AddComments(worksheet);

                    MemoryStream ms = new MemoryStream();
                    workbook.SaveAs(ms);
                    ms.Position = 0;

                    return File(ms, "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ExcelComments.xlsx");
                }
            }
            else if (button == "Convert To PDF")
            {
                //Initialize ExcelEngine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Initialize IApplication and set the default application version
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                    IWorkbook workbook = application.Workbooks.Open(ResolveApplicationDataPath(@"CommentsTemplate.xlsx"));
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Add Comments
                    AddComments(worksheet);

                    //Set print location of comments
                    worksheet.PageSetup.PrintComments = ExcelPrintLocation.PrintSheetEnd;

                    //Initialize XlsIORenderer and convert the Excel document to PDF
                    ExcelToPdfConverter converter = new ExcelToPdfConverter(workbook);
                    PdfDocument document = converter.Convert();

                    MemoryStream ms = new MemoryStream();
                    document.Save(ms);
                    ms.Position = 0;

                    document.Save("ExcelComments.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                }
            }
            return View();
        }
        /// <summary>
        /// Add threaded comments and notes in worksheet.
        /// </summary>
        /// <param name="worksheet"></param>
        private void AddComments(IWorksheet worksheet)
        {
            //Add Comments (Notes)
            IComment comment = worksheet.Range["H1"].AddComment();
            comment.Text = "This Total column comment will be printed at the end of sheet.";
            comment.IsVisible = true;

            //Add Threaded Comments
            IThreadedComment threadedComment = worksheet.Range["H16"].AddThreadedComment("What is the reason for the higher total amount of \"desk\"  in the west region?", "User1", DateTime.Now);
            threadedComment.AddReply("The unit cost of desk is higher compared to other items in the west region. As a result, the total amount is elevated.", "User2", DateTime.Now);
            threadedComment.AddReply("Additionally, Wilson sold 31 desks in the west region, which is also a contributing factor to the increased total amount.", "User3", DateTime.Now);
        }
    }
}