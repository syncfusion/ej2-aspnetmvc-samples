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
        TreeViewFieldsSettings localFields = new TreeViewFieldsSettings();
        TreeViewFieldsSettings hierarchicalFields = new TreeViewFieldsSettings();
        public ActionResult LocalData()
        {
            TreeviewLocalData treeviewLocal = new TreeviewLocalData();
            TreeviewHierarchical treeviewHierarchical = new TreeviewHierarchical();
            localFields.DataSource = treeviewLocal.getTreeviewLocalData();
            localFields.HasChildren = "HasChild";
            localFields.Expanded = "Expanded";
            localFields.Id = "Id";
            localFields.Selected = "Selected";
            localFields.ParentID = "PId";
            localFields.Text = "Name";
            ViewData["fields"] = localFields;
            hierarchicalFields.DataSource = treeviewHierarchical.getTreeviewHierarchicalModel();
            hierarchicalFields.Expanded = "Expanded";
            hierarchicalFields.Id = "Code";
            hierarchicalFields.Selected = "Selected";
            hierarchicalFields.Text = "Name";
            hierarchicalFields.Child = "Child";
            ViewData["hierarchicalFields"] = hierarchicalFields;
            return View();
        }
       
    }
}