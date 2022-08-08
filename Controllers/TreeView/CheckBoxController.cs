using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.TreeView
{
    public partial class TreeViewController : Controller
    {
        TreeViewFieldsSettings checkboxfields = new TreeViewFieldsSettings();
        public ActionResult CheckBox()
        {
           
            TreeviewModel treevireModel = new TreeviewModel();
            checkboxfields.DataSource = treevireModel.getTreeviewModel();
            checkboxfields.HasChildren = "HasChild";
            checkboxfields.Expanded = "Expanded";
            checkboxfields.Id = "Id";
            checkboxfields.ParentID = "PId";
            checkboxfields.Text = "Name";
            ViewBag.checkboxfields = checkboxfields;
            return View();
        }
    }
}