#region Copyright
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Data;
using System.Data.OleDb;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace EJ2MVCSampleBrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region Table Styles
        public ActionResult TableStyles(string Group1, string Group2)
        {
            if (Group1 == null)
                return View();
            string dataPath = ResolveApplicationDataPath("TemplateTableStyle.doc", "Data\\DocIO");
            WordDocument document = new WordDocument(dataPath);

            string dataBase = ResolveApplicationDataPath("Northwind.mdb", "Data");
            // Get Data from the Database.
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            string connectionstring = "Data Source = " + ResolveApplicationDataPath("Northwind.mdb", "Data");
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;" + connectionstring;
            conn.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Suppliers", conn);
            adapter.Fill(ds);
            ds.Tables[0].TableName = "Suppliers";
            adapter.Dispose();
            conn.Close();

            // Execute Mail Merge with groups.
            document.MailMerge.ExecuteGroup(ds.Tables[0]);

            #region Built-in Style
            if (Group1 == "Built-in")
            {
                //Get table to apply style.
                WTable table = (WTable)document.LastSection.Tables[0];

                //Apply built-in table style to the table.
                table.ApplyStyle(BuiltinTableStyle.MediumShading1Accent5);
            }
            #endregion Built-in Style

            #region Custom Style
            else
            {
                #region Custom table styles
                //Get table to apply style
                WTable table = (WTable)document.LastSection.Tables[0];
                //Apply custom table style to the table
                #region Apply Table style
                WTableStyle tableStyle = document.AddTableStyle("Tablestyle") as WTableStyle;
                System.Drawing.Color borderColor = System.Drawing.Color.WhiteSmoke;
                System.Drawing.Color firstRowBackColor = System.Drawing.Color.Blue;
                System.Drawing.Color backColor = System.Drawing.Color.WhiteSmoke;
                ConditionalFormattingStyle firstRowStyle, lastRowStyle, firstColumnStyle, lastColumnStyle, oddColumnBandingStyle, oddRowBandingStyle, evenRowBandingStyle;

                #region Table Properties
                tableStyle.TableProperties.RowStripe = 1;
                tableStyle.TableProperties.ColumnStripe = 1;
                tableStyle.TableProperties.LeftIndent = 0;

                tableStyle.TableProperties.Paddings.Top = 0;
                tableStyle.TableProperties.Paddings.Bottom = 0;
                tableStyle.TableProperties.Paddings.Left = 5.4f;
                tableStyle.TableProperties.Paddings.Right = 5.4f;

                tableStyle.TableProperties.Borders.Top.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Top.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Top.Color = System.Drawing.Color.AliceBlue;
                tableStyle.TableProperties.Borders.Top.Space = 0;

                tableStyle.TableProperties.Borders.Bottom.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Bottom.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Bottom.Color = borderColor;
                tableStyle.TableProperties.Borders.Bottom.Space = 0;

                tableStyle.TableProperties.Borders.Left.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Left.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Left.Color = borderColor;
                tableStyle.TableProperties.Borders.Left.Space = 0;

                tableStyle.TableProperties.Borders.Right.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Right.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Right.Color = borderColor;
                tableStyle.TableProperties.Borders.Right.Space = 0;

                tableStyle.TableProperties.Borders.Horizontal.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Horizontal.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Horizontal.Color = borderColor;
                tableStyle.TableProperties.Borders.Horizontal.Space = 0;
                #endregion

                #region Conditional Formatting Properties
                #region First Row Conditional Formatting Style
                firstRowStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.FirstRow);

                #region Character format
                firstRowStyle.CharacterFormat.Bold = true;
                firstRowStyle.CharacterFormat.BoldBidi = true;
                firstRowStyle.CharacterFormat.TextColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
                #endregion

                #region Table Cell Properties
                firstRowStyle.CellProperties.Borders.Top.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Top.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Top.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Top.Space = 0;

                firstRowStyle.CellProperties.Borders.Bottom.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Bottom.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Bottom.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Bottom.Space = 0;

                firstRowStyle.CellProperties.Borders.Left.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Left.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Left.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Left.Space = 0;

                firstRowStyle.CellProperties.Borders.Right.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Right.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Right.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Right.Space = 0;

                firstRowStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;

                firstRowStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;

                firstRowStyle.CellProperties.BackColor = firstRowBackColor;
                firstRowStyle.CellProperties.ForeColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                firstRowStyle.CellProperties.TextureStyle = TextureStyle.TextureNone;
                #endregion
                #endregion

                #region Last Row Conditional Formatting Style
                lastRowStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.LastRow);

                #region Character format
                lastRowStyle.CharacterFormat.Bold = true;
                lastRowStyle.CharacterFormat.BoldBidi = true;
                #endregion

                #region Table Cell Properties
                lastRowStyle.CellProperties.Borders.Top.BorderType = BorderStyle.Double;
                lastRowStyle.CellProperties.Borders.Top.LineWidth = .75f;
                lastRowStyle.CellProperties.Borders.Top.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Top.Space = 0;

                lastRowStyle.CellProperties.Borders.Bottom.BorderType = BorderStyle.Single;
                lastRowStyle.CellProperties.Borders.Bottom.LineWidth = 1f;
                lastRowStyle.CellProperties.Borders.Bottom.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Bottom.Space = 0;

                lastRowStyle.CellProperties.Borders.Left.BorderType = BorderStyle.Single;
                lastRowStyle.CellProperties.Borders.Left.LineWidth = 1f;
                lastRowStyle.CellProperties.Borders.Left.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Left.Space = 0;

                lastRowStyle.CellProperties.Borders.Right.BorderType = BorderStyle.Single;
                lastRowStyle.CellProperties.Borders.Right.LineWidth = 1f;
                lastRowStyle.CellProperties.Borders.Right.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Right.Space = 0;

                lastRowStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;

                lastRowStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;
                #endregion
                #endregion

                #region First Column Conditional Formatting Style
                firstColumnStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.FirstColumn);
                #region Character format
                firstColumnStyle.CharacterFormat.Bold = true;
                firstColumnStyle.CharacterFormat.BoldBidi = true;
                #endregion
                #endregion

                #region Last Column Conditional Formatting Style
                lastColumnStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.LastColumn);
                #region Character format
                lastColumnStyle.CharacterFormat.Bold = true;
                lastColumnStyle.CharacterFormat.BoldBidi = true;
                #endregion
                #endregion

                #region Odd Column Banding Conditional Formatting Style
                oddColumnBandingStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.OddColumnBanding);
                #region Table Cell Properties
                oddColumnBandingStyle.CellProperties.BackColor = backColor;
                oddColumnBandingStyle.CellProperties.ForeColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                oddColumnBandingStyle.CellProperties.TextureStyle = TextureStyle.TextureNone;
                #endregion
                #endregion

                #region Odd Row Banding Conditional Formatting Style
                oddRowBandingStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.OddRowBanding);
                #region Table Cell Properties
                oddRowBandingStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;

                oddRowBandingStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;

                oddRowBandingStyle.CellProperties.BackColor = backColor;
                oddRowBandingStyle.CellProperties.ForeColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                oddRowBandingStyle.CellProperties.TextureStyle = TextureStyle.TextureNone;
                #endregion
                #endregion

                #region Even Row Banding Conditional Formatting Style
                evenRowBandingStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.EvenRowBanding);
                #region Table Cell Properties
                evenRowBandingStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;
                evenRowBandingStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;
                #endregion
                #endregion
                #endregion
                #endregion
                table.ApplyStyle("Tablestyle");
                #endregion
            }
            #endregion Custom Style

            #region Document save option
            //Save as .docx format
            if (Group2 == "WordDocx")
            {
                return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group2 == "WordML")
            {
                return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .pdf format
            else if (Group2 == "Pdf")
            {
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfDoc = converter.ConvertToPDF(document);

                return pdfDoc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }
            #endregion Document save option

            return View();
        }
        #endregion Table Styles
    }
}