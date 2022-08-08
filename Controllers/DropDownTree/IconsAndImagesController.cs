using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.DropDowns;

namespace EJ2MVCSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        DropDownTreeFields iconsFields = new DropDownTreeFields();
        public ActionResult IconsAndImages()
        {
            DropDownTreeIcons dropdownTreeIconsAndImages = new DropDownTreeIcons();
            iconsFields.DataSource = dropdownTreeIconsAndImages.getIconsData();
            iconsFields.Value = "nodeId";
            iconsFields.Text = "nodeText";
            iconsFields.IconCss = "icon";
            iconsFields.ImageUrl = "image";
            iconsFields.Expanded = "expanded";
            iconsFields.Child = "child";
            ViewBag.iconsFields = iconsFields;
            return View();
        }
    }
}