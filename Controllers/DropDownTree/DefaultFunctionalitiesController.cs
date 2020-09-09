using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields fields = new DropDownTreeFields();
        public ActionResult DefaultFunctionalities()
        {
            DropDownTreeDefaultData dropDownTreeData = new DropDownTreeDefaultData();
            fields.DataSource = dropDownTreeData.getDropDownTreeDefaultData();
            fields.Value = "Id";
            fields.Text = "Name";
            fields.Expanded = "Expanded";
            fields.Child = "SubChild";
            ViewBag.fields = fields;
            return View();
        }
    }
}