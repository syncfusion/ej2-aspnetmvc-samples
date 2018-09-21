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
        TreeViewFieldsSettings rtlFields = new TreeViewFieldsSettings();
       
        public ActionResult RTL()
        {
            TreeviewRTL treeviewRtlModel = new TreeviewRTL(); ;
            rtlFields.DataSource = treeviewRtlModel.getTreeviewRTL();
            rtlFields.HasChildren = "HasChild";
            rtlFields.Expanded = "Expanded";
            rtlFields.Id = "Id";
            rtlFields.ParentID = "PId";
            rtlFields.Text = "Name";
            ViewBag.rtlFields = rtlFields;
            return View();
        }
    }

}