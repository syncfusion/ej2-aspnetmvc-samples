#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DropDownListController : Controller
    {
        public ActionResult VirtualScroll()
        {
            DropDownListRecord model = new DropDownListRecord();
            model.RecordList = new DropDownListRecord().RecordModelList();
            return View(model);
        }
    }
    public class DropDownListRecord
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public List<DropDownListRecord> RecordList { set; get; }
        public List<DropDownListRecord> RecordModelList()
        {
            return Enumerable.Range(1, 150).Select(i => new DropDownListRecord()
            {
                ID = i.ToString(),
                Text = "Item " + i,
            }).ToList();
        }
    }
}
