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
   
        TreeViewFieldsSettings fields = new TreeViewFieldsSettings();
      
        public ActionResult DefaultFunctionalities()
        {
            TreeviewModel treevireModel = new TreeviewModel();
            fields.DataSource = treevireModel.getTreeviewModel();
            fields.HasChildren = "HasChild";
            fields.Expanded = "Expanded";
            fields.Id = "Id";
            fields.ParentID = "PId";
            fields.Text = "Name";
            ViewBag.fields = fields;
            return View();
        }
       
    }
}