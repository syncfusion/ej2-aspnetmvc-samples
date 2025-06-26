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
using System.Web;
using Microsoft.Owin.Security;

namespace EJ2MVCSampleBrowser.Models
{
    public class ProgrammaticOperationsModel
    {   
        public string ID { get; set; }
        public string Text { get; set; }
        public List<ProgrammaticOperationsModel> AnnotationLists()
        {
            List<ProgrammaticOperationsModel> annotations = new List<ProgrammaticOperationsModel>();
            annotations.Add(new ProgrammaticOperationsModel { ID = "Highlight", Text = "Highlight" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Underline", Text = "Underline" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Strikethrough", Text = "Strikethrough" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Squiggly", Text = "Squiggly" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Line", Text = "Line" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Arrow", Text = "Arrow" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Rectangle", Text = "Rectangle" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Circle", Text = "Circle" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Polygon", Text = "Polygon" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Distance", Text = "Distance" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Perimeter", Text = "Perimeter" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Area", Text = "Area" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Radius", Text = "Radius" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Volume", Text = "Volume" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "StickyNotes", Text = "Sticky Notes" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Ink", Text = "Ink" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "Stamp", Text = "Stamp" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "CustomStamp", Text = "Custom Stamp" });
            annotations.Add(new ProgrammaticOperationsModel { ID = "FreeText", Text = "Free Text" });
            return annotations;
        }

        public List<ProgrammaticOperationsModel> StampTypeLists()
        {
            List<ProgrammaticOperationsModel> stampTypes = new List<ProgrammaticOperationsModel>();
            stampTypes.Add(new ProgrammaticOperationsModel { ID = "Dynamic", Text = "Dynamic" });
            stampTypes.Add(new ProgrammaticOperationsModel { ID = "SignHere", Text = "Sign Here" });
            stampTypes.Add(new ProgrammaticOperationsModel { ID = "StandardBusiness", Text = "Standard Business" });
            return stampTypes;
        }

        public List<ProgrammaticOperationsModel> DynamicStampLists()
        {
            List<ProgrammaticOperationsModel> dynamicStamps = new List<ProgrammaticOperationsModel>();
            dynamicStamps.Add(new ProgrammaticOperationsModel { ID = "Approved", Text = "Approved" });
            dynamicStamps.Add(new ProgrammaticOperationsModel { ID = "Confidential", Text = "Confidential" });
            dynamicStamps.Add(new ProgrammaticOperationsModel { ID = "NotApproved", Text = "Not Approved" });
            dynamicStamps.Add(new ProgrammaticOperationsModel { ID = "Received", Text = "Received" });
            dynamicStamps.Add(new ProgrammaticOperationsModel { ID = "Reviewed", Text = "Reviewed" });
            dynamicStamps.Add(new ProgrammaticOperationsModel { ID = "Revised", Text = "Revised" });
            return dynamicStamps;
        }

        public List<ProgrammaticOperationsModel> SignHereStampLists()
        {
            List<ProgrammaticOperationsModel> signHereStamps = new List<ProgrammaticOperationsModel>();
            signHereStamps.Add(new ProgrammaticOperationsModel { ID = "Accepted", Text = "Accepted" });
            signHereStamps.Add(new ProgrammaticOperationsModel { ID = "InitialHere", Text = "Initial Here" });
            signHereStamps.Add(new ProgrammaticOperationsModel { ID = "Rejected", Text = "Rejected" });
            signHereStamps.Add(new ProgrammaticOperationsModel { ID = "SignHere", Text = "Sign Here" });
            signHereStamps.Add(new ProgrammaticOperationsModel { ID = "Witness", Text = "Witness" });
            return signHereStamps;
        }

