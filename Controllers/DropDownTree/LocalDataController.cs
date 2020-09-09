using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields localFields = new DropDownTreeFields();
        DropDownTreeFields hierarchicalFields = new DropDownTreeFields();
        public ActionResult LocalData()
        {
            DropDownTreeLocalData dropDownTreeLocal = new DropDownTreeLocalData();
            DropDownTreeHierarchical dropDownTreeHierarchical = new DropDownTreeHierarchical();
            localFields.DataSource = dropDownTreeLocal.getDropDownTreeLocalData();  
            localFields.HasChildren = "HasChild";
            localFields.Expanded = "Expanded";
            localFields.Value = "Id";
            localFields.ParentValue = "PId";
            localFields.Text = "Name";
            ViewBag.localFields = localFields;
            hierarchicalFields.DataSource = dropDownTreeHierarchical.getDropDownTreeHierarchical();
            hierarchicalFields.Value = "Code";
            hierarchicalFields.Text = "Name";
            hierarchicalFields.Child = "Child";
            ViewBag.hierarchicalFields = hierarchicalFields;
            return View();
        }
    }
}