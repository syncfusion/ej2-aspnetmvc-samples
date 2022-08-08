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
        TreeViewFieldsSettings dragfields = new TreeViewFieldsSettings();
        TreeViewFieldsSettings dropfields = new TreeViewFieldsSettings();
        public ActionResult DragandDrop()
        {
            TreeviewModel treevireModel = new TreeviewModel();
            TreeviewDrag treeviewDrag = new TreeviewDrag();
            dragfields.DataSource = treevireModel.getTreeviewModel();
            dragfields.HasChildren = "HasChild";
            dragfields.Expanded = "Expanded";
            dragfields.Id = "Id";
            dragfields.ParentID = "PId";
            dragfields.Text = "Name";
            ViewBag.dragfields = dragfields;
          
           
            dropfields.DataSource = treeviewDrag.getTreeviewDrag();
            dropfields.HasChildren = "HasChild";
            dropfields.Expanded = "Expanded";
            dropfields.Id = "Id";
            dropfields.ParentID = "PId";
            dropfields.Text = "Name";
            ViewBag.dropfields = dropfields;

            return View();
        }
       
    }
}