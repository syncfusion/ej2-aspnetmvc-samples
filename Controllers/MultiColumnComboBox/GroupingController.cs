using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.MultiColumnComboBox
{
    public partial class MultiColumnComboBoxController : Controller
    {
        public ActionResult Grouping()
        {
            ViewData["data"] = new EJ2MVCSampleBrowser.Models.Products().GetAllRecords();
            return View();
        }
    }
}