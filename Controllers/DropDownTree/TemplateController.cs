using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields templateData = new DropDownTreeFields();
        public ActionResult Template()
        {
            DropDownTreeTemplate dropdownTreeTemplate = new DropDownTreeTemplate();
            templateData.DataSource = dropdownTreeTemplate.Template();
            templateData.Value = "id";
            templateData.Text = "name";
            templateData.Expanded = "expanded";
            templateData.HasChildren = "hasChild";
            templateData.ParentValue = "pid";
            ViewBag.templateData = templateData;
            return View();
        }
    }
}