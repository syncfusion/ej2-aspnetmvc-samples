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
using System.Web.Mvc;

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using System.Drawing;
using System.IO;
using System.Web.Http.Results;
using System.IO.Pipes;
using Syncfusion.Compression.Zip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.AspNet.SignalR;


namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /SplitPDF/

        public ActionResult SplitPDF()
        {
            return View();
        }

        private string result;

        [HttpPost]
        public ActionResult SplitPDF(string Browser, string splitOption, int startPageNumber, int endPageNumber, int fileCount, int pageNoCount, HttpPostedFileBase file)
        {
            Stream fileStream = GetInputSplitDocument(file);
            result = null;
            if (splitOption == "fixedRange")
            {

                if (startPageNumber != 0 && endPageNumber != 0)
                {
                    int splitAtPage = startPageNumber;
                    int splitAtPage1 = endPageNumber;

                    if (splitAtPage <= splitAtPage1)
                    {
                        PdfLoadedDocument ldoc = new PdfLoadedDocument(fileStream);

                        if (splitAtPage1 <= ldoc.Pages.Count && splitAtPage != 0)
                        {
                            //Create PDF documents.
                            PdfDocument doc1 = new PdfDocument();

                            //Import PDF document into splitAtPage index.                   
                            doc1.ImportPageRange(ldoc, splitAtPage - 1, splitAtPage1 - 1);

                            //Save to disk
                            if (Browser == "Browser")
                            {
                                return doc1.ExportAsActionResult("Document1.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
                            }
                            else
                            {
                                return doc1.ExportAsActionResult("Document1.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
                            }
                        }
                        else
                        {
                            int pagecount = ldoc.Pages.Count;
                            ViewBag.lab = "Invalid Page no: The page range should be 1 to " + pagecount;
                        }
                    }
                    else
                    {
                        PdfLoadedDocument ldoc = new PdfLoadedDocument(file.InputStream);
                        int pagecount = ldoc.Pages.Count;
                        ldoc.Close(true);
                        ViewBag.lab = "Invalid page range: The page range should be 1 to " + pagecount;
                    }
                }
                else
                {
                    PdfLoadedDocument ldoc = new PdfLoadedDocument(file.InputStream);
                    int pagecount = ldoc.Pages.Count;
                    ldoc.Close(true);
                    ViewBag.lab = "Invalid page range: The page range should be 1 to " + pagecount;
                }
            }
            else if (splitOption == "fileCount")
            {
                PdfLoadedDocument ldoc = new PdfLoadedDocument(fileStream);
                int pageCount = ldoc.Pages.Count;
                if (fileCount != 0)
                {
                    if (fileCount <= pageCount)
                    {
                        // Create PDF split options
                        PdfSplitOptions option = new PdfSplitOptions();

                        option.SplitTags = true;

                        ZipArchive zipArchive = new ZipArchive();

                        int[,] splitRanges = GetPageRanges(pageCount, fileCount);

                        int index = 0;


                        // Split the document by ImportPageRange
                        for (int i = 0; i < splitRanges.Length / 2; i++)
                        {
                            //Create PDF documents.
                            PdfDocument doc1 = new PdfDocument();

                            //Import PDF document into splitAtPage index.                   
                            doc1.ImportPageRange(ldoc, splitRanges[i, 0], splitRanges[i, 1]);

                            //Save the splited document into stream
                            MemoryStream stream = new MemoryStream();
                            doc1.Save(stream);

                            zipArchive.AddItem($"split{splitRanges[index, 0] + 1}-{splitRanges[index, 1] + 1}.pdf", stream, false, FileAttributes.Normal);
                            index++;

                            doc1.Close(true);


                        }
                        // Save the zip archive in memory stream
                        MemoryStream memoryStream = new MemoryStream();
                        zipArchive.Save(memoryStream, false);

                        // Close the ZipArchive
                        zipArchive.Dispose();

                        return File(memoryStream.ToArray(), "application/zip", "SplitedFiles.zip");
                    }
                    else
                    {
                        ViewBag.lab = "Invalid file count: The file count should be 1 to " + pageCount;
                    }
                }
                else
                {
                    ViewBag.lab = "Invalid file count: The file count should be 1 to " + pageCount;
                }

                ldoc.Close(true);
            }
            else if (splitOption == "pageCount")
            {
                PdfLoadedDocument ldoc = new PdfLoadedDocument(fileStream);
                int pageCount = ldoc.Pages.Count;

                // Calculate the number of PDFs needed
                int numberOfSplits = (pageCount + pageNoCount - 1) / pageNoCount;

                if (pageNoCount != 0)
                {
                    if (pageNoCount <= pageCount)
                    {
                        // Create PDF split options
                        PdfSplitOptions option = new PdfSplitOptions();

                        option.SplitTags = true;

                        ZipArchive zipArchive = new ZipArchive();

                        int index = 1;

                        for (int i = 0; i < numberOfSplits; i++)
                        {
                            // Create a new PDF document for each split
                            using (PdfDocument newDocument = new PdfDocument())
                            {
                                int startPage = i * pageNoCount;
                                int endPage = startPage + pageNoCount - 1;

                                // Ensure endPage does not exceed the total number of pages
                                if (endPage >= pageCount)
                                {
                                    endPage = pageCount - 1;
                                }

                                // Extract pages and add them to the new document
                                for (int j = startPage; j <= endPage; j++)
                                {
                                    newDocument.ImportPage(ldoc, j);
                                }

                                // Save the new PDF document
                                MemoryStream stream = new MemoryStream();
                                newDocument.Save(stream);

                                zipArchive.AddItem($"split{index}.pdf", stream, false, FileAttributes.Normal);
                                index++;
                            }
                        }

                        // Save the zip archive in memory stream
                        MemoryStream memoryStream = new MemoryStream();
                        zipArchive.Save(memoryStream, false);

                        // Close the ZipArchive.
                        zipArchive.Dispose();

                        // Close the loaded document
                        ldoc.Close(true);


                        return File(memoryStream.ToArray(), "application/zip", "SplitedFiles.zip");
                    }
                    else
                    {
                        ViewBag.lab = "Invalid page count: The page count should be 1 to " + pageCount;
                    }
                }
                else
                {
                    ViewBag.lab = "Invalid page count: The page count should be 1 to " + pageCount;
                }
                ldoc.Close(true);

            }
            else
            {
                ViewBag.lab = "Enter the page no to split";
            }
            return View();
        }
        int[,] GetPageRanges(int pageCount, int fileCount)
        {
            // Calculate the base number of pages per file and the remaining pages
            int pagesPerFileBase = pageCount / fileCount;
            int remainingPages = pageCount % fileCount;

            // Create an array to store the number of pages for each file
            int[] pagesPerFile = new int[fileCount];

            // Distribute the pages among the files
            for (int i = 0; i < fileCount; i++)
            {
                pagesPerFile[i] = pagesPerFileBase;
                if (remainingPages > 0)
                {
                    pagesPerFile[i]++;
                    remainingPages--;
                }
            }
            int startPage = 0;
            int endPage = 0;
            int[,] splitRanges = new int[fileCount, 2];

            for (int i = 0; i < fileCount; i++)
            {
                endPage = startPage + pagesPerFile[i] - 1;
                splitRanges[i, 0] = startPage;
                splitRanges[i, 1] = endPage;

                startPage = endPage + 1;
            }
            return splitRanges;
        }

        private Stream GetInputSplitDocument(HttpPostedFileBase file)
        {

            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                if (extension == ".pdf")
                {
                    MemoryStream stream = new MemoryStream();
                    Request.InputStream.CopyTo(stream);
                    return stream;
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose a valid PDF document to add watermark");
                    return null;
                }
            }
            else
            {
                //Opens an existing document from stream through constructor of `WordDocument` class
                FileStream fileStreamPath = new FileStream(ResolveApplicationDataPath(@"SplitPDF.pdf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                return fileStreamPath;
            }
        }
    }
}
