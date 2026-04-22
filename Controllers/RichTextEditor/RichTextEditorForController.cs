#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class RichTextEditorModel
    {
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
            if (model.Value != null)
            {
                var textWithoutHtml = RemoveHtmlTags(model.Value.Trim());
                textWithoutHtml = textWithoutHtml.Replace(" ", "");
                int imgCount = CountImageTags(model.Value);
                int adjustedLength = textWithoutHtml.Trim().Length + imgCount;
                if (string.IsNullOrWhiteSpace(textWithoutHtml) || adjustedLength < 20)
                {
                    ModelState.AddModelError("Value", "The Rich Text Editor content must contain at least 20 letters");
                    return View(model);
                }
                else
                {
                    model.Value = string.Empty;
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("Value", "Value is required");
                return View(model);
            }
        }
        private string RemoveHtmlTags(string htmlContent)
        {
            return Regex.Replace(htmlContent, "<.*?>", string.Empty);
        }
        private int CountImageTags(string text)
        {
            var imgCount = Regex.Matches(text, "<img[^>]*>").Count;
            return imgCount;
        }
    }
}
