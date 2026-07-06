using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.MultiColumnComboBox
{
    public partial class MultiColumnComboBoxController : Controller
    {
        public ActionResult RemoteData()
        {
            ViewData["query"] = "new ej.data.Query().select(['FirstName', 'EmployeeID', 'Designation', 'Country']).take(10).requiresCount()";
            return View();
        }
    }
}