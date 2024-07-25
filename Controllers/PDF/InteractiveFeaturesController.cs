#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Web.Mvc;
using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Tables;
using System.Data;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /InteractiveFeatures/
        # region Fields
        PdfDocument document;
        PdfPage interactivePage;
        System.Drawing.Color whiteColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
        #endregion
        public ActionResult InteractiveFeatures()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InteractiveFeatures(string InsideBrowser)
        {
            # region Field Definitions
            document = new PdfDocument();
            document.PageSettings.Margins.All = 0;
            document.PageSettings.Size = new SizeF(PdfPageSize.A4.Width, 600);
            interactivePage = document.Pages.Add();
            PdfGraphics g = interactivePage.Graphics;
            RectangleF rect = new RectangleF(0, 0, interactivePage.Graphics.ClientSize.Width, 100);

            PdfBrush whiteBrush = new PdfSolidBrush(whiteColor);
            PdfPen whitePen = new PdfPen(whiteColor, 5);
            PdfBrush purpleBrush = new PdfSolidBrush(System.Drawing.Color.FromArgb(255, 158, 0, 160));
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 25);
            System.Drawing.Color maroonColor = System.Drawing.Color.FromArgb(255, 188, 32, 60);
            System.Drawing.Color orangeColor = System.Drawing.Color.FromArgb(255, 255, 167, 73);
            #endregion

            #region Header
            g.DrawRectangle(purpleBrush, rect);
            g.DrawPie(whitePen, whiteBrush, new RectangleF(-20, 35, 700, 200), 20, -180);
            g.DrawRectangle(whiteBrush, new RectangleF(0, 99.5f, 700, 200));
            g.DrawString("Invoice", new PdfStandardFont(PdfFontFamily.TimesRoman, 24), PdfBrushes.White, new PointF(500, 10));
            string imagePath = ResolveApplicationImagePath("AdventureCycle.jpg");
            g.DrawImage(PdfImage.FromFile(imagePath), new RectangleF(100, 70, 390, 130));
            #endregion

            #region Body

            //Invoice Number
            Random invoiceNumber = new Random();
            g.DrawString("Invoice No: " + invoiceNumber.Next().ToString(), new PdfStandardFont(PdfFontFamily.Helvetica, 14), new PdfSolidBrush(maroonColor), new PointF(50, 210));
            g.DrawString("Date: ", new PdfStandardFont(PdfFontFamily.Helvetica, 14), new PdfSolidBrush(maroonColor), new PointF(350, 210));

            //Current Date
            PdfTextBoxField textBoxField = new PdfTextBoxField(interactivePage, "date");
            textBoxField.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            textBoxField.Bounds = new RectangleF(384, 204, 150, 30);
            textBoxField.ForeColor = new PdfColor(maroonColor);
            textBoxField.ReadOnly = true;
            document.Actions.AfterOpen = new PdfJavaScriptAction(@"var newdate = new Date(); 
            var thisfieldis = this.getField('date');  
            
            var theday = util.printd('dddd',newdate); 
            var thedate = util.printd('d',newdate); 
            var themonth = util.printd('mmmm',newdate);
            var theyear = util.printd('yyyy',newdate);  
            
            thisfieldis.strokeColor=color.transparent;
            thisfieldis.value = theday + ' ' + thedate + ', ' + themonth + ' ' + theyear ;");
            document.Form.Fields.Add(textBoxField);

            //invoice table
            PdfLightTable table = new PdfLightTable();
            table.Style.ShowHeader = true;
            g.DrawRectangle(new PdfSolidBrush(System.Drawing.Color.FromArgb(238, 238, 238, 248)), new RectangleF(50, 240, 500, 140));

            //Header Style
            PdfCellStyle headerStyle = new PdfCellStyle();
            headerStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Bold);
            headerStyle.TextBrush = whiteBrush;
            headerStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            headerStyle.BackgroundBrush = new PdfSolidBrush(orangeColor);
            headerStyle.BorderPen = new PdfPen(whiteBrush, 0);
            table.Style.HeaderStyle = headerStyle;

            //Cell Style
            PdfCellStyle bodyStyle = new PdfCellStyle();
            bodyStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
            bodyStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Left);
            bodyStyle.BorderPen = new PdfPen(whiteBrush, 0);
            table.Style.DefaultStyle = bodyStyle;
            table.DataSource = GetAdventureWorkCycleDataSet();
            table.Columns[0].Width = 90;
            table.Columns[1].Width = 160;
            table.Columns[3].Width = 100;
            table.Columns[4].Width = 65;
            table.Style.CellPadding = 3;
            table.BeginCellLayout += table_BeginCellLayout;

            PdfLightTableLayoutResult result = table.Draw(interactivePage, new RectangleF(50, 240, 500, 140));

            g.DrawString("Grand Total:", new PdfStandardFont(PdfFontFamily.Helvetica, 12), new PdfSolidBrush(System.Drawing.Color.FromArgb(255, 255, 167, 73)), new PointF(result.Bounds.Right - 150, result.Bounds.Bottom));
            CreateTextBox(interactivePage, "GrandTotal", "Grand Total", new RectangleF(result.Bounds.Width - 15, result.Bounds.Bottom - 2, 66, 18), true, "");


            //Send to Server
            PdfButtonField sendButton = new PdfButtonField(interactivePage, "OrderOnline");
            sendButton.Bounds = new RectangleF(200, result.Bounds.Bottom + 70, 80, 25);
            sendButton.BorderColor = whiteColor;
            sendButton.BackColor = maroonColor;
            sendButton.ForeColor = whiteColor;
            sendButton.Text = "Order Online";
            PdfSubmitAction submitAction = new PdfSubmitAction("http://stevex.net/dump.php");
            submitAction.DataFormat = SubmitDataFormat.Html;
            sendButton.Actions.MouseUp = submitAction;
            document.Form.Fields.Add(sendButton);

            //Order by Mail
            PdfButtonField sendMail = new PdfButtonField(interactivePage, "sendMail");
            sendMail.Bounds = new RectangleF(300, result.Bounds.Bottom + 70, 80, 25);
            sendMail.Text = "Order By Mail";
            sendMail.BorderColor = whiteColor;
            sendMail.BackColor = maroonColor;
            sendMail.ForeColor = whiteColor;

            // Create a javascript action.
            PdfJavaScriptAction javaAction = new PdfJavaScriptAction("address = app.response(\"Enter an e-mail address.\",\"SEND E-MAIL\",\"\");"
+ "var aSubmitFields = [];"
+ "for( var i = 0 ; i < this.numFields; i++){"
        + "aSubmitFields[i] = this.getNthFieldName(i);"
    + "}"
+ "if (address){ cmdLine = \"mailto:\" + address;this.submitForm(cmdLine,true,false,aSubmitFields);}");

            sendMail.Actions.MouseUp = javaAction;
            document.Form.Fields.Add(sendMail);

            //Print
            PdfButtonField printButton = new PdfButtonField(interactivePage, "print");
            printButton.Bounds = new RectangleF(400, result.Bounds.Bottom + 70, 80, 25);
            printButton.BorderColor = whiteColor;
            printButton.BackColor = maroonColor;
            printButton.ForeColor = whiteColor;
            printButton.Text = "Print";
            printButton.Actions.MouseUp = new PdfJavaScriptAction("this.print (true); ");
            document.Form.Fields.Add(printButton);

            string attachmentPath = ResolveApplicationDataPath("Product Catalog.pdf");
            PdfAttachment attachment = new PdfAttachment(attachmentPath);
            attachment.ModificationDate = DateTime.Now;
            attachment.Description = "Specification";
            document.Attachments.Add(attachment);

            //Open Specification
            PdfButtonField openSpecificationButton = new PdfButtonField(interactivePage, "openSpecification");
            openSpecificationButton.Bounds = new RectangleF(50, result.Bounds.Bottom + 20, 87, 15);
            openSpecificationButton.TextAlignment = PdfTextAlignment.Left;
            openSpecificationButton.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
            openSpecificationButton.BorderStyle = PdfBorderStyle.Underline;
            openSpecificationButton.BorderColor = orangeColor;
            openSpecificationButton.BackColor = new PdfColor(255, 255, 255);
            openSpecificationButton.ForeColor = orangeColor;
            openSpecificationButton.Text = "Open Specification";
            openSpecificationButton.Actions.MouseUp = new PdfJavaScriptAction("this.exportDataObject({ cName: 'Product Catalog.pdf', nLaunch: 2 });");
            document.Form.Fields.Add(openSpecificationButton);

            RectangleF uriAnnotationRectangle = new RectangleF(interactivePage.Graphics.ClientSize.Width - 160, interactivePage.Graphics.ClientSize.Height - 30, 80, 20);
            PdfTextWebLink linkAnnot = new PdfTextWebLink();
            linkAnnot.Url = "http://www.adventure-works.com";
            linkAnnot.Text = "http://www.adventure-works.com";
            linkAnnot.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);
            linkAnnot.Brush = PdfBrushes.White;
            linkAnnot.DrawTextWebLink(interactivePage, uriAnnotationRectangle.Location);
            #endregion

            #region Footer
            g.DrawRectangle(purpleBrush, new RectangleF(0, interactivePage.Graphics.ClientSize.Height - 100, interactivePage.Graphics.ClientSize.Width, 100));
            g.DrawPie(whitePen, whiteBrush, new RectangleF(-20, interactivePage.Graphics.ClientSize.Height - 250, 700, 200), 0, 180);
            #endregion
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

        #region Helper Methods

        void table_BeginCellLayout(object sender, BeginCellLayoutEventArgs args)
        {
            if (args.CellIndex == 2 && args.RowIndex > -1)
            {
                CreateTextBox(interactivePage, "price" + args.RowIndex.ToString(), "Price", args.Bounds, true, args.Value);
                args.Skip = true;

            }
            else if (args.CellIndex == 3 && args.RowIndex == -1)
            {
                PdfPopupAnnotation popupAnnotation = new PdfPopupAnnotation(new RectangleF(args.Bounds.Right - 18, args.Bounds.Top + 2, 1, 1),
                               "Please enter a validate interger between 1 to 50");
                popupAnnotation.Border.Width = 4;
                popupAnnotation.Open = false;
                popupAnnotation.Border.HorizontalRadius = 10;
                popupAnnotation.Border.VerticalRadius = 10;
                popupAnnotation.Icon = PdfPopupIcon.Comment;
                interactivePage.Annotations.Add(popupAnnotation);
            }
            else if (args.CellIndex == 3 && args.RowIndex > -1)
            {
                PdfTextBoxField textBoxField = new PdfTextBoxField(interactivePage, "quantity" + args.RowIndex.ToString());


                //Set properties to the textbox.
                textBoxField.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 12); ;
                textBoxField.BorderColor = new PdfColor(whiteColor);
                textBoxField.BackColor = System.Drawing.Color.FromArgb(255, 238, 238, 248);
                textBoxField.Bounds = args.Bounds;
                textBoxField.Text = "0";
                PdfJavaScriptAction action = new PdfJavaScriptAction(@"event.rc = event.value > -1 && event.value < 51; 
                var f = this.getField('price" + args.RowIndex.ToString() + @"')
                var f1 = this.getField('quantity" + args.RowIndex.ToString() + @"')
                var f2 = this.getField('TotalPrice" + args.RowIndex.ToString() + @"')
                var f3 = this.getField('GrandTotal');
                if(!event.rc)
                {

                f1.fillColor=color.red;
                app.beep();
                }
                else
                {
                    f1.fillColor = color.transparent;
                    f2.value = f1.value * f.value;
                    f3.value = this.getField('TotalPrice0').value + this.getField('TotalPrice1').value + this.getField('TotalPrice2').value + this.getField('TotalPrice3').value + this.getField('TotalPrice4').value +this.getField('TotalPrice5').value;
                }");
                textBoxField.Actions.LostFocus = action;
                document.Form.Fields.Add(textBoxField);
            }
            else if (args.CellIndex == 4 && args.RowIndex > -1)
            {
                CreateTextBox(interactivePage, "TotalPrice" + args.RowIndex.ToString(), "Total Price", args.Bounds, true, "0");
            }
        }
        /// <summary>
        /// Creates textbox and adds it in the form.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="text"></param>
        /// <param name="tooltip"></param>
        /// <param name="f"></param>
        /// <param name="bounds"></param>
        private void CreateTextBox(PdfPage page, string text, string tooltip, RectangleF bounds, bool readOnly, string value)
        {
            // Create a Text box field.
            PdfTextBoxField textBoxField = new PdfTextBoxField(page, text);
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            //Set properties to the textbox.
            textBoxField.Font = font;
            textBoxField.BackColor = System.Drawing.Color.FromArgb(255, 238, 238, 248);
            textBoxField.BorderColor = whiteColor;
            textBoxField.Bounds = bounds;
            textBoxField.ToolTip = tooltip;
            textBoxField.ReadOnly = readOnly;
            textBoxField.Text = value;
            document.Form.Fields.Add(textBoxField);
        }

        /// <summary>
        /// Returns dataset.
        /// </summary>
        private DataSet GetAdventureWorkCycleDataSet()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(ResolveApplicationDataPath("AdventureWorkCycle.xml"));
            return dataSet;
        }
        #endregion
        # region ResolveApplicationDataPath
        /// <summary>
        /// Get the data file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected string ResolveApplicationDataPath(string fileName)
        {
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\App_Data") + "\\PDF").FullName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }

        protected string ResolveApplicationImagePath(string fileName)
        {
            string dataPath = new System.IO.DirectoryInfo(Server.MapPath("~\\Content") + "\\PDF").FullName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }
        # endregion
    }
}
