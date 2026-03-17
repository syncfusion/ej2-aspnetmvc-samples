#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
using Syncfusion.EJ2.Buttons;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SpeedDialController : Controller
    {
        public ActionResult Styles()
        {
            List<SpeedDialItem> items = new List<SpeedDialItem>();
            List<SpeedDialItem> label = new List<SpeedDialItem>();
            List<SpeedDialItem> titles = new List<SpeedDialItem>();
            items.Add(new SpeedDialItem
                {
                Text = "Cut",
                IconCss = "speeddial-icons speeddial-icon-cut"
            });
            items.Add(new SpeedDialItem
                {
                Text = "Copy",
                IconCss = "speeddial-icons speeddial-icon-copy"
            });
            items.Add(new SpeedDialItem
                {
                Text = "Paste",
                IconCss = "speeddial-icons speeddial-icon-paste"
            });
            items.Add(new SpeedDialItem
                {
                Text = "Delete",
                IconCss = "speeddial-icons speeddial-icon-delete"
            });
            items.Add(new SpeedDialItem
                {
                Text = "Save",
                IconCss = "speeddial-icons speeddial-icon-save"
            });
            titles.Add(new SpeedDialItem
                {
                Title = "Cut",
                IconCss = "speeddial-icons speeddial-icon-cut"
            });
            titles.Add(new SpeedDialItem
                {
                Title = "Copy",
                IconCss = "speeddial-icons speeddial-icon-copy"
            });
            titles.Add(new SpeedDialItem
                {
                Title = "Paste",
                IconCss = "speeddial-icons speeddial-icon-paste"
            });
            titles.Add(new SpeedDialItem
                {
                Title = "Delete",
                IconCss = "speeddial-icons speeddial-icon-delete"
            });
            titles.Add(new SpeedDialItem
                {
                Title = "Save",
                IconCss = "speeddial-icons speeddial-icon-save"
            });
            label.Add(new SpeedDialItem
                {
                Text = "Cut",
            });
            label.Add(new SpeedDialItem
                {
                Text = "Copy",
            });
            label.Add(new SpeedDialItem
                {
                Text = "Paste",
            });
            label.Add(new SpeedDialItem
                {
                Text = "Delete",
            });
            label.Add(new SpeedDialItem
                {
                Text = "Save",
            });
            ViewData["datasource"] = items;
            ViewData["datasourceLabel"] = label;
            ViewData["datasourceLabelTitles"] = titles;
            return View();
        }
    }

}
