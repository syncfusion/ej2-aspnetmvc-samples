using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.MultiColumnComboBox
{
    public partial class MultiColumnComboBoxController : Controller
    {
        public ActionResult KeyboardNavigation()
        {
            ViewData["data"] = new EJ2MVCSampleBrowser.Models.ProductDetails().GetAllRecords();
            return View();
        }
    }
}