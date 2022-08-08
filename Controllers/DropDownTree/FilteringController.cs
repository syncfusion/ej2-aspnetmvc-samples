using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields filteringData = new DropDownTreeFields();
        public ActionResult Filtering()
        {
            DropDownTreeFiltering dropdownTreeFiltering = new DropDownTreeFiltering();
            filteringData.DataSource = dropdownTreeFiltering.Filtering();
            filteringData.Value = "id";
            filteringData.Text = "name";
            filteringData.Expanded = "expanded";
            filteringData.HasChildren = "hasChild";
            filteringData.ParentValue = "pid";
            ViewBag.filteringdata = filteringData;
            return View();
        }
    }
}