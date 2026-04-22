#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class MarkdownEditorController : Controller
    {
        public ActionResult Overview()
        {
            ViewData["Value"] =@"## Welcome to the Syncfusion&reg; EJ2 Markdown Editor

The **Syncfusion Rich Text Editor** in **Markdown** mode delivers a lightweight, distraction-free editing experience with full Markdown syntax support &mdash; powered natively by Syncfusion's own **MarkdownConverter**.

Write beautiful documents faster using simple, readable Markdown syntax and see the formatted result instantly with live preview.

### Why Choose Markdown Mode?

- Clean, plain-text syntax that is easy to read and write &mdash; even in raw form
- Input or modify text, apply formatting, and view the Markdown preview side-by-side using the splitter control.
- Toolbar + keyboard shortcuts for rapid formatting
- Easy to convert content to HTML or other formats
- Ideal for documentation, notes, and developer-focused content
- Reduces clutter and keeps the writing experience distraction-free

### Supported Markdown Features in Action

# Headings
## Markdown Editor Demo
### Create Clean, Structured Content
#### Organize Sections Effortlessly
##### Add Subheadings for Clarity
###### Provide Notes or Additional Info

Headings help structure your content, making it easier to read, scan, and organize information within the Markdown editor.

#### Text Formatting
**Bold text highlights important information.**

*Markdown makes writing simple and clean.*

**_You can also combine bold and italic for emphasis._**

~~Use strikethrough to indicate removed or outdated content.~~

`Inline code is perfect for short code snippets like commands or variables.`

### Table
Create simple tables to organize information clearly and quickly.

| Feature | Description |
|---------|-------------|
| Markdown   | Lightweight, easy-to-read formatting syntax |
| Preview    | Shows formatted output side-by-side |

#### Lists

**Unordered**
- Explore the editor features
- Add content with simple syntax
    - Insert nested bullet points
    - Organize topics hierarchically
- Keep your notes clear and readable

**Ordered**
1. Start writing your content
2. Apply Markdown formatting
    1. Add sub-steps for detailed tasks
    2. Improve clarity with structure
3. Review and finalize your document

**Task List**
- [x] Completed task
- [ ] Write documentation
- [ ] Release new version

#### Blockquotes

> Markdown makes writing on the web beautiful and readable.
>
> &mdash; John Gruber, Creator of Markdown

#### Code Blocks
Inline code: Use `npm install @syncfusion/ej2-richtexteditor`";
            ViewData["Items"] = new object[] {"Bold", "Italic", "StrikeThrough", "|", "Formats", "Blockquote", "OrderedList", "UnorderedList", "|", "CreateTable", "CreateLink", "Image", "|", "Undo", "Redo" };
            return View();
        }
    }
}