        public List<ProgrammaticOperationsModel> StandardBusinessLists()
        {
            List<ProgrammaticOperationsModel> standardBusinessStamps = new List<ProgrammaticOperationsModel>();
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "Approved", Text = "Approved" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "Completed", Text = "Completed" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "Confidential", Text = "Confidential" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "Draft", Text = "Draft" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "Final", Text = "Final" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "ForComment", Text = "For Comment" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "ForPublicRelease", Text = "For Public Release" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "InformationOnly", Text = "Information Only" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "NotApproved", Text = "Not Approved" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "NotForPublicRelease", Text = "Not For Public Release" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "PreliminaryResults", Text = "Preliminary Results" });
            standardBusinessStamps.Add(new ProgrammaticOperationsModel { ID = "Void", Text = "Void" });
            return standardBusinessStamps;
        }
        public List<ProgrammaticOperationsModel> LineHeadStyles()
        {
            List<ProgrammaticOperationsModel> lineHeadStyles = new List<ProgrammaticOperationsModel>();
            lineHeadStyles.Add(new ProgrammaticOperationsModel { ID = "None", Text = "None" });
            lineHeadStyles.Add(new ProgrammaticOperationsModel { ID = "Arrow", Text = "Closed Arrow" });
            lineHeadStyles.Add(new ProgrammaticOperationsModel { ID = "OpenArrow", Text = "Open Arrow" });
            lineHeadStyles.Add(new ProgrammaticOperationsModel { ID = "Square", Text = "Square" });
            lineHeadStyles.Add(new ProgrammaticOperationsModel { ID = "Diamond", Text = "Diamond" });
            lineHeadStyles.Add(new ProgrammaticOperationsModel { ID = "Circle", Text = "Round" });
            return lineHeadStyles;
        }
        public List<ProgrammaticOperationsModel> InkAnnotationDataList()
        {
            List<ProgrammaticOperationsModel> inkAnnotationData = new List<ProgrammaticOperationsModel>();
            inkAnnotationData.Add(new ProgrammaticOperationsModel { ID = "Syncfusion", Text = "Syncfusion" });
            inkAnnotationData.Add(new ProgrammaticOperationsModel { ID = "PdfViewer", Text = "PdfViewer" });
            inkAnnotationData.Add(new ProgrammaticOperationsModel { ID = "Star", Text = "Star" });
            return inkAnnotationData;
        }
        public List<ProgrammaticOperationsModel> FontFamilyList()
        {
            List<ProgrammaticOperationsModel> fontFamily = new List<ProgrammaticOperationsModel>();
            fontFamily.Add(new ProgrammaticOperationsModel { ID = "Helvetica", Text = "Helvetica" });
            fontFamily.Add(new ProgrammaticOperationsModel { ID = "Courier", Text = "Courier" });
            fontFamily.Add(new ProgrammaticOperationsModel { ID = "Symbol", Text = "Symbol" });
            fontFamily.Add(new ProgrammaticOperationsModel { ID = "TimesNewRoman", Text = "Times New Roman" });
            return fontFamily;
        }
        public List<ProgrammaticOperationsModel> TextAlignmentList()
        {
            List<ProgrammaticOperationsModel> textAlignment = new List<ProgrammaticOperationsModel>();
            textAlignment.Add(new ProgrammaticOperationsModel { ID = "Center", Text = "Center" });
            textAlignment.Add(new ProgrammaticOperationsModel { ID = "Right", Text = "Right" });
            textAlignment.Add(new ProgrammaticOperationsModel { ID = "Left", Text = "Left" });
            textAlignment.Add(new ProgrammaticOperationsModel { ID = "Justify", Text = "Justify" });
            return textAlignment;
        }

        public List<ProgrammaticOperationsModel> FontStyleList()
        {
            List<ProgrammaticOperationsModel> fontStyles = new List<ProgrammaticOperationsModel>();
            fontStyles.Add(new ProgrammaticOperationsModel { ID = "None", Text = "None" });
            fontStyles.Add(new ProgrammaticOperationsModel { ID = "Bold", Text = "Bold" });
            fontStyles.Add(new ProgrammaticOperationsModel { ID = "Underline", Text = "Underline" });
            fontStyles.Add(new ProgrammaticOperationsModel { ID = "Italic", Text = "Italic" });
            fontStyles.Add(new ProgrammaticOperationsModel { ID = "Strikethrough", Text = "Strikethrough" });
            return fontStyles;
        }

        public List<ProgrammaticOperationsModel> CommentStatusList()
        {
            List<ProgrammaticOperationsModel> commentStatus = new List<ProgrammaticOperationsModel>();
            commentStatus.Add(new ProgrammaticOperationsModel { ID = "None", Text = "None" });
            commentStatus.Add(new ProgrammaticOperationsModel { ID = "Accepted", Text = "Accepted" });
            commentStatus.Add(new ProgrammaticOperationsModel { ID = "Cancelled", Text = "Cancelled" });
            commentStatus.Add(new ProgrammaticOperationsModel { ID = "Completed", Text = "Completed" });
            commentStatus.Add(new ProgrammaticOperationsModel { ID = "Rejected", Text = "Rejected" });
            return commentStatus;
        }
        public List<ProgrammaticOperationsModel> AllowInteractionsList()
        {
            List<ProgrammaticOperationsModel> allowInteractions = new List<ProgrammaticOperationsModel>();
            allowInteractions.Add(new ProgrammaticOperationsModel { ID = "None", Text = "None" });
            allowInteractions.Add(new ProgrammaticOperationsModel { ID = "Delete", Text = "Delete" });
            allowInteractions.Add(new ProgrammaticOperationsModel { ID = "PropertyChange", Text = "Property Change" });
            allowInteractions.Add(new ProgrammaticOperationsModel { ID = "Move", Text = "Move" });
            allowInteractions.Add(new ProgrammaticOperationsModel { ID = "Select", Text = "Select" });
            allowInteractions.Add(new ProgrammaticOperationsModel { ID = "Resize", Text = "Resize" });
            return allowInteractions;
        }
    }
}