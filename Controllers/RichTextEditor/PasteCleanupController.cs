using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2CoreSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        // GET: /<controller>/
        public ActionResult PasteCleanup()
        {
            ViewBag.data = new FormatOption().FormatOptions();
            ViewBag.value = @"<p>RichTextEditor is a WYSIWYG editing control which will reduce the effort for users while
                trying to express their formatting word content as HTML or Markdown format.</p>
            <p><b>Paste Cleanup properties:</b></p>
            <ul>
                <li>
                    <p>prompt - specifies whether to enable the prompt when pasting in RichTextEditor.</p>
                </li>
                <li>
                    <p>plainText - specifies whether to paste as plain text or not in RichTextEditor.</p>
                </li>
                <li>
                    <p>keepFormat- specifies whether to keep or remove the format when pasting in
                        RichTextEditor.</p>
                </li>
                <li>
                    <p>deniedTags - specifies the tags to restrict when pasting in RichTextEditor.</p>
                </li>
                <li>
                    <p>deniedAttributes - specifies the attributes to restrict when pasting in
                        RichTextEditor.</p>
                </li>
                <li>
                    <p>allowedStyleProperties - specifies the allowed style properties when pasting in
                        RichTextEditor.</p>
                </li>
            </ul>";

            return View();
        }
    }
}
