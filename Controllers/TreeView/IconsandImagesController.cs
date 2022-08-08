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
        TreeViewFieldsSettings iconFields = new TreeViewFieldsSettings();
      
        public ActionResult IconsandImages()
        {
            TreeviewImageIcons treeviewIcon = new TreeviewImageIcons();
            iconFields.DataSource = treeviewIcon.getTreeviewImageIconsModel();           
            iconFields.Id = "NodeId";
            iconFields.Text = "NodeText";
            iconFields.IconCss = "Icon";
            iconFields.Child = "NodeChild";
            iconFields.Expanded = "Expanded";
            ViewBag.iconFields = iconFields;
            return View();
       
        }
        
    }


}