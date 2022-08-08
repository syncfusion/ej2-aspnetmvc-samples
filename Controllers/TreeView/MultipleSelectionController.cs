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
        TreeViewFieldsSettings multipleFields = new TreeViewFieldsSettings();
     
        public ActionResult MultipleSelection()
        {
            TreeviewMultiSelect treeviewMultiSelect = new TreeviewMultiSelect();
            multipleFields.DataSource = treeviewMultiSelect.getTreeviewMultiSelect();
            multipleFields.HasChildren = "HasChild";
            multipleFields.Expanded = "Expanded";
            multipleFields.Id = "Id";
            multipleFields.ParentID = "PId";
            multipleFields.Text = "Name";
            multipleFields.Selected = "Selected";
            ViewBag.multipleFields = multipleFields;
            return View();
        }
      
    }


}