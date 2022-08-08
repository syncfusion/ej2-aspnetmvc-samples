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
        TreeViewFieldsSettings templateFields = new TreeViewFieldsSettings();
        public ActionResult Template()
        {
            TreeviewTemplate treeviewTemplate = new TreeviewTemplate();
            templateFields.DataSource = treeviewTemplate.getTreeviewTemplate();
            templateFields.HasChildren = "HasChild";
            templateFields.Expanded = "Expanded";
            templateFields.Selected = "Selected";
            templateFields.Id = "id";
            templateFields.ParentID = "pid";
            templateFields.Text = "name";
            ViewBag.templateFields = templateFields;
            return View();
        }

    }
}