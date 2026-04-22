#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.BlockEditor;
using System.Collections.Generic;
using System.Web.Mvc;
using static EJ2MVCSampleBrowser.Models.BlockData;

namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public List<BlockModel> BlockDataPaste { get; set; }
        public ActionResult PasteSettings()
        {
            BlockDataPaste = new BlockData().GetBlockDataPaste();
            ViewData["BlockDataPaste"] = BlockDataPaste;
            return View();
        }
    }
}