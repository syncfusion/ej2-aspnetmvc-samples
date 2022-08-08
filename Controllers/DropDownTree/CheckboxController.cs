using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields checkboxFields = new DropDownTreeFields();
        public ActionResult Checkbox()
        {
            DropDownTreeCheckbox dropdDownTreeData = new DropDownTreeCheckbox();
            checkboxFields.DataSource = dropdDownTreeData.Checkbox();
            checkboxFields.Value = "id";
            checkboxFields.Text = "name";
            checkboxFields.Expanded = "expanded";
            checkboxFields.HasChildren = "hasChild";
            checkboxFields.ParentValue = "pid";
            ViewBag.checkboxfields = checkboxFields;
            return View();
        }
    }
}