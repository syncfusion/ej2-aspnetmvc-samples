using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class RichTextEditorModel
    {
        [Required(ErrorMessage = "Value is required")]
        [AllowHtml]
        public string Value { get; set; }
    }
    public partial class RichTextEditorController : Controller
    {
        RichTextEditorModel rteModel = new RichTextEditorModel();
        public ActionResult RichTextEditorFor()
        {
            rteModel.Value = "<p>Type or edit the content to post the <b>Rich Text Editor</b> value.</p>";
            return View(rteModel);
        }
        [HttpPost]
        public ActionResult RichTextEditorFor(RichTextEditorModel model)
        {
            rteModel.Value = model.Value;
            return View(rteModel);
        }
    }
}
