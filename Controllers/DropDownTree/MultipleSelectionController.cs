using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields selectionData = new DropDownTreeFields();
        public ActionResult MultipleSelection()
        {
            DropDownTreeMultiSelection dropdownTreeMultiSelection = new DropDownTreeMultiSelection();
            selectionData.DataSource = dropdownTreeMultiSelection.MultipleSelection();
            selectionData.Value = "id";
            selectionData.Text = "name";
            selectionData.Expanded = "expanded";
            selectionData.HasChildren = "hasChild";
            selectionData.ParentValue = "pid";
            ViewBag.selectionData = selectionData;
            return View();
        }
    }
}