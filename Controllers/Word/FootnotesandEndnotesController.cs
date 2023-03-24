#region Copyright
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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

namespace EJ2MVCSampleBrowser.Controllers.Word
{
    public partial class WordController : Controller
    {
        string dataPath3;
        #region FootnotesandEndnotes
        public ActionResult FootnotesandEndnotes(string Group1)
        {
            if (Group1 == null)
                return View();

            //A new document is created.            
            WordDocument document = new WordDocument();

            //Image location
            dataPath3 = ResolveApplicationDataPath("", "Images\\Word");

            //Create footnotes at the bottom of the page
            CreateFootNote(document);

            //Create endnotes at the end of the section
            CreateEndNote(document);

            if (Group1 == "WordDoc")
            {
                //Save as .doc format
                return document.ExportAsActionResult("Sample.doc", FormatType.Doc, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (Group1 == "WordDocx")
            {
                return document.ExportAsActionResult("Sample.docx", FormatType.Docx, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            // Save as WordML(.xml) format
            else if (Group1 == "WordML")
            {
                return document.ExportAsActionResult("Sample.xml", FormatType.WordML, HttpContext.ApplicationInstance.Response, HttpContentDisposition.Attachment);
            }
            return View();
        }
        #region Helper Methods
        #region CreateFootNote
        void CreateFootNote(WordDocument document)
        {
            //Add a new section to the document.
            IWSection section = document.AddSection();

            //Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            IWTextRange textRange = paragraph.AppendText("\t\t\t\t\tDemo for Footnote");
            textRange.CharacterFormat.TextColor = Color.Black;
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 20;

            section.AddParagraph();
            section.AddParagraph();
            paragraph = section.AddParagraph();
            WFootnote footnote = new WFootnote(document);
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Google").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(dataPath3 + "google.png"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Google is the most famous search engines in the Word ");

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Yahoo").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(dataPath3 + "yahoo.gif"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Yahoo experience makes it easier to discover the news and information that you care about most. ");

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Northwind Traders").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(dataPath3 + "Northwind_logo.png"));
            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases. ");

            //Setting number format for Footnote
            document.FootnoteNumberFormat = FootEndNoteNumberFormat.Arabic;

            //Setting Footnote position
            document.FootnotePosition = FootnotePosition.PrintAtBottomOfPage;
        }
        #endregion

        #region CreateEndNote
        void CreateEndNote(WordDocument document)
        {
            //Add a new section to the document.
            IWSection section = document.AddSection();

            //Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            IWTextRange textRange = paragraph.AppendText("\t\t\t\t\tDemo for Endnote");
            textRange.CharacterFormat.TextColor = Color.Black;
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 20;

            section.AddParagraph();
            section.AddParagraph();
            paragraph = section.AddParagraph();
            WFootnote footnote = new WFootnote(document);
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Google").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(dataPath3 + "google.png"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Google is the most famous search engines in the Word ");

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;


            //Insert Text into the paragraph
            paragraph.AppendText("Yahoo").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(dataPath3 + "yahoo.gif"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Yahoo experience makes it easier to discover the news and information that you care about most. ");

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Northwind Traders").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(dataPath3 + "Northwind_logo.png"));
            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases.  ");

            //Set the number format for the Endnote.
            document.EndnoteNumberFormat = Syncfusion.DocIO.FootEndNoteNumberFormat.LowerCaseRoman;
            document.RestartIndexForEndnote = Syncfusion.DocIO.EndnoteRestartIndex.DoNotRestart;
            //Set the Endnote position.
            document.EndnotePosition = Syncfusion.DocIO.EndnotePosition.DisplayEndOfSection;
        }
        #endregion
        #endregion
        #endregion FootnotesandEndnotes
    }
}
