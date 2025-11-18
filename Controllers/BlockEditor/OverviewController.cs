#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using Syncfusion.EJ2.BlockEditor;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public List<Block> BlockDataOverview { get; set; }
        public ActionResult Overview()
        {
            BlockDataOverview = new BlockData().GetBlockDataOverview();
            ViewData["BlockDataOverview"] = BlockDataOverview;
            return View();
        }
    }
}