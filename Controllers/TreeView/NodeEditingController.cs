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
        TreeViewFieldsSettings nodefields = new TreeViewFieldsSettings();
      
        public ActionResult NodeEditing()
        {
            TreeviewModel treevireModel = new TreeviewModel();
            nodefields.DataSource = treevireModel.getTreeviewModel();
            nodefields.HasChildren = "HasChild";
            nodefields.Expanded = "Expanded";
            nodefields.Id = "Id";
            nodefields.ParentID = "PId";
            nodefields.Text = "Name";
            ViewBag.nodefields = nodefields;
            return View();
        }
    }
}