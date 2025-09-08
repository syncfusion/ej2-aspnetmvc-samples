#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Windows.Forms.VisualStyles;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.PdfViewer
{
    public partial class PdfViewerController : Controller
    { 
        public ActionResult ProgrammaticOperations()
        {   
            ViewBag.annotationData = new ProgrammaticOperationsModel().AnnotationLists();
            ViewBag.stampTypeData = new ProgrammaticOperationsModel().StampTypeLists();
            ViewBag.dynamicStamps = new ProgrammaticOperationsModel().DynamicStampLists();
            ViewBag.signHereStamps = new ProgrammaticOperationsModel().SignHereStampLists();
            ViewBag.standardBusiness = new ProgrammaticOperationsModel().StandardBusinessLists();
            ViewBag.lineHeadStyles = new ProgrammaticOperationsModel().LineHeadStyles();
            ViewBag.inkAnnotationData = new ProgrammaticOperationsModel().InkAnnotationDataList();
            ViewBag.fontFamily = new ProgrammaticOperationsModel().FontFamilyList();
            ViewBag.textAlignment = new ProgrammaticOperationsModel().TextAlignmentList();
            ViewBag.fontStyles = new ProgrammaticOperationsModel().FontStyleList();
            ViewBag.commentStatus = new ProgrammaticOperationsModel().CommentStatusList();
            ViewBag.allowInteractions = new ProgrammaticOperationsModel().AllowInteractionsList();
            List<ContextMenuItem> menuItems = new List<ContextMenuItem>() {
                new ContextMenuItem{Text = "Edit"},
                new ContextMenuItem{Text = "Delete"}
            };
            ViewBag.menuItems = menuItems;
            return View();
        }

    }
}