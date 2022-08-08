using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields customFields = new DropDownTreeFields();
        public ActionResult CustomTemplate()
        {
            DropDownTreeCheckbox dropdDownTreeData = new DropDownTreeCheckbox();
            customFields.DataSource = dropdDownTreeData.Checkbox();
            customFields.Value = "id";
            customFields.Text = "name";
            customFields.Expanded = "expanded";
            customFields.HasChildren = "hasChild";
            customFields.ParentValue = "pid";
            ViewBag.CustomFields = customFields;
            DropDownTreeTreeSettings treeSettings = new DropDownTreeTreeSettings();
            treeSettings.AutoCheck = true;
            ViewBag.TreeSettings = treeSettings;
            return View();
        }
    }
}