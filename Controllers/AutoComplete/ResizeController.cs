using EJ2MVCSampleBrowser.Models;
using System;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class AutoCompleteController : Controller
    {
        public ActionResult Resize()
        {
            ViewData["data"] = new BooksData().GetBooksData();
            return View();
        }
    }
}