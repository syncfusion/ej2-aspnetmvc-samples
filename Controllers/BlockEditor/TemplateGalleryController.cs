#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Syncfusion.EJ2.BlockEditor;
using EJ2MVCSampleBrowser.Models;
using static EJ2MVCSampleBrowser.Models.BlockData;
using System.Collections.Generic;

namespace EJ2MVCSampleBrowser.Controllers.BlockEditor
{
    public partial class BlockEditorController : Controller
    {
        public ActionResult TemplateGallery()
        {
            // Get all templates (strongly-typed)
            var pages = BlockData.GetPages();

            // Bind first template blocks for initial render (Overview-style)
            var initialBlocks = pages.ElementAtOrDefault(1)?.Blocks ?? new List<BlockModel>();
            ViewData["InitialBlocks"] = initialBlocks;

            // Serialize all pages for client-side switching; ensure enums serialize as strings
            var jsonSettings = new JsonSerializerSettings
            {
                Converters = new JsonConverter[] { new StringEnumConverter() },
                NullValueHandling = NullValueHandling.Ignore
            };
            ViewBag.TemplatePagesJson = JsonConvert.SerializeObject(pages, jsonSettings);

            return View();
        }
    }
}