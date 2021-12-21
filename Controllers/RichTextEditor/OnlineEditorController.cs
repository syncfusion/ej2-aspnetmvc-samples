using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult OnlineEditor()
        {
            ViewBag.Tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase", "SuperScript", "SubScript", "|",
                "Formats", "Alignments", "NumberFormatList", "BulletFormatList",
                "Outdent", "Indent", "|",
                "CreateTable", "CreateLink", "Image", "FileManager", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            ViewBag.Value = @"
<p>
    The Rich Text Editor is a WYSIWYG (what you see is what you get) editor used to create and edit
    the content and return the valid HTML markup or markdown of the content.
    This provides a lot of commands to edit and format the content.
</p>
<p><b>Toolbar</b></p>
<p>
    The editor’s toolbar provides various commands to align the text, format, insert a link, image,
    list, undo/redo operations, HTML view, and more. The toolbar comes with different modes such as
    floating, multi-row, and expanded.
</p>
<p><b>Links</b></p>
<p>
    Create a hyperlink using the 'insert link' dialog and you can edit the hyperlink text, display text,
    and tooltip using the 'edit link' dialog and quick toolbar. If the text has valid hyperlink text,
    the editor converts it to hyperlink automatically. For example, link to Rich Text Editor.
</p>
<p><b>Table</b></p>
<p>
    This editor allows you to insert a table with options to add, edit, and remove and perform other
    table-related actions.
</p>
<p>For example</p>
<table>
    <tbody>
        <tr>
            <th>Employee name</th>
            <th>Role</th>
            <th>Mail</th>
            <th>Country</th>
        </tr>
        <tr>
            <td>Janet Fleet</td>
            <td>Manager</td>
            <td>janet95@arpy.com</td>
            <td>France</td>
        </tr>
        <tr>
            <td>Nancy Buchanan</td>
            <td>Project Lead</td>
            <td>nancy55@rpy.com</td>
            <td>Sweden</td>
        </tr>
        <tr>
            <td>Rose Rose</td>
            <td>Project Lead</td>
            <td>rose44@sample.com</td>
            <td>France</td>
        </tr>
    </tbody>
</table>
<p><b>Image</b></p>
<p>
    Allows you to insert images with caption, alt text, link, resize, and drag-and-drop from an
    online source and local computer. You can upload an image to the server and insert it into the editor.
    It provides an option to customize a quick toolbar for an image.
</p>
<p>For example</p>
<img id='rteImageID' style='height:300px;transform: rotate(0deg);' alt='Logo'
        src='https://ej2.syncfusion.com/aspnetmvc/Content/images/RichTextEditor/RTEImage-Feather.png' />
<p><b>Lists</b></p>
<p>You can include content with ordered and unordered lists.</p>
<p>Examples for an ordered list:</p>
<ul>
    <li>TypeScript</li>
    <li>Javascript</li>
    <li>Angular</li>
    <li>React</li>
    <li>Vue</li>
</ul>
<p>Examples for an unordered list:</p>
<ol>
    <li>Rich Text Editor</li>
    <li>Toolbar</li>
    <li>Button</li>
    <li>Dialog</li>
    <li>Data Grid</li>
</ol>
<p>The editor has a lot of features to edit HTML content and Markdown content in web applications.</p>";
            return View();
        }
    }
}
